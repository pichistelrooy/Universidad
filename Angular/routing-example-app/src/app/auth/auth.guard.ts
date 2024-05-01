import { Injectable } from '@angular/core';
import { CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot, Router } from '@angular/router';
import { UserService } from 'src/app/services/user.service';

@Injectable({
  providedIn: 'root'
})
export class AuthGuard implements CanActivate {
  constructor(private userService : UserService,private route: Router){}

  canActivate(
    next: ActivatedRouteSnapshot,
    state: RouterStateSnapshot): boolean  {
      let url : string = state.url
      return this.checkLogin(url)
  }

  checkLogin(url : string) : boolean {
    if(this.userService.token === undefined){
      this.userService.token = localStorage.getItem('token');
    }
    if(this.userService.token) { 
      return true 
    }
    this.userService.redirectUrl = url;
    this.route.navigate(['/login']);
    return false;
  }
  
}