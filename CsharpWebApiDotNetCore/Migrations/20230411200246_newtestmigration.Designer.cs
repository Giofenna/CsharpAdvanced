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
    [Migration("20230411200246_newtestmigration")]
    partial class newtestmigration
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "test@test.nl",
                            FirstName = "Test",
                            LastName = "Test"
                        });
                });

            modelBuilder.Entity("CsharpWebApiDotNetCore.Models.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("IsCover")
                        .HasColumnType("bit");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.ToTable("Image");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            IsCover = true,
                            LocationId = 2,
                            Url = "https://th.bing.com/th/id/OIP.4XB8NF1awQyApnQDDmBmQwHaEo?pid=ImgDet&rs=1"
                        },
                        new
                        {
                            Id = 1,
                            IsCover = true,
                            LocationId = 1,
                            Url = "https://th.bing.com/th/id/OIP.4XB8NF1awQyApnQDDmBmQwHaEo?pid=ImgDet&rs=1"
                        });
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 1,
                            AvatarId = 1,
                            FirstName = "Jeffry",
                            LastName = "Bahmer"
                        });
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

                    b.Property<int?>("LandlordId")
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

                    b.HasIndex("LandlordId");

                    b.ToTable("Location");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Description",
                            Features = 0,
                            LandlordId = 1,
                            NumberOfGuests = 4,
                            PricePerDay = 20f,
                            Rooms = 2,
                            SubTitle = "SubTitle",
                            Title = "Title",
                            Type = 1
                        },
                        new
                        {
                            Id = 2,
                            Description = "Description",
                            Features = 0,
                            LandlordId = 1,
                            NumberOfGuests = 4,
                            PricePerDay = 30f,
                            Rooms = 2,
                            SubTitle = "SubTitle",
                            Title = "Title",
                            Type = 1
                        });
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CustomerId = 1,
                            Discount = 0f,
                            EndDate = new DateTime(2023, 4, 16, 22, 2, 46, 671, DateTimeKind.Local).AddTicks(5640),
                            LocationId = 1,
                            StartDate = new DateTime(2023, 4, 11, 22, 2, 46, 671, DateTimeKind.Local).AddTicks(5606)
                        });
                });

            modelBuilder.Entity("CsharpWebApiDotNetCore.Models.Image", b =>
                {
                    b.HasOne("CsharpWebApiDotNetCore.Models.Location", null)
                        .WithMany("Images")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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
                    b.HasOne("CsharpWebApiDotNetCore.Models.Landlord", "Landlord")
                        .WithMany("Locations")
                        .HasForeignKey("LandlordId");

                    b.Navigation("Landlord");
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

            modelBuilder.Entity("CsharpWebApiDotNetCore.Models.Customer", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("CsharpWebApiDotNetCore.Models.Landlord", b =>
                {
                    b.Navigation("Locations");
                });

            modelBuilder.Entity("CsharpWebApiDotNetCore.Models.Location", b =>
                {
                    b.Navigation("Images");

                    b.Navigation("Reservations");
                });
#pragma warning restore 612, 618
        }
    }
}
