using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.MyMessage = " Hi guys, how area you there.";
            ViewBag.Vaca = "Mascarin";

            return View();
        }

        [HttpPost]
        public ActionResult About(string email)
        {

            List<Usuario> usuarios = new List<Usuario>(){
                new Usuario{
                    email = email,
                    nombre = "Pedro castillo",
                },
                new Usuario{
                    email = email,
                    nombre = "Saco largo"
                }
            };
            // ViewBag : no es recomendable al pasar dato de un modelo
            // Loa adecuado es enviar el objeto

            ViewBag.Message = "Your application description page.";
            return View(usuarios);
        }
        [HttpGet]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
    }


    public class Usuario
    {
        public String email{get;set;}
        public String nombre{get;set;}

        public void SendEmail()
        {

        }
    }
}