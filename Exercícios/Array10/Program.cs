using System;

namespace Array10
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array10 = new int[10];


            for (int i = 0; i < array10.Length; i++)
            {
                array10[i] = Convert.ToInt32(Console.ReadLine());
            }


            for (int i = 0; i < array10.Length; i++)
            {
                int auxiliar;
                for (int j = i + 1; j < array10.Length; j++)
                {
                    if (array10[i] > array10[j])
                    {
                        auxiliar = array10[i];
                        array10[i] = array10[j];
                        array10[j] = auxiliar;
                    }
                }
            }
                Console.WriteLine($"\nO maior valor é {array10[(array10.Length - 1)]}");
        }
    }
}
