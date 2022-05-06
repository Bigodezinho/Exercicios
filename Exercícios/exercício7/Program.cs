using System;

namespace exercício7
{
    class Program
    {
        static void Main(string[] args)
        {
            double Xa, Xb, Ya, Yb, distancia;
           
            Console.WriteLine("Insira a coordenada X do primeiro ponto:");
            Xa = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira a coordenada Y do primeiro ponto:");
            Ya = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira a coordenada X do segundo ponto:");
            Xb = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira a coordenada Y do segundo ponto:");
            Yb = Convert.ToDouble(Console.ReadLine());
            distancia = Math.Pow((Math.Sqrt(Math.Pow((Xa - Xb), 2) + Math.Pow((Ya - Yb), 2))),2);
            Console.WriteLine("A distancia entre as duas coordenadas é: " + distancia);




        }
    }
}
