using System;

namespace calculadora
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("1- Adição, 2- Subtração, 3- Multiplicação, 4- Divisão, 0- Sair");
            double escolhaUsuario = Convert.ToDouble(Console.ReadLine());
            while (escolhaUsuario != 0 && escolhaUsuario <= 4 && escolhaUsuario >= 1)
            {

                if (escolhaUsuario == 1) 
                {
                    Console.WriteLine("Insira o primeiro numero:");
                    double x = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Insira o segundo numero:");
                    double y = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("O resultado da soma é " + adicao(x, y));
                }
                if (escolhaUsuario == 2)
                {
                    Console.WriteLine("Insira o primeiro numero:");
                    double x = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Insira o segundo numero:");
                    double y = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("O resultado da soma é " + subtracao(x, y));
                }
                if (escolhaUsuario == 3)
                {
                    Console.WriteLine("Insira o primeiro numero:");
                    double x = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Insira o segundo numero:");
                    double y = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("O resultado da soma é " + multiplicacao(x, y));
                }
                if (escolhaUsuario == 4)
                {
                    Console.WriteLine("Insira o primeiro numero:");
                    double x = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Insira o segundo numero:");
                    double y = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("O resultado da soma é " + divisao(x, y));
                }

                Console.WriteLine("1- Adição, 2- Subtração, 3- Multiplicação, 4- Divisão, 0- Sair");
                escolhaUsuario = Convert.ToDouble(Console.ReadLine());
            }
            if (escolhaUsuario > 4 || escolhaUsuario < 1)
            {
                Console.WriteLine("Operação não encontrada.");
            }

        }

        static double adicao(double a, double b)
        {
            return a + b;
        }
        static double subtracao(double a, double b)
        {
            return a - b;
        }
        static double multiplicacao(double a, double b)
        {
            return a * b;
        }
        static double divisao(double a, double b)
        {
            return a / b;
        }        
    }
}

