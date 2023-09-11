﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Restorant.Persistence.Context;

#nullable disable

namespace Restorant.Persistence.Migrations
{
    [DbContext(typeof(RestorantDbContext))]
    [Migration("20230530064229_mig_14")]
    partial class mig_14
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FoodOrder", b =>
                {
                    b.Property<Guid>("FoodsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("OrdersId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("FoodsId", "OrdersId");

                    b.HasIndex("OrdersId");

                    b.ToTable("FoodOrder");
                });

            modelBuilder.Entity("FoodPayment", b =>
                {
                    b.Property<Guid>("FoodsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PaymentsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("FoodsId", "PaymentsId");

                    b.HasIndex("PaymentsId");

                    b.ToTable("FoodPayment");
                });

            modelBuilder.Entity("Restorant.Domain.Entiteis.Basket", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Adet")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FoodId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("FoodId");

                    b.ToTable("Baskets");
                });

            modelBuilder.Entity("Restorant.Domain.Entiteis.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyisim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("İsim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Restorant.Domain.Entiteis.Food", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Exists")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Foods");
                });

            modelBuilder.Entity("Restorant.Domain.Entiteis.Like", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FoodId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("FoodId");

                    b.ToTable("Likes");
                });

            modelBuilder.Entity("Restorant.Domain.Entiteis.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("ActiveOrder")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TableId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("TableId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Restorant.Domain.Entiteis.Payment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CustoemrId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("KartNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Masano")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SonKullanımTarih")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyisim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("TotalPrice")
                        .HasColumnType("float");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("cvv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("İsim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CustoemrId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("Restorant.Domain.Entiteis.Table", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Maxpeople")
                        .HasColumnType("int");

                    b.Property<bool>("Reservation")
                        .HasColumnType("bit");

                    b.Property<string>("TableNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Tables");
                });

            modelBuilder.Entity("Restorant.Domain.Entiteis.Worker", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Addres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("OnTheJob")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Wage")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Workers");
                });

            modelBuilder.Entity("FoodOrder", b =>
                {
                    b.HasOne("Restorant.Domain.Entiteis.Food", null)
                        .WithMany()
                        .HasForeignKey("FoodsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Restorant.Domain.Entiteis.Order", null)
                        .WithMany()
                        .HasForeignKey("OrdersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FoodPayment", b =>
                {
                    b.HasOne("Restorant.Domain.Entiteis.Food", null)
                        .WithMany()
                        .HasForeignKey("FoodsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Restorant.Domain.Entiteis.Payment", null)
                        .WithMany()
                        .HasForeignKey("PaymentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Restorant.Domain.Entiteis.Basket", b =>
                {
                    b.HasOne("Restorant.Domain.Entiteis.Customer", "Customer")
                        .WithMany("Baskets")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Restorant.Domain.Entiteis.Food", "Food")
                        .WithMany("Baskets")
                        .HasForeignKey("FoodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Food");
                });

            modelBuilder.Entity("Restorant.Domain.Entiteis.Like", b =>
                {
                    b.HasOne("Restorant.Domain.Entiteis.Customer", "Customer")
                        .WithMany("foods")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Restorant.Domain.Entiteis.Food", "Food")
                        .WithMany("Customers")
                        .HasForeignKey("FoodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Food");
                });

            modelBuilder.Entity("Restorant.Domain.Entiteis.Order", b =>
                {
                    b.HasOne("Restorant.Domain.Entiteis.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Restorant.Domain.Entiteis.Table", "Table")
                        .WithMany("Orders")
                        .HasForeignKey("TableId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Table");
                });

            modelBuilder.Entity("Restorant.Domain.Entiteis.Payment", b =>
                {
                    b.HasOne("Restorant.Domain.Entiteis.Customer", "Custoemr")
                        .WithMany("Payments")
                        .HasForeignKey("CustoemrId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Custoemr");
                });

            modelBuilder.Entity("Restorant.Domain.Entiteis.Customer", b =>
                {
                    b.Navigation("Baskets");

                    b.Navigation("Orders");

                    b.Navigation("Payments");

                    b.Navigation("foods");
                });

            modelBuilder.Entity("Restorant.Domain.Entiteis.Food", b =>
                {
                    b.Navigation("Baskets");

                    b.Navigation("Customers");
                });

            modelBuilder.Entity("Restorant.Domain.Entiteis.Table", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
