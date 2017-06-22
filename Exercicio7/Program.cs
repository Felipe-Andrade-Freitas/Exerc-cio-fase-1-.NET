using System;

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int antecessor, sucessor;

            Console.Write("Digite o numero: ");
            numero = int.Parse(Console.ReadLine());

            sucessor = numero + 1;
            antecessor = numero - 1;

            Console.WriteLine("");
            Console.WriteLine("O antecessor do numero " + numero + " e: " + antecessor);
            Console.WriteLine("");
            Console.WriteLine("O sucessor do numero " + numero + " e: " + sucessor);
            Console.ReadLine();
        }
    }
}