using System;

namespace Exercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero;
            double result;

            Console.Write("Digite o numero: ");
            numero = double.Parse(Console.ReadLine());
            result = numero / 3;
            Console.WriteLine("A terca parte do numero " + numero + " e: " + result);
            Console.Read();
        }
    }
}