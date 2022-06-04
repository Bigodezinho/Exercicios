using System;

namespace exercício03._06._22
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] vetor10 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; //Exercício da média
            double valor1 = 10, valor2 = 20; //Exercício do menor número
            string texto = "Exercício 4"; //Exercício do char
            Console.WriteLine("Digite o primeiro número:"); //Soma
            double n1 = Convert.ToDouble(Console.ReadLine()); //Soma
            Console.WriteLine("Digite o segundo número:"); //Soma
            double n2 = Convert.ToDouble(Console.ReadLine()); //Soma
            Console.WriteLine("O resultao da soma é " + soma(n1, n2)); //Soma
            Console.WriteLine("A média é: " + media(vetor10));  //Média
            Console.WriteLine(ArrayChar(texto));    //Char
        }
        static double soma(double n1, double n2) //Soma
        {
            return n1 + n2;
        }
        static double media(double[] vetor10) //Média
        {
            double somar = 0;
            for (int i = 0; i < vetor10.Length - 1; i++)
            {
                somar += vetor10[i];                
            }
            return somar / 10;
        }
        static double menor(double valor1, double valor2) //Menor
        {
            if (valor1 < valor2)
                return valor1;
            else
                return valor2;
        }
        static char[] ArrayChar(string texto) //Char
        {
            char[] vetor = new char[texto.Length];

            for (int i = 0; i < texto.Length; i++)
            {
                Console.WriteLine(texto[i]);
            }
            return vetor;
        }

    }
}


