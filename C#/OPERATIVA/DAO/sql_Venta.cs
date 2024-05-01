using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using TPOPERATIVA.Entidades;
using CONEXION = TPOPERATIVA.DAO.Conexión;

namespace TPOPERATIVA.DAO
{
    public class sql_Venta
    {
    private static sql_Venta _Instance;

        protected sql_Venta()
        {
        }

        public static sql_Venta Instance()
        {
            if (_Instance == null)
            {
                _Instance = new sql_Venta();
            }
            return _Instance;
        }

        CONEXION MiConexion = new CONEXION();

        public void Agregar(CVenta Venta)
        {
            string cmd = "INSERT INTO Ventas (idcliente,idlote,idenvase,cantidad,precioventa) VALUES (" +
                Venta.idcliente + "," + Venta.idlote + ",'" + Venta.idenvase + "'," + Venta.cantidad + 
                Venta.precioventa + ")"; 

            MiConexion.EjecutarSql(cmd);
        }

        /*public List<CVenta> MisCompras(int idUsuario)
        {
            List<CVenta> ListaVentas = new List<CVenta>();
            DataTable TablaVentas = new DataTable();

            string cmd = "select * from ticketventa where idusuario = " + idUsuario;

            TablaVentas = MiConexion.ObtenerDatos(cmd);
            foreach (DataRow aux in TablaVentas.Rows)
            {
                CVenta Venta = new CVenta(Convert.ToInt32(aux["NroTicket"].ToString()), aux["fecha"].ToString(), Convert.ToInt32(aux["idcartelera"].ToString()),Convert.ToInt32(aux["idespectaculo"].ToString()), Convert.ToInt32(aux["Cantidad"].ToString()),Convert.ToInt32(aux["TarjetaCredito"].ToString()),
                                    aux["NroTarjeta"].ToString(),Convert.ToInt32(aux["idusuario"].ToString()),Convert.ToDecimal(aux["PrecioVentaTotal"].ToString()));
                ListaVentas.Add(Venta);
            }
            return ListaVentas;
        }*/
    }
}