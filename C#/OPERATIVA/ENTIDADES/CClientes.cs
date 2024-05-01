using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TPOPERATIVA.Entidades
{
    public class CClientes
    {

        int idCliente;
        string Nombre;

        public int idcliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }

        public string nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }

        public CClientes()
        {
        }

        public CClientes(int idcli, string nom)
        {
            idCliente = idcli;
            Nombre = nom;
        }

    }
}