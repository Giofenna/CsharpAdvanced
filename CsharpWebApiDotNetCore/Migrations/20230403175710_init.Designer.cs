﻿// <auto-generated />
using System;
using CsharpWebApiDotNetCore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CsharpWebApiDotNetCore.Migrations
{
    [DbContext(typeof(AirDBContext))]
    [Migration("20230403175710_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CsharpWebApiDotNetCore.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("CsharpWebApiDotNetCore.Models.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("IsCover")
                        .HasColumnType("bit");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Image");
                });

            modelBuilder.Entity("CsharpWebApiDotNetCore.Models.Landlord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int?>("AvatarId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AvatarId");

                    b.ToTable("Landlord");
                });

            modelBuilder.Entity("CsharpWebApiDotNetCore.Models.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Features")
                        .HasColumnType("int");

                    b.Property<int?>("ImageId")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfGuests")
                        .HasColumnType("int");

                    b.Property<float>("PricePerDay")
                        .HasColumnType("real");

                    b.Property<int>("Rooms")
                        .HasColumnType("int");

                    b.Property<string>("SubTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ImageId");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("CsharpWebApiDotNetCore.Models.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<float>("Discount")
                        .HasColumnType("real");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("LocationId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("LocationId");

                    b.ToTable("Reservation");
                });

            modelBuilder.Entity("LandlordLocation", b =>
                {
                    b.Property<int>("LandlordsId")
                        .HasColumnType("int");

                    b.Property<int>("LocationsId")
                        .HasColumnType("int");

                    b.HasKey("LandlordsId", "LocationsId");

                    b.HasIndex("LocationsId");

                    b.ToTable("LandlordLocation");
                });

            modelBuilder.Entity("CsharpWebApiDotNetCore.Models.Landlord", b =>
                {
                    b.HasOne("CsharpWebApiDotNetCore.Models.Image", "Avatar")
                        .WithMany()
                        .HasForeignKey("AvatarId");

                    b.Navigation("Avatar");
                });

            modelBuilder.Entity("CsharpWebApiDotNetCore.Models.Location", b =>
                {
                    b.HasOne("CsharpWebApiDotNetCore.Models.Image", "Image")
                        .WithMany()
                        .HasForeignKey("ImageId");

                    b.Navigation("Image");
                });

            modelBuilder.Entity("CsharpWebApiDotNetCore.Models.Reservation", b =>
                {
                    b.HasOne("CsharpWebApiDotNetCore.Models.Customer", "Customer")
                        .WithMany("Reservations")
                        .HasForeignKey("CustomerId");

                    b.HasOne("CsharpWebApiDotNetCore.Models.Location", "Location")
                        .WithMany("Reservations")
                        .HasForeignKey("LocationId");

                    b.Navigation("Customer");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("LandlordLocation", b =>
                {
                    b.HasOne("CsharpWebApiDotNetCore.Models.Landlord", null)
                        .WithMany()
                        .HasForeignKey("LandlordsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CsharpWebApiDotNetCore.Models.Location", null)
                        .WithMany()
                        .HasForeignKey("LocationsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CsharpWebApiDotNetCore.Models.Customer", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("CsharpWebApiDotNetCore.Models.Location", b =>
                {
                    b.Navigation("Reservations");
                });
#pragma warning restore 612, 618
        }
    }
}