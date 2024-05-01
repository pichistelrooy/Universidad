using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TPOPERATIVA.DAO;
using TPOPERATIVA.Entidades;

namespace TPOPERATIVA.Controladora
{
    public class C_sql_Clientes
    {
        sql_Clientes oClientes = sql_Clientes.Instance();

        public void Agregar(int idcliente, string nombre)
        {
            CClientes oCliente = new CClientes();
            oCliente.idcliente = idcliente;
            oCliente.nombre = nombre;

            oClientes.Agregar(oCliente);
        }

        public void Eliminar(int id)
        {
            oClientes.Eliminar(id);
        }

        public void Modificar(CClientes Clientes)
        {
            oClientes.Modificar(Clientes);
        }

    }
}