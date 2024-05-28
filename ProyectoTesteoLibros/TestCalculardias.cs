using EjerciciosDePrueba.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTesteoLibros
{
    public class TestCalculardias
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test31años6meses21dias()
        {
            int resultado = ProgramEjercicios.TestCalcularDiasDeVida
                (31, 6, 21);
            Assert.That(resultado, Is.EqualTo(11522));
        }
        [Test]
        public void Test20años2meses3dias()
        {
            int resultado = ProgramEjercicios.TestCalcularDiasDeVida
                (20, 2, 3);
            Assert.That(resultado, Is.EqualTo(7365));
        }
    }
}
