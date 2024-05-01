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
    public class sql_Usuarios
    {
        private static sql_Usuarios _Instance;

        protected sql_Usuarios()
        {
        }

        public static sql_Usuarios Instance()
        {
            if (_Instance == null)
            {
                _Instance = new sql_Usuarios();
            }
            return _Instance;
        }

        CONEXION MiConexion = new CONEXION();

        public void Agregar(CUsuarios Usuarios)
        {
            string cmd = "INSERT INTO Usuarios (Usuario, password, nombre, idpermiso) VALUES ('" +
                Usuarios.usuario + "','" + Usuarios.password + "'," + Usuarios.nombreapellido + "," 
                + Usuarios.permiso + "')";
            MiConexion.EjecutarSql(cmd);
        }

        public void Modificar(CUsuarios Usuarios)
        {
            string cmd = "UPDATE Usuarios SET Usuario = " + Usuarios.usuario + "', nombre = '" + 
                Usuarios.nombreapellido + "', password = '" + Usuarios.password + "', idpermiso = '" + 
                Usuarios.permiso;
            MiConexion.EjecutarSql(cmd);
        }

        public void Eliminar(int idUsuario)
        {
            string cmd = "update Usuarios set activo = 0 where idusuario = " + idUsuario;
            MiConexion.EjecutarSql(cmd);
        }

        public void ActivarUsuario(int idusuario)
        {
            string cmd = "update usuarios set activo = 1 where idusuario = " + idusuario;
            MiConexion.EjecutarSql(cmd);
        }

        public List<CUsuarios> ListaUsuarios()
        {
            List<CUsuarios> ListaUsuarios = new List<CUsuarios>();
            DataTable TablaUsuarios = new DataTable();
            string cmd = "SELECT * FROM Usuarios";
            TablaUsuarios = MiConexion.ObtenerDatos(cmd);
            foreach (DataRow aux in TablaUsuarios.Rows)
            {
                CUsuarios Usuarios = new CUsuarios(Convert.ToInt32(aux["idusuario"]), aux["Usuario"].ToString(), aux["nombre"].ToString(), 
                    aux["password"].ToString(), Convert.ToInt32(aux["idpermiso"]), Convert.ToInt32(aux["activo"]));
                ListaUsuarios.Add(Usuarios);
            }
            return ListaUsuarios;
        }

        public CUsuarios UsuarioLog(string usuario, string con)
        {
            string cmd = "SELECT * FROM Usuarios where usuario='" + usuario + "'";
            DataTable dataUsuarios = MiConexion.ObtenerDatos(cmd);
            foreach (DataRow aux in dataUsuarios.Rows)
            {
                if (aux["password"].ToString() != con)
                {
                    throw new Exception("*Contraseña invalida.");
                }
                CUsuarios oUsuario = new CUsuarios();
                oUsuario.idusuario = Convert.ToInt32(aux["idusuario"].ToString());
                oUsuario.nombreapellido = aux["nombre"].ToString();
                oUsuario.usuario = aux["Usuario"].ToString();
                oUsuario.password = aux["password"].ToString();
                oUsuario.permiso = Convert.ToInt32(aux["idPermiso"]);
                oUsuario.activo = Convert.ToInt32(aux["activo"]);
                    
                return oUsuario;
            }
            return null;
        }
    }
}