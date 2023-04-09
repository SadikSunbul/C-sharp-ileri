﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ÖrnekProje.Migrations
{
    [DbContext(typeof(TetstContex))]
    [Migration("20230406122057_mig_1")]
    partial class mig_1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.HasSequence("A1Sequence");

            modelBuilder.HasSequence("deger")
                .StartsAt(900L);

            modelBuilder.Entity("A1", b =>
                {
                    b.Property<int>("AId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("NEXT VALUE FOR [A1Sequence]");

                    SqlServerPropertyBuilderExtensions.UseSequence(b.Property<int>("AId"));

                    b.Property<string>("Aacıklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AId");

                    b.ToTable("A1");

                    b.UseTpcMappingStrategy();
                });

            modelBuilder.Entity("Asınıfı", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Aacıklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Asınıfıs");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Asınıfı");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Hesap", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("HesapAdı")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Hesaplar");
                });

            modelBuilder.Entity("Kurs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("KursAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Kurslar");
                });

            modelBuilder.Entity("Sınıf", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Sınıfno")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sınıflar");
                });

            modelBuilder.Entity("Xsınıfı", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Xacıklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("xsınıfı", (string)null);

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("kişi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyadi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Kişiler");
                });

            modelBuilder.Entity("kişikurs", b =>
                {
                    b.Property<int>("KursId")
                        .HasColumnType("int");

                    b.Property<int>("KişiId")
                        .HasColumnType("int");

                    b.HasKey("KursId", "KişiId");

                    b.HasIndex("KişiId");

                    b.ToTable("Kişikurslar");
                });

            modelBuilder.Entity("kullanıcı", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HesapId")
                        .HasColumnType("int");

                    b.Property<string>("Soyadı")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("HesapId")
                        .IsUnique();

                    b.ToTable("Kullanıcılar");
                });

            modelBuilder.Entity("Öğrenci", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("KayıtZamanı")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 4, 6, 15, 20, 57, 863, DateTimeKind.Local).AddTicks(9324));

                    b.Property<string>("Soyadı")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("SınıfNo")
                        .HasColumnType("int");

                    b.Property<string>("Tc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("sequences")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("NEXT VALUE FOR deger");

                    b.HasKey("Id");

                    b.HasIndex("SınıfNo");

                    b.HasIndex("Adi", "Soyadı");

                    b.ToTable("Öğrenciler");
                });

            modelBuilder.Entity("B1", b =>
                {
                    b.HasBaseType("A1");

                    b.Property<string>("Bacıklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("B1");
                });

            modelBuilder.Entity("Bsınıfı", b =>
                {
                    b.HasBaseType("Asınıfı");

                    b.Property<string>("Bacıklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Bsınıfı");
                });

            modelBuilder.Entity("Ysınıfı", b =>
                {
                    b.HasBaseType("Xsınıfı");

                    b.Property<string>("Yacıklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Ysınıfı", (string)null);
                });

            modelBuilder.Entity("C1", b =>
                {
                    b.HasBaseType("B1");

                    b.Property<string>("Cacıklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("C1");
                });

            modelBuilder.Entity("Csınıfı", b =>
                {
                    b.HasBaseType("Bsınıfı");

                    b.Property<string>("Cacıklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Csınıfı");
                });

            modelBuilder.Entity("Zsınıfı", b =>
                {
                    b.HasBaseType("Ysınıfı");

                    b.Property<string>("Zacıklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Zsınıfı", (string)null);
                });

            modelBuilder.Entity("kişikurs", b =>
                {
                    b.HasOne("kişi", "Kişi")
                        .WithMany("Kurslar")
                        .HasForeignKey("KişiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Kurs", "Kurs")
                        .WithMany("Kişiler")
                        .HasForeignKey("KursId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kişi");

                    b.Navigation("Kurs");
                });

            modelBuilder.Entity("kullanıcı", b =>
                {
                    b.HasOne("Hesap", "Hesap")
                        .WithOne("Kullanıcı")
                        .HasForeignKey("kullanıcı", "HesapId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hesap");
                });

            modelBuilder.Entity("Öğrenci", b =>
                {
                    b.HasOne("Sınıf", "Sınıf")
                        .WithMany("Öğrenciler")
                        .HasForeignKey("SınıfNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sınıf");
                });

            modelBuilder.Entity("Ysınıfı", b =>
                {
                    b.HasOne("Xsınıfı", null)
                        .WithOne()
                        .HasForeignKey("Ysınıfı", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Zsınıfı", b =>
                {
                    b.HasOne("Ysınıfı", null)
                        .WithOne()
                        .HasForeignKey("Zsınıfı", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Hesap", b =>
                {
                    b.Navigation("Kullanıcı")
                        .IsRequired();
                });

            modelBuilder.Entity("Kurs", b =>
                {
                    b.Navigation("Kişiler");
                });

            modelBuilder.Entity("Sınıf", b =>
                {
                    b.Navigation("Öğrenciler");
                });

            modelBuilder.Entity("kişi", b =>
                {
                    b.Navigation("Kurslar");
                });
#pragma warning restore 612, 618
        }
    }
}
