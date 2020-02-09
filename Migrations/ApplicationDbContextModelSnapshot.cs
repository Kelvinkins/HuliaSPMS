﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SkyLightWeb.Data;

namespace SkyLightWeb.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("SkyLightWeb.Models.Asset", b =>
                {
                    b.Property<string>("AssetID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AssetName");

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<string>("CustodianID");

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateDeleted");

                    b.Property<DateTime>("DateDiscontinued");

                    b.Property<bool>("Deleted");

                    b.Property<string>("DeletedBy");

                    b.Property<string>("Description");

                    b.Property<bool>("Discontinued");

                    b.Property<string>("EquipmentID");

                    b.Property<string>("GpsProtocol");

                    b.Property<double>("Latitude");

                    b.Property<double>("Longitude");

                    b.Property<string>("MarkedBy");

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("Reason");

                    b.Property<string>("State");

                    b.Property<string>("TransactionID");

                    b.HasKey("AssetID");

                    b.HasIndex("CustodianID");

                    b.HasIndex("EquipmentID");

                    b.HasIndex("TransactionID");

                    b.ToTable("Assets");
                });

            modelBuilder.Entity("SkyLightWeb.Models.Custodian", b =>
                {
                    b.Property<string>("CustodianID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CustodianName");

                    b.Property<string>("CustodianType");

                    b.Property<DateTime>("DateAdded");

                    b.Property<string>("Description");

                    b.Property<bool>("Discontinued");

                    b.HasKey("CustodianID");

                    b.ToTable("Custodians");
                });

            modelBuilder.Entity("SkyLightWeb.Models.Equipment", b =>
                {
                    b.Property<string>("EquipmentID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateAdded");

                    b.Property<string>("Description");

                    b.Property<bool>("Discontinued");

                    b.Property<string>("EquipmentName");

                    b.Property<string>("EquipmentType");

                    b.Property<int>("ReOrderLimit");

                    b.Property<bool>("TrackInventory");

                    b.HasKey("EquipmentID");

                    b.ToTable("Equipments");
                });

            modelBuilder.Entity("SkyLightWeb.Models.Transaction", b =>
                {
                    b.Property<string>("TransactionID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<bool>("Discontinued");

                    b.Property<DateTime>("TransactionDate");

                    b.Property<string>("TransactionName");

                    b.Property<string>("TransactionType");

                    b.HasKey("TransactionID");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("SkyLightWeb.Models.TransactionDetail", b =>
                {
                    b.Property<string>("TransactionDetailID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AssetID");

                    b.Property<string>("Description");

                    b.Property<string>("EquipmentID");

                    b.Property<DateTime>("TransactionDate");

                    b.Property<string>("TransactionID");

                    b.Property<string>("TransactionType");

                    b.HasKey("TransactionDetailID");

                    b.HasIndex("AssetID");

                    b.HasIndex("EquipmentID");

                    b.HasIndex("TransactionID");

                    b.ToTable("TransactionDetails");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SkyLightWeb.Models.Asset", b =>
                {
                    b.HasOne("SkyLightWeb.Models.Custodian", "Custodian")
                        .WithMany("Assets")
                        .HasForeignKey("CustodianID");

                    b.HasOne("SkyLightWeb.Models.Equipment", "Equipment")
                        .WithMany("Assets")
                        .HasForeignKey("EquipmentID");

                    b.HasOne("SkyLightWeb.Models.Transaction")
                        .WithMany("Assets")
                        .HasForeignKey("TransactionID");
                });

            modelBuilder.Entity("SkyLightWeb.Models.TransactionDetail", b =>
                {
                    b.HasOne("SkyLightWeb.Models.Asset", "Asset")
                        .WithMany()
                        .HasForeignKey("AssetID");

                    b.HasOne("SkyLightWeb.Models.Equipment")
                        .WithMany("TransactionDetails")
                        .HasForeignKey("EquipmentID");

                    b.HasOne("SkyLightWeb.Models.Transaction", "Transaction")
                        .WithMany("TransactionDetails")
                        .HasForeignKey("TransactionID");
                });
#pragma warning restore 612, 618
        }
    }
}
