using System;

namespace ArrayInvertido
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array10 = new int[10];
            int[] array10invertido = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite 10 números:");
                array10[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < array10.Length; i++)
            {
                array10invertido[i] = array10[array10.Length - 1 - i];
            }

            for (int i = 0; i < array10.Length; i++)
            {
                Console.WriteLine(array10invertido[i]);
            }     
            }
    }
}
