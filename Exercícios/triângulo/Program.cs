using System;

namespace triângulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            bool repete = true;

            while (repete == true)
            {
                //isoceles
                if (a == b && (a + b) > c)
                {
                    Console.WriteLine("Isóceles");
                }
                if (b == c && (b + c) > a)
                {
                    Console.WriteLine("Isóceles");
                }
                if (c == a && (c + a) > b)
                {
                    Console.WriteLine("Isóceles");
                }
                //isoceles

                //escaleno
                if (a != b && (a + b) > c)
                {
                    Console.WriteLine("Isóceles");
                }
                if (b != c && (b + c) > a)
                {
                    Console.WriteLine("Isóceles");
                }
                if (c != a && (c + a) > b)
                {
                    Console.WriteLine("Isóceles");
                }
                //escaleno

                //equilatero
                if (a == b && a == c)
                {
                    Console.WriteLine("Equilátero");
                }
                if (b == c && b == a)
                {
                    Console.WriteLine("Equilátero");
                }
                if (c == a && c == b)
                {
                    Console.WriteLine("Equilátero");
                }
                else
                {
                    Console.WriteLine("Não é um triângulo, digite 1 para inserir novamente os valores ou digite 0 para sair");
                    a = Convert.ToInt32(Console.ReadLine());
                    if (a == 1)
                    {

                        a = Convert.ToInt32(Console.ReadLine());
                        b = Convert.ToInt32(Console.ReadLine());
                        c = Convert.ToInt32(Console.ReadLine());

                    }
                    if (a == 0)
                    {
                        repete = false;
                    }
                }
                Console.WriteLine("Digite 1 para inserir novamente os valores ou digite 0 para sair");
                a = Convert.ToInt32(Console.ReadLine());
                if (a == 1)
                {

                    a = Convert.ToInt32(Console.ReadLine());
                    b = Convert.ToInt32(Console.ReadLine());
                    c = Convert.ToInt32(Console.ReadLine());

                }
                if (a == 0)
                {
                    repete = false;
                }
            }
        }
    }
}
