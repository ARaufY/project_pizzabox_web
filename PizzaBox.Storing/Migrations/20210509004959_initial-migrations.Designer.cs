﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using PizzaBox.Storage;

namespace PizzaBox.Storing.Migrations
{
    [DbContext(typeof(PizzaBoxContext))]
    [Migration("20210509004959_initial-migrations")]
    partial class initialmigrations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("CustomerStore", b =>
                {
                    b.Property<long>("CustomersEntityId")
                        .HasColumnType("bigint");

                    b.Property<long>("StoresEntityId")
                        .HasColumnType("bigint");

                    b.HasKey("CustomersEntityId", "StoresEntityId");

                    b.HasIndex("StoresEntityId");

                    b.ToTable("CustomerStore");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Crust", b =>
                {
                    b.Property<long>("EntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("EntityId");

                    b.ToTable("Crusts");

                    b.HasData(
                        new
                        {
                            EntityId = 1L,
                            Name = "original"
                        },
                        new
                        {
                            EntityId = 2L,
                            Name = "stuffed"
                        },
                        new
                        {
                            EntityId = 3L,
                            Name = "flatbread"
                        });
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Customer", b =>
                {
                    b.Property<long>("EntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<long>("OrderEntityId")
                        .HasColumnType("bigint");

                    b.Property<long>("StoreEntiryId")
                        .HasColumnType("bigint");

                    b.HasKey("EntityId");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Order", b =>
                {
                    b.Property<long>("EntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<long?>("CustomerEntityId")
                        .HasColumnType("bigint");

                    b.Property<long?>("StoreEntityId")
                        .HasColumnType("bigint");

                    b.HasKey("EntityId");

                    b.HasIndex("CustomerEntityId");

                    b.HasIndex("StoreEntityId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Pizza", b =>
                {
                    b.Property<long>("EntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<long>("CrustEntityId")
                        .HasColumnType("bigint");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("OrderEntityId")
                        .HasColumnType("bigint");

                    b.Property<long>("SizeEntityId")
                        .HasColumnType("bigint");

                    b.HasKey("EntityId");

                    b.HasIndex("CrustEntityId");

                    b.HasIndex("OrderEntityId");

                    b.HasIndex("SizeEntityId");

                    b.ToTable("Pizzas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Pizza");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Size", b =>
                {
                    b.Property<long>("EntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.HasKey("EntityId");

                    b.ToTable("Sizes");

                    b.HasData(
                        new
                        {
                            EntityId = 1L,
                            Name = "small",
                            Price = 0m
                        },
                        new
                        {
                            EntityId = 2L,
                            Name = "medium",
                            Price = 0m
                        },
                        new
                        {
                            EntityId = 3L,
                            Name = "large",
                            Price = 0m
                        });
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Store", b =>
                {
                    b.Property<long>("EntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<long>("OrderEntityId")
                        .HasColumnType("bigint");

                    b.HasKey("EntityId");

                    b.ToTable("Stores");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Topping", b =>
                {
                    b.Property<long>("EntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.HasKey("EntityId");

                    b.ToTable("Toppings");

                    b.HasData(
                        new
                        {
                            EntityId = 1L,
                            Name = "pepperoni",
                            Price = 0m
                        },
                        new
                        {
                            EntityId = 2L,
                            Name = "pineapple",
                            Price = 0m
                        },
                        new
                        {
                            EntityId = 3L,
                            Name = "ham",
                            Price = 0m
                        },
                        new
                        {
                            EntityId = 4L,
                            Name = "green peppers",
                            Price = 0m
                        },
                        new
                        {
                            EntityId = 5L,
                            Name = "black olives",
                            Price = 0m
                        });
                });

            modelBuilder.Entity("PizzaTopping", b =>
                {
                    b.Property<long>("PizzasEntityId")
                        .HasColumnType("bigint");

                    b.Property<long>("ToppingsEntityId")
                        .HasColumnType("bigint");

                    b.HasKey("PizzasEntityId", "ToppingsEntityId");

                    b.HasIndex("ToppingsEntityId");

                    b.ToTable("PizzaTopping");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.SpecialtyPizza", b =>
                {
                    b.HasBaseType("PizzaBox.Domain.Models.Pizza");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasDiscriminator().HasValue("SpecialtyPizza");
                });

            modelBuilder.Entity("CustomerStore", b =>
                {
                    b.HasOne("PizzaBox.Domain.Models.Customer", null)
                        .WithMany()
                        .HasForeignKey("CustomersEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PizzaBox.Domain.Models.Store", null)
                        .WithMany()
                        .HasForeignKey("StoresEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Order", b =>
                {
                    b.HasOne("PizzaBox.Domain.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerEntityId");

                    b.HasOne("PizzaBox.Domain.Models.Store", null)
                        .WithMany("Orders")
                        .HasForeignKey("StoreEntityId");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Pizza", b =>
                {
                    b.HasOne("PizzaBox.Domain.Models.Crust", "Crust")
                        .WithMany("Pizzas")
                        .HasForeignKey("CrustEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PizzaBox.Domain.Models.Order", "Order")
                        .WithMany("Pizzas")
                        .HasForeignKey("OrderEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PizzaBox.Domain.Models.Size", "Size")
                        .WithMany()
                        .HasForeignKey("SizeEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Crust");

                    b.Navigation("Order");

                    b.Navigation("Size");
                });

            modelBuilder.Entity("PizzaTopping", b =>
                {
                    b.HasOne("PizzaBox.Domain.Models.Pizza", null)
                        .WithMany()
                        .HasForeignKey("PizzasEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PizzaBox.Domain.Models.Topping", null)
                        .WithMany()
                        .HasForeignKey("ToppingsEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Crust", b =>
                {
                    b.Navigation("Pizzas");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Customer", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Order", b =>
                {
                    b.Navigation("Pizzas");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Store", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
