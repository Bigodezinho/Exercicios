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
            Console.WriteLine(nome[0] + " ou " + nome[1] + " ou " + nome[2] + " ou " + nome[3] + " ou " + nome[4] + " ou " + nome[5] + " ou " + nome[6] + " ou "
                + nome[7] + " ou " + nome[8] + " ou " + nome[9]);

        }
    }
}