using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Venda
    {
        public Venda(int valor, string produto, decimal preco)
        {
            Produto = produto;
            Valor = Valor;
            Preco = preco;
        }
        public int Valor { get; set; }
        public string Produto { get; set; }

        public decimal  Preco { get; set; }
    }
}