using System;

namespace exercício14
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] contas = new string[5];
            double[] valor = new double[5];
            double acao;
            string comparador;


            for (int i = 0; i < contas.Length; i++) 
            {
                Console.WriteLine("Digite o nome da conta: ");
                contas[i] = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Digite o valor inicial da conta: ");
                valor[i] = Convert.ToDouble(Console.ReadLine());

            }
            Console.WriteLine("O que deseja fazer: 1-Sacar, 2-Depositar, 3- transferir, 4-sair");
            acao = Convert.ToDouble(Console.ReadLine());

            while (acao != 4) {
                if (acao == 1) {
                    Console.WriteLine("informe o nome da conta que deseja sacar: ");
                    comparador = Convert.ToString(Console.ReadLine());

                    for (int i = 0; i < contas.Length; i++) {
                        if (comparador == contas[i]) {
                            Console.WriteLine("é joao memo");
                        }
                    }
                }






            }
            }
        }

    }

