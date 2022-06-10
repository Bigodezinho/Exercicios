using System;
using System.Collections.Generic;
using System.Text;

namespace OrientaçãoObjetoExercício01
{
    public class Veiculo(string modelo, string chassis, string ano, string marca, string motor, string pais, string combustivel, double preco, double potencia, double torque)/// construtor 
    {
        this.Modelo = modelo;
        this.Chassis = chassis;
        this.Ano = ano;
        this.Marca = marca;
        this.Motor = motor;
        this.Pais = pais;
        this.Combustivel = combustivel;
        this.Preco = preco;
        this.Potencia = potencia;
        this.Torque = torque;
    }

}

