using System;
using System.Text;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Text.Encoding();
            Encoding enc = new UTF8Encoding(true, true);


            int x;
            int y;
            int z;
            double resultado = 0;

            Console.WriteLine("Digite o primeiro número: ", enc);
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro numero: ");
            z = int.Parse(Console.ReadLine());

            resultado = (x + y + z) / 3;

            Console.WriteLine("A media de " + x + ", " + y + " e " + z + " e: " + resultado);
            Console.ReadLine();
        }
    }
}

