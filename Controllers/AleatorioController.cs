using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab04_martinez.Models;

namespace Lab04_martinez.Controllers
{
    public class AleatorioController : Controller
    {
        // GET: Aleatorio
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Generar(ClsAteatorio objAleatorio)
        {
            Random random = new Random();
            objAleatorio.a = random.Next(3);
            objAleatorio.b = random.Next(3);
            objAleatorio.c = random.Next(3);

            if(objAleatorio.a == objAleatorio.b)
            {
                if (objAleatorio.b == objAleatorio.c)
                {
                    objAleatorio.resultado = "Los 3 numeros son iguales. Ganaste una entrada!";
                }
                else
                {
                    objAleatorio.resultado = "Perdiste, sigues intentando...";
                }
            }
            
            return View(objAleatorio);
        }
    }
}