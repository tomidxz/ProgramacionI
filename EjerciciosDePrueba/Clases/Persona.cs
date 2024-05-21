using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDePrueba.Clases
{
    internal class Persona
    {
        private string nombre;
        private string dirección;
        private int año_nac;
        public string Apellido { get; set; }
        private int dni;

        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }



        public Persona(string nombre, string dirección, int año_nac)
        {
            this.nombre = nombre;
            this.dirección = dirección;
            this.año_nac = año_nac;
        }

        public void Decir(string texto)
        {
            Console.WriteLine($"{this.nombre} dice: {texto}");
        }
    }
}
