using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccountOO
{

    public class Transacao
    {
        public decimal Valor { get; }
        public DateTime Data { get; }
        public string Notes { get; }

        public Transacao(decimal valor, DateTime data, string note)
        {
            Valor = valor;
            Data = data;
            Notes = note;
        }
    }
}