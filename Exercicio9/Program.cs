using System;

namespace Exercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            int result;

            Console.Write("Digite o primeiro numero: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo numero: ");
            n2 = int.Parse(Console.ReadLine());
            result = n1 + n2;
            Console.WriteLine("A soma dos numeros " + n1 + " + " + n2 + " e " + result);
            Console.Read();
        }
    }
}