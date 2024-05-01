using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TPOPERATIVA.Entidades;
using TPOPERATIVA.DAO;
using TPOPERATIVA.Controladora;
using TPOPERATIVA.Formularios;
using System.Drawing;

namespace TPOPERATIVA.Formularios
{
    public partial class fmRegistrarse : System.Web.UI.Page
    {
        C_sql_Usuarios sqlUsuario = new C_sql_Usuarios();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                LimpiarCampos();
            }
        }

        protected void LimpiarCampos()
        {
            txtContraseña.Text = "";
            txtNombre.Text = "";
            txtRepetirContraseña.Text = "";
            txtUsuario.Text = "";
            lblResultado.Visible = false; 
        }

        protected void btnRegistrarse_Click(object sender, EventArgs e)
        {
            try
            {
                sqlUsuario.Agregar(txtUsuario.Text, txtNombre.Text, txtContraseña.Text, 2);// permiso fijo
                lblResultado.Text = "Usuario Registrado correctamente";
                lblResultado.ForeColor = Color.Green;
                lblResultado.Visible = true;
                Response.Redirect("fmLoguin.aspx", true);
            }
            catch (Exception ex)
            {
                lblResultado.Text = ex.Message;
                lblResultado.ForeColor = Color.Red;
                lblResultado.Visible = true;
            }
        }

    }
}