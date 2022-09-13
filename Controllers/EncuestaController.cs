using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab04_martinez.Models;

namespace Lab04_martinez.Controllers
{
    public class EncuestaController : Controller
    {
        // GET: Encuesta
        public ActionResult Index()
        {
            return View();
        }

        public EncuestaController()
        {

          /*
            Session["cv1"] = 0;
            Session["vp1"] = 0;
            Session["pc1"] = 0;

            Session["cv2"] = 0;
            Session["vp2"] = 0;
            Session["pc2"] = 0;

            Session["cv3"] = 0;
            Session["vp3"] = 0;
            Session["pc3"] = 0;
            
          */
        }

        public ActionResult Encuestar(ClsEncuesta objEncuesta)
        {
            
            
            ViewBag.Pregunta1 = "PHP";
            ViewBag.Pregunta2 = "Python";
            ViewBag.Pregunta3 = "Java";

            objEncuesta.totalvoto = 0;
            objEncuesta.totalporcentaje = 0.0d;

            

            if (@Request["curso"]=="Curso 1")
            {
                int cont = 0;

                if (Session["cv1"] == null)
                {
                    Session["cv1"] = 1;
                }
                else
                {
                    cont = Convert.ToInt32(Session["cv1"]);
                    cont++;
                    Session["cv1"] = cont;
                    objEncuesta.totalvoto+= Convert.ToInt32(Session["cv1"]);

                }
            }
            if (@Request["curso"] == "Curso 2")
            {
                int cont = 0;

                if (Session["cv2"] == null)
                {
                    Session["cv2"] = 1;
                }
                else
                {
                    cont = Convert.ToInt32(Session["cv2"]);
                    cont++;
                    Session["cv2"] = cont;
                    objEncuesta.totalvoto += Convert.ToInt32(Session["cv2"]);

                }
            }
            if (@Request["curso"] == "Curso 3")
            {
                int cont = 0;

                if (Session["cv3"] == null)
                {
                    Session["cv3"] = 1;
                }
                else
                {
                    cont = Convert.ToInt32(Session["cv3"]);
                    cont++;
                    Session["cv3"] = cont;
                    objEncuesta.totalvoto += Convert.ToInt32(Session["cv3"]);

                }
            }

            Session["totalvotos"] = Convert.ToInt32((Session["cv1"])) + Convert.ToInt32((Session["cv2"])) + Convert.ToInt32((Session["cv3"]));

            //Session["vp1"] = (Convert.ToDouble(Session["porc1"])).ToString("0.00");
            Session["pc1"] = (Convert.ToDouble(Session["cv1"]) * 100.0d / Convert.ToDouble(Session["totalvotos"])).ToString("0.00");

            //Session["vp2"] = (Convert.ToDouble(Session["porc2"])).ToString("0.00");
            Session["pc2"] = (Convert.ToDouble(Session["cv2"]) * 100.0d / Convert.ToDouble(Session["totalvotos"])).ToString("0.00");

            //Session["vp3"] = (Convert.ToDouble(Session["porc3"])).ToString("0.00");
            Session["pc3"] = (Convert.ToDouble(Session["cv3"]) * 100.0d / Convert.ToDouble(Session["totalvotos"])).ToString("0.00");

            Session["totalporcentaje"] = (Convert.ToDouble(Session["pc1"]) + Convert.ToDouble(Session["pc2"])+ Convert.ToDouble(Session["pc3"])).ToString("0.00");

            return View(objEncuesta);
        }
    
        public ActionResult Reiniciar (ClsEncuesta objEncuesta)
        {
            Session["cv1"] = 1;
            Session["cv2"] = 1;
            Session["cv3"] = 1;

            return View(objEncuesta);
        }
    }
}