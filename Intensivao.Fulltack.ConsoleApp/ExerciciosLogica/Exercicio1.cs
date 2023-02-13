using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Exercicio1
{
    public static void Calcular()
    {
        Console.WriteLine("1º Crie um vetor com nomes de todos os integrantes do intensivão exiba todos os nomes, \r\n  " +
            "e também faça com que acrescente os sobrenomes para cada integrante e exiba novamente com os nomes completos.");
        Console.WriteLine();


        string[] names = new string[] { "Matheus", "Sergio Hideki", "Amanda", "Laura", "Ruana", "Tiago", "Jean", "Marlei",
                "Nicoly", "Junior", "Victor", "Luciana"};

        string[] sobrenomes = new string[] { " Lemos", " Ono", " Leticia", " Montenegro", " Rodrigues", " Freitas", " Jesus", " Correia",
                " Kethylin", " Soac", " Pessoa", " Sales"};

        for (int a = 0; a < names.Length; a++)
        {
            Console.Write($"{names[a]} | ");
            Console.WriteLine(names[a] + " " + sobrenomes[a]);

        }
    }
}

    
    

