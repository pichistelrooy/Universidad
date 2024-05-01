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
    public class sql_Envases
    {
        private static sql_Envases _Instance;

        protected sql_Envases()
        {
        }

        public static sql_Envases Instance()
        {
            if (_Instance == null)
            {
                _Instance = new sql_Envases();
            }
            return _Instance;
        }

        CONEXION MiConexion = new CONEXION();

        public void Agregar(CEnvases Envases)
        {
            string cmd = "INSERT INTO Envases (Denominacion,Capacidad) VALUES ('" + Envases.denominacion
              + "','" + Envases.capacidad + "')";
            MiConexion.EjecutarSql(cmd);
        }

        public void Eliminar(int idEnvase)
        {
            string cmd = "DELETE Envases where idenvase = " + idEnvase;
            MiConexion.EjecutarSql(cmd);
        }

        public void Modificar(CEnvases Envases)
        {
            string cmd = "update Envases set Capacidad = " + Envases.capacidad + " and Denominacion = " + Envases.denominacion +
                " where idEnvase = " + Envases.idenvase;
            MiConexion.EjecutarSql(cmd);
        }

        public int ComprobarEnvase(int idenvase)
        {
            return 0;
            DataTable TablaEnvase = new DataTable();
            string cmd = "select count(*) as Cant from lotes where idenvase = " + idenvase;
            TablaEnvase = MiConexion.ObtenerDatos(cmd);

            foreach (DataRow aux in TablaEnvase.Rows)
            {
                if (Convert.ToInt32(aux["Cant"]) > 0)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

    }
}