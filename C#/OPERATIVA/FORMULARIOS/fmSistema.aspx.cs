using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TPOPERATIVA.Controladora;
using TPOPERATIVA.Entidades;
using TPOPERATIVA.DAO;
using System.Drawing;


namespace TPOPERATIVA.Formularios
{
    public partial class fmSistema : System.Web.UI.Page
    {
       /* C_sql_Permiso oPermiso = new C_sql_Permiso();
        C_sql_Usuarios oUsuarios = new C_sql_Usuarios();
        C_sql_Venta oVenta = new C_sql_Venta();
        C_sql_Clientes oCliente = new C_sql_Clientes();
        C_sql_Envases oEnvase = new C_sql_Envases();
        C_sql_Lotes oLotes = new C_sql_Lotes();*/

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUsuarios_Click(object sender, EventArgs e)
        {
            Response.Redirect("fmUsuarios.aspx", true); // falta modificar usuario
        }

        protected void btnEnvases_Click(object sender, EventArgs e)
        {
            Response.Redirect("fmEnvases.aspx", true); // falta
        }

        protected void btnLotes_Click(object sender, EventArgs e)
        {
            Response.Redirect("fmLotes.aspx", true);
        }
    }
}