using System;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;

            // Usar o Write "não o WriteLine" para que leia o número na mesma linha.
            Console.Write("Digite o primeiro numero: ");
            n1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo numero: ");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Voce digitou os numeros: " + n1 + " e " + n2);
            Console.ReadLine();
        }
    }
}