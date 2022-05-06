using System;

namespace exercício5
{
    class Program
    {
        static void Main(string[] args)
        {

            double valor, impostos;


            Console.WriteLine("Insira o valor do produto:");
            valor = Convert.ToDouble(Console.ReadLine());

            if (valor <= 100) {
                valor = (valor * 100) / 5;
                impostos = (valor * 100) % 5;
                Console.WriteLine("Insira o valor do produto:");
                //5
            } 
            else if (valor > 100 && valor <= 300) {
                valor = (valor * 100) / 15;
                impostos = (valor * 100) % 15;

                //15
            }
            else if (valor > 300 && valor <= 1000) {
                valor = (valor * 100) / 25;
                impostos = (valor * 100) % 25;
                //25

            }
        }
