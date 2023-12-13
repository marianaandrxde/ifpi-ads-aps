using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using NuGet.Protocol.Plugins;

namespace MarianaAndrade.Models
{
    public class Pagamento
    {
        public int Id {get;set;}
        public DateFormat DataLimite {get;set;}
        public double Valor {get;set;}
        public bool Pago {get;set;}
    }
}