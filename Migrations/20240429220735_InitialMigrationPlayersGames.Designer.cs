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
    [Migration("20240429220735_InitialMigrationPlayersGames")]
    partial class InitialMigrationPlayersGames
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("rugby_stat_tracker.Models.IndividualGames", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Minutes")
                        .HasColumnType("int");

                    b.Property<int>("PlayerIdId")
                        .HasColumnType("int");

                    b.Property<int>("Position")
                        .HasColumnType("int");

                    b.Property<int>("Tries")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PlayerIdId");

                    b.ToTable("IndividualStats");
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
                });

            modelBuilder.Entity("rugby_stat_tracker.Models.IndividualGames", b =>
                {
                    b.HasOne("rugby_stat_tracker.Models.Player", "PlayerId")
                        .WithMany("IndividualGames")
                        .HasForeignKey("PlayerIdId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PlayerId");
                });

            modelBuilder.Entity("rugby_stat_tracker.Models.Player", b =>
                {
                    b.Navigation("IndividualGames");
                });
#pragma warning restore 612, 618
        }
    }
}