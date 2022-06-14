using System;
using System.Collections.Generic;

namespace TreinoListas
{
    public class Produto
    {
        public int Quantidade { get; set; }
        public string Nome { get; set; }

        public Produto(int quantidade, string nome)
        {
            this.Quantidade = quantidade;
            this.Nome = nome;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto01 = new Produto(10, "maça"); //É mais vantajoso criar um contrutor para preencher mais facilmente novas intancias

            Produto produto02 = new Produto(20, "banana");

            List<Produto> lista = new List<Produto>();
            lista.Add(produto01);
            lista.Add(produto02);

            lista[0].Nome = "melancia"; //Alterando propriedade de um item dentro da lista
            lista[0].Quantidade = 2;

            lista.RemoveAt(0); //Removendo primeiro item da lista

            foreach (Produto produto in lista)
            {
                Console.WriteLine(produto.Nome);
                Console.WriteLine(produto.Quantidade);
            }
        }
    }
}
