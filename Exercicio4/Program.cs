using System;
using System.Text;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {

            int x;
            int y;
            int z;
            double resultado = 0;

            Console.Write("Digite o primeiro numero: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo numero: ");
            y = int.Parse(Console.ReadLine());
            Console.Write("Digite o terceiro numero: ");
            z = int.Parse(Console.ReadLine());

            resultado = (x + y + z) / 3;

            Console.WriteLine("A media dos numeros " + x + ", " + y + " e " + z + " sao: " + resultado);
            Console.ReadLine();
        }
    }
}

