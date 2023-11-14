﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TelescopeMVC.DataBase;

#nullable disable

namespace TelescopeMVC.Migrations
{
    [DbContext(typeof(TelescopeContext))]
    partial class TelescopeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.13");

            modelBuilder.Entity("TelescopeMVC.Models.TelescopeApp.Models.Telescope", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Aperture")
                        .HasColumnType("INTEGER");

                    b.Property<int>("FocalLenght")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Manufacturer")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("Picture")
                        .HasColumnType("BLOB");

                    b.HasKey("Id");

                    b.ToTable("Telescopes");
                });
#pragma warning restore 612, 618
        }
    }
}
