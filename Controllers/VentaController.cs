using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab04_martinez.Models;

namespace Lab04_martinez.Controllers
{
    public class VentaController : Controller
    {
        public static double precioC1 = 500, precioC2=350,precioC3=1500,precioC4=850.99;
        // GET: Venta
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CalcularVenta(ClsVenta objVenta)
        {
            if (objVenta.cursophp == true)
            {
                objVenta.subtotal = objVenta.subtotal + precioC1;
            }
            if (objVenta.cursoweb == true)
            {
                objVenta.subtotal = objVenta.subtotal + precioC2;
            }
            if (objVenta.cursomovil == true)
            {
                objVenta.subtotal = objVenta.subtotal + precioC3;
            }
            if (objVenta.cursopython == true)
            {
                objVenta.subtotal = objVenta.subtotal + precioC4;
            }

            objVenta.igv = objVenta.subtotal * 0.18;
            objVenta.total = objVenta.subtotal + objVenta.igv;

            return View(objVenta);

            //<a href="~/Venta/CalcularVenta">
        }
    }
}