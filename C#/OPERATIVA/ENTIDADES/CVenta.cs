using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TPOPERATIVA.Entidades
{
    public class CVenta
    {
        int IDCliente;
        int idEnvase;
        int idLote;
        int Cantidad;
        decimal PrecioVenta;

        public int idcliente
        {
            get { return IDCliente; }
            set { IDCliente = value; }
        }

       public int idenvase
       {
           get { return idEnvase; }
           set { idEnvase = value; }
       }

       public int idlote
       {
           get { return idLote; }
           set { idLote = value; }
       }

       public int cantidad
       {
           get { return Cantidad; }
           set { Cantidad = value; }
       }

        public decimal precioventa
        {
            get { return PrecioVenta; }
            set { PrecioVenta = value; }
        }

       public CVenta()
       {
       }

       public CVenta(int idcli,int idenva, int idlot,int cant, decimal precven)
       {
           IDCliente = idcli;
           idEnvase = idenva;
           idLote = idlot;
           Cantidad = cant;
            PrecioVenta = precven;
       }
    }
}