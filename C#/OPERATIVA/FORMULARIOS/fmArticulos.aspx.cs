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
    public partial class fmArticulos : System.Web.UI.Page
    {
        C_sql_Envases oEnvases = new C_sql_Envases();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            oEnvases.Agregar(1, txtNombre.Text, Convert.ToInt32(txtCapacidad.Text));
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            CEnvases oEnvase = new CEnvases();
            oEnvase.idenvase = Convert.ToInt32(ddlArticulos.SelectedValue);
            oEnvase.denominacion = txtNombre.Text;
            oEnvase.capacidad = Convert.ToInt32(txtCapacidad.Text);

            oEnvases.Modificar(oEnvase);
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            int Cantidad;
         
            Cantidad =  oEnvases.ComprobarEnvase(Convert.ToInt32(ddlArticulos.SelectedValue));

            if (Cantidad == 0)
            {
                try
                {
                    oEnvases.Eliminar(Convert.ToInt32(ddlArticulos.SelectedValue));
                    lblResultado.Text = "Artículo eliminado correctamente";
                    lblResultado.ForeColor = Color.Green;
                    lblResultado.Visible = true;
                }
                catch (Exception ex)
                {
                    lblResultado.Text = ex.Message;
                    lblResultado.ForeColor = Color.Red;
                    lblResultado.Visible = true;
                }
            }
            else
            {
                lblResultado.Text = "No se puede eliminar el Artículo porque tiene Lotes cargados";
                lblResultado.ForeColor = Color.Red;
                lblResultado.Visible = true;
            }
        }

    }
}