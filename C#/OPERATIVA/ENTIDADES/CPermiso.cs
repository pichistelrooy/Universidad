using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TPOPERATIVA.Entidades
{
    public class CPermiso
    {
        int idPermiso;
        string Permiso;
        

         public CPermiso()
        {
        }

        public int idpermiso
        {
            get { return idPermiso; }
            set { idPermiso = value; }
        }

        public string perrmiso
        {
            get { return Permiso; }
            set { Permiso = value; }
        }

    

        public CPermiso(int id, string per)
        {
            idPermiso = id;
            Permiso = per;
        }
    }
}