using System;

namespace _3notas10alunos
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] Nota1dos10alunos = new double[10];
            double[] Nota2dos10alunos = new double[10];
            double[] Nota3dos10alunos = new double[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Insira a primeira nota do aluno " + i);
                Nota1dos10alunos[i] = Convert.ToDouble(Console.ReadLine()); 
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Insira a segunda nota do aluno " + i);
                Nota2dos10alunos[i] = Convert.ToDouble(Console.ReadLine());
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Insira a terceira nota do aluno " + i);
                Nota3dos10alunos[i] = Convert.ToDouble(Console.ReadLine());
            }

            //for (int i = 0; i < 10; i++)

            // nota1[i] + nota2[i] + nota3[i] = 3notasDoAluno1
            // 

        }
    }
}













//        static int[] PegarOmaiorNumero(int[] array10)
//{
//    for (int i = 0; i < array10.Length; i++)
//    {
//        int auxiliar;
//        for (int j = i + 1; j < array10.Length; j++)
//        {
//            if (array10[i] > array10[j])
//            {
//                auxiliar = array10[i];                  //TROCA O LUGAR DO ARRAY, OLHA FOTO PAINT AREA TRABALHO
//                array10[i] = array10[j];
//                array10[j] = auxiliar;
//            }
//        }
//    }
//    return array10;
//}