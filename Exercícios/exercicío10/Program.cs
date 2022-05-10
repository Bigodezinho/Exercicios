using System;

namespace exercicío10
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota = 0;
            double soma = 0;
            double contador = 0;
            double media = 0;

            Console.WriteLine("Insira uma nota: ");
            nota = Convert.ToDouble(Console.ReadLine());

            while (contador < 9)
            {
                soma = soma + nota;
                contador = contador + 1;
                Console.WriteLine("Insira uma nota: ");
                nota = Convert.ToDouble(Console.ReadLine());
            }
            media = soma / contador;
            Console.WriteLine("A média das notas é " + media);
        }
    }
    }

