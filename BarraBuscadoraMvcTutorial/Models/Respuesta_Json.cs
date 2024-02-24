using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BarraBuscadoraMvcTutorial.Models
{
    public class Respuesta_Json
    {
        public int Codigo { get; set; }
        public string Mensaje { get; set; }
        public object Data { get; set; }
    }
}