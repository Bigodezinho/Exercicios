using System;

namespace exercicio14
{
    class banco
    {
        static void Main(string[] args)
        {
            string[] contas = new string[5];
            double[] saldoContas = new double[5];

            
            for (int i = 0; i < contas.Length; i++)
            {
                Console.WriteLine("Insira o código da conta " + i);
                contas[i] = Console.ReadLine();
                Console.WriteLine("Insira o saldo da conta " + i);
                saldoContas[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("Insira a opcao que deseja:");
            Console.WriteLine("1-Sacar");
            Console.WriteLine("2-Depositar");
            Console.WriteLine("3-Transferir");
            Console.WriteLine("0-Sair");
            int opcao = Convert.ToInt32(Console.ReadLine());

            while (opcao != 0)
            {
                if (opcao == 1)
                {
                    Console.WriteLine("Por favor, informe a conta para saque:");
                    string contaSaque = Console.ReadLine();

                    for (int i = 0; i < contas.Length; i++)
                    {
                        if (contaSaque == contas[i])
                        {
                            Console.WriteLine("Informe o valor para saque");
                            double valorSaque = Convert.ToDouble(Console.ReadLine());
                            if (saldoContas[i] >= valorSaque)
                            {
                                saldoContas[i] = saldoContas[i] - valorSaque;
                                Console.WriteLine("Saque efetuado.");
                            }
                            else
                            {
                                Console.WriteLine("Saldo insuficiente.");
                            }
                        }
                    }
                }
                else if (opcao == 2)
                {
                    Console.WriteLine("Por favor, informe a conta para saque:");
                    string contaSaque = Console.ReadLine();

                    for (int i = 0; i < contas.Length; i++)
                    {
                        if (contaSaque == contas[i])
                        {
                            Console.WriteLine("Informe o valor para depósito");
                            double valorDeposito = Convert.ToDouble(Console.ReadLine());
                            saldoContas[i] = saldoContas[i] + valorDeposito;
                            Console.WriteLine("Valor depositado.");
                                                        
                        }
                    }
                }
                else if (opcao == 3)
                {
                    Console.WriteLine("Por favor, informe a conta de origem:");
                    string contaOrigemTransfer = Console.ReadLine();

                    Console.WriteLine("Por favor, informe a conta de destino:");
                    string contaDestinoTransfer = Console.ReadLine();

                    string contaOrigemEncontrada = string.Empty;
                    int posicaoOrigem = 0;

                    string contaDestinoEncontrada = string.Empty;
                    int posicaoDestino = 0;

                    if (contaOrigemTransfer != contaDestinoTransfer)
                    {
                        for (int i = 0; i < contas.Length; i++)
                        {
                            //encontra a conta origem e guarda a conta, a referência dentro do vetor e o saldo;
                            if (contaOrigemTransfer == contas[i])
                            {
                                Console.WriteLine("Conta origem encontrada.");
                                contaOrigemEncontrada = contas[i];
                                posicaoOrigem = i;
                            }
                            //procura a conta destino e guarda a conta, a referência dentro do vetor e o saldo;
                            if (contaDestinoTransfer == contas[i])
                            {
                                Console.WriteLine("Conta destino encontrada.");
                                contaDestinoEncontrada = contas[i];
                                posicaoDestino = i;
                            }
                        }

                        if (!string.IsNullOrEmpty(contaOrigemEncontrada) && !string.IsNullOrEmpty(contaDestinoEncontrada))
                        {
                            Console.WriteLine("Informe o valor para transferência");
                            double valorTransfer = Convert.ToDouble(Console.ReadLine());
                            if (saldoContas[posicaoOrigem] >= valorTransfer)
                            {
                                saldoContas[posicaoOrigem] = saldoContas[posicaoOrigem] - valorTransfer;
                                saldoContas[posicaoDestino] += valorTransfer;
                                Console.WriteLine("Valor transferido");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Uma das contas ou as duas não foram encontradas.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Informe contas diferentes para a operação.");
                    }
                }

                Console.WriteLine("Insira a opcao que deseja:");
                Console.WriteLine("1-Sacar");
                Console.WriteLine("2-Depositar");
                Console.WriteLine("3-Transferir");
                Console.WriteLine("0-Sair");
                opcao = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}