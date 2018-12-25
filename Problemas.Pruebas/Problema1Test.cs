using System;
using Xunit;
using Problemas.Codigo;

namespace Problemas.Pruebas
{
    public class Problema1Test
    {
        Problema1 problema;
        public Problema1Test()
        {
            problema = new Problema1();
        }

        [Theory]
        [InlineData(new int[]{1,2,3,4,7,10}, 17)]
        [InlineData(new int[]{1,2,3,4,7,8}, 15)]
        [InlineData(new int[]{1,9,7,2}, 3)]
        public void RespuestaExisteEnElArreglo(int[] numbers, int k)
        {
            var n = numbers;
            var resultado = problema.ObtenerRespuesta(n, k);
            var resultado2 = problema.ObtenerRespuestaMenosEficiente(n, k);
            Assert.True(resultado, String.Format("No se encontró la suma de {0} en el arreglo {1}", k, n));
            Assert.True(resultado2, String.Format("No se encontró la suma de {0} en el arreglo {1}", k, n));
        }

        [Theory]
        [InlineData(new int[]{1,2,3,4,7,10}, 16)]
        [InlineData(new int[]{1,2,3,4,7,8}, 14)]
        [InlineData(new int[]{1,9,7,2}, 4)]
        public void RespuestaNoExisteEnElArreglo(int[] numbers, int k)
        {
            var n = numbers;
            var resultado = problema.ObtenerRespuesta(n, k);
            var resultado2 = problema.ObtenerRespuestaMenosEficiente(n, k);
            Assert.False(resultado, String.Format("Se encontró la suma de {0} en el arreglo {1}", k, n));
            Assert.False(resultado2, String.Format("Se encontró la suma de {0} en el arreglo {1}", k, n));
        }
    }
}
