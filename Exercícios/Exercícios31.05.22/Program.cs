using System;

namespace Exercícios31._05._22
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, idade;

            Console.WriteLine("Digite o número da tarefa que deseja realizar:\r\n\r\n1-Soma.\r\n2-Maior valor.\r\n3-Ano de nascimento.\r\n4-Equação 2x - 8 = 0.\r\n5-Sair.");
            int opcao = Convert.ToInt32(Console.ReadLine());
            if (opcao == 1)
            {
                Console.WriteLine("Digite o primeiro número da soma");
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o segundo número da soma");
                b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(a + " + " + b + " é igual a " + (a + b));
            }
            if (opcao == 2)
            {
                Console.WriteLine("Digite o primeiro valor");
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o segundo valor");
                b = Convert.ToDouble(Console.ReadLine());
                if (a > b)
                    Console.WriteLine(a + " é o maior valor.");
                else if (a < b)
                    Console.WriteLine(b + " é o maior valor.");
                else
                    Console.WriteLine("Os valores são iguais");
            }
            if (opcao == 3)
            {
                Console.WriteLine("Digite ano de nascimento de uma pessoa:");
                a = Convert.ToDouble(Console.ReadLine());
                idade = 2022 - a;
                Console.WriteLine("Essa pessoa tem " + idade + " anos.");
            }
            if (opcao == 4)
            {
                Console.WriteLine("2x - 8 = 0");
                a = 8 / 2;
                Console.WriteLine("x é igual a " + a);
            }
        }
    }
}
