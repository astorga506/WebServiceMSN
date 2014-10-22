using Dominio;
using LibreriaMSN.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServiceMSN
{
    /// <summary>
    /// Summary description for ClienteMSN
    /// </summary>
    [WebService(Namespace = "http://msn.cr/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ClienteMSN : System.Web.Services.WebService
    {
        private ClienteDAO cdao = new ClienteDAO();

        [WebMethod]
        public Boolean EsCliente(string correo, string contrasena)
        {
            return cdao.EsCliente(correo, contrasena);
        }//EsCliente

        [WebMethod]
        public Cliente GetCliente(int idCliente)
        {
            return cdao.GetCliente(idCliente);
        }//GetCliente
    }
}
