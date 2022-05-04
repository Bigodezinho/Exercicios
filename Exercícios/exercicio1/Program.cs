using System;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            string nome;


            Console.WriteLine("Insira seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Insira sua idade:");
            idade = Convert.ToInt32(Console.ReadLine());

            if (idade < 18)
            {
                Console.WriteLine(nome + ", você é menor de idade.");

            }
            else {

                Console.WriteLine(nome + ", você é maior de idade.");
            }



        }
    }
}
