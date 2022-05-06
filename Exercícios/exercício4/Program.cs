using System;

namespace exercício4
{
    class Program
    {
        static void Main(string[] args)
        {
           double n1, n2, n3, media;

            Console.WriteLine("Insira a primeira nota:");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira a segunda nota:");
            n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira a terceira nota:");
            n3 = Convert.ToDouble(Console.ReadLine());


            if (n1 > n2 && n1 > n3)
            {
                Console.WriteLine("A primeira nota: " + n1 + " é a maior.");
            }
            else if (n2 > n1 && n2 > n3)
            {
              
                Console.WriteLine("A segunda nota: " + n2 + " é a maior.");
            }
            else if (n3 > n1 && n3 > n2)
            {

                Console.WriteLine("A terceira nota: " + n3 + " é a maior.");
            }

            media = (n1 + n2 + n3) / 3;
            Console.WriteLine("A média das notas é:" + media);

        }
    }
}
