﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sushimi.Data;

#nullable disable

namespace Sushimi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250409152504_AdminUser")]
    partial class AdminUser
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

            modelBuilder.Entity("Sushimi.Models.AdminUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AdminUsers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Password = "admin123",
                            Username = "admin"
                        });
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

                    b.Property<float>("Weight")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("Dishes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = "Sushi",
                            Name = "California",
                            Price = 410,
                            Weight = 300f
                        },
                        new
                        {
                            Id = 2,
                            Category = "Sushi",
                            Name = "California with Tuna",
                            Price = 520,
                            Weight = 290f
                        },
                        new
                        {
                            Id = 3,
                            Category = "Sushi",
                            Name = "Enigma",
                            Price = 350,
                            Weight = 300f
                        },
                        new
                        {
                            Id = 4,
                            Category = "Sushi",
                            Name = "Sakura",
                            Price = 480,
                            Weight = 290f
                        },
                        new
                        {
                            Id = 5,
                            Category = "Sushi",
                            Name = "Felix with Crab",
                            Price = 380,
                            Weight = 305f
                        },
                        new
                        {
                            Id = 6,
                            Category = "Sushi",
                            Name = "Itachi",
                            Price = 390,
                            Weight = 320f
                        },
                        new
                        {
                            Id = 7,
                            Category = "Sushi",
                            Name = "Red Dragon",
                            Price = 530,
                            Weight = 325f
                        },
                        new
                        {
                            Id = 8,
                            Category = "Sushi",
                            Name = "Philadelphia",
                            Price = 400,
                            Weight = 320f
                        },
                        new
                        {
                            Id = 9,
                            Category = "Sets",
                            Name = "set 1",
                            Price = 1035,
                            Weight = 600f
                        },
                        new
                        {
                            Id = 10,
                            Category = "Sets",
                            Name = "set 2",
                            Price = 1540,
                            Weight = 895f
                        },
                        new
                        {
                            Id = 11,
                            Category = "Sets",
                            Name = "set 3",
                            Price = 1265,
                            Weight = 950f
                        },
                        new
                        {
                            Id = 12,
                            Category = "Sets",
                            Name = "set 4",
                            Price = 3300,
                            Weight = 2100f
                        },
                        new
                        {
                            Id = 13,
                            Category = "Sets",
                            Name = "set 5",
                            Price = 2280,
                            Weight = 1600f
                        },
                        new
                        {
                            Id = 14,
                            Category = "Sets",
                            Name = "set 6",
                            Price = 1320,
                            Weight = 650f
                        },
                        new
                        {
                            Id = 15,
                            Category = "Hot",
                            Name = "Beef udon noodles",
                            Price = 169,
                            Weight = 260f
                        },
                        new
                        {
                            Id = 16,
                            Category = "Hot",
                            Name = "Funchoza with seafood",
                            Price = 245,
                            Weight = 250f
                        },
                        new
                        {
                            Id = 17,
                            Category = "Hot",
                            Name = "Unagi chicken with rice",
                            Price = 155,
                            Weight = 280f
                        },
                        new
                        {
                            Id = 18,
                            Category = "Hot",
                            Name = "Udon noodles with prawns",
                            Price = 245,
                            Weight = 370f
                        },
                        new
                        {
                            Id = 19,
                            Category = "Snaсks",
                            Name = "Inari",
                            Price = 140,
                            Weight = 65f
                        },
                        new
                        {
                            Id = 20,
                            Category = "Snaсks",
                            Name = "Sashimi",
                            Price = 480,
                            Weight = 155f
                        },
                        new
                        {
                            Id = 21,
                            Category = "Snaсks",
                            Name = "Tartar",
                            Price = 360,
                            Weight = 150f
                        },
                        new
                        {
                            Id = 22,
                            Category = "Snaсks",
                            Name = "Chuka",
                            Price = 230,
                            Weight = 185f
                        },
                        new
                        {
                            Id = 23,
                            Category = "Drinks",
                            Name = "Coca-Cola",
                            Price = 35,
                            Weight = 0.5f
                        },
                        new
                        {
                            Id = 24,
                            Category = "Drinks",
                            Name = "Fanta",
                            Price = 35,
                            Weight = 0.5f
                        },
                        new
                        {
                            Id = 25,
                            Category = "Drinks",
                            Name = "Sprite",
                            Price = 35,
                            Weight = 0.5f
                        },
                        new
                        {
                            Id = 26,
                            Category = "Drinks",
                            Name = "Dr-Pepper",
                            Price = 40,
                            Weight = 0.5f
                        },
                        new
                        {
                            Id = 27,
                            Category = "Drinks",
                            Name = "Morshynska 1L",
                            Price = 50,
                            Weight = 1f
                        },
                        new
                        {
                            Id = 28,
                            Category = "Drinks",
                            Name = "Juice",
                            Price = 50,
                            Weight = 0.5f
                        },
                        new
                        {
                            Id = 29,
                            Category = "Snaсks",
                            Name = "Shrimp shiso kimchi",
                            Price = 245,
                            Weight = 120f
                        },
                        new
                        {
                            Id = 30,
                            Category = "Snaсks",
                            Name = "Chips",
                            Price = 135,
                            Weight = 100f
                        },
                        new
                        {
                            Id = 31,
                            Category = "Hot",
                            Name = "Ramen Spicy",
                            Price = 145,
                            Weight = 350f
                        },
                        new
                        {
                            Id = 32,
                            Category = "Drinks",
                            Name = "Morshynska 0.5L",
                            Price = 35,
                            Weight = 0.5f
                        });
                });

            modelBuilder.Entity("Sushimi.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Sushimi.Models.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DishId")
                        .HasColumnType("int");

                    b.Property<string>("DishName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderItems");
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

            modelBuilder.Entity("Sushimi.Models.OrderItem", b =>
                {
                    b.HasOne("Sushimi.Models.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("Sushimi.Models.Order", b =>
                {
                    b.Navigation("OrderItems");
                });
#pragma warning restore 612, 618
        }
    }
}
