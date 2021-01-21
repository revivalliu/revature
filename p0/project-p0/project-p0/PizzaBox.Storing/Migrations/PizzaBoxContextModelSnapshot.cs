﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PizzaBox.Storing;

namespace PizzaBox.Storing.Migrations
{
    [DbContext(typeof(PizzaBoxContext))]
    partial class PizzaBoxContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("PizzaBox.Domain.Abstracts.APizzaModel", b =>
                {
                    b.Property<long>("EntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<long?>("CrustEntityId")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("OrderEntityId")
                        .HasColumnType("bigint");

                    b.Property<long?>("SizeEntityId")
                        .HasColumnType("bigint");

                    b.HasKey("EntityId");

                    b.HasIndex("CrustEntityId");

                    b.HasIndex("OrderEntityId");

                    b.HasIndex("SizeEntityId");

                    b.ToTable("Pizzas");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Crust", b =>
                {
                    b.Property<long>("EntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<int>("CrustId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("EntityId");

                    b.ToTable("Crusts");

                    b.HasData(
                        new
                        {
                            EntityId = 201L,
                            CrustId = 0,
                            Name = "Double-dough",
                            Price = 5m
                        },
                        new
                        {
                            EntityId = 203L,
                            CrustId = 0,
                            Name = "Deep Dish",
                            Price = 6m
                        },
                        new
                        {
                            EntityId = 202L,
                            CrustId = 0,
                            Name = "St. Louis",
                            Price = 4m
                        });
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Order", b =>
                {
                    b.Property<long>("EntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<DateTime>("DateOrdered")
                        .HasColumnType("datetime2");

                    b.Property<long?>("PizzaEntityId")
                        .HasColumnType("bigint");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<long?>("StoreEntityId")
                        .HasColumnType("bigint");

                    b.Property<long?>("UserEntityId")
                        .HasColumnType("bigint");

                    b.HasKey("EntityId");

                    b.HasIndex("PizzaEntityId");

                    b.HasIndex("StoreEntityId");

                    b.HasIndex("UserEntityId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Size", b =>
                {
                    b.Property<long>("EntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("EntityId");

                    b.ToTable("Sizes");

                    b.HasData(
                        new
                        {
                            EntityId = 101L,
                            Name = "Large",
                            Price = 10m
                        },
                        new
                        {
                            EntityId = 102L,
                            Name = "Medium",
                            Price = 8m
                        },
                        new
                        {
                            EntityId = 103L,
                            Name = "Samll",
                            Price = 6m
                        });
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Store", b =>
                {
                    b.Property<long>("EntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("OrderEntityId")
                        .HasColumnType("bigint");

                    b.HasKey("EntityId");

                    b.HasIndex("OrderEntityId");

                    b.ToTable("Stores");

                    b.HasData(
                        new
                        {
                            EntityId = 2L,
                            Name = "PizzaHut"
                        },
                        new
                        {
                            EntityId = 3L,
                            Name = "Domino"
                        },
                        new
                        {
                            EntityId = 4L,
                            Name = "RoundTable"
                        });
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Topping", b =>
                {
                    b.Property<long>("EntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<long?>("APizzaModelEntityId")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("EntityId");

                    b.HasIndex("APizzaModelEntityId");

                    b.ToTable("Toppings");

                    b.HasData(
                        new
                        {
                            EntityId = 301L,
                            Name = "Pineapple",
                            Price = 3m
                        },
                        new
                        {
                            EntityId = 302L,
                            Name = "Olives",
                            Price = 1m
                        },
                        new
                        {
                            EntityId = 303L,
                            Name = "Pepperoni",
                            Price = 4m
                        });
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.User", b =>
                {
                    b.Property<long>("EntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("OrderEntityId")
                        .HasColumnType("bigint");

                    b.Property<long?>("SelectedStoreEntityId")
                        .HasColumnType("bigint");

                    b.HasKey("EntityId");

                    b.HasIndex("OrderEntityId");

                    b.HasIndex("SelectedStoreEntityId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("PizzaBox.Domain.Abstracts.APizzaModel", b =>
                {
                    b.HasOne("PizzaBox.Domain.Models.Crust", "Crust")
                        .WithMany()
                        .HasForeignKey("CrustEntityId");

                    b.HasOne("PizzaBox.Domain.Models.Order", "Order")
                        .WithMany("Pizzas")
                        .HasForeignKey("OrderEntityId");

                    b.HasOne("PizzaBox.Domain.Models.Size", "Size")
                        .WithMany()
                        .HasForeignKey("SizeEntityId");

                    b.Navigation("Crust");

                    b.Navigation("Order");

                    b.Navigation("Size");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Order", b =>
                {
                    b.HasOne("PizzaBox.Domain.Abstracts.APizzaModel", "Pizza")
                        .WithMany()
                        .HasForeignKey("PizzaEntityId");

                    b.HasOne("PizzaBox.Domain.Models.Store", "Store")
                        .WithMany("Orders")
                        .HasForeignKey("StoreEntityId");

                    b.HasOne("PizzaBox.Domain.Models.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserEntityId");

                    b.Navigation("Pizza");

                    b.Navigation("Store");

                    b.Navigation("User");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Store", b =>
                {
                    b.HasOne("PizzaBox.Domain.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderEntityId");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Topping", b =>
                {
                    b.HasOne("PizzaBox.Domain.Abstracts.APizzaModel", null)
                        .WithMany("_toppings")
                        .HasForeignKey("APizzaModelEntityId");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.User", b =>
                {
                    b.HasOne("PizzaBox.Domain.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderEntityId");

                    b.HasOne("PizzaBox.Domain.Models.Store", "SelectedStore")
                        .WithMany()
                        .HasForeignKey("SelectedStoreEntityId");

                    b.Navigation("Order");

                    b.Navigation("SelectedStore");
                });

            modelBuilder.Entity("PizzaBox.Domain.Abstracts.APizzaModel", b =>
                {
                    b.Navigation("_toppings");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Order", b =>
                {
                    b.Navigation("Pizzas");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Store", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.User", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
