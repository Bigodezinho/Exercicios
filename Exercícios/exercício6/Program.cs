using System;

namespace exercício6
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome1, nome2;


            Console.WriteLine("Insira seu primeiro nome:");
            nome1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Insira seu último nome:");
            nome2 = Convert.ToString(Console.ReadLine());

            Console.WriteLine("nome: " + nome1 + " " + nome2 + ".");
        }
    }
}
