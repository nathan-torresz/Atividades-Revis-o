using System;

namespace Atividades_revisão
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Digite o nº de apitos: ");
            int apitos = Convert.ToInt32(Console.ReadLine());
            if(apitos == 1)
            {
                Console.WriteLine("Problema na Placa");
            }
            else if(apitos == 2)
            {
                Console.WriteLine("Problema na memória");
            }
            else
            {
                Console.WriteLine("Erro!");
            }*/

            /*Console.WriteLine("Digite o nº de apitos: ");
            int apitos = Convert.ToInt32(Console.ReadLine());

            switch (apitos)
            {
                case 1:
                    Console.WriteLine("Problem de placa");
                    break;
                case 2:
                    Console.WriteLine("Problem de memória");
                    break;
                default:
                    Console.WriteLine("Erro!");
                    break;
            }*/

            Random numAleatorio = new Random();
            int a = numAleatorio.Next(1, 11);
            int b = numAleatorio.Next(1, 11);
            Random numB = new Random();
            int c = numB.Next(0, 2);
            int resp;

            if (c == 0)
            {
                do
                {
                    Console.WriteLine("Qual o resultado da subtração de " + a + " + " + b);
                    resp = Convert.ToInt32(Console.ReadLine());

                    if (resp == a + b)
                    {
                        Console.WriteLine("Entrada permitida!");
                    }
                    else
                    {
                        Console.WriteLine("Erro tente novamente");
                    }
                } while (resp < (a + b) || resp > (a + b));
            }
            else if (c == 1)
            {
                do
                {
                    Console.WriteLine("Qual o resultado da subtração de " + a + " - " + b);
                    resp = Convert.ToInt32(Console.ReadLine());

                    if (resp == a - b)
                    {
                        Console.WriteLine("Entrada permitida!");
                    }
                    else
                    {
                        Console.WriteLine("Erro tente novamente");
                    }
                } while (resp < (a - b) || resp > (a - b));
            }
        }
    }
}
