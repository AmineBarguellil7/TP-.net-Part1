﻿// <auto-generated />
using System;
using AM.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    [DbContext(typeof(AmContext))]
    [Migration("20230317105038_New-code")]
    partial class Newcode
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AM.Application.Core.Domain.Flight", b =>
                {
                    b.Property<int>("FlightId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FlightId"));

                    b.Property<string>("Departure")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.Property<string>("Destination")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.Property<DateTime>("EffectiveArrival")
                        .HasColumnType("date");

                    b.Property<int>("EstimateDuration")
                        .HasColumnType("int");

                    b.Property<DateTime>("FlightDate")
                        .HasColumnType("date");

                    b.Property<int?>("PlaneId")
                        .HasColumnType("int");

                    b.HasKey("FlightId");

                    b.HasIndex("PlaneId");

                    b.ToTable("Flights");
                });

            modelBuilder.Entity("AM.Application.Core.Domain.Passenger", b =>
                {
                    b.Property<int>("PassportNmber")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(7)
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PassportNmber"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("date");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.Property<string>("TelNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.HasKey("PassportNmber");

                    b.ToTable("Passengers", (string)null);

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("AM.Application.Core.Domain.Plane", b =>
                {
                    b.Property<int>("PlaneId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PlaneId"));

                    b.Property<int>("Capacity")
                        .HasColumnType("int")
                        .HasColumnName("PlaneCapacity");

                    b.Property<DateTime>("ManufactureDate")
                        .HasColumnType("date");

                    b.Property<int>("PlaneType")
                        .HasColumnType("int");

                    b.HasKey("PlaneId");

                    b.ToTable("MyPlanes", (string)null);
                });

            modelBuilder.Entity("AM.Application.Core.Domain.Ticket", b =>
                {
                    b.Property<int>("PassengerFK")
                        .HasColumnType("int");

                    b.Property<int>("FlightFK")
                        .HasColumnType("int");

                    b.Property<string>("Siege")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.Property<bool>("VIP")
                        .HasColumnType("bit");

                    b.Property<double>("prix")
                        .HasPrecision(2, 3)
                        .HasColumnType("float(2)");

                    b.HasKey("PassengerFK", "FlightFK");

                    b.HasIndex("FlightFK");

                    b.ToTable("Ticket");
                });

            modelBuilder.Entity("FlightPassenger", b =>
                {
                    b.Property<int>("ListFlightFlightId")
                        .HasColumnType("int");

                    b.Property<int>("PassengersPassportNmber")
                        .HasColumnType("int");

                    b.HasKey("ListFlightFlightId", "PassengersPassportNmber");

                    b.HasIndex("PassengersPassportNmber");

                    b.ToTable("FlightPassenger");
                });

            modelBuilder.Entity("AM.Application.Core.Domain.Staff", b =>
                {
                    b.HasBaseType("AM.Application.Core.Domain.Passenger");

                    b.Property<DateTime>("EmployementDate")
                        .HasColumnType("date");

                    b.Property<string>("Function")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.Property<float>("Salary")
                        .HasColumnType("real");

                    b.ToTable("Staffs", (string)null);
                });

            modelBuilder.Entity("AM.Application.Core.Domain.Traveller", b =>
                {
                    b.HasBaseType("AM.Application.Core.Domain.Passenger");

                    b.Property<string>("HealthInformation")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.Property<string>("Nationality")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.ToTable("Travellers", (string)null);
                });

            modelBuilder.Entity("AM.Application.Core.Domain.Flight", b =>
                {
                    b.HasOne("AM.Application.Core.Domain.Plane", "Plane")
                        .WithMany("Flights")
                        .HasForeignKey("PlaneId");

                    b.Navigation("Plane");
                });

            modelBuilder.Entity("AM.Application.Core.Domain.Passenger", b =>
                {
                    b.OwnsOne("AM.Application.Core.Domain.FullName", "fullName", b1 =>
                        {
                            b1.Property<int>("PassengerPassportNmber")
                                .HasColumnType("int");

                            b1.Property<string>("FirstName")
                                .IsRequired()
                                .HasMaxLength(50)
                                .HasColumnType("varchar");

                            b1.Property<string>("LastName")
                                .IsRequired()
                                .HasMaxLength(50)
                                .HasColumnType("varchar");

                            b1.HasKey("PassengerPassportNmber");

                            b1.ToTable("Passengers");

                            b1.WithOwner()
                                .HasForeignKey("PassengerPassportNmber");
                        });

                    b.Navigation("fullName")
                        .IsRequired();
                });

            modelBuilder.Entity("AM.Application.Core.Domain.Ticket", b =>
                {
                    b.HasOne("AM.Application.Core.Domain.Flight", "flight")
                        .WithMany("Tickets")
                        .HasForeignKey("FlightFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AM.Application.Core.Domain.Passenger", "passenger")
                        .WithMany("tickets")
                        .HasForeignKey("PassengerFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("flight");

                    b.Navigation("passenger");
                });

            modelBuilder.Entity("FlightPassenger", b =>
                {
                    b.HasOne("AM.Application.Core.Domain.Flight", null)
                        .WithMany()
                        .HasForeignKey("ListFlightFlightId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AM.Application.Core.Domain.Passenger", null)
                        .WithMany()
                        .HasForeignKey("PassengersPassportNmber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AM.Application.Core.Domain.Staff", b =>
                {
                    b.HasOne("AM.Application.Core.Domain.Passenger", null)
                        .WithOne()
                        .HasForeignKey("AM.Application.Core.Domain.Staff", "PassportNmber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AM.Application.Core.Domain.Traveller", b =>
                {
                    b.HasOne("AM.Application.Core.Domain.Passenger", null)
                        .WithOne()
                        .HasForeignKey("AM.Application.Core.Domain.Traveller", "PassportNmber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AM.Application.Core.Domain.Flight", b =>
                {
                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("AM.Application.Core.Domain.Passenger", b =>
                {
                    b.Navigation("tickets");
                });

            modelBuilder.Entity("AM.Application.Core.Domain.Plane", b =>
                {
                    b.Navigation("Flights");
                });
#pragma warning restore 612, 618
        }
    }
}
