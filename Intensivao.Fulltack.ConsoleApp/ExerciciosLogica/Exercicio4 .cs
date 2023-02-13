using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Exercicio4
{
    public static void Calcular()
    {
        Console.WriteLine("4º Crie um vetor que com os seguintes valores: 2, 5, 15, 56, 22, 3, 9, sabendo disso, ordene os valores de forma sequencial e repita 3x o valor '22'.");


        int[] numeros = new int[] { 2, 5, 15, 56, 22, 3, 9 };


        Array.Sort(numeros);
        foreach (int numero in numeros)
        {
            if (numero == 22)
            {
                for (int i = 0; i <= 2; i++)
                {
                    Console.Write(numero + ", ");
                }
            }


            else
            {
                Console.Write(numero);
            }

        }
    }
}

    
    

