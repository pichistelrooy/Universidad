using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using TPOPERATIVA.Controladora;
using TPOPERATIVA.Entidades;

namespace TPOPERATIVA
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Código que se ejecuta al iniciar la aplicación
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Session["C_sql_Usuarios"] = new C_sql_Usuarios();
            Session["CUsuarios"] = new CUsuarios();
            Session["C_sql_Venta"] = new C_sql_Venta();
        }

    }
}