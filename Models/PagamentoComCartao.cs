using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarianaAndrade.Models
{
    public class PagamentoComCartao : TipoDePagamento
    {
        public string? NumeroDoCartao {get;set;}
        public string? BandeiraDoCartao {get;set;}
    }
}