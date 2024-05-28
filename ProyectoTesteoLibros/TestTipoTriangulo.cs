using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTesteoLibros
{
    public class TestTipoTriangulo
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Testequilatero()
        {
            string resultado = ProgramEjercicios.TestTipoDeTriangulos
                (1, 1, 1);
            Assert.That(resultado, Is.EqualTo("equilátero"));
        }

        [Test]
        public void Testescaleno()
        {
            string resultado = ProgramEjercicios.TestTipoDeTriangulos
                (1, 1, 4);
            Assert.That(resultado, Is.EqualTo("isóceles"));
        }
        [Test]
        public void Testisoceles()
        {
            string resultado = ProgramEjercicios.TestTipoDeTriangulos
                (1, 2, 3);
            Assert.That(resultado, Is.EqualTo("escaleno"));
        }
    }
}
