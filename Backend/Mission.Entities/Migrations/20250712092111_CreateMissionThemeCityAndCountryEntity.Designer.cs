﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission.Entities;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Mission.Entities.Migrations
{
    [DbContext(typeof(MissionDBContext))]
    [Migration("20250712092111_CreateMissionThemeCityAndCountryEntity")]
    partial class CreateMissionThemeCityAndCountryEntity
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Mission.Entities.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("CountryId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CityName = "Ahmedabad",
                            CountryId = 1
                        },
                        new
                        {
                            Id = 2,
                            CityName = "Rajkot",
                            CountryId = 2
                        },
                        new
                        {
                            Id = 3,
                            CityName = "Surat",
                            CountryId = 3
                        },
                        new
                        {
                            Id = 4,
                            CityName = "Jamnagar",
                            CountryId = 4
                        },
                        new
                        {
                            Id = 5,
                            CityName = "New York",
                            CountryId = 5
                        },
                        new
                        {
                            Id = 6,
                            CityName = "California",
                            CountryId = 6
                        },
                        new
                        {
                            Id = 7,
                            CityName = "Texas",
                            CountryId = 7
                        },
                        new
                        {
                            Id = 8,
                            CityName = "London",
                            CountryId = 8
                        },
                        new
                        {
                            Id = 9,
                            CityName = "Manchester",
                            CountryId = 9
                        },
                        new
                        {
                            Id = 10,
                            CityName = "Birmingham",
                            CountryId = 10
                        },
                        new
                        {
                            Id = 11,
                            CityName = "Moscow",
                            CountryId = 11
                        },
                        new
                        {
                            Id = 12,
                            CityName = "Saint Petersburg",
                            CountryId = 12
                        },
                        new
                        {
                            Id = 13,
                            CityName = "Yekaterinburg",
                            CountryId = 13
                        });
                });

            modelBuilder.Entity("Mission.Entities.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Countires");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CountryName = "India"
                        },
                        new
                        {
                            Id = 2,
                            CountryName = "USA"
                        },
                        new
                        {
                            Id = 3,
                            CountryName = "UK"
                        },
                        new
                        {
                            Id = 4,
                            CountryName = "Russia"
                        });
                });

            modelBuilder.Entity("Mission.Entities.Models.MissionSkill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("SkillName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("MissionSkills");
                });

            modelBuilder.Entity("Mission.Entities.Models.MissionTheme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ThemeName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("MissionThemes");
                });

            modelBuilder.Entity("Mission.Entities.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UserImage")
                        .HasColumnType("text");

                    b.Property<string>("UserType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EmailAddress = "admin@tatvasoft.com",
                            FirstName = "Admin",
                            LastName = "Tatva",
                            Password = "admin",
                            PhoneNumber = "1234567890",
                            UserImage = "",
                            UserType = "admin"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
