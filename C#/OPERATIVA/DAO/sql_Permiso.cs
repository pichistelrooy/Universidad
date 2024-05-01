using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using TPOPERATIVA.DAO;
using TPOPERATIVA.Entidades;
using CONEXION = TPOPERATIVA.DAO.Conexión;

namespace TPOPERATIVA.DAO
{
    public class sql_Permiso
    {
        private static sql_Permiso _Instance;

        protected sql_Permiso()
        {
        }

        public static sql_Permiso Instance()
        {
            if (_Instance == null)
            {
                _Instance = new sql_Permiso();
            }
            return _Instance;
        }

        CONEXION MiConexion = new CONEXION();


        public List<CPermiso> ListaPermisos()
        {
            List<CPermiso> ListaPermisos = new List<CPermiso>();
            DataTable TablaPermisos = new DataTable();
            string cmd = "SELECT * FROM Permisos";
            TablaPermisos = MiConexion.ObtenerDatos(cmd);
            foreach (DataRow aux in TablaPermisos.Rows)
            {
                CPermiso Permiso = new CPermiso(Convert.ToInt32(aux["idPermiso"]), aux["Nombre"].ToString());
                ListaPermisos.Add(Permiso);
            }
            return ListaPermisos;
        }
    }
}