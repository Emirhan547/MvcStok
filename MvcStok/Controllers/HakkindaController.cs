using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcStok.Models.Entity;

namespace MvcStok.Controllers
{
    public class HakkindaController : Controller
    {
        // GET: Hakkında
        public ActionResult Index()
        {
            return View();
        }
    }
}