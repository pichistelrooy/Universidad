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
    public class sql_Clientes
    {
        private static sql_Clientes _Instance;

        protected sql_Clientes()
        {
        }

        public static sql_Clientes Instance()
        {
            if (_Instance == null)
            {
                _Instance = new sql_Clientes();
            }
            return _Instance;
        }

        CONEXION MiConexion = new CONEXION();

        public void Agregar(CClientes Cliente)
        {
            string cmd = "INSERT INTO Clientes (Nombre) VALUES ('" + Cliente.nombre + "')";
            MiConexion.EjecutarSql(cmd);
        }

        public void Eliminar(int idCliente)
        {
            string cmd = "DELETE clientes where idcliente = " + idCliente;
            MiConexion.EjecutarSql(cmd);
        }

        public void Modificar(CClientes Cliente)
        {
            string cmd = "update clientes set Nombre = " + Cliente.nombre + " where idcliente = " + Cliente.idcliente;
            MiConexion.EjecutarSql(cmd);
        }

    }
}