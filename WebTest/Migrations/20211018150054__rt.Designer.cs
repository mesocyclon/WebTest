﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebTest.Models;

namespace WebTest.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20211018150054__rt")]
    partial class _rt
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebTest.Models.UsersModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Fu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Iu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ou")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("30fb2dd3-ea0e-4f05-b0db-ef6341a593f0"),
                            Fu = "В космос ",
                            Iu = "text text",
                            Ou = "text text text"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
