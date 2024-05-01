using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TPOPERATIVA.DAO;
using TPOPERATIVA.Controladora;
using TPOPERATIVA.Formularios;
using System.Drawing;

namespace TPOPERATIVA.FORMULARIOS
{
    public partial class fmUsuarios : System.Web.UI.Page
    {
        C_sql_Usuarios sql_Usuarios = new C_sql_Usuarios();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                LimpiarCampos();
            }
        }

        protected void LimpiarCampos()
        {
            ddlUsuarios.Text = "";
            lblResultado.Visible = false;
        }

        protected void btnBaja_Click(object sender, EventArgs e)
        {
            sql_Usuarios.Eliminar(Convert.ToInt32(ddlUsuarios.Text));
        }

        protected void btnAlta_Click(object sender, EventArgs e)
        {
            sql_Usuarios.ActivarUsuario(Convert.ToInt32(ddlUsuarios.Text));
        }
    }
}