using System;

namespace ArrayBool
{
    class Program
    {
        static void Main(string[] args)
        { 
        
        int[] notas = new int[10];

        Console.WriteLine("Insira a nota de 10 alunos:");

        for (int i = 0; i < notas.Length; i++)
        {
            Console.WriteLine("Insira uma nota:");
            notas[i] = Convert.ToInt32(Console.ReadLine());
        }


            for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i] >= 7)
                {
                    Console.WriteLine("aluno " + i + " foi aprovado com nota " + notas[i]);
                }
                if (notas[i] < 7)
                {
                    Console.WriteLine("aluno " + i + " foi reprovado com nota " + notas[i]);
                }
            }
        }
    }
}






//static bool[] sucesso(int[] notas, bool[] sucesso)
//{
//    for (int i = 0; i < notas.Length; i++)
//    {
//        sucesso[i] = (notas[i] >= 7) ? true : false;

//    }
//    return sucesso;
//}

//{
//    int[] notas = new int[10];
//    bool[] aprovados = new bool[10];
//    sucesso(notas, aprovados);

//    for (int i = 0; i < notas.Length; i++)
//    {

//        Console.WriteLine("Digite a nota para dez alunos");
//        notas[i] = Convert.ToInt32(Console.ReadLine());
//    }

//    for (int i = 0; i < notas.Length; i++)
//    {

//        String escreva = (aprovados[i]) ? ($"\nAluno {i}, com a nota {notas[i]}, Você foi Aprovado") : ($"\nAluno {i}, com a nota {notas[i]}, Você foi Reprovado");

//        Console.WriteLine(escreva);
//    }
//}