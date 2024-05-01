using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TPOPERATIVA.DAO;
using TPOPERATIVA.Entidades;

namespace TPOPERATIVA.Controladora
{
    public class C_sql_Permiso
    {
        sql_Permiso oPermiso = sql_Permiso.Instance();

        public List<CPermiso> ListaPermisos
        {
            get
            {
                return oPermiso.ListaPermisos();
            }
        }
    }
}