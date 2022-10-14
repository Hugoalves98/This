using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;
        public Produto()
        {
            Quantidade = 0;
        }
        public Produto(string nome, double preco) : this()
        {
            Nome = nome;
            Preco = preco;
        }
        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            Quantidade = quantidade;
        }
    }
}
