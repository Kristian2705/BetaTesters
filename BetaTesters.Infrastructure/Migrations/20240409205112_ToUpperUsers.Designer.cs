﻿// <auto-generated />
using System;
using BetaTesters.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BetaTesters.Infrastructure.Migrations
{
    [DbContext(typeof(BetaTestersDbContext))]
    [Migration("20240409205112_ToUpperUsers")]
    partial class ToUpperUsers
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BetaTesters.Infrastructure.Data.Models.ApplicationUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<decimal>("Balance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid?>("BetaProgramId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

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

                    b.HasIndex("BetaProgramId");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("f903f113-d659-4848-87c5-97f49082ba46"),
                            AccessFailedCount = 0,
                            Age = 18,
                            Balance = 0m,
                            ConcurrencyStamp = "c4307c76-c676-4751-bd1a-49e49a543817",
                            Email = "useroff@mail.com",
                            EmailConfirmed = false,
                            FirstName = "User",
                            LastName = "Userov",
                            LockoutEnabled = false,
                            NormalizedEmail = "USEROFF@MAIL.COM",
                            NormalizedUserName = "USERUSEROV",
                            PasswordHash = "AQAAAAEAACcQAAAAEDr3v8BQc5V1si79jSb25euvujbz3e/UnAZwt9BeaGynBsAKkjjWO+lA9LA8wFeKvA==",
                            PhoneNumber = "0881234567",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "UserUserov"
                        },
                        new
                        {
                            Id = new Guid("38885cfb-4b65-4503-9958-6389ac64eb1a"),
                            AccessFailedCount = 0,
                            Age = 22,
                            Balance = 0m,
                            ConcurrencyStamp = "fd4cd467-43e4-4d58-ab88-730d3d730bc4",
                            Email = "modoff@mail.com",
                            EmailConfirmed = false,
                            FirstName = "Moderator",
                            LastName = "Modov",
                            LockoutEnabled = false,
                            NormalizedEmail = "MODOFF@MAIL.COM",
                            NormalizedUserName = "MODERATORMODOV",
                            PasswordHash = "AQAAAAEAACcQAAAAEFSMz1ntXJn+qIPLhLkD8itWKd9p40Y9KVz23dcwlwHHooyPS6E75GDgqz5PU2MEqQ==",
                            PhoneNumber = "0891234561",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "ModeratorModov"
                        },
                        new
                        {
                            Id = new Guid("dac439da-96ea-4ca5-aa3b-f059bd94c92c"),
                            AccessFailedCount = 0,
                            Age = 31,
                            Balance = 0m,
                            ConcurrencyStamp = "c2315ded-8e62-46be-b88b-f866bcb0a972",
                            Email = "owneroff@mail.com",
                            EmailConfirmed = false,
                            FirstName = "Owner",
                            LastName = "Ownerov",
                            LockoutEnabled = false,
                            NormalizedEmail = "OWNEROFF@MAIL.COM",
                            NormalizedUserName = "OWNERONWEROV",
                            PasswordHash = "AQAAAAEAACcQAAAAEAw76b+xKqMzgmSkViDW20JQPVO+r2HfSyokMiC+bitDMtz7Xyf3tvWAdotI65OVsw==",
                            PhoneNumber = "0891234561",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "OwnerOnwerov"
                        });
                });

            modelBuilder.Entity("BetaTesters.Infrastructure.Data.Models.BetaProgram", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<Guid>("OwnerId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("BetaPrograms");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f47b6e5c-46b8-4961-a809-787515b7d37e"),
                            Description = "This is the official beta testing program for Facebook",
                            ImageUrl = "https://store-images.s-microsoft.com/image/apps.37935.9007199266245907.b029bd80-381a-4869-854f-bac6f359c5c9.91f8693c-c75b-4050-a796-63e1314d18c9?h=464",
                            Name = "Facebook Beta Program",
                            OwnerId = new Guid("dac439da-96ea-4ca5-aa3b-f059bd94c92c")
                        });
                });

            modelBuilder.Entity("BetaTesters.Infrastructure.Data.Models.CandidateApplication", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Approval")
                        .HasColumnType("int");

                    b.Property<Guid>("BetaProgramId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CandidateId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Motivation")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<Guid?>("ReviewerId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("BetaProgramId");

                    b.HasIndex("CandidateId");

                    b.HasIndex("ReviewerId");

                    b.ToTable("CandidateApplications");
                });

            modelBuilder.Entity("BetaTesters.Infrastructure.Data.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryName = "New Feature"
                        },
                        new
                        {
                            Id = 2,
                            CategoryName = "Bug Fix"
                        },
                        new
                        {
                            Id = 3,
                            CategoryName = "Check State"
                        });
                });

            modelBuilder.Entity("BetaTesters.Infrastructure.Data.Models.Payment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Money")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("ReceiverId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SenderId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ReceiverId");

                    b.HasIndex("SenderId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("BetaTesters.Infrastructure.Data.Models.Task", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Approval")
                        .HasColumnType("int");

                    b.Property<DateTime?>("AssignDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<Guid?>("ContractorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("FinishDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<Guid>("ProgramId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Reward")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ContractorId");

                    b.HasIndex("CreatorId");

                    b.HasIndex("ProgramId");

                    b.ToTable("Tasks");

                    b.HasData(
                        new
                        {
                            Id = new Guid("1047656a-df91-40d2-af79-c5611484660d"),
                            Approval = 1,
                            CategoryId = 2,
                            CreatorId = new Guid("38885cfb-4b65-4503-9958-6389ac64eb1a"),
                            Description = "Users can't properly create a new post is now fixed",
                            IsDeleted = false,
                            Name = "Posts issue fix",
                            ProgramId = new Guid("f47b6e5c-46b8-4961-a809-787515b7d37e"),
                            Reward = 20m,
                            State = 3
                        },
                        new
                        {
                            Id = new Guid("5733b9e5-5cce-4007-b400-8bc3aed03d1c"),
                            Approval = 1,
                            AssignDate = new DateTime(2024, 4, 9, 23, 51, 12, 54, DateTimeKind.Local).AddTicks(3343),
                            CategoryId = 1,
                            ContractorId = new Guid("f903f113-d659-4848-87c5-97f49082ba46"),
                            CreatorId = new Guid("dac439da-96ea-4ca5-aa3b-f059bd94c92c"),
                            Description = "Added a new feature where users can chat with friends",
                            IsDeleted = false,
                            Name = "Added chat groups",
                            ProgramId = new Guid("f47b6e5c-46b8-4961-a809-787515b7d37e"),
                            Reward = 30m,
                            State = 2
                        },
                        new
                        {
                            Id = new Guid("54fc2296-7656-4aa9-aab7-afbe7a90fcea"),
                            Approval = 1,
                            AssignDate = new DateTime(2024, 4, 9, 23, 51, 12, 54, DateTimeKind.Local).AddTicks(3482),
                            CategoryId = 3,
                            ContractorId = new Guid("f903f113-d659-4848-87c5-97f49082ba46"),
                            CreatorId = new Guid("38885cfb-4b65-4503-9958-6389ac64eb1a"),
                            Description = "Check if the update profile feature works properly",
                            IsDeleted = false,
                            Name = "Check profile update",
                            ProgramId = new Guid("f47b6e5c-46b8-4961-a809-787515b7d37e"),
                            Reward = 15m,
                            State = 2
                        });
                });

            modelBuilder.Entity("BetaTesters.Infrastructure.Data.Models.Transaction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Money")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

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

                    b.HasData(
                        new
                        {
                            Id = new Guid("1c69a1cd-0a41-4e4d-a00a-a08d18c2cea9"),
                            ConcurrencyStamp = "56fdbcdd-18f2-4dc7-b4b3-afa95fd32b9e",
                            Name = "default user",
                            NormalizedName = "default user"
                        },
                        new
                        {
                            Id = new Guid("b280f152-005b-49b2-a82a-7a1a142f898a"),
                            ConcurrencyStamp = "54a538d5-f112-41ff-96d7-796bc416bc19",
                            Name = "moderator",
                            NormalizedName = "moderator"
                        },
                        new
                        {
                            Id = new Guid("cd3cbaa6-1e80-45a4-a2ef-6de3fee4ed59"),
                            ConcurrencyStamp = "010078cd-98ac-42eb-8581-21bd9afa7acb",
                            Name = "owner",
                            NormalizedName = "owner"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = new Guid("f903f113-d659-4848-87c5-97f49082ba46"),
                            RoleId = new Guid("1c69a1cd-0a41-4e4d-a00a-a08d18c2cea9")
                        },
                        new
                        {
                            UserId = new Guid("38885cfb-4b65-4503-9958-6389ac64eb1a"),
                            RoleId = new Guid("b280f152-005b-49b2-a82a-7a1a142f898a")
                        },
                        new
                        {
                            UserId = new Guid("dac439da-96ea-4ca5-aa3b-f059bd94c92c"),
                            RoleId = new Guid("cd3cbaa6-1e80-45a4-a2ef-6de3fee4ed59")
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

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

            modelBuilder.Entity("BetaTesters.Infrastructure.Data.Models.ApplicationUser", b =>
                {
                    b.HasOne("BetaTesters.Infrastructure.Data.Models.BetaProgram", "BetaProgram")
                        .WithMany()
                        .HasForeignKey("BetaProgramId");

                    b.Navigation("BetaProgram");
                });

            modelBuilder.Entity("BetaTesters.Infrastructure.Data.Models.BetaProgram", b =>
                {
                    b.HasOne("BetaTesters.Infrastructure.Data.Models.ApplicationUser", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("BetaTesters.Infrastructure.Data.Models.CandidateApplication", b =>
                {
                    b.HasOne("BetaTesters.Infrastructure.Data.Models.BetaProgram", "BetaProgram")
                        .WithMany("Applications")
                        .HasForeignKey("BetaProgramId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BetaTesters.Infrastructure.Data.Models.ApplicationUser", "Candidate")
                        .WithMany("Applications")
                        .HasForeignKey("CandidateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BetaTesters.Infrastructure.Data.Models.ApplicationUser", "Reviewer")
                        .WithMany("ReviewedApplications")
                        .HasForeignKey("ReviewerId");

                    b.Navigation("BetaProgram");

                    b.Navigation("Candidate");

                    b.Navigation("Reviewer");
                });

            modelBuilder.Entity("BetaTesters.Infrastructure.Data.Models.Payment", b =>
                {
                    b.HasOne("BetaTesters.Infrastructure.Data.Models.ApplicationUser", "Receiver")
                        .WithMany("ReceivedPayments")
                        .HasForeignKey("ReceiverId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BetaTesters.Infrastructure.Data.Models.ApplicationUser", "Sender")
                        .WithMany("SentPayments")
                        .HasForeignKey("SenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Receiver");

                    b.Navigation("Sender");
                });

            modelBuilder.Entity("BetaTesters.Infrastructure.Data.Models.Task", b =>
                {
                    b.HasOne("BetaTesters.Infrastructure.Data.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BetaTesters.Infrastructure.Data.Models.ApplicationUser", "Contractor")
                        .WithMany("Tasks")
                        .HasForeignKey("ContractorId");

                    b.HasOne("BetaTesters.Infrastructure.Data.Models.ApplicationUser", "Creator")
                        .WithMany("CreatedTasks")
                        .HasForeignKey("CreatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BetaTesters.Infrastructure.Data.Models.BetaProgram", "Program")
                        .WithMany("Tasks")
                        .HasForeignKey("ProgramId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Contractor");

                    b.Navigation("Creator");

                    b.Navigation("Program");
                });

            modelBuilder.Entity("BetaTesters.Infrastructure.Data.Models.Transaction", b =>
                {
                    b.HasOne("BetaTesters.Infrastructure.Data.Models.ApplicationUser", "User")
                        .WithMany("Transactions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("BetaTesters.Infrastructure.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("BetaTesters.Infrastructure.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BetaTesters.Infrastructure.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("BetaTesters.Infrastructure.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BetaTesters.Infrastructure.Data.Models.ApplicationUser", b =>
                {
                    b.Navigation("Applications");

                    b.Navigation("CreatedTasks");

                    b.Navigation("ReceivedPayments");

                    b.Navigation("ReviewedApplications");

                    b.Navigation("SentPayments");

                    b.Navigation("Tasks");

                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("BetaTesters.Infrastructure.Data.Models.BetaProgram", b =>
                {
                    b.Navigation("Applications");

                    b.Navigation("Tasks");
                });
#pragma warning restore 612, 618
        }
    }
}
