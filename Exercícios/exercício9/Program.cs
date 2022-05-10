using System;

namespace exercício9
{
    class Program
    {
        static void Main(string[] args)
        {
            double entrada = 0;
            double soma = 0;
            double contador = 0;
            double media = 0;

            Console.WriteLine("Insira uma nota: ");
            entrada = Convert.ToDouble(Console.ReadLine());

            while(entrada > 0){
                soma = soma + entrada;
                contador = contador + 1;
                Console.WriteLine("Insira uma nota: ");
                entrada = Convert.ToDouble(Console.ReadLine());
            }
            media = soma / contador;
            Console.WriteLine("A média das notas é " + media);
        }

    }
 }

