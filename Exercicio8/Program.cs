using System;

namespace Exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, endereco, telefone;

            Console.Write("Digite o seu nome: ");
            nome = Console.ReadLine();
            Console.Write("Digite o seu endereco: ");
            endereco = Console.ReadLine();
            Console.Write("Digite o seu telefone: ");
            telefone = Console.ReadLine();

            Console.WriteLine("O seu nome e: " + nome + ", seu endereco e: " + endereco + " e seu telefone e: " + telefone);
            Console.ReadLine();
        }
    }
}