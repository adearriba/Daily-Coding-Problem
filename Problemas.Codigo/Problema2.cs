/*
This problem was asked by Uber.

Given an array of integers, return a new array such that each element at index i of the new array is the product 
of all the numbers in the original array except the one at i.

For example, if our input was [1, 2, 3, 4, 5], the expected output would be [120, 60, 40, 30, 24]. 
If our input was [3, 2, 1], the expected output would be [2, 3, 6].

Follow-up: what if you can't use division?
 */
 
 using System;

public class Problema2
{
    /*
    Usando division podemos tener una complejidad lineal O(N)
    Primero resolvemos la multiplicación total y luego "cancelamos" el elemento dividiéndolo.
    Esto es por la regla básica de multiplicación y división.
     */
    public int[] UsandoDivision(int[] numeros){
        var resultado = new int[numeros.Length];
        var multiplicacion = 1;

        //Resolvemos la multiplicacion total primero
        for (int i = 0; i < numeros.Length; i++)
        {
            multiplicacion *= numeros[i];
        }

        //Por cada elemento dividimos por si mismo y lo agregamos al resultado
        for (int i = 0; i < numeros.Length; i++)
        {
            resultado[i] = multiplicacion / numeros[i];
        }

        return resultado;
    }

    /*
    Sin usar división no parece posible que la solución sea lineal.
    Solamente encuentro una solución con complejidad cuadrática 0(N^2).
     */
    public int[] SinUsarDivision(int[] numeros){
        var resultado = new int[numeros.Length];

        for (int i = 0; i < numeros.Length; i++)
        {
            resultado[i] = 1;
            for (int j = 0; j < numeros.Length; j++)
            {
                if (i==j)
                    continue;
                
                resultado[i] *=  numeros[j];
            }
        }

        return resultado;
    }
}