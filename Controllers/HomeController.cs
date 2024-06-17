using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace STEAM2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Homepage()
        {
            return View();
        }

        // GET: About
        public ActionResult About()
        {
            return View();
        }

        // GET: Contatti
        public ActionResult Contact()
        {
            return View();
        }

        // GET: paginaGioco
        public ViewResult paginaGioco(int? idGioco)
        {
            ViewBag.idGioco = idGioco;
            return View();
        }
    }
}