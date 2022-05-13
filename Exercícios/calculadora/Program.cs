using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("1- Adição, 2- Subtração, 3- Multiplicação, 4- Divisão, 0- Sair");
            int escolhaUsuario = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Insira o primeiro numero:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o segundo numero:");
            int y = Convert.ToInt32(Console.ReadLine());

        
        static int SomarNumeros(int a, int b)
        {
            return a + b;
        }
        static int subtrairNumeros(int a, int b)
        {
            return a - b;
        }
        static int multiplicarNumeros(int a, int b)
        {
            return a * b;
        }
        static int dividirNumeros(int a, int b)
        {
            return a / b;
        }
    }
}
