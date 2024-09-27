﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sushimi.Data;

#nullable disable

namespace Sushimi.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Sushimi.Models.Dish", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Dishes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = "Sushi",
                            Name = "California",
                            Price = 410,
                            Weight = 300
                        },
                        new
                        {
                            Id = 2,
                            Category = "Sushi",
                            Name = "California with Tuna",
                            Price = 520,
                            Weight = 290
                        },
                        new
                        {
                            Id = 3,
                            Category = "Sushi",
                            Name = "Enigma",
                            Price = 350,
                            Weight = 300
                        },
                        new
                        {
                            Id = 4,
                            Category = "Sushi",
                            Name = "Sakura",
                            Price = 480,
                            Weight = 290
                        },
                        new
                        {
                            Id = 5,
                            Category = "Sushi",
                            Name = "Felix with Crab",
                            Price = 380,
                            Weight = 305
                        },
                        new
                        {
                            Id = 6,
                            Category = "Sushi",
                            Name = "Itachi",
                            Price = 390,
                            Weight = 320
                        },
                        new
                        {
                            Id = 7,
                            Category = "Sushi",
                            Name = "Red Dragon",
                            Price = 530,
                            Weight = 325
                        },
                        new
                        {
                            Id = 8,
                            Category = "Sushi",
                            Name = "Fiadelfia",
                            Price = 400,
                            Weight = 320
                        },
                        new
                        {
                            Id = 9,
                            Category = "Sets",
                            Name = "set 1",
                            Price = 1035,
                            Weight = 600
                        },
                        new
                        {
                            Id = 10,
                            Category = "Sets",
                            Name = "set 2",
                            Price = 1540,
                            Weight = 895
                        },
                        new
                        {
                            Id = 11,
                            Category = "Sets",
                            Name = "set 3",
                            Price = 1265,
                            Weight = 950
                        },
                        new
                        {
                            Id = 12,
                            Category = "Sets",
                            Name = "set 4",
                            Price = 3300,
                            Weight = 2100
                        },
                        new
                        {
                            Id = 13,
                            Category = "Sets",
                            Name = "set 5",
                            Price = 2280,
                            Weight = 1600
                        },
                        new
                        {
                            Id = 14,
                            Category = "Sets",
                            Name = "set 6",
                            Price = 1320,
                            Weight = 650
                        },
                        new
                        {
                            Id = 15,
                            Category = "Hot",
                            Name = "Beef udon noodles",
                            Price = 169,
                            Weight = 260
                        },
                        new
                        {
                            Id = 16,
                            Category = "Hot",
                            Name = "Funchoza with seafood",
                            Price = 245,
                            Weight = 250
                        },
                        new
                        {
                            Id = 17,
                            Category = "Hot",
                            Name = "Unagi chicken with rice",
                            Price = 155,
                            Weight = 280
                        },
                        new
                        {
                            Id = 18,
                            Category = "Hot",
                            Name = "Udon noodles with prawns",
                            Price = 245,
                            Weight = 370
                        },
                        new
                        {
                            Id = 19,
                            Category = "Snaks",
                            Name = "Inari",
                            Price = 140,
                            Weight = 65
                        },
                        new
                        {
                            Id = 20,
                            Category = "Snaks",
                            Name = "Sashimi",
                            Price = 480,
                            Weight = 155
                        },
                        new
                        {
                            Id = 21,
                            Category = "Snaks",
                            Name = "Tatar",
                            Price = 360,
                            Weight = 150
                        },
                        new
                        {
                            Id = 22,
                            Category = "Snaks",
                            Name = "Chuka",
                            Price = 230,
                            Weight = 185
                        },
                        new
                        {
                            Id = 23,
                            Category = "Drinks",
                            Name = "Coca-Cola",
                            Price = 35,
                            Weight = 5
                        },
                        new
                        {
                            Id = 24,
                            Category = "Drinks",
                            Name = "Fanta",
                            Price = 35,
                            Weight = 5
                        },
                        new
                        {
                            Id = 25,
                            Category = "Drinks",
                            Name = "Sprite",
                            Price = 35,
                            Weight = 5
                        },
                        new
                        {
                            Id = 26,
                            Category = "Drinks",
                            Name = "Dr-Pepper",
                            Price = 40,
                            Weight = 5
                        },
                        new
                        {
                            Id = 27,
                            Category = "Drinks",
                            Name = "Morshinkska",
                            Price = 35,
                            Weight = 5
                        },
                        new
                        {
                            Id = 28,
                            Category = "Drinks",
                            Name = "Juice",
                            Price = 50,
                            Weight = 5
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
