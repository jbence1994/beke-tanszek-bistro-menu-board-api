﻿// <auto-generated />
using BekeTanszekBistro.MenuBoard.Api.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BekeTanszekBistro.MenuBoard.Api.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20211030102944_SeedTypesTable")]
    partial class SeedTypesTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("BekeTanszekBistro.MenuBoard.Api.Core.Models.Type", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("types");
                });
#pragma warning restore 612, 618
        }
    }
}