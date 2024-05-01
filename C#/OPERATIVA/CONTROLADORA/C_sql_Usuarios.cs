using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TPOPERATIVA.DAO;
using TPOPERATIVA.Entidades;

namespace TPOPERATIVA.Controladora
{
    public class C_sql_Usuarios
    {
        sql_Usuarios oUsuarios = sql_Usuarios.Instance();

        public void Agregar(string user, string nombre, string password, int permiso)
        {
            CUsuarios oUsuario = new CUsuarios();
            oUsuario.usuario = user;
            oUsuario.nombreapellido = nombre;
            oUsuario.password = password;
            oUsuario.permiso = permiso;

            oUsuarios.Agregar(oUsuario);
        }

        public void Modificar(string user, string nombre, string password, int permiso)
        {
            CUsuarios oUsuario = new CUsuarios();
            oUsuario.usuario = user;
            oUsuario.nombreapellido = nombre;
            oUsuario.password = password;
            oUsuario.permiso = permiso;

            oUsuarios.Modificar(oUsuario);
        }

        public void Eliminar(int id)
        {
            oUsuarios.Eliminar(id);
        }

        public void ActivarUsuario(int id)
        {
            oUsuarios.ActivarUsuario(id);
        }

        public List<CUsuarios> ListaUsuarios
        {
            get
            {
                return oUsuarios.ListaUsuarios();
            }
        }

        public CUsuarios Usuario(string usuario, string con)
        {
            if (usuario == "" || con == "")
            {
                throw new Exception("*Error al registrar los datos.");
            }
            CUsuarios oUsuario = oUsuarios.UsuarioLog(usuario, con);
            if (oUsuario == null)
            {
                throw new Exception("*Usuario inexistente.");
            }

            return oUsuario;
        }

    }
}