using System;

namespace exercício12
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] nome = new string[10];

            for (int i = 0; i < nome.Length; i++)
            {

                Console.WriteLine("insira um nome: ");
                nome[i] = Convert.ToString(Console.ReadLine());

            }
            for (int i = 0; i < nome.Length; i++)
            {
                Console.WriteLine(nome[i]);
            }
        }
    }
}