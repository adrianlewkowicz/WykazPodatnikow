﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPIRegister.Domain;

#nullable disable

namespace WebAPIRegister.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WebAPIRegister.Domain.Entity", b =>
                {
                    b.Property<bool?>("HasVirtualAccounts")
                        .HasColumnType("bit");

                    b.Property<int?>("Id")
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("int");

                    b.Property<string>("Krs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nip")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegistrationDenialBasis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RegistrationDenialDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("RegistrationLegalDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Regon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RemovalBasis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RemovalDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ResidenceAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RestorationBasis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RestorationDate")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("StatusVat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkingAddress")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Entity");
                });
#pragma warning restore 612, 618
        }
    }
}