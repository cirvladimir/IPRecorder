using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IPRecordewr.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public string Index(string who)
        {
            if (this.HttpContext.Application.AllKeys.Contains("ip" + who))
                return (string)this.HttpContext.Application["ip" + who];
            return "Not set";
        }

        public void Record(string who)
        {
            this.HttpContext.Application["ip" + who] = this.Request.UserHostAddress;
        }
    }
}