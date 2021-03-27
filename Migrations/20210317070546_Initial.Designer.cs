﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApi.Helpers;

namespace WebApi.Migrations
{
    [DbContext(typeof(SqliteDataContext))]
    [Migration("20210317070546_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0");

            modelBuilder.Entity("WebApi.Entities.AllocationManager", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<int>("GarageId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsVerified")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("BLOB");

                    b.Property<DateTime?>("PasswordReset")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("BLOB");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.Property<string>("Space")
                        .HasColumnType("TEXT");

                    b.Property<string>("State")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Verified")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("AllocationManagers");
                });

            modelBuilder.Entity("WebApi.Entities.Garage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<string>("CleaningRate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("OccupiedCapacity")
                        .HasColumnType("TEXT");

                    b.Property<int>("ParkingManagerId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ParkingManagerId1")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ParkingRate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.Property<string>("Space")
                        .HasColumnType("TEXT");

                    b.Property<string>("State")
                        .HasColumnType("TEXT");

                    b.Property<string>("TotalCapacity")
                        .HasColumnType("TEXT");

                    b.Property<bool>("hasCleaningService")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ParkingManagerId1");

                    b.ToTable("Garages");
                });

            modelBuilder.Entity("WebApi.Entities.Parking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AllocationMangerId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CleaningCost")
                        .HasColumnType("TEXT");

                    b.Property<string>("Cost")
                        .HasColumnType("TEXT");

                    b.Property<string>("DriverName")
                        .HasColumnType("TEXT");

                    b.Property<int>("GarageId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ParkingCost")
                        .HasColumnType("TEXT");

                    b.Property<int>("SpaceId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("UserCheckIn")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UserCheckOut")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("VehicleNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("isActive")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("isBooked")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("withCleaningService")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Parkings");
                });

            modelBuilder.Entity("WebApi.Entities.ParkingHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AllocationMangerId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CleaningCost")
                        .HasColumnType("TEXT");

                    b.Property<string>("Cost")
                        .HasColumnType("TEXT");

                    b.Property<string>("DriverName")
                        .HasColumnType("TEXT");

                    b.Property<int>("GarageId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ParkingCost")
                        .HasColumnType("TEXT");

                    b.Property<int>("SpaceId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("UserCheckIn")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UserCheckOut")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("VehicleNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("interval")
                        .HasColumnType("TEXT");

                    b.Property<bool>("withCleaningService")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("ParkingHistories");
                });

            modelBuilder.Entity("WebApi.Entities.ParkingManager", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<int>("GarageId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsVerified")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("BLOB");

                    b.Property<DateTime?>("PasswordReset")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("BLOB");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.Property<string>("State")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Verified")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ParkingManagers");
                });

            modelBuilder.Entity("WebApi.Entities.Space", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AllocationManagerId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Code")
                        .HasColumnType("TEXT");

                    b.Property<int>("GarageId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("OccupiedCapacity")
                        .HasColumnType("TEXT");

                    b.Property<string>("TotalCapacity")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AllocationManagerId");

                    b.HasIndex("GarageId");

                    b.ToTable("Spaces");
                });

            modelBuilder.Entity("WebApi.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("BLOB");

                    b.Property<DateTime?>("PasswordReset")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("BLOB");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.Property<string>("ResetToken")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("ResetTokenExpires")
                        .HasColumnType("TEXT");

                    b.Property<string>("Role")
                        .HasColumnType("TEXT");

                    b.Property<string>("State")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("TEXT");

                    b.Property<string>("VerificationToken")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Verified")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("WebApi.Entities.Garage", b =>
                {
                    b.HasOne("WebApi.Entities.ParkingManager", "ParkingManager")
                        .WithMany()
                        .HasForeignKey("ParkingManagerId1");
                });

            modelBuilder.Entity("WebApi.Entities.Parking", b =>
                {
                    b.HasOne("WebApi.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebApi.Entities.ParkingHistory", b =>
                {
                    b.HasOne("WebApi.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebApi.Entities.Space", b =>
                {
                    b.HasOne("WebApi.Entities.AllocationManager", "AllocationManager")
                        .WithMany("Spaces")
                        .HasForeignKey("AllocationManagerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApi.Entities.Garage", "Garage")
                        .WithMany("Spaces")
                        .HasForeignKey("GarageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebApi.Entities.User", b =>
                {
                    b.OwnsMany("WebApi.Entities.RefreshToken", "RefreshTokens", b1 =>
                        {
                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("INTEGER");

                            b1.Property<DateTime>("Created")
                                .HasColumnType("TEXT");

                            b1.Property<string>("CreatedByIp")
                                .HasColumnType("TEXT");

                            b1.Property<DateTime>("Expires")
                                .HasColumnType("TEXT");

                            b1.Property<string>("ReplacedByToken")
                                .HasColumnType("TEXT");

                            b1.Property<DateTime?>("Revoked")
                                .HasColumnType("TEXT");

                            b1.Property<string>("RevokedByIp")
                                .HasColumnType("TEXT");

                            b1.Property<string>("Token")
                                .HasColumnType("TEXT");

                            b1.Property<int>("UserId")
                                .HasColumnType("INTEGER");

                            b1.HasKey("Id");

                            b1.HasIndex("UserId");

                            b1.ToTable("RefreshToken");

                            b1.WithOwner("User")
                                .HasForeignKey("UserId");
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
