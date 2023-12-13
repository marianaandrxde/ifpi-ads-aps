using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarianaAndrade.Models
{
    public class Produto
    {
        public int Id {get;set;}
        public string? Nome{get;set;}
        public string? Descricao {get;set;}
        public int Quantidade {get;set;}
        public double Preco {get;set;}

        public List<Marca> Marcas { get; set; } = new List<Marca>();
        public List<Item> Itens { get; set; } = new List<Item>();

    }
}