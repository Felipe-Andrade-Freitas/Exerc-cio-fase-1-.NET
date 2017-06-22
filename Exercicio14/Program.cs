using System;

namespace Exercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            double PR1, PR2;
            double media;

            Console.Write("Digite o valor da primeira prova: ");
            PR1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor da segunda prova: ");
            PR2 = double.Parse(Console.ReadLine());

            media = (PR1 + PR2) / 2;

            Console.WriteLine("A media do aluno e: " + media);
            Console.Read();
        }
    }
}