using System;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.Write("Digite o numero: ");
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Voce digitou o numero: " + numero);
            Console.ReadLine();
        }
    }
}