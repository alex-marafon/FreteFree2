﻿// <auto-generated />
using System;
using FreteFree.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FreteFree.Migrations
{
    [DbContext(typeof(FreteFreeContext))]
    [Migration("20201222005946_inicial")]
    partial class inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FreteFree.Models.Motorista.Motorista", b =>
                {
                    b.Property<int>("MotoristaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<decimal>("CNPJ")
                        .HasColumnType("decimal(20)");

                    b.Property<decimal>("CPFMotorista")
                        .HasColumnType("decimal(20)");

                    b.Property<string>("CaminhaoProprietario")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(100)");

                    b.Property<string>("CidadeCarreta")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(100)");

                    b.Property<string>("CidadeCavalo")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(100)");

                    b.Property<string>("CidadeMotorista")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(100)");

                    b.Property<DateTime>("DataCadastoMotorista")
                        .HasColumnType("datetime2");

                    b.Property<string>("EnderecoMotorista")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(100)");

                    b.Property<string>("EnderecoProprietario")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(100)");

                    b.Property<int>("EstadoCarreta")
                        .HasColumnType("int");

                    b.Property<int>("EstadoCavalo")
                        .HasColumnType("int");

                    b.Property<int>("EstadoMotorista")
                        .HasColumnType("int");

                    b.Property<int?>("MotoristaId1")
                        .HasColumnType("int");

                    b.Property<string>("NomeMotorista")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(100)");

                    b.Property<string>("PlacaCarreta")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(100)");

                    b.Property<string>("PlacaCavalo")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(100)");

                    b.Property<decimal>("RGMotorista")
                        .HasColumnType("decimal(20)");

                    b.Property<decimal>("TelefoneFixo")
                        .HasColumnType("decimal(20)");

                    b.Property<decimal>("TelefoneMovel")
                        .HasColumnType("decimal(20)");

                    b.Property<decimal>("TelefoneProprietario")
                        .HasColumnType("decimal(20)");

                    b.Property<int>("TipoCaminhao")
                        .HasColumnType("int");

                    b.HasKey("MotoristaId");

                    b.HasIndex("MotoristaId1");

                    b.ToTable("Motorista");
                });

            modelBuilder.Entity("FreteFree.Models.Motorista.OrdemCarregamento", b =>
                {
                    b.Property<int>("OrdemCarregamentoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DataOrdemCarregamento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Destino")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(100)");

                    b.Property<int>("EmpresaId")
                        .HasColumnType("int");

                    b.Property<int>("Medida")
                        .HasColumnType("int");

                    b.Property<int>("MotoristaId")
                        .HasColumnType("int");

                    b.Property<string>("TipoCarga")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(100)");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(20)");

                    b.HasKey("OrdemCarregamentoId");

                    b.HasIndex("EmpresaId");

                    b.HasIndex("MotoristaId");

                    b.ToTable("OrdemCarregamento");
                });

            modelBuilder.Entity("FreteFree.Models.Processo.Empresa", b =>
                {
                    b.Property<int>("EmpresaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<string>("CidadeEmpresa")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(100)");

                    b.Property<DateTime>("DataCadastroEmpresa")
                        .HasColumnType("datetime2");

                    b.Property<int?>("EmpresaId1")
                        .HasColumnType("int");

                    b.Property<string>("NomeEmpresa")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(100)");

                    b.Property<string>("NomeResponsavel")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(100)");

                    b.Property<decimal>("TelefoneEmpresa")
                        .HasColumnType("decimal(20)");

                    b.HasKey("EmpresaId");

                    b.HasIndex("EmpresaId1");

                    b.ToTable("Empresa");
                });

            modelBuilder.Entity("FreteFree.Models.Motorista.Motorista", b =>
                {
                    b.HasOne("FreteFree.Models.Motorista.Motorista", null)
                        .WithMany("Motoristas")
                        .HasForeignKey("MotoristaId1");
                });

            modelBuilder.Entity("FreteFree.Models.Motorista.OrdemCarregamento", b =>
                {
                    b.HasOne("FreteFree.Models.Processo.Empresa", "Empresa")
                        .WithMany()
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FreteFree.Models.Motorista.Motorista", "Motorista")
                        .WithMany()
                        .HasForeignKey("MotoristaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FreteFree.Models.Processo.Empresa", b =>
                {
                    b.HasOne("FreteFree.Models.Processo.Empresa", null)
                        .WithMany("Empresas")
                        .HasForeignKey("EmpresaId1");
                });
#pragma warning restore 612, 618
        }
    }
}