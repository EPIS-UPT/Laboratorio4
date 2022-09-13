using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab04_martinez.Models
{
    public class ClsVenta
    {
        public bool cursophp { get; set; }
        public bool cursoweb { get; set; }
        public bool cursomovil { get; set; }
        public bool cursopython { get; set; }
        public double subtotal { get; set; }
        public double igv { get; set; }
        public double total { get; set; }

    }
}