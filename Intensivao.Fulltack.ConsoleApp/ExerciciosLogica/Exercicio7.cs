using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Exercicio7
{
    public static void Calcular()
    {
        Console.WriteLine("7º Uma fábrica controla o tempo de trabalho sem acidentes pela quantidade de dias. Faça um " +
            "algoritmo para converter este tempo em anos, meses e dias.Assuma que cada mês possui sempre 30 dias.");
        Console.WriteLine();


        Console.Write("Digite a quantidade de dias sem acidente: ");
        int qtdDias = Convert.ToInt32(Console.ReadLine());
        double ano;
        double mes;

        if (qtdDias >= 0)
        {
            ano = qtdDias / 365;
            Console.WriteLine("Qtd de anos sem acidente: " + ano);
        }
        if (qtdDias >= 0)
        {
            mes = qtdDias / 30;
            Console.WriteLine("Quantidade de meses sem acidente: " + mes);

        }
        





    }
}

    
    

