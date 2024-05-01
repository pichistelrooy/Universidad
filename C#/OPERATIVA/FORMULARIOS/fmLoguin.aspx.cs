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

namespace TPOPERATIVA.Formularios
{
    public partial class fmLoguin : System.Web.UI.Page
    {
        C_sql_Usuarios sqlUsuario = new C_sql_Usuarios();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            bool Autenticado = false;
            Autenticado = LoginCorrecto(Login1.UserName, Login1.Password);
            e.Authenticated = Autenticado;
            if (Autenticado)
            {
                Response.Redirect("fmPrincipal.aspx");
            }
        }

        private bool LoginCorrecto(string Usuario, string Contrasena)
        {
            try
            {
                Session["CUsuarios"] = ((C_sql_Usuarios)Session["C_sql_Usuarios"]).Usuario(Login1.UserName, Login1.Password);
            }
            catch (Exception ex)
            {
                return false;
            }
                if (Usuario != null)
                    return true;
                return false;
        }

        protected void btnRegistrarse_Click(object sender, EventArgs e)
        {
            Response.Redirect("fmRegistrarse.aspx",true);
        }
    }
}