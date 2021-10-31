﻿// <auto-generated />
using System;
using BekeTanszekBistro.MenuBoard.Api.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BekeTanszekBistro.MenuBoard.Api.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("BekeTanszekBistro.MenuBoard.Api.Core.Models.DailyMenu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime")
                        .HasColumnName("date");

                    b.Property<int>("MealId")
                        .HasColumnType("int")
                        .HasColumnName("meal_id");

                    b.HasKey("Id");

                    b.HasIndex("MealId");

                    b.ToTable("daily_menus");
                });

            modelBuilder.Entity("BekeTanszekBistro.MenuBoard.Api.Core.Models.Meal", b =>
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

                    b.Property<int>("TypeId")
                        .HasColumnType("int")
                        .HasColumnName("type_id");

                    b.HasKey("Id");

                    b.HasIndex("TypeId");

                    b.ToTable("meals");
                });

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

            modelBuilder.Entity("BekeTanszekBistro.MenuBoard.Api.Core.Models.DailyMenu", b =>
                {
                    b.HasOne("BekeTanszekBistro.MenuBoard.Api.Core.Models.Meal", "Meal")
                        .WithMany()
                        .HasForeignKey("MealId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Meal");
                });

            modelBuilder.Entity("BekeTanszekBistro.MenuBoard.Api.Core.Models.Meal", b =>
                {
                    b.HasOne("BekeTanszekBistro.MenuBoard.Api.Core.Models.Type", "Type")
                        .WithMany("Meals")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Type");
                });

            modelBuilder.Entity("BekeTanszekBistro.MenuBoard.Api.Core.Models.Type", b =>
                {
                    b.Navigation("Meals");
                });
#pragma warning restore 612, 618
        }
    }
}
