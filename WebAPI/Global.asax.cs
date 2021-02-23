using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Http;
using System.Web.Routing;
using WebAPI.Global;

namespace WebAPI
{

    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);


            string Conn = WebConfigurationManager.ConnectionStrings["MesDB"].ConnectionString;

            EncrytLibrary.AES aes = new EncrytLibrary.AES();
            ConnString.strConn = aes.AESDecrypt256(Conn);


            log4net.Config.XmlConfigurator.Configure();

        }
    }
}
