﻿using Dominio;
using LibreriaMSN.Dominio;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServiceMSN
{
    /// <summary>
    /// Summary description for MSN
    /// </summary>
    [WebService(Namespace = "http://msn.cr/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class MSN : System.Web.Services.WebService
    {

    }//class
}//namespace
