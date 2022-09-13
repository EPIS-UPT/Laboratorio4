using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab04_martinez.Models;
namespace Lab04_martinez.Controllers
{
    public class EncuestasController : Controller
    {
        private ClsEncuestas Encuesta;
        // GET: Encuestas
        public ActionResult Index()
        {
            return View();
        }
        public EncuestasController()
        {
            if (System.Web.HttpContext.Current.Session["encuesta"] == null)
            {
                Encuesta = new ClsEncuestas();

                Encuesta.titulo = "¿Qué lenguaje de programación te gustaría seguir?";

                Encuesta.total = 0;
                Encuesta.Alternativa = new List<ClsAlternativa>();

                ClsAlternativa alter1 = new ClsAlternativa();
                alter1.titulo = "Java";
                alter1.cantidad = 0;
                alter1.porcentaje = 0;
                Encuesta.Alternativa.Add(alter1);

                ClsAlternativa alter2 = new ClsAlternativa();
                alter2.titulo = "Python";
                alter2.cantidad = 0;
                alter2.porcentaje = 0;
                Encuesta.Alternativa.Add(alter2);

                ClsAlternativa alter3 = new ClsAlternativa();
                alter3.titulo = "C#";
                alter3.cantidad = 0;
                alter3.porcentaje = 0;
                Encuesta.Alternativa.Add(alter3);

                ClsAlternativa alter4 = new ClsAlternativa();
                alter4.titulo = "JavaScript";
                alter4.cantidad = 0;
                alter4.porcentaje = 0;
                Encuesta.Alternativa.Add(alter4);

                ClsAlternativa alter5 = new ClsAlternativa();
                alter5.titulo = "Cobol";
                alter5.cantidad = 0;
                alter5.porcentaje = 0;
                Encuesta.Alternativa.Add(alter5);
            }
            else
            {
                Encuesta = System.Web.HttpContext.Current.Session["encuesta"] as ClsEncuestas;
            }
        }
        // GET: Encuestas

        [HttpGet]
        public ActionResult Index(ClsEncuestas encuesta)
        {
            return View(Encuesta);
        }

        
        /*
        public ActionResult Index()
        {
            int index = Int32.Parse(Request["index"].ToString());

            ClsAlternativa alternativa = Encuesta.Alternativa[index];

            alternativa.cantidad++;
            Encuesta.total = Encuesta.Alternativa.Sum(x => x.cantidad);

            foreach (ClsAlternativa alt in Encuesta.Alternativa)
            {
                alt.porcentaje = alt.cantidad * 100 / Encuesta.total;
            }

            System.Web.HttpContext.Current.Session["encuesta"] = Encuesta;

            return View(Encuesta);
        }
        */
    }

}