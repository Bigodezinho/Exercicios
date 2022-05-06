using System;

namespace exercício_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor, valorDescontado, impostos, valorUsuario;

            Console.WriteLine("Insira o valor do produto:");
            valor = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira o valor percentual de desconto:");
            valorUsuario = Convert.ToDouble(Console.ReadLine());

            valorDescontado = (valor * valorUsuario) / 100;

            if (valor <= 100)
            {
                valorDescontado = (valor * 5) / 100;
                valor = valor - valorDescontado;
                

                Console.WriteLine("o valor com o desconto é de: " + valor + " Reais");
                Console.WriteLine("o valor do imposto é de: " +  valorDescontado + " Reais");

            }
            else if (valor > 100 && valor <= 300)
            {
                valorDescontado = (valor * 15) / 100;
                valor = valor - valorDescontado;

                Console.WriteLine("o valor com o desconto é de: " + valor + " Reais");
                Console.WriteLine("o valor do imposto é de: " + valorDescontado + " Reais");

            }
            else if (valor > 300 && valor <= 1000)
            {
                valorDescontado = (valor * 25) / 100;
                valor = valor - valorDescontado;

                Console.WriteLine("o valor com o desconto é de: " + valor + " Reais");
                Console.WriteLine("o valor do imposto é de: " + valorDescontado + " Reais");

            }
        }
    }
}
