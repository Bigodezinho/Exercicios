using System;

namespace exercício13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor1 = new int[5];
            int[] vetor2 = new int[5];
            int[] vetor3 = new int[5];

            for (int i = 0; i < vetor1.Length; i++)
            {
                Console.WriteLine("Primeiro vetor: ");
                vetor1[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < vetor2.Length; i++)
            {
                Console.WriteLine("Segundo vetor: ");
                vetor2[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < vetor3.Length; i++)
            {
                vetor3[i] = vetor1[i] * vetor2[i];
                Console.WriteLine("Multiplicação entre os vetores: " + vetor3[i]);
            }
        }
    }
}