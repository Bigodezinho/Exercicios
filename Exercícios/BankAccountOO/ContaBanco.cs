using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccountOO
{
    class ContaBanco
    {
        private static int accountNumberSeed = 1234567890;
        public string Numero { get; }
        public string Dono { get; set; }
        public decimal Saldo { get
            {
                decimal saldo = 0;
                foreach (var item in allTransactions)
                {
                    saldo += item.Valor;
                }

                return saldo;
            }
        }

        //Construtor
        public ContaBanco(string nome, decimal valorinicial)
        {
            Numero = accountNumberSeed.ToString();
            accountNumberSeed++;

            Dono = nome;
            FazerDeposito(valorinicial, DateTime.Now, "valor inicial");
        }

        //Lista
        private List<Transacao> allTransactions = new List<Transacao>();
        public void FazerDeposito(decimal valor, DateTime data, string note)
        {
            if (valor <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(valor), "O valor do depósito de ve ser positivo");
            }
            var deposito = new Transacao(valor, data, note);
            allTransactions.Add(deposito);
        }

        //
        public void FazerSaque(decimal valor, DateTime data, string note)
        {
            if (valor <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(valor), "O valor do saque de ve ser positivo");
            }
            if (Saldo - valor < 0)
            {
                throw new InvalidOperationException("Sem fundos para saque");
            }
            var saque = new Transacao(-valor, data, note);
            allTransactions.Add(saque);
        }

    }
}
