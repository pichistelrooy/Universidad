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

namespace TPOPERATIVA.Formularios
{
    public partial class fmLotes : System.Web.UI.Page
    {
        C_sql_Lotes sql_Lotes = new C_sql_Lotes();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                LimpiarCampos();
            }
        }

        protected void btnCargarLote_Click(object sender, EventArgs e)
        {
            try
            {
                sql_Lotes.Agregar(1,Convert.ToInt32(ddlArticulos.SelectedValue),
                    Convert.ToInt32(txtCantidad.Text), Convert.ToInt32(txtCantidad.Text), Convert.ToDecimal(txtPrecioCompra.Text));
                lblResultado.Text = "Lote cargado correctamente";
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

        protected void LimpiarCampos()
        {
            txtPrecioCompra.Text = "";
            txtCantidad.Text = "";
            lblResultado.Visible = false;
        }
    }
}