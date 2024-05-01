using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TPOPERATIVA.DAO;
using TPOPERATIVA.Entidades;

namespace TPOPERATIVA.Controladora
{
    public class C_sql_Lotes
    {
        sql_Lotes oLotes = sql_Lotes.Instance();

        public void Agregar(int idlote, int idenvase, int cant, int disp, decimal preciocomp)
        {
            CLotes oLote = new CLotes();
            oLote.idlote = idlote;
            oLote.idenvase = idenvase;
            oLote.cantidad = cant;
            oLote.disponibles = disp;
            oLote.preciocompra = preciocomp;

            oLotes.Agregar(oLote);
        }

        public void Eliminar(int id)
        {
            oLotes.Eliminar(id);
        }

        public void Modificar(CLotes Lotes)
        {
            oLotes.Modificar(Lotes);
        }
    }
}