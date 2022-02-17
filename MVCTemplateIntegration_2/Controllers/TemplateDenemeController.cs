using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTemplateIntegration_2.Controllers
{
    public class TemplateDenemeController : Controller
    {
        // GET: TemplateDeneme
        public ActionResult Index()
        {
            return View();
        }
    }
}