using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TPOPERATIVA.Entidades;
using TPOPERATIVA.Controladora;

namespace TPOPERATIVA.Formularios
{
    public partial class mp1 : System.Web.UI.MasterPage
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            CUsuarios aux = ((CUsuarios)Session["CUsuarios"]);

            ComprobarUsuario(aux);
        }

        protected void ComprobarUsuario(CUsuarios aux)
        {
            try
            {
                if (aux.usuario != null)
                {
                    btnEntrar.Text = "Salir";
                    if (aux.permiso == 1) // es administrador
                    {
                        btnAdministrador.Visible = true;
                        btnVentas.Visible = false;
                        lblMensaje.Text = "Bienvenido " + aux.nombreapellido + "(" + aux.usuario + ")";
                    }
                    if (aux.permiso == 2) // es ventas
                    {
                        btnAdministrador.Visible = false;
                        btnVentas.Visible = true;
                        lblMensaje.Text = "Bienvenido " + aux.nombreapellido + "(" + aux.usuario + ")";
                    }
                }
            }
            catch
            {
                lblMensaje.Text = "Ingresdar al Sistema";
                btnEntrar.Text = "Entrar";
                btnAdministrador.Visible = false;
                btnVentas.Visible = false;
            }
        }

        protected void btnEntrar_Click(object sender, EventArgs e)
        {
            if (btnEntrar.Text == "Entrar")
            {
                Response.Redirect("fmloguin.aspx", true);
            }
            else
            {
                Session["CUsuarios"] = null;
                CUsuarios aux = ((CUsuarios)Session["CUsuarios"]);
                ComprobarUsuario(aux);
            }
        }

        protected void btnAdministrador_Click(object sender, EventArgs e)
        {
            Response.Redirect("fmAdministrador.aspx", true);
        }

        protected void btnVentas_Click(object sender, EventArgs e)
        {
            Responsse.Redirect("fmSistema.aspx", true);
        }
    }
}