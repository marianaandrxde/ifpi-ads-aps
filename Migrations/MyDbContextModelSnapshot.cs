﻿// <auto-generated />
using System;
using MarianaAndrade.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MarianaAndrade.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ItemNotaDeVenda", b =>
                {
                    b.Property<int>("ItensId")
                        .HasColumnType("int");

                    b.Property<int>("NotaDeVendaId")
                        .HasColumnType("int");

                    b.HasKey("ItensId", "NotaDeVendaId");

                    b.HasIndex("NotaDeVendaId");

                    b.ToTable("ItemNotaDeVenda");
                });

            modelBuilder.Entity("ItemProduto", b =>
                {
                    b.Property<int>("ItensId")
                        .HasColumnType("int");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("int");

                    b.HasKey("ItensId", "ProdutoId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("ItemProduto");
                });

            modelBuilder.Entity("MarianaAndrade.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.Property<int?>("NotaDeVendaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NotaDeVendaId");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("MarianaAndrade.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Percentual")
                        .HasColumnType("int");

                    b.Property<double>("Preco")
                        .HasColumnType("double");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Itens");
                });

            modelBuilder.Entity("MarianaAndrade.Models.Marca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.Property<int?>("ProdutoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProdutoId");

                    b.ToTable("Marcas");
                });

            modelBuilder.Entity("MarianaAndrade.Models.NotaDeVenda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Data")
                        .HasColumnType("int");

                    b.Property<int?>("PagamentoId")
                        .HasColumnType("int");

                    b.Property<bool>("Tipo")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.HasIndex("PagamentoId");

                    b.ToTable("NotasDeVenda");
                });

            modelBuilder.Entity("MarianaAndrade.Models.Pagamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("DataLimite")
                        .HasColumnType("int");

                    b.Property<bool>("Pago")
                        .HasColumnType("tinyint(1)");

                    b.Property<double>("Valor")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("Pagamento");
                });

            modelBuilder.Entity("MarianaAndrade.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.Property<double>("Preco")
                        .HasColumnType("double");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("MarianaAndrade.Models.TipoDePagamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("InformacoesAdicionais")
                        .HasColumnType("longtext");

                    b.Property<string>("NomeDoCobrado")
                        .HasColumnType("longtext");

                    b.Property<int?>("NotaDeVendaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NotaDeVendaId");

                    b.ToTable("Tipopagamento");

                    b.HasDiscriminator<string>("Discriminator").HasValue("TipoDePagamento");
                });

            modelBuilder.Entity("MarianaAndrade.Models.Transportadora", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.Property<int?>("NotaDeVendaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NotaDeVendaId");

                    b.ToTable("Transportadoras");
                });

            modelBuilder.Entity("MarianaAndrade.Models.Vendedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.Property<int?>("NotaDeVendaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NotaDeVendaId");

                    b.ToTable("Vendedores");
                });

            modelBuilder.Entity("MarianaAndrade.Models.PagamentoComCartao", b =>
                {
                    b.HasBaseType("MarianaAndrade.Models.TipoDePagamento");

                    b.Property<string>("BandeiraDoCartao")
                        .HasColumnType("longtext");

                    b.Property<string>("NumeroDoCartao")
                        .HasColumnType("longtext");

                    b.HasDiscriminator().HasValue("PagamentoComCartao");
                });

            modelBuilder.Entity("MarianaAndrade.Models.PagamentoComCheque", b =>
                {
                    b.HasBaseType("MarianaAndrade.Models.TipoDePagamento");

                    b.Property<int>("Banco")
                        .HasColumnType("int");

                    b.Property<string>("NomeDoBanco")
                        .HasColumnType("longtext");

                    b.HasDiscriminator().HasValue("PagamentoComCheque");
                });

            modelBuilder.Entity("ItemNotaDeVenda", b =>
                {
                    b.HasOne("MarianaAndrade.Models.Item", null)
                        .WithMany()
                        .HasForeignKey("ItensId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MarianaAndrade.Models.NotaDeVenda", null)
                        .WithMany()
                        .HasForeignKey("NotaDeVendaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ItemProduto", b =>
                {
                    b.HasOne("MarianaAndrade.Models.Item", null)
                        .WithMany()
                        .HasForeignKey("ItensId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MarianaAndrade.Models.Produto", null)
                        .WithMany()
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MarianaAndrade.Models.Cliente", b =>
                {
                    b.HasOne("MarianaAndrade.Models.NotaDeVenda", null)
                        .WithMany("Cliente")
                        .HasForeignKey("NotaDeVendaId");
                });

            modelBuilder.Entity("MarianaAndrade.Models.Marca", b =>
                {
                    b.HasOne("MarianaAndrade.Models.Produto", "Produto")
                        .WithMany("Marcas")
                        .HasForeignKey("ProdutoId");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("MarianaAndrade.Models.NotaDeVenda", b =>
                {
                    b.HasOne("MarianaAndrade.Models.Pagamento", "Pagamento")
                        .WithMany()
                        .HasForeignKey("PagamentoId");

                    b.Navigation("Pagamento");
                });

            modelBuilder.Entity("MarianaAndrade.Models.TipoDePagamento", b =>
                {
                    b.HasOne("MarianaAndrade.Models.NotaDeVenda", null)
                        .WithMany("TipoDePagamento")
                        .HasForeignKey("NotaDeVendaId");
                });

            modelBuilder.Entity("MarianaAndrade.Models.Transportadora", b =>
                {
                    b.HasOne("MarianaAndrade.Models.NotaDeVenda", null)
                        .WithMany("Transportadora")
                        .HasForeignKey("NotaDeVendaId");
                });

            modelBuilder.Entity("MarianaAndrade.Models.Vendedor", b =>
                {
                    b.HasOne("MarianaAndrade.Models.NotaDeVenda", null)
                        .WithMany("Vendedor")
                        .HasForeignKey("NotaDeVendaId");
                });

            modelBuilder.Entity("MarianaAndrade.Models.NotaDeVenda", b =>
                {
                    b.Navigation("Cliente");

                    b.Navigation("TipoDePagamento");

                    b.Navigation("Transportadora");

                    b.Navigation("Vendedor");
                });

            modelBuilder.Entity("MarianaAndrade.Models.Produto", b =>
                {
                    b.Navigation("Marcas");
                });
#pragma warning restore 612, 618
        }
    }
}
