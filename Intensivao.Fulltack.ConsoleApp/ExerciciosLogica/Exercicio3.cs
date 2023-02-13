using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Exercicio3
{
    public static void Calcular()
    {
        Console.WriteLine("3º Realize um cálculo de média final entre quatro notas e informe se ele está na média, abaixo ou acima, considerando que \r\n  abaixo (menor que 4 pontos), na média (entre 4 e menor que 7 pontos) e acima (maior ou igual que 7 pontos)");
        Console.WriteLine();


        static void Main(string[] args)
        {

            Console.WriteLine("Digite a primeira nota: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota: ");
            double c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a quarta nota: ");
            double d = Convert.ToDouble(Console.ReadLine());

            double media = (a + b + c + d) / 4;

            if (media < 4)
            {
                Console.WriteLine("Aluno abaixo da média");
                Console.WriteLine("Sua média foi: " + media);
            }
            else if (media >= 4 && media < 7)
            {
                Console.WriteLine("Aluno na média");
                Console.WriteLine("Sua média foi: " + media);
            }
            else if (media >= 7)
            {
                Console.WriteLine("Parabéns!! Aprovado a cima da média.");
                Console.WriteLine($"Sua média foi:  {media}");
            }
        }
    }
}






