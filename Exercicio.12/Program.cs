using System;

namespace Exercicio._12
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2;
            double media;

            Console.Write("Digite o primeiro numero: ");
            n1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo numero: ");
            n2 = double.Parse(Console.ReadLine());

            media = (n1 + n2) / 2;

            Console.WriteLine("A media dos numeros " + n1 + " e " + n2 + " e: " + media);
            Console.Read();
        }
    }
}