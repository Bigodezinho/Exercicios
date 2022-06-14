/*1)Você deve criar alguns métodos de acordo 
com sua necessidade. Além deles, crie um método "Bonifica" que 
aumenta o salario do funcionário de acordo com o parâmetro 
passado como argumento. Crie, também, um método "Demite",
que não recebe parâmetro algum, só modifica o valor booleano 
indicando que o funcionário não trabalha mais aqui. */

using System;

namespace TreinoOO
{
    class Funcionario
    {
        public string Nome { get; set; }
        public string Departamento { get; set; }
        public double Salario { get; set; }
        public string DataAdmissao { get; set; }
        public string Rg { get; set; }
        public bool Ativo { get; set; }

        public Funcionario(string nome, string departamento, double salario, string dataadmissao, string rg, bool ativo)
        {
            this.Nome = nome;
            this.Departamento = departamento;
            this.Salario = salario;
            this.DataAdmissao = dataadmissao;
            this.Rg = rg;
            this.Ativo = ativo;
        }

        public void Bonifica(double valor)
        {
            this.Salario += valor;
        }
        public void Demitido(bool estado)
        {
            this.Ativo = estado;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario(Console.ReadLine(), Console.ReadLine(), Convert.ToDouble(Console.ReadLine()), Console.ReadLine(), Console.ReadLine(), Convert.ToBoolean(Console.ReadLine()));
            Console.WriteLine("Nome: " + funcionario.Nome);
            Console.WriteLine("Departamento: " + funcionario.Departamento);
            Console.WriteLine("Salario: " + funcionario.Salario);
            Console.WriteLine("Data de admissão: " + funcionario.DataAdmissao);
            Console.WriteLine("Rg: " + funcionario.Rg);
            Console.WriteLine("Ativo: " + funcionario.Ativo);
        }
    }
}
