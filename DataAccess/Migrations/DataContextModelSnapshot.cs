﻿// <auto-generated />
using System;
using A2Mac1.Costino.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace A2Mac1.Costino.DataAccess.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("A2Mac1.Costino.Core.Entities.Equipment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Height")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Equipments");
                });

            modelBuilder.Entity("Project", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BaseCurrencyId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BasedOnOhSettingId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("CompanySurcharge")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("ComponentMargin")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("ComponentsOh")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("ConsumableMargin")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("ConsumableOh")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("DepreciationRatio")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("DepreciationTime")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EndedOn")
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("ExternalWorkMargin")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("ExternalWorkOh")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("FolderId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("HoursPerShift")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("InternalLogisticRatio")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsIncludedInternalLogistic")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastUpdatedFromOhSetting")
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("LogisticOh")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("ManufacturingMargin")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("ManufacturingOh")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("MaterialMargin")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("MaterialOh")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("OtherCostOh")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("OwnerId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("PackingOh")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProductDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProductLifeTimeInYears")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("ProductionDayPerWeek")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("ProductionWeeksPerYear")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProjectLeaderId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProjectManager")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ReleasedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ReleasedToReferenceDbOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("ResponsibleChiefExecutive")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("SgaOh")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("ShiftPerWeek")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("StartedOn")
                        .HasColumnType("datetime2");

                    b.Property<int?>("StatusId")
                        .HasColumnType("int");

                    b.Property<string>("TeamMembers")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Version")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("VersionReleasedOn")
                        .HasColumnType("datetime2");

                    b.Property<int?>("YearlyProducedPieces")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Projects");
                });
#pragma warning restore 612, 618
        }
    }
}
