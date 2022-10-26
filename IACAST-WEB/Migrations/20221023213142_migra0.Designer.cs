﻿// <auto-generated />
using System;
using IACAST_WEB.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace IACAST_WEB.Migrations
{
    [DbContext(typeof(IACAST_WEBContext))]
    [Migration("20221023213142_migra0")]
    partial class migra0
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("IACAST_WEB.Models.Episode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Released")
                        .HasColumnType("datetime2");

                    b.Property<int?>("TheGuestId")
                        .HasColumnType("int");

                    b.Property<int?>("TheHostId")
                        .HasColumnType("int");

                    b.Property<string>("Theme")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("TheGuestId");

                    b.HasIndex("TheHostId");

                    b.ToTable("Episode");
                });

            modelBuilder.Entity("IACAST_WEB.Models.Guest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Guest");
                });

            modelBuilder.Entity("IACAST_WEB.Models.Hosts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Hosts");
                });

            modelBuilder.Entity("IACAST_WEB.Models.Episode", b =>
                {
                    b.HasOne("IACAST_WEB.Models.Guest", "TheGuest")
                        .WithMany()
                        .HasForeignKey("TheGuestId");

                    b.HasOne("IACAST_WEB.Models.Hosts", "TheHost")
                        .WithMany()
                        .HasForeignKey("TheHostId");

                    b.Navigation("TheGuest");

                    b.Navigation("TheHost");
                });
#pragma warning restore 612, 618
        }
    }
}
