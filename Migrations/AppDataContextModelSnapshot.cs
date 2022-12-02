﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebapiEVO.Data;

#nullable disable

namespace WebapiEVO.Migrations
{
    [DbContext(typeof(AppDataContext))]
    partial class AppDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("WebapiEVO.Models.Departamento", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.Property<string>("Sigla")
                        .HasColumnType("longtext");

                    b.HasKey("ID");

                    b.ToTable("Departamentos");
                });

            modelBuilder.Entity("WebapiEVO.Models.Funcionario", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("DepartamentoID")
                        .HasColumnType("int");

                    b.Property<string>("Foto")
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.Property<string>("RG")
                        .HasColumnType("longtext");

                    b.HasKey("ID");

                    b.HasIndex("DepartamentoID");

                    b.ToTable("Funcionarios");
                });

            modelBuilder.Entity("WebapiEVO.Models.Funcionario", b =>
                {
                    b.HasOne("WebapiEVO.Models.Departamento", "Departamento")
                        .WithMany("Funcionarios")
                        .HasForeignKey("DepartamentoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departamento");
                });

            modelBuilder.Entity("WebapiEVO.Models.Departamento", b =>
                {
                    b.Navigation("Funcionarios");
                });
#pragma warning restore 612, 618
        }
    }
}
