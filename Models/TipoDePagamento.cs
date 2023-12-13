using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarianaAndrade.Models
{
    public class TipoDePagamento {
        public int Id {get;set;}
        public string? NomeDoCobrado {get;set;}
        public string? InformacoesAdicionais {get;set;}
    }
}