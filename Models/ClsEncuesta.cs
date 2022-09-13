using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab04_martinez.Models
{
    public class ClsEncuesta
    {
        public string pregunta1 { get; set; }
        public string pregunta2 { get; set; }
        public string pregunta3 { get; set; }

        public int voto1 { get; set; }
        public int voto2 { get; set; }
        public int voto3 { get; set; }

        public double porcentaje1 { get; set; }
        public double porcentaje2 { get; set; }
        public double porcentaje3  { get; set; }

        public int totalvoto { get; set; }
        public double totalporcentaje { get; set; }
    }
}