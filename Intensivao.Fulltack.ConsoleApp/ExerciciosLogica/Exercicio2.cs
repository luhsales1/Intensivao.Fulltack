using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Exercicio2
{
    public static void Calcular()
    {
        Console.WriteLine("2ºElabore um algoritmo que recebe o salário mensal atual de um funcionário e um percentual de reajuste e exiba o novo salário.");
        Console.WriteLine();


        {
            double salario, NovoSalario, reajuste;
            double percent = 10;

            Console.WriteLine("Digite seu Salário: ");
            salario = Convert.ToDouble(Console.ReadLine());


            if (salario >= 0)
            {
                reajuste = salario * 0.10;
                NovoSalario = salario + reajuste;
                percent = 10;
                Console.WriteLine("Seu Salário foi reajustado para: {0:0.00}", NovoSalario);
                Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
                Console.WriteLine("Em percentual: {0} %", percent);
            }
            else
            {
                return;
            }
        }
    }
}




