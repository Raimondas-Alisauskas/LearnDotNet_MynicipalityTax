﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MunicipalityTax.Persistence.DbContexts;

namespace MunicipalityTax.Persistence.Migrations
{
    [DbContext(typeof(MtxDbContext))]
    [Migration("20201205092755_InitialWithData")]
    partial class InitialWithData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("MunicipalityTax.Domain.Entities.MunicipalityEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MunicipalityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Municipality");

                    b.HasData(
                        new
                        {
                            Id = new Guid("7ebced2b-e2f9-45e0-bf75-111111111100"),
                            MunicipalityName = "TestMunicipality"
                        });
                });

            modelBuilder.Entity("MunicipalityTax.Domain.Entities.TaxScheduleEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MunicipalityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ScheduleType")
                        .HasColumnType("int");

                    b.Property<decimal>("Tax")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("TaxStartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("MunicipalityId");

                    b.ToTable("TaxSchedule");

                    b.HasData(
                        new
                        {
                            Id = new Guid("7ebced2b-e2f9-45e0-bf75-111111111111"),
                            MunicipalityId = new Guid("7ebced2b-e2f9-45e0-bf75-111111111100"),
                            ScheduleType = 0,
                            Tax = 0.1m,
                            TaxStartDate = new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("7ebced2b-e2f9-45e0-bf75-111111111112"),
                            MunicipalityId = new Guid("7ebced2b-e2f9-45e0-bf75-111111111100"),
                            ScheduleType = 1,
                            Tax = 0.2m,
                            TaxStartDate = new DateTime(2015, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("7ebced2b-e2f9-45e0-bf75-111111111113"),
                            MunicipalityId = new Guid("7ebced2b-e2f9-45e0-bf75-111111111100"),
                            ScheduleType = 2,
                            Tax = 0.3m,
                            TaxStartDate = new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("7ebced2b-e2f9-45e0-bf75-111111111114"),
                            MunicipalityId = new Guid("7ebced2b-e2f9-45e0-bf75-111111111100"),
                            ScheduleType = 3,
                            Tax = 0.4m,
                            TaxStartDate = new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("MunicipalityTax.Domain.Entities.TaxScheduleEntity", b =>
                {
                    b.HasOne("MunicipalityTax.Domain.Entities.MunicipalityEntity", "Municipality")
                        .WithMany("TaxSchedules")
                        .HasForeignKey("MunicipalityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Municipality");
                });

            modelBuilder.Entity("MunicipalityTax.Domain.Entities.MunicipalityEntity", b =>
                {
                    b.Navigation("TaxSchedules");
                });
#pragma warning restore 612, 618
        }
    }
}
