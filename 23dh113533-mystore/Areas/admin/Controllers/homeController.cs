using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _23dh113533_mystore.Areas.admin.Controllers
{
    public class homeController : Controller
    {
        // GET: admin/home
        public ActionResult Index()
        {
            return View();
        }
    }
}