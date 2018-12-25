/*
Good morning! Here's your coding interview problem for today.

This problem was recently asked by Google.

Given a list of numbers and a number k, return whether any two numbers from the list add up to k.

For example, given [10, 15, 3, 7] and k of 17, return true since 10 + 7 is 17.

Bonus: Can you do this in one pass?

 */
 
using System;
using System.Collections.Generic;

namespace Problemas.Codigo
{
    public class Problema1
    {
        /*
        Se consigue un algoritmo de complejidad lineal O(N) para dar respuesta a este problema.

        Se quiere encontrar 2 numeros que sumen K en una lista. Por lo tanto: K = a + b

        Ejemplo: K = 17; numeros = {10,3,7}

        Entonces hacemos lo siguiente en el loop:
            - Primera iteracion: 
                Preguntamos si existe un complemento 7 (17 - 10) (K - n[i])
                Como no existe, ingresando un item al hashset con el indice 10 (n[i])

            -Segunda iteracion:
                Preguntamos si existe un complemento 14 (17 - 3) (K - n[i])
                Como no existe, ingresando un item al hashset con el indice 3 (n[i])

            -Tercera iteracion:
                Preguntamos si existe un complemento 10 (17 - 7) (K - n[i])
                Como SI existe porque lo agregamos en la 1ra iteración, podemos cambiar a TRUE y salir del loop

         */
        public bool ObtenerRespuesta(int[] n, int k)
        {
            var resultado = false;
            HashSet<int> set = new HashSet<int>();

            for (int i = 0; i < n.Length; i++)
            {
                if(set.Contains(k - n[i]))
                {
                    resultado = true;         
                    break;
                }       
                set.Add(n[i]);
            }

            return resultado;
        }

        /*
        Esta versión usa una complejidad cuadrática O(n2) al usar 2 loops, uno anidado al otro.
        Es una respuesta menos eficiente pero más fácil de deducir que la anterior.
         */
        public bool ObtenerRespuestaMenosEficiente(int[] n, int k)
        {
            var resultado = false;
            
            for (int i = 0; i < n.Length-1; i++)
            {
                //Siempre empieza en el indice siguiente al del loop anterior
                //En el peor de los casos, todos los numeros seran sumados entre si
                //Debido a esto, el crecimiento es exponencial en referencia a la variable "n"
                for (int j = (i+1); j < n.Length; j++)
                {
                    if(n[i] + n[j] == k)
                    {
                        resultado = true;
                        break;
                    }
                }
            }

            return resultado;
        }
    }
}
