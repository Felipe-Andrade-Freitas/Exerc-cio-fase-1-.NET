using System;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
                var command = string.Empty;

                do
                {
                    // Imprime menu
                    Console.WriteLine("1) opção 1");
                    Console.WriteLine("2) opção 2");
                    // ...

                    // Lê o comando selecionado
                    command = Console.ReadLine();

                    switch (command)
                    {
                        case "1":
                            Console.WriteLine("")
                            break
                        case "2":
                            // Faça a opção 2
                            break
                        default
                            Console.WriteLine("\"{0}\" não é um opção válida.", command);
                    }

                } while (command != "exit");

            }
        }
    }