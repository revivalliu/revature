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
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("PizzaBox.Domain.Models.Customer", b =>
                {
                    b.Property<long>("EntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EntityId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Order", b =>
                {
                    b.Property<long>("EntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<long?>("CustomerEntityId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<long>("StoreEntityId")
                        .HasColumnType("bigint");

                    b.HasKey("EntityId");

                    b.HasIndex("CustomerEntityId");

                    b.HasIndex("StoreEntityId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Store", b =>
                {
                    b.Property<long>("EntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EntityId");

                    b.ToTable("Stores");

                    b.HasData(
                        new
                        {
                            EntityId = 1L,
                            Name = "Texas"
                        },
                        new
                        {
                            EntityId = 2L,
                            Name = "Maryland"
                        },
                        new
                        {
                            EntityId = 3L,
                            Name = "Florida"
                        });
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Order", b =>
                {
                    b.HasOne("PizzaBox.Domain.Models.Customer", null)
                        .WithMany("Orders")
                        .HasForeignKey("CustomerEntityId");

                    b.HasOne("PizzaBox.Domain.Models.Store", "Store")
                        .WithMany("Orders")
                        .HasForeignKey("StoreEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Store");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Customer", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Store", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
