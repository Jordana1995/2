using System;
using Calculadora.Models;

namespace Calculadora
{

    class Program
    {

        static void Main(string[]args)
        {
            Calculador calc = new Calculador();

            System.Console.WriteLine("Resultado da primeira soma: " + calc.Somar(10,10));
            System.Console.WriteLine("Resultado da segunda soma: " + calc.Somar(10,10,10));
        }
    }
}