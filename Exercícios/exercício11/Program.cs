using System;

namespace exercício11
{
    class Program
    {
        static void Main(string[] args)
        {
            int Nentradas = Convert.ToInt32(Console.ReadLine());
            int[] entrada1 = new int[Nentradas];
            int[] entrada2 = new int[Nentradas];
            Console.WriteLine("Digite a quantidade de entradas: ");

            for (int i = 0; i < entrada1.Length; i++)
            {
                Console.WriteLine("Digite a primeira entrada: ");
                entrada1[i] = Convert.ToInt32(Console.ReadLine());
                entrada2[i] = entrada1[i];
            }

           
                }

            }
        }
    }
