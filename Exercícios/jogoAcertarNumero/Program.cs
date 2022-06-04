using System;

namespace jogoAcertarNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numeroAleatorio = new Random();           
            Console.WriteLine("Insira um valor para ser o limite mínimo:");
            int limiteMin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira um valor para ser o limite máximo:");
            int limiteMax = Convert.ToInt32(Console.ReadLine());
            int onumero = numeroAleatorio.Next(limiteMin, limiteMax);

            Console.WriteLine("Tente acertar o numero que foi gerado entre: " + limiteMin + " e " + limiteMax);
            int tentativa = Convert.ToInt32(Console.ReadLine());

            while (tentativa != onumero)
            {
                if (tentativa > onumero)
                {
                    Console.WriteLine("O número aleatório é menor:");
                    tentativa = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("O número aleatório é maior:");
                    tentativa = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Acertou");
        }
    }
}
