/*1) Modele um funcionário. Ele deve ter o nome do funcionário,
o departamento onde trabalha, seu salário (double), a data de 
entrada de admissão (string),seu RG(string) e um valor booleano 
que indique se o funcionário ainda está ativo na empresa ou se
 já foi mandado embora. Você deve criar alguns métodos de acordo 
com sua necessidade. Além deles, crie um método "Bonifica" que 
aumenta o salario do funcionário de acordo com o parâmetro 
passado como argumento. Crie, também, um método "Demite",
que não recebe parâmetro algum, só modifica o valor booleano 
indicando que o funcionário não trabalha mais aqui. */


using System;

namespace FuncionárioOO
{
    public class Funcionario
    {
        //public Funcao Funcao { get; set; }
        public string Nome
        {
            get;
            set;
        }
        public string Departamento
        {
            get;
            set;
        }
        public double Salario
        {
            get;
            set;
        }
        public string DataAdmissao
        {
            get;
            set;
        }
        public string Rg
        {
            get;
            set;
        }
        public bool Ativo
        {
            get;
            set;
        }
        public void Bonifica(double valor)
        {
            this.Salario += valor;
        }
        public void Demite(bool estado)
        {
            this.Ativo = estado;
        }
        public Funcionario(string nome, string departamento, double salario, string dataAdmissao, string rg, bool ativo) //Construtor, esses variaveis atribuídas tem
        {                                                                                                                //os valores adicionados depois, lá em baixo
            this.Nome = nome;
            this.Departamento = departamento;
            this.Salario = salario;
            this.DataAdmissao = dataAdmissao;
            this.Rg = rg;
            this.Ativo = ativo;
        }
        public Funcionario()
        {
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario(Console.ReadLine(), Console.ReadLine(), //Cria um funcionário, lê os parâmetros digitados
                                                      Convert.ToDouble(Console.ReadLine()),
                                                      Console.ReadLine(), Console.ReadLine(), true);
            //funcionario;
            Console.WriteLine("Nome: " + funcionario.Nome);                                   //mostra "Nome: " + o parâmetro que foi digitado
            Console.WriteLine("Ativo: " + funcionario.Ativo);
            Console.WriteLine("Data de Admissao: " + funcionario.DataAdmissao);
            Console.WriteLine("Departamento: " + funcionario.Departamento);
            Console.WriteLine("Rg: " + funcionario.Rg);
            Console.WriteLine("Salario: " + funcionario.Salario);

            //com valores estáticos:
            Funcionario funcionario1 = new Funcionario("Jonathan", "Gerência Tecnologia da Informação", //Cria um segundo funcionario
                                                      2500.0, "15/07/2021", "5989267", true);           //Lê os parâmetros que já foram fixados diferente dalí de cima
            //funcionario1;
            Console.WriteLine("Nome: " + funcionario1.Nome);                                            //Mostra "Nome: " + o parâmetro que foram fixados          
            Console.WriteLine("Ativo: " + funcionario1.Ativo);
            Console.WriteLine("Data de Admissao: " + funcionario1.DataAdmissao);
            Console.WriteLine("Departamento: " + funcionario1.Departamento);
            Console.WriteLine("Rg: " + funcionario1.Rg);
            Console.WriteLine("Salario: " + funcionario1.Salario);

            //Passando os valores depois da inicialização (usando get e set)                  FAZENDO EXATAMENTO OQ TA DIZENDO ALÍ <-
            Funcionario funcionario2 = new Funcionario();

            //funcionario2;
            Console.WriteLine("Nome: " + funcionario2.Nome);
            Console.WriteLine("Ativo: " + funcionario2.Ativo);
            Console.WriteLine("Data de Admissao: " + funcionario2.DataAdmissao);
            Console.WriteLine("Departamento: " + funcionario2.Departamento);
            Console.WriteLine("Rg: " + funcionario2.Rg);
            Console.WriteLine("Salario: " + funcionario2.Salario);

            funcionario2.Ativo = true;
            funcionario2.DataAdmissao = "15/07/2021";
            funcionario2.Departamento = "Gerência Tecnologia da Informação";
            funcionario2.Nome = "Jonathan";
            funcionario2.Rg = "5989267";
            funcionario2.Salario = 2500.0;

            funcionario2.Demite(false);                                                      //Executando os métodos criados lá em cima, o demitir e o bonificar
            funcionario2.Demite(true);
            funcionario2.Bonifica(1500);

            Console.WriteLine("Nome: " + funcionario2.Nome);
            Console.WriteLine("Ativo: " + funcionario2.Ativo);
            Console.WriteLine("Data de Admissao: " + funcionario2.DataAdmissao);
            Console.WriteLine("Departamento: " + funcionario2.Departamento);
            Console.WriteLine("Rg: " + funcionario2.Rg);
            Console.WriteLine("Salario: " + funcionario2.Salario);
        }
    }
}