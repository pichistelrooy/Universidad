using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TPOPERATIVA.DAO;
using TPOPERATIVA.Entidades;

namespace TPOPERATIVA.Controladora
{
    public class C_sql_Envases
    {
        sql_Envases oEnvases = sql_Envases.Instance();

        public void Agregar(int idenva, string denom, int capa)
        {
            CEnvases oEnvase = new CEnvases();
            oEnvase.idenvase = idenva;
            oEnvase.denominacion = denom;
            oEnvase.capacidad = capa;

            oEnvases.Agregar(oEnvase);
        }

        public void Eliminar(int id)
        {
            oEnvases.Eliminar(id);
        }

        public void Modificar(CEnvases Envases)
        {
            oEnvases.Modificar(Envases);
        }

        public int ComprobarEnvase(int idenvase)
        {
            return oEnvases.ComprobarEnvase(idenvase);
        }
    }
}