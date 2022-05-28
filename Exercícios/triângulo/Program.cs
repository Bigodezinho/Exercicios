using System;

namespace triângulo
{
    class Program
    {
        static void Main(string[] args)
        {
            int ladoMaior = 0;
            int lado1 = Convert.ToInt32(Console.ReadLine());
            int lado2 = Convert.ToInt32(Console.ReadLine());
            int lado3 = Convert.ToInt32(Console.ReadLine());
            int sair = 1;


            while (sair == 1)
            {
                if (lado1 > lado2 && lado1 > lado3)
                {
                    ladoMaior = lado1;
                }
                if (lado2 > lado1 && lado2 > lado3)
                {
                    ladoMaior = lado2;
                }
                if (lado3 > lado1 && lado3 > lado2)
                {
                    ladoMaior = lado3;
                }

                //verificar se é triângulo
                Maior(lado1, lado2, lado3, ladoMaior, sair); //lado1
                //Maior(lado2, lado1, lado3, ladoMaior, sair); //lado2
                //Maior(lado3, lado1, lado2, ladoMaior, sair); //lado3
        }
        static void Maior(int lado1, int lado2, int lado3, int ladoMaior, int sair)
        {
            sair = 1;
            if (ladoMaior == lado2 && lado2 == lado3 && lado3 == ladoMaior && lado3 == lado2)
            {
                Console.WriteLine("É um triângulo equilátero");
            }
            if (lado1 > lado2 && lado1 > lado3)
            {
                ladoMaior = lado1;
                if (lado2 + lado3 < ladoMaior)
                {
                    if ((lado2 + lado3) > ladoMaior)
                    {

                        if (ladoMaior == lado2 || lado2 == lado3 || lado3 == ladoMaior || lado3 == lado2)
                        {
                            Console.WriteLine("É um triângulo isóceles");
                        }
                        sair = 0;
                    }
                    else
                    {
                        Console.WriteLine("Não é um triângulo, digite 1 para inserir novamente os valores ou digite 0 para sair");
                        sair = Convert.ToInt32(Console.ReadLine());
                        if (sair == 1)
                        {
                            lado1 = Convert.ToInt32(Console.ReadLine());
                            lado2 = Convert.ToInt32(Console.ReadLine());
                            lado3 = Convert.ToInt32(Console.ReadLine());
                        }
                    }
                }
            }
        }
    }
}
