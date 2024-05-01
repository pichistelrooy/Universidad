using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace TPOPERATIVA.DAO
{
    public class Conexión
    {
        SqlConnection MiConexion = new SqlConnection("Data Source=DESKTOP-3EJVH6H;Initial Catalog=OPERATIVA;Integrated Security=True");

        public void IniciarConexion()
        {
            try
            {
                if (MiConexion.State == ConnectionState.Closed)
                {
                    MiConexion.Open();
                }
            }
            catch
            {
                throw new Exception("Error de Conexión al Servidor... verifique");
            }
        }

        public void TerminarConexión()
        {
            try
            {
                MiConexion.Close();
            }
            catch
            {
                throw new Exception("Error de Conexión al Servidor... verifique");
            }
        }

        public DataTable ObtenerDatos(string CommandText)
        {
            try
            {
                DataTable DatosTabla = new DataTable();
                SqlCommand cmd = new SqlCommand(CommandText, MiConexion);
                IniciarConexion();
                SqlDataReader DataLeer = cmd.ExecuteReader();
                DatosTabla.Load(DataLeer);
                TerminarConexión();
                return DatosTabla;
            }
            catch
            {
                throw new Exception("Error al leer datos del Servidor... verifique");
            }
        }

        public object Eject(string cmdtext)
        {
            object aux = null;
            SqlCommand cmd = new SqlCommand(cmdtext, MiConexion);
            IniciarConexion();
            aux = cmd.ExecuteScalar();
            TerminarConexión();
            return aux;
         }

        public void EjecutarSql(string cmdtext)
        {
            SqlCommand cmd = new SqlCommand(cmdtext, MiConexion);
            IniciarConexion();
            cmd.ExecuteNonQuery();
            TerminarConexión();
        }
    }
}