using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TPOPERATIVA.DAO;
using TPOPERATIVA.Entidades;

namespace TPOPERATIVA.Controladora
{
    public class C_sql_Venta
    {
        sql_Venta oVentas = sql_Venta.Instance();
        //List<CVenta> listaventas = new List<CVenta>();
        //List<CVenta> listaventasaux = new List<CVenta>();

        public void Agregar(int idcliente, int idenvase, int idlote, int cantidad, decimal precioventa)
        {
            CVenta oVenta = new CVenta();
            oVenta.idcliente = idcliente;
            oVenta.idenvase = idenvase;
            oVenta.idlote = idlote;
            oVenta.cantidad = cantidad;
            oVenta.precioventa = precioventa;

            oVentas.Agregar(oVenta);
        }

       /* public void Eliminar(int id)
        {
            oVentas.Eliminar(id);
        }*/

        /*public List<CVenta> MisCompras(int iduser)
        {
           return oVentas.MisCompras(iduser);
        }*/
    }
}