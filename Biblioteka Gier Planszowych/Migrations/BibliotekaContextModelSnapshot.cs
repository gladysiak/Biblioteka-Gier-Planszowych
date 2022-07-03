﻿// <auto-generated />
using Biblioteka_Gier_Planszowych.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Biblioteka_Gier_Planszowych.Migrations
{
    [DbContext(typeof(BibliotekaContext))]
    partial class BibliotekaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.6");

            modelBuilder.Entity("Biblioteka_Gier_Planszowych.Models.Gra_Planszowa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Gatunek")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Opis")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Tytuł")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Wydawca")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Gra_Planszowa");
                });

            modelBuilder.Entity("Biblioteka_Gier_Planszowych.Models.Uzytkownik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Haslo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Imie")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nazwisko")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Uprawnienia")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
