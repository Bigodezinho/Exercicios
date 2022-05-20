using System;

namespace Array10
{
    class Program
    {
        static void Main(string[] args)
        {

            int entrada = 0;
            int[] array10 = new int[10];

            Console.WriteLine("Insira o tamanho do array:");
            entrada = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < array10.Length; i++)
            {
                Console.WriteLine("Insira um número:");
                array10[i] = Convert.ToInt32(Console.ReadLine());
            }
            PegarOmaiorNumero(array10);

            
            Console.WriteLine($"\nO maior valor é {array10[(array10.Length - 1)]}");
        }
        static int[] PegarOmaiorNumero(int[] array10)
        {
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
            return array10;
        }
    }

}
       

