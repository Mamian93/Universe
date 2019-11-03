﻿// <auto-generated />
using System;
using AllinOneForDummies.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AllinOneForDummies.Core.Migrations
{
    [DbContext(typeof(DummiesContext))]
    partial class DummiesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AllinOneForDummies.Core.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyName");

                    b.Property<int>("Country");

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("AllinOneForDummies.Core.Moon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("AttractivenessRating");

                    b.Property<DateTime?>("DeleteTime");

                    b.Property<bool?>("IsDeleted");

                    b.Property<string>("Name");

                    b.Property<int>("PlanetId");

                    b.Property<decimal>("Radius");

                    b.HasKey("Id");

                    b.HasIndex("PlanetId");

                    b.ToTable("Moons");
                });

            modelBuilder.Entity("AllinOneForDummies.Core.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanyId");

                    b.Property<int>("Country");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("People");
                });

            modelBuilder.Entity("AllinOneForDummies.Core.Planet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("AttractivenessRating");

                    b.Property<DateTime?>("DeleteTime");

                    b.Property<long>("Distance");

                    b.Property<bool?>("IsDeleted");

                    b.Property<string>("Name")
                        .HasMaxLength(255);

                    b.Property<int>("PlanetType");

                    b.Property<decimal>("Radius");

                    b.Property<int>("StarId");

                    b.HasKey("Id");

                    b.HasIndex("StarId");

                    b.ToTable("Planets");
                });

            modelBuilder.Entity("AllinOneForDummies.Core.Star", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("CapableOfLiving");

                    b.Property<DateTime?>("DeleteTime");

                    b.Property<bool?>("IsDeleted");

                    b.Property<string>("Name")
                        .HasMaxLength(255);

                    b.Property<int>("Size");

                    b.Property<int>("StarActivity");

                    b.HasKey("Id");

                    b.ToTable("Stars");
                });

            modelBuilder.Entity("AllinOneForDummies.Core.Moon", b =>
                {
                    b.HasOne("AllinOneForDummies.Core.Planet", "Planet")
                        .WithMany("Moons")
                        .HasForeignKey("PlanetId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AllinOneForDummies.Core.Person", b =>
                {
                    b.HasOne("AllinOneForDummies.Core.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AllinOneForDummies.Core.Planet", b =>
                {
                    b.HasOne("AllinOneForDummies.Core.Star", "Star")
                        .WithMany("Planets")
                        .HasForeignKey("StarId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
