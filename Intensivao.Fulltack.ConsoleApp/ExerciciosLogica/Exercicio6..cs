﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Exercicio6
{
    public static void Calcular()

    {
        Double PesoPrato, ValorPagar;
        

        Console.WriteLine("6º O restaurante sancho-pança cobra R$12,00 por cada quilo de refeição." +
            " Escreva um algoritmo que leia o peso do prato montado pelo cliente(em quilos) e imprima o valor a pagar." +
            " Assuma que abalança já desconte o peso do prato.");
        Console.WriteLine();


        Console.WriteLine("QUAL O PESO DO PRATO:  ");
        PesoPrato = Convert.ToDouble(Console.ReadLine());

        ValorPagar = PesoPrato * 12;

        Console.WriteLine($"VALOR A PAGAR =  R$ {ValorPagar}", CultureInfo.CurrentCulture);
        
        
    }
}

    
    

