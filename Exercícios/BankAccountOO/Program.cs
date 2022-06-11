using System;

namespace BankAccountOO
{
    class Program
    {
        static void Main(string[] args)
        {
            var conta = new ContaBanco("Joao", 1000);
            Console.WriteLine($"Conta {conta.Numero} foi criada por {conta.Dono} com {conta.Saldo} reais de saldo inicial.");

            conta.FazerSaque(500, DateTime.Now, "aluguel");
            Console.WriteLine(conta.Saldo);
            conta.FazerDeposito(100, DateTime.Now, "Amigou me emprestou");
            Console.WriteLine(conta.Saldo);
        }
    }
}
