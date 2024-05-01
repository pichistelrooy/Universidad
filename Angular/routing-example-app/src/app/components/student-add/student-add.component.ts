import { Component, OnInit } from '@angular/core';
import { Student } from 'src/app/models/student';
import { Career } from 'src/app/models/career';
import { StudentAsyncService } from 'src/app/services/student-async.service';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { CustomValidator } from 'src/app/components/custom-validator';

@Component({
  selector: 'app-student-add',
  templateUrl: './student-add.component.html',
  styleUrls: ['./student-add.component.css']
})
export class StudentAddComponent implements OnInit {
  student = new Student()
  studentForm: FormGroup
  careers = new Array<Career>()
  CustomValidator: any;

  constructor(private studentAsyncService: StudentAsyncService) { }

  ngOnInit() {
    this.studentForm = new FormGroup({
      'firstName': new FormControl(this.student.firstName, [Validators.required,
        Validators.minLength(20), CustomValidator.forbiddenNames(/Juan/)]),
      'lastName': new FormControl(this.student.lastName, [Validators.required]),
      'email': new FormControl(this.student.email, [Validators.required,CustomValidator.checkIfEmail()]),
      'dni': new FormControl(this.student.dni, [Validators.required]),
      'address': new FormControl(this.student.address),
      'careerId': new FormControl(this.student.careerId, [Validators.required]),
    })
    this.studentAsyncService.getCareerAll()
      .subscribe(response => {
          this.careers = response as Career[]
      },
      error => {
        console.log(error.message)
      })
  }

  onSubmit() {
      this.student = <Student> this.studentForm.value;
      this.studentAsyncService.add(this.student).subscribe(data=> console.log(data))
  }

  get firstName() {
    return this.studentForm.get('firstName');
  }
  get lastName() {
    return this.studentForm.get('lastName');
  }
  get dni() {
    return this.studentForm.get('dni');
  }
  get email() {
    return this.studentForm.get('email');
  }
  get careerId() {
    return this.studentForm.get('careerId');
  }

}
