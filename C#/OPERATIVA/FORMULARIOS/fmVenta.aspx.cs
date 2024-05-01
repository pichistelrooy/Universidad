using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TP_Tickets.Controladora;
using TP_Tickets.Entidades;
using TP_Tickets.DAO;
using System.Drawing;

namespace TP_Tickets.Formularios
{
    public partial class fmVenta : System.Web.UI.Page
    {
        C_sql_Venta oVenta = new C_sql_Venta();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                limpiarCampos();
            }
            CUsuarios aux = ((CUsuarios)Session["CUsuarios"]);
        }

        protected void btnComprar_Click(object sender, EventArgs e)
        {
            GridViewRow rowDeporte = GridView1.SelectedRow;
            GridViewRow rowCine = GridView2.SelectedRow;
            GridViewRow rowTeatro = GridView3.SelectedRow;
            GridViewRow rowRecitales = GridView4.SelectedRow;

            CUsuarios aux = ((CUsuarios)Session["CUsuarios"]);


            if (ASPxPageControl2.ActiveTabPage.Name == "tabDeportes")
            {

                if (rowDeporte != null)
                {
                    try
                    {
                        oVenta.Agregar(Convert.ToInt32(rowDeporte.Cells[1].Text), Convert.ToInt32(rowDeporte.Cells[2].Text),
                            rowDeporte.Cells[4].Text, aux.idusuario, 1, txtNroTarjeta.Text,
                            Convert.ToInt32(txtCantidad.Text), Convert.ToInt32(rowDeporte.Cells[6].Text));

                        lblResultado.ForeColor = Color.Green;
                        lblResultado.Text = "La compra se realizo con éxito";
                        lblResultado.Visible = true;
                    }
                    catch (Exception ex)
                    {
                        lblResultado.ForeColor = Color.Red;
                        lblResultado.Text = ex.Message;
                        lblResultado.Visible = true;
                    }
                }
            }
                
                if (ASPxPageControl2.ActiveTabPage.Name == "tabCine")
                {
                    if (rowCine != null)
                    {
                        try
                        {
                            oVenta.Agregar(Convert.ToInt32(rowCine.Cells[1].Text), Convert.ToInt32(rowCine.Cells[2].Text),
                                rowCine.Cells[4].Text, aux.idusuario, 1, txtNroTarjeta.Text,
                                Convert.ToInt32(txtCantidad.Text), Convert.ToInt32(rowCine.Cells[6].Text));

                            lblResultado.ForeColor = Color.Green;
                            lblResultado.Text = "La compra se realizo con éxito";
                            lblResultado.Visible = true;
                        }
                        catch (Exception ex)
                        {
                            lblResultado.ForeColor = Color.Red;
                            lblResultado.Text = ex.Message;
                            lblResultado.Visible = true;
                        }
                    }
                }

                if (ASPxPageControl2.ActiveTabPage.Name == "tabTeatro")
                {
                    if (rowTeatro != null)
                    {
                        try
                        {
                            oVenta.Agregar(Convert.ToInt32(rowTeatro.Cells[1].Text), Convert.ToInt32(rowTeatro.Cells[2].Text),
                                rowTeatro.Cells[4].Text, aux.idusuario, 1, txtNroTarjeta.Text,
                                Convert.ToInt32(txtCantidad.Text), Convert.ToInt32(rowTeatro.Cells[6].Text));

                            lblResultado.ForeColor = Color.Green;
                            lblResultado.Text = "La compra se realizo con éxito";
                            lblResultado.Visible = true;
                        }
                        catch (Exception ex)
                        {
                            lblResultado.ForeColor = Color.Red;
                            lblResultado.Text = ex.Message;
                            lblResultado.Visible = true;
                        }
                    }
                }

                if (ASPxPageControl2.ActiveTabPage.Name == "tabRecitales")
                {
                    if (rowRecitales != null)
                    {
                        try
                        {
                            oVenta.Agregar(Convert.ToInt32(rowRecitales.Cells[1].Text), Convert.ToInt32(rowRecitales.Cells[2].Text),
                                rowRecitales.Cells[4].Text, aux.idusuario, 1, txtNroTarjeta.Text,
                                Convert.ToInt32(txtCantidad.Text), Convert.ToInt32(rowRecitales.Cells[6].Text));

                            lblResultado.ForeColor = Color.Green;
                            lblResultado.Text = "La compra se realizo con éxito";
                            lblResultado.Visible = true;
                        }
                        catch (Exception ex)
                        {
                            lblResultado.ForeColor = Color.Red;
                            lblResultado.Text = ex.Message;
                            lblResultado.Visible = true;
                        }
                    }
                }

            txtCantidad.Text = "";
            txtNroTarjeta.Text = "";
        }

        protected void limpiarCampos()
        {
            txtCantidad.Text = "";
            txtNroTarjeta.Text = "";
            lblResultado.Visible = false;
        }
    }
}