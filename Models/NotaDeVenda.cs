using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace MarianaAndrade.Models
{
    public class NotaDeVenda
    {
        public int Id {get;set;}
        public DateFormat Data {get;set;}
        public bool Tipo {get;set;}

        public Pagamento? Pagamento {get;set;}

        public List<Item>? Itens {get;set;}
        public List<Cliente>? Cliente { get;set;}
        public List<Vendedor>? Vendedor{ get;set;}
        public List<Transportadora>? Transportadora { get;set;}
        public List<TipoDePagamento>? TipoDePagamento { get;set;}


        public bool cancelado = false;
        public bool Devolvido = false;
        public bool Cancelar() {
            cancelado = true;
            return true;

        }
        public bool Devolver(){
            Devolvido = true;
            return true;

        }

    }
}