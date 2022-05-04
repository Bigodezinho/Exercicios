using System;

namespace exercício3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;
            int n2;
            int operacao;
            int resultado;


            Console.WriteLine("Insira o primeiro número da operação:");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o segundo número da operação:");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira qual operação será utilizada através dos números (1-adição, 2-subtração, 3-divisão, 4-multiplicação)");
            operacao = Convert.ToInt32(Console.ReadLine());


            if (operacao == 1)
            {
                resultado = n1 + n2;
                Console.WriteLine(n1 + " + " + n2 + " é igual á " + resultado);
            }
            else if (operacao == 2)
            {

                resultado = n1 - n2;
                Console.WriteLine(n1 + " - " + n2 + " é igual á " + resultado);
            }
            else if (operacao == 3)
            {

                resultado = n1 / n2;
                Console.WriteLine(n1 + " / " + n2 + " é igual á " + resultado);
            }
            else if (operacao == 4)
            {

                resultado = n1 * n2;
                Console.WriteLine(n1 + " * " + n2 + " é igual á " + resultado);
            }



        }
    }
}
