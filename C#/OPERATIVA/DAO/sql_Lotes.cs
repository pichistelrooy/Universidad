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
    public class sql_Lotes
    {
       private static sql_Lotes _Instance;

       protected sql_Lotes()
        {
        }

       public static sql_Lotes Instance()
        {
            if (_Instance == null)
            {
                _Instance = new sql_Lotes();
            }
            return _Instance;
        }

        CONEXION MiConexion = new CONEXION();

        public void Agregar(CLotes Lotes)
        {
            string cmd = "INSERT INTO Lotes (IDEnvase,Cantidad,Disponibles, PrecioCompra) VALUES (" + Lotes.idenvase
              + "," + Lotes.cantidad + "," + Lotes.cantidad + "," + Lotes.preciocompra + ")";
            MiConexion.EjecutarSql(cmd);
        }

        public void Eliminar(int idLote)
        {
            string cmd = "DELETE Lotes where idLote = " + idLote;
            MiConexion.EjecutarSql(cmd);
        }

        public void Modificar(CLotes Lotes)
        {
            string cmd = "update Lotes set Cantidad = " + Lotes.cantidad + ", Disponibles = " + Lotes.cantidad + 
                ", IDEnvase = " + Lotes.idenvase + ", PrecioCompra = " +
                Lotes.preciocompra + " where idlote = " + Lotes.idlote;
            MiConexion.EjecutarSql(cmd);
        }
    }
}