﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MvcCadeteria.Migrations
{
    [DbContext(typeof(MvcCadeteriaContext))]
    partial class MvcCadeteriaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.10");

            modelBuilder.Entity("MvcCadeteria.Models.Cadete", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("calle")
                        .HasColumnType("TEXT");

                    b.Property<string>("nombre")
                        .HasColumnType("TEXT");

                    b.Property<int>("numero")
                        .HasColumnType("INTEGER");

                    b.Property<string>("telefono")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Cadete");
                });
#pragma warning restore 612, 618
        }
    }
}
