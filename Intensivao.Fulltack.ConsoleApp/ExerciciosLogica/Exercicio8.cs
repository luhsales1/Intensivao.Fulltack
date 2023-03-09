using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Exercicio8
{
    public static void Calcular()
    {
        int notas, resto;

        notas = int.Parse(Console.ReadLine());
        Console.Clear();

        Console.WriteLine(notas);

        Console.WriteLine($"{notas / 100} Notas de R$100,00");
        resto = (notas % 100);

        Console.WriteLine($"{resto / 50} Notas de R$50,00");
        resto = resto % 50;

        Console.WriteLine($"{resto / 20} Notas de R$20,00");
        resto = resto % 20;

        Console.WriteLine($"{resto / 10} Notas de R$10,00");
        resto = resto % 20;

        Console.WriteLine($"{resto / 5} Notas de R$5,00");
        resto = resto % 5;

        Console.WriteLine($"{resto / 2} Notas de R$2,00");
        resto = resto % 2;

        Console.WriteLine($"{resto / 1} Notas de R$1,00");
        resto = resto % 1;

    }
}




