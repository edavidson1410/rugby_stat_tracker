﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using rugby_stat_tracker.Data;

#nullable disable

namespace rugby_stat_tracker.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240429230705_InitialDataSeed")]
    partial class InitialDataSeed
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("rugby_stat_tracker.Models.IndividualGame", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Minutes")
                        .HasColumnType("int");

                    b.Property<int?>("PlayerId")
                        .HasColumnType("int");

                    b.Property<int>("Position")
                        .HasColumnType("int");

                    b.Property<int>("Tries")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PlayerId");

                    b.ToTable("IndividualGames");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Minutes = 80,
                            Position = 13,
                            Tries = 1
                        },
                        new
                        {
                            Id = 2,
                            Minutes = 80,
                            Position = 13,
                            Tries = 1
                        },
                        new
                        {
                            Id = 3,
                            Minutes = 80,
                            Position = 13,
                            Tries = 1
                        });
                });

            modelBuilder.Entity("rugby_stat_tracker.Models.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Hometown")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Position")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Players");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Birthdate = new DateTime(1992, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Hometown = "Jackson, MO",
                            Name = "Eric Davidson",
                            Position = 13
                        },
                        new
                        {
                            Id = 2,
                            Birthdate = new DateTime(1992, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Hometown = "Nelson, New Zealand",
                            Name = "Aidan Milne",
                            Position = 12
                        },
                        new
                        {
                            Id = 3,
                            Birthdate = new DateTime(1992, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Hometown = "Mexico",
                            Name = "Victor Romero",
                            Position = 6
                        });
                });

            modelBuilder.Entity("rugby_stat_tracker.Models.IndividualGame", b =>
                {
                    b.HasOne("rugby_stat_tracker.Models.Player", null)
                        .WithMany("IndividualGames")
                        .HasForeignKey("PlayerId");
                });

            modelBuilder.Entity("rugby_stat_tracker.Models.Player", b =>
                {
                    b.Navigation("IndividualGames");
                });
#pragma warning restore 612, 618
        }
    }
}
