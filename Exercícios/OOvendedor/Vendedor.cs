using System;
using System.Collections.Generic;
using System.Text;

namespace OOvendedor
{
    public class Vendedor
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Endereco { get; set; }


        public Vendedor(string nome, string cpf, string endereco)
        {
            this.Nome = nome;
            this.Cpf = cpf;
            this.Endereco = endereco;
        }

    }
}
