using System;
using Xunit;
using Problemas.Codigo;

namespace Problemas.Pruebas
{
    public class Problema2Test
    {
        Problema2 problema;
        public Problema2Test()
        {
            problema = new Problema2();
        }

        [Fact]
        public void UsandoDivision()
        {
            var n1 = new int[]{1, 2, 3, 4, 5};
            var n2 = new int[]{3, 2, 1};

            var resultado1 = problema.UsandoDivision(n1);
            var resultado2 = problema.UsandoDivision(n2);

            var esperado1 = new int[]{120, 60, 40, 30, 24};
            var esperado2 = new int[]{2, 3, 6};

            Assert.Equal(esperado1, resultado1);
            Assert.Equal(esperado2, resultado2);
        }

        [Fact]
        public void SinUsarDivision()
        {
            var n1 = new int[]{1, 2, 3, 4, 5};
            var n2 = new int[]{3, 2, 1};

            var resultado1 = problema.SinUsarDivision(n1);
            var resultado2 = problema.SinUsarDivision(n2);

            var esperado1 = new int[]{120, 60, 40, 30, 24};
            var esperado2 = new int[]{2, 3, 6};

            Assert.Equal(esperado1, resultado1);
            Assert.Equal(esperado2, resultado2);
        }

    }
}
