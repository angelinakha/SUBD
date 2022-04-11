﻿// <auto-generated />
using System;
using DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DB.Migrations
{
    [DbContext(typeof(Database))]
    partial class DatabaseModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("DB.Tables.Airplane", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Aircraftname")
                        .HasColumnType("text");

                    b.Property<int>("MaxNumberOfSeats")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Airplanes");
                });

            modelBuilder.Entity("DB.Tables.Flight", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int?>("AirplaneId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DestinationTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("FlightDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("IdAirplane")
                        .HasColumnType("integer");

                    b.Property<int>("IdPilot")
                        .HasColumnType("integer");

                    b.Property<int>("IdRoute")
                        .HasColumnType("integer");

                    b.Property<int>("OccupPlaces")
                        .HasColumnType("integer");

                    b.Property<int?>("PilotId")
                        .HasColumnType("integer");

                    b.Property<int>("RouteId")
                        .HasColumnType("integer");

                    b.Property<int?>("TicketId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AirplaneId");

                    b.HasIndex("PilotId");

                    b.HasIndex("RouteId");

                    b.HasIndex("TicketId");

                    b.ToTable("Flights");
                });

            modelBuilder.Entity("DB.Tables.Pilot", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("NamePilot")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Pilots");
                });

            modelBuilder.Entity("DB.Tables.Route", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("DeparturePoint")
                        .HasColumnType("text");

                    b.Property<DateTime>("DepartureTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Destination")
                        .HasColumnType("text");

                    b.Property<DateTime>("FlightDate")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("Routes");
                });

            modelBuilder.Entity("DB.Tables.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("FlightDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("FlightNumber")
                        .HasColumnType("text");

                    b.Property<decimal>("TicketPrice")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("DB.Tables.Flight", b =>
                {
                    b.HasOne("DB.Tables.Airplane", "Airplane")
                        .WithMany("Flights")
                        .HasForeignKey("AirplaneId");

                    b.HasOne("DB.Tables.Pilot", "Pilot")
                        .WithMany("Flights")
                        .HasForeignKey("PilotId");

                    b.HasOne("DB.Tables.Route", "Route")
                        .WithMany("Flights")
                        .HasForeignKey("RouteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DB.Tables.Ticket", "Ticket")
                        .WithMany("Flights")
                        .HasForeignKey("TicketId");

                    b.Navigation("Airplane");

                    b.Navigation("Pilot");

                    b.Navigation("Route");

                    b.Navigation("Ticket");
                });

            modelBuilder.Entity("DB.Tables.Airplane", b =>
                {
                    b.Navigation("Flights");
                });

            modelBuilder.Entity("DB.Tables.Pilot", b =>
                {
                    b.Navigation("Flights");
                });

            modelBuilder.Entity("DB.Tables.Route", b =>
                {
                    b.Navigation("Flights");
                });

            modelBuilder.Entity("DB.Tables.Ticket", b =>
                {
                    b.Navigation("Flights");
                });
#pragma warning restore 612, 618
        }
    }
}
