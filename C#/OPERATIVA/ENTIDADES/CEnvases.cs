using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TPOPERATIVA.Entidades
{
    public class CEnvases
    {
        int idEnvase;
        string Denominacion;
        int Capacidad;
        
        public int idenvase
        {
            get { return idEnvase; }
            set { idEnvase = value; }
        }

        public int capacidad
        {
            get { return Capacidad; }
            set { Capacidad = value; }
        }

        public string denominacion
        {
            get { return Denominacion; }
            set { Denominacion = value; }
        }

        public CEnvases()
        {
        }

        public CEnvases(int idenva, string nombre, int capa)
        {
            idEnvase = idenva;
            Denominacion = nombre;
            Capacidad = capa;
        }

    }
}