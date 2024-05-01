using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TPOPERATIVA.Entidades
{
    public class CUsuarios
    {
        int idUsuario;
        string Usuario;
        string NombreApellido;
        string Password;
        int Permiso;
        int Activo;

         public CUsuarios()
        {
        }

        public int idusuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        public string usuario
        {
            get { return Usuario; }
            set { Usuario = value; }
        }

        public string nombreapellido
        {
            get { return NombreApellido; }
            set { NombreApellido = value; }
        }

        public string password
        {
            get { return Password; }
            set { Password = value; }
        }

        public int permiso
        {
            get { return Permiso; }
            set { Permiso = value; }
        }

        public int activo
        {
            get { return Activo; }
            set { Activo = value; }
        }

        public CUsuarios(int id, string usu, string nomape, string pass, int per, int act)
        {
            idUsuario = id;
            Usuario = usu;
            NombreApellido = nomape;
            Password = pass;
            Permiso = per;
            Activo = act;
        }
    }
}