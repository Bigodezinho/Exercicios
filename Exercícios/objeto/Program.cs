using System;

namespace ConsoleApp38
{
    public class Funcionario
    {
        /// instanciando a classe.
        string nome { get; set; }
        string departamento { get; set; }
        double salario { get; set; }
        string dataDeEntrada { get; set; }
        string rg { get; set; }
        bool ativo { get; set; }


        public class Engenheiro : Funcionario
        { 
            public string Crea { get; set; }
            public string AreaAtuacao { get; set; }
            public Engenheiro()
            { 
            }
            public Engenheiro(string crea, string areaAtuacao, double salario)
            {
                this.Crea = crea;
                this.AreaAtuacao = areaAtuacao;
                this.salario = salario;
            }
        }

        public Funcionario(string nome, string departamento, double salario, string dataDeEntrada, string rg, bool ativo)/// construtor 
        {
            this.nome = nome;
            this.departamento = departamento;
            this.salario = salario;
            this.dataDeEntrada = dataDeEntrada;
            this.rg = rg;
            this.ativo = ativo;
        }
        public Funcionario() /// contrutor vazio
        {

        }
        public void bonifica(double valor) /// metodo
        {
            this.salario += valor;
        }

        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario("itamar berti", "Desenvolvimento de sistemas", 7500.50, "30.12.2021", "6.634.324", true);
            Funcionario funcionario1 = new Funcionario(Console.ReadLine(), Console.ReadLine(), Convert.ToInt64(Console.ReadLine()), Console.ReadLine(), Console.ReadLine(), true); /// recebendo os valores dos objetos da classe.

            funcionario.nome = "itamar"; /// assim se passa o valor depois de inicializar.
            funcionario.bonifica(500); /// usando o metodo no objeto.


            /// Print dos objetos.
            Console.WriteLine("nome: " + funcionario.nome);
            Console.WriteLine("departamento: " + funcionario.departamento);
            Console.WriteLine("salario: " + funcionario.salario);
            Console.WriteLine("data de entrada: " + funcionario.dataDeEntrada);
            Console.WriteLine("RG: " + funcionario.rg);
            Console.WriteLine("Funcionario ativo? " + funcionario.ativo);
        }
    }
}
