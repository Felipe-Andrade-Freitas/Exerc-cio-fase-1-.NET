using System;

namespace Exercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            double saldo;
            double reajuste;
            double juros;

            Console.Write("Digite o saldo da Aplicacao: ");
            saldo = double.Parse(Console.ReadLine());
            Console.Write("Digite o Juros: ");
            juros = double.Parse(Console.ReadLine());

            reajuste = saldo * (juros / 100);
            saldo += reajuste;
            Console.WriteLine("Seu novo saldo e: " + saldo);
            Console.ReadLine();
        }
    }
}