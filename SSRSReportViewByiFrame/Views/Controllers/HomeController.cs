using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SSRSReportViewByiFrame.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["reportURL"] = Uri.EscapeUriString("../.." + System.Configuration.ConfigurationManager.AppSettings.Get("applicationURL") + System.Configuration.ConfigurationManager.AppSettings.Get("ReportViewerURL"));
            return View();
        }
    }
}
