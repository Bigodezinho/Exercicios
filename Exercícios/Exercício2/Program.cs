using System;

namespace Exercício2
{
    class Program
    {
        static void Main(string[] args)
        {
            double altura;
            double peso;
            double imc;


            Console.WriteLine("Insira sua altura:");
            altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira seu peso em quilos:");
            peso = Convert.ToDouble(Console.ReadLine());

            imc = peso / (altura * altura);

            if (imc <= 18.5)
            {
                Console.WriteLine("Seu imc é de: " + imc + ", você está abaixo do peso.");

            }
            else if ((imc >= 18.5) && (imc <= 24.9))
            {

                Console.WriteLine("Seu imc é de: " + imc + ", você está com o peso normal.");
            }
            else if ((imc >= 25) && (imc <= 29.9))
            {
                Console.WriteLine("Seu imc é de: " + imc + ", você está com sobrepeso.");

            }
            else if ((imc >= 30) && (imc <= 34.9))
            {
                Console.WriteLine("Seu imc é de: " + imc + ", você está com obesidade I.");

            }
            else if ((imc >= 35) && (imc <= 39.9))
            {
                Console.WriteLine("Seu imc é de: " + imc + ", você está com obesidade II.");

            }
            else if (imc > 40)
            {
                Console.WriteLine("Seu imc é de:" + imc + ", você está com obesidade III.");

            }


        }
    }
}
