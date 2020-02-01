﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Picerija.Models;

namespace Picerija.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
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
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

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
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Picerija.Models.Pica", b =>
                {
                    b.Property<int>("PicaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Akcija")
                        .HasColumnType("bit");

                    b.Property<string>("Alergenai")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageThumnailUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Kaina")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("Pagaminta")
                        .HasColumnType("bit");

                    b.Property<string>("Pavadinimas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RusisId")
                        .HasColumnType("int");

                    b.Property<string>("Sudetis")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PicaId");

                    b.HasIndex("RusisId");

                    b.ToTable("Picos");

                    b.HasData(
                        new
                        {
                            PicaId = 1,
                            Akcija = true,
                            Alergenai = "A,B,C",
                            ImageUrl = "C:\\Users\\Marius\\Desktop\\C#Vakariniai mokymai\\Picerija\\Picerija\\wwwroot\\paveiksliukai\\margarita.png",
                            Kaina = 7.99m,
                            Pagaminta = true,
                            Pavadinimas = "Margarita",
                            RusisId = 3,
                            Sudetis = "Padas, suris, Desreles"
                        },
                        new
                        {
                            PicaId = 2,
                            Akcija = true,
                            Alergenai = "A,B,C",
                            ImageUrl = "C:\\Users\\Marius\\Desktop\\C#Vakariniai mokymai\\Picerija\\Picerija\\wwwroot\\paveiksliukai\\salami.png",
                            Kaina = 6.99m,
                            Pagaminta = true,
                            Pavadinimas = "Salami",
                            RusisId = 1,
                            Sudetis = "Padas, suris, Salami"
                        },
                        new
                        {
                            PicaId = 3,
                            Akcija = true,
                            Alergenai = "A,B,C",
                            ImageUrl = "C:\\Users\\Marius\\Desktop\\C#Vakariniai mokymai\\Picerija\\Picerija\\wwwroot\\paveiksliukai\\margarita.png",
                            Kaina = 7.99m,
                            Pagaminta = true,
                            Pavadinimas = "Taiti",
                            RusisId = 3,
                            Sudetis = "Padas, suris, Taiti"
                        },
                        new
                        {
                            PicaId = 4,
                            Akcija = true,
                            Alergenai = "A,B,C",
                            ImageUrl = "C:\\Users\\Marius\\Desktop\\C#Vakariniai mokymai\\Picerija\\Picerija\\wwwroot\\paveiksliukai\\vegetariana.png",
                            Kaina = 7.99m,
                            Pagaminta = true,
                            Pavadinimas = "Vegetariana",
                            RusisId = 2,
                            Sudetis = "Padas, suris, Darzoves"
                        });
                });

            modelBuilder.Entity("Picerija.Models.Rusis", b =>
                {
                    b.Property<int>("RusisId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Aprasymas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RusisPavadinimas")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RusisId");

                    b.ToTable("Rusys");

                    b.HasData(
                        new
                        {
                            RusisId = 1,
                            RusisPavadinimas = "Astri"
                        },
                        new
                        {
                            RusisId = 2,
                            RusisPavadinimas = "Vegetariska"
                        },
                        new
                        {
                            RusisId = 3,
                            RusisPavadinimas = "Soti"
                        });
                });

            modelBuilder.Entity("Picerija.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("ShoppingCartItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Kiekis")
                        .HasColumnType("int");

                    b.Property<int?>("PicaId")
                        .HasColumnType("int");

                    b.Property<string>("ShoppingCartId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShoppingCartItemId");

                    b.HasIndex("PicaId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("Picerija.Models.Uzsakymas", b =>
                {
                    b.Property<int>("UzsakymasId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresas")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<decimal>("PilnasUzsakymas")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("TelefonoNumeris")
                        .IsRequired()
                        .HasColumnType("nvarchar(12)")
                        .HasMaxLength(12);

                    b.Property<DateTime>("UzsakytaLaikas")
                        .HasColumnType("datetime2");

                    b.Property<string>("Vardas")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("UzsakymasId");

                    b.ToTable("Uzsakymai");
                });

            modelBuilder.Entity("Picerija.Models.UzsakymoInfo", b =>
                {
                    b.Property<int>("UzsakymoInfoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Kaina")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Kiekis")
                        .HasColumnType("int");

                    b.Property<int>("PicaId")
                        .HasColumnType("int");

                    b.Property<int?>("UzsakymasId")
                        .HasColumnType("int");

                    b.Property<int>("UzsakymoId")
                        .HasColumnType("int");

                    b.HasKey("UzsakymoInfoId");

                    b.HasIndex("PicaId");

                    b.HasIndex("UzsakymasId");

                    b.ToTable("UzsakymoInfos");
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

            modelBuilder.Entity("Picerija.Models.Pica", b =>
                {
                    b.HasOne("Picerija.Models.Rusis", "Rusis")
                        .WithMany("Picos")
                        .HasForeignKey("RusisId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Picerija.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("Picerija.Models.Pica", "Pica")
                        .WithMany()
                        .HasForeignKey("PicaId");
                });

            modelBuilder.Entity("Picerija.Models.UzsakymoInfo", b =>
                {
                    b.HasOne("Picerija.Models.Pica", "Pica")
                        .WithMany()
                        .HasForeignKey("PicaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Picerija.Models.Uzsakymas", "Uzsakymas")
                        .WithMany("UzsakymoInfos")
                        .HasForeignKey("UzsakymasId");
                });
#pragma warning restore 612, 618
        }
    }
}