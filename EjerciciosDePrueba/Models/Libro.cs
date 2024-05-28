using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDePrueba.Models
{
    public class Libro
    {
        public string _id { get; set; }
        public string nombre { get; set; }
        public int capitulos { get; set; }
        public string portada_url { get; set; }
        public string sinopsis { get; set; }
        public string estado { get; set; }
    }
}
