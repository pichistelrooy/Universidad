using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TPOPERATIVA.Entidades
{
    public class CLotes
    {
        int IDLote;
        int IDEnvase;
        int Cantidad;
        int Disponibles;
        Decimal PrecioCompra;


        public int idlote
        {
            get { return IDLote; }
            set { IDLote = value; }
        }

        public int idenvase
        {
            get { return IDEnvase; }
            set { IDEnvase = value; }
        }

        public int cantidad
        {
            get { return Cantidad; }
            set { Cantidad = value; }
        }

        public int disponibles
        {
            get { return Disponibles; }
            set { Disponibles = value; }
        }

        public decimal preciocompra
        {
            get { return PrecioCompra;  }
            set { PrecioCompra = value; }
        }

        public CLotes()
        {
        }

        public CLotes(int lote, int envase, int cant, int dispo, decimal precio)
        {
            IDLote = lote;
            IDEnvase = envase;
            Cantidad = cant;
            Disponibles = dispo;
            PrecioCompra = preciocompra;
        }
    }
}