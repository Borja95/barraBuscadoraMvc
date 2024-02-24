using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BarraBuscadoraMvcTutorial.Models
{
    public class Atleta
    {
        public int Id { get; set; }
        public string Nombre_Atleta { get; set; }
        public string Pais_Origen { get; set; }
        public string Marca { get; set; }
        public string Lugar_Marca { get; set; }
        public int Anio_Marca { get; set; }
    }
}