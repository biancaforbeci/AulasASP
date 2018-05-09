using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MeuPrimeiroProjetoWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Página de descrição da aplicação";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Página de contato"; // precisa ter o mesmo nome ViewBag.Message aqui e na view.

            return View();
        }

        public ActionResult Testando()
        {
            ViewBag.Message = "Página de teste";

            return View();
        }

    }
}