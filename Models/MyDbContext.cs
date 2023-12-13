using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MarianaAndrade.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
       {
       }

        public DbSet<NotaDeVenda>? NotasDeVenda { get;set;}
        public DbSet<Cliente>? Clientes { get;set;}
        public DbSet<Vendedor>? Vendedores { get;set;}
        public DbSet<Transportadora>? Transportadoras { get;set;}
        public DbSet<Pagamento>? Pagamento { get;set;}
        public DbSet<Item>? Itens { get;set;}
        public DbSet<Produto>? Produtos { get;set;}
        public DbSet<Marca>? Marcas{ get;set;}
        public DbSet<TipoDePagamento>? Tipopagamento { get;set;}
        public DbSet<PagamentoComCheque>? PagamentoComCheque { get;set;}
        public DbSet<PagamentoComCartao>? PagamentoComcartao { get;set;}

    }
}