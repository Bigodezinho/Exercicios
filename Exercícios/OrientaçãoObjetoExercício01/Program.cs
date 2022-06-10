using System;

namespace OrientaçãoObjetoExercício01
{
    public class Veiculo
    {
        string Modelo { get; set; }
        string Chassis { get; set; }
        string Ano { get; set; }
        string Marca { get; set; }
        string TipoMotor { get; set; }
        string Pais { get; set; }
        string TipoCombustivel { get; set; }
        double Preco { get; set; }
        double Potencia { get; set; }
        double Torque { get; set; }

        public Veiculo(string modelo, string chassis, string ano, string marca, string tipomotor, string pais, string combustivel, double preco, double potencia, double torque)/// construtor 
        {
            this.Modelo = modelo;
            this.Chassis = chassis;
            this.Ano = ano;
            this.Marca = marca;
            this.TipoMotor = tipomotor;
            this.Pais = pais;
            this.TipoCombustivel = combustivel;
            this.Preco = preco;
            this.Potencia = potencia;
            this.Torque = torque;
        }

        public Veiculo()
        {
        }

        static void Main(string[] args)
    {
            Veiculo uno = new Veiculo();
    }
}
}
