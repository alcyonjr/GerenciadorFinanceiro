﻿// <auto-generated />
using System;
using Gerenciador_Financeiro.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Gerenciador_Financeiro.Migrations
{
    [DbContext(typeof(GerenciadorFinanceiroContext))]
    [Migration("20190217043654_Initial-Users-For-Testing")]
    partial class InitialUsersForTesting
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Gerenciador_Financeiro.Model.Conta", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao")
                        .HasMaxLength(150);

                    b.Property<long?>("ID_USUARIO");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.HasIndex("Descricao")
                        .IsUnique();

                    b.HasIndex("ID_USUARIO");

                    b.ToTable("Contas");
                });

            modelBuilder.Entity("Gerenciador_Financeiro.Model.Despesa", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataDespesa")
                        .HasColumnName("DATA_DESPESA");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<long>("ID_CONTA");

                    b.HasKey("Id");

                    b.HasIndex("ID_CONTA");

                    b.ToTable("Despesas");
                });

            modelBuilder.Entity("Gerenciador_Financeiro.Model.Receita", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataReceita")
                        .HasColumnName("DATA_RECEITA");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<long?>("ID_CONTA");

                    b.HasKey("Id");

                    b.HasIndex("ID_CONTA");

                    b.ToTable("Receitas");
                });

            modelBuilder.Entity("Gerenciador_Financeiro.Model.Usuario", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<byte[]>("Salt")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<byte[]>("Senha")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.HasKey("Id");

                    b.HasIndex("Login")
                        .IsUnique();

                    b.ToTable("Usuarios");

                    b.HasData(
                        new
                        {
                            Id = -1L,
                            Login = "vinicius",
                            Salt = new byte[] { 223, 65, 156, 219, 104, 186, 233, 204, 35, 37, 173, 199, 14, 198, 78, 21, 16, 11, 3, 125, 155, 13, 193, 67, 194, 231, 27, 49, 204, 224, 79, 176, 189, 161, 162, 145, 2, 38, 150, 156, 37, 64, 160, 109, 27, 173, 139, 119, 89, 221, 185, 181, 240, 34, 173, 71, 78, 139, 68, 103, 172, 32, 112, 15, 41, 27, 200, 2, 0, 159, 80, 179, 17, 231, 244, 161, 222, 219, 121, 146, 48, 239, 14, 138, 67, 67, 165, 36, 236, 11, 235, 241, 74, 102, 32, 107, 94, 93, 211, 91, 79, 52, 249, 168, 149, 163, 15, 202, 104, 112, 65, 71, 244, 235, 239, 25, 192, 139, 83, 136, 95, 233, 96, 37, 160, 241, 86, 87 },
                            Senha = new byte[] { 172, 36, 156, 105, 229, 245, 117, 135, 122, 216, 238, 179, 69, 114, 61, 187, 197, 91, 100, 20, 79, 122, 181, 33, 53, 172, 95, 184, 46, 8, 130, 44, 57, 252, 158, 128, 204, 111, 32, 139, 31, 80, 242, 228, 195, 37, 58, 108, 211, 41, 170, 59, 131, 217, 211, 38, 214, 217, 117, 110, 114, 5, 216, 203, 24, 142, 122, 204, 31, 190, 102, 50, 117, 70, 107, 25, 40, 73, 183, 163, 233, 25, 101, 31, 74, 208, 64, 43, 234, 173, 46, 198, 71, 94, 252, 106, 168, 128, 48, 217, 100, 114, 59, 94, 5, 75, 184, 0, 216, 235, 83, 112, 72, 244, 184, 103, 241, 193, 238, 94, 2, 211, 31, 162, 186, 23, 29, 150 }
                        },
                        new
                        {
                            Id = -2L,
                            Login = "alcyon",
                            Salt = new byte[] { 223, 65, 156, 219, 104, 186, 233, 204, 35, 37, 173, 199, 14, 198, 78, 21, 16, 11, 3, 125, 155, 13, 193, 67, 194, 231, 27, 49, 204, 224, 79, 176, 189, 161, 162, 145, 2, 38, 150, 156, 37, 64, 160, 109, 27, 173, 139, 119, 89, 221, 185, 181, 240, 34, 173, 71, 78, 139, 68, 103, 172, 32, 112, 15, 41, 27, 200, 2, 0, 159, 80, 179, 17, 231, 244, 161, 222, 219, 121, 146, 48, 239, 14, 138, 67, 67, 165, 36, 236, 11, 235, 241, 74, 102, 32, 107, 94, 93, 211, 91, 79, 52, 249, 168, 149, 163, 15, 202, 104, 112, 65, 71, 244, 235, 239, 25, 192, 139, 83, 136, 95, 233, 96, 37, 160, 241, 86, 87 },
                            Senha = new byte[] { 172, 36, 156, 105, 229, 245, 117, 135, 122, 216, 238, 179, 69, 114, 61, 187, 197, 91, 100, 20, 79, 122, 181, 33, 53, 172, 95, 184, 46, 8, 130, 44, 57, 252, 158, 128, 204, 111, 32, 139, 31, 80, 242, 228, 195, 37, 58, 108, 211, 41, 170, 59, 131, 217, 211, 38, 214, 217, 117, 110, 114, 5, 216, 203, 24, 142, 122, 204, 31, 190, 102, 50, 117, 70, 107, 25, 40, 73, 183, 163, 233, 25, 101, 31, 74, 208, 64, 43, 234, 173, 46, 198, 71, 94, 252, 106, 168, 128, 48, 217, 100, 114, 59, 94, 5, 75, 184, 0, 216, 235, 83, 112, 72, 244, 184, 103, 241, 193, 238, 94, 2, 211, 31, 162, 186, 23, 29, 150 }
                        });
                });

            modelBuilder.Entity("Gerenciador_Financeiro.Model.Conta", b =>
                {
                    b.HasOne("Gerenciador_Financeiro.Model.Usuario", "Usuario")
                        .WithMany("Contas")
                        .HasForeignKey("ID_USUARIO");
                });

            modelBuilder.Entity("Gerenciador_Financeiro.Model.Despesa", b =>
                {
                    b.HasOne("Gerenciador_Financeiro.Model.Conta", "Conta")
                        .WithMany("Despesas")
                        .HasForeignKey("ID_CONTA")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Gerenciador_Financeiro.Model.Receita", b =>
                {
                    b.HasOne("Gerenciador_Financeiro.Model.Conta", "Conta")
                        .WithMany("Receitas")
                        .HasForeignKey("ID_CONTA");
                });
#pragma warning restore 612, 618
        }
    }
}
