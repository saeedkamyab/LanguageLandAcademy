﻿// <auto-generated />
using System;
using ManagmentSystem.Infrastructure.EfCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ManagmentSystem.Infrastructure.EfCore.Migrations
{
    [DbContext(typeof(ManagmentSystemContext))]
    [Migration("20240113204407_initaliDb")]
    partial class initaliDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ManagmentSystem.Domain.TuitionAgg.Tuition", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("FinanceAmount")
                        .HasColumnType("float");

                    b.Property<string>("FinanceDescription")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime>("FinancePayDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("FinanceStatus")
                        .HasColumnType("bit");

                    b.Property<bool>("IsRemoved")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Tuitions", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
