using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab04_martinez.Models
{
    public class ClsEncuestas
    {
        public string titulo { get; set; }
        public int total { get; set; }
        public List<ClsAlternativa> Alternativa { get; set; }
    }
}