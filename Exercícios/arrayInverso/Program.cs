using System;

namespace arrayInverso
{
    class program
    {
        static void main(string[] args)
        {
            int[] array10 = new int[10];
            int[] array10invertido = new int[10];

            for (int i = 0; i < 10; i++)
            {
                array10[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < array10.Length; i++)
            {
                //Subtrair 1 pois os índices dos Arrays começam a partir do 0
                array10invertido[i] = array10[array10.Length - 1 - i];
            }
            Console.WriteLine(array10invertido);
        }

    }
}

