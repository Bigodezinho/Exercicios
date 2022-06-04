using System;

namespace exercicios02._06._22
{
    class Program
    {
        static void Main(string[] args)
        {
            //exercicio1
            Console.WriteLine("Exercício 1\r\n");
            double[] a = {10,20,30,40,50};
            double armazena = 0;

            for (int i = 0; i < 5; i++)
            {
                armazena = a[i] *2;
                Console.WriteLine(armazena);
            }

            //exercicio2
            Console.WriteLine("\r\n");
            Console.WriteLine("Exercício 2\r\n");
            double[] b = { 10, 20, 30, 40, 50, 60, 70 };
            double[] c = new double[7];

            for (int i = 0; i < 7; i++)
            {
                c[i] = b[i];
                Console.WriteLine(c[i]);
            }

            //exercicio3
            Console.WriteLine("\r\n");
            Console.WriteLine("Exercício 3\r\n");
            double[] d = { 10, 20, 30, 40, 50 };

            for (int i = 0; i < 5; i++)
            {
                d[i] = d[i] * i;
                Console.WriteLine(d[i]);
            }

            //exercício4
            //APENAS MOSTRANDO LETRA POR LETRA (CONTANDO COM OS ESPAÇOS)
            Console.WriteLine("\r\n");
            Console.WriteLine("Exercício 4\r\n");

            string texto = "Exercício 4"; //pode ser um readline();
            char[] chars = new char[texto.Length];

            for (int i = 0; i < texto.Length; i++)
            {
                Console.WriteLine(texto[i]);
            }

            //FORMA PASSANDO PARA UM OUTRO VETOR E MOSTRANDO TAMBÉM LETRA POR LETRA
            //for (int i = 0; i < chars.Length; i++)
            //{
            //    chars[i] = texto[i];
            //    Console.WriteLine(chars[i]);
            //}


            //FORMA DO EXEMPLO DA APOSTILA
            //foreach (char x in texto)
            //{
            //    Console.WriteLine($"Texto na posição {texto.IndexOf(x)}, {x}");
            //}

            //USANDO UMA MATRIZ BIDIMENSIONAL (LINHA E COLUNA)

            //Matriz com 2 dimensões (5 linhas, 5 colunas)
            int[,] matriz = new int[5, 5];
            Random random = new Random();

            for (int i = 0; i < matriz.GetLength(0); i++)       //Primeiro for para as linhas
            {
                                                                
                for (int j = 0; j < matriz.GetLength(1); j++)   //Segundo for para as colunas
                    matriz[i, j] = random.Next(0, 10);
            }
        }
        //static + tipo do retorno + nome da função + (parametros entre parenteses){}

        //Usando função para preencher um vetor

        int[] valores = PreencherVetor(50);

        static int[] PreencherVetor(int tamanho)
        {
            int[] vetor = new int[tamanho];
            Random random = new Random();
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = random.Next(0, 10);
            }
            return vetor;
        }
    }
}
