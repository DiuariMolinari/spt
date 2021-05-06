﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SPT.Models;

namespace SPT.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SPT.Models.Consorcio", b =>
                {
                    b.Property<int>("ConsorcioId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DescricaoPlano");

                    b.Property<string>("NomeSegmento");

                    b.Property<int>("QtdMesPlano");

                    b.Property<int>("TaxaSeguro");

                    b.Property<int>("ValorCarta");

                    b.HasKey("ConsorcioId");

                    b.ToTable("View_Consorcio");
                });

            modelBuilder.Entity("SPT.Models.FolhaPagamento", b =>
                {
                    b.Property<int>("FolhaPagamentoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FuncionarioId");

                    b.Property<double>("HorasTrabalhadas");

                    b.Property<DateTime>("Periodo");

                    b.HasKey("FolhaPagamentoId");

                    b.HasIndex("FuncionarioId");

                    b.ToTable("FolhaPagamentos");
                });

            modelBuilder.Entity("SPT.Models.Funcionario", b =>
                {
                    b.Property<int>("FuncionarioId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cpf");

                    b.Property<string>("Nome");

                    b.Property<bool>("Status");

                    b.Property<double>("ValorHora");

                    b.HasKey("FuncionarioId");

                    b.ToTable("Funcionarios");
                });

            modelBuilder.Entity("SPT.Models.Investimento", b =>
                {
                    b.Property<int>("InvestimentoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Periodo");

                    b.Property<int>("TipoInvestimento");

                    b.Property<double>("ValorInvestido");

                    b.HasKey("InvestimentoId");

                    b.ToTable("Investimentos");
                });

            modelBuilder.Entity("SPT.Models.FolhaPagamento", b =>
                {
                    b.HasOne("SPT.Models.Funcionario", "Funcionario")
                        .WithMany()
                        .HasForeignKey("FuncionarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
