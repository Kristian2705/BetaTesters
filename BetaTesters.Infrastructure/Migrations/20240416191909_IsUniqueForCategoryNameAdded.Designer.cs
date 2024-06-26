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
    [Migration("20240416191909_IsUniqueForCategoryNameAdded")]
    partial class IsUniqueForCategoryNameAdded
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
                            ConcurrencyStamp = "bbe47911-7b46-42d7-9798-a467b12b935c",
                            Email = "useroff@mail.com",
                            EmailConfirmed = false,
                            FirstName = "User",
                            LastName = "Userov",
                            LockoutEnabled = false,
                            NormalizedEmail = "USEROFF@MAIL.COM",
                            NormalizedUserName = "USEROFF@MAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEC9mpenXZRfheIl05iQVyIS91DNnh/R4BcEQpf4/6gVHtX9PCAtikmo6MZk0Af2Rhg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "14ae61bc-343b-486c-8bd5-5558ca8842a9",
                            TwoFactorEnabled = false,
                            UserName = "useroff@mail.com"
                        },
                        new
                        {
                            Id = new Guid("38885cfb-4b65-4503-9958-6389ac64eb1a"),
                            AccessFailedCount = 0,
                            Age = 22,
                            Balance = 0m,
                            BetaProgramId = new Guid("f47b6e5c-46b8-4961-a809-787515b7d37e"),
                            ConcurrencyStamp = "a8e559d3-35cc-4a9a-b47f-11f38e586799",
                            Email = "modoff@mail.com",
                            EmailConfirmed = false,
                            FirstName = "Moderator",
                            LastName = "Modov",
                            LockoutEnabled = false,
                            NormalizedEmail = "MODOFF@MAIL.COM",
                            NormalizedUserName = "MODOFF@MAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEE4yPDVARqlFGPOLplTx+QhKjrZPsCSeFgsw7Q/yzmB4ILE1m+SYUG/uXuVvVe8gDw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "12b0ca84-c0e6-422e-b997-82887e4bb10f",
                            TwoFactorEnabled = false,
                            UserName = "modoff@mail.com"
                        },
                        new
                        {
                            Id = new Guid("dac439da-96ea-4ca5-aa3b-f059bd94c92c"),
                            AccessFailedCount = 0,
                            Age = 31,
                            Balance = 500.00m,
                            BetaProgramId = new Guid("f47b6e5c-46b8-4961-a809-787515b7d37e"),
                            ConcurrencyStamp = "53f40176-d940-4d37-a40e-0939c52f05c0",
                            Email = "owneroff@mail.com",
                            EmailConfirmed = false,
                            FirstName = "Owner",
                            LastName = "Ownerov",
                            LockoutEnabled = false,
                            NormalizedEmail = "OWNEROFF@MAIL.COM",
                            NormalizedUserName = "OWNEROFF@MAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEHaerl4YKth068FT8nPSn5kb0oxCpo8uxnwLMWLOxtddtLrl5SynYIPkVsEio+VBrg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "72377f23-f6de-4bf1-bd1b-68950a9e96e0",
                            TwoFactorEnabled = false,
                            UserName = "owneroff@mail.com"
                        },
                        new
                        {
                            Id = new Guid("7051fdf0-f598-412c-8d48-3a0c65f0ceac"),
                            AccessFailedCount = 0,
                            Age = 25,
                            Balance = 0m,
                            ConcurrencyStamp = "55ee2bd4-ff69-4ffc-b7b6-5d7686599e46",
                            Email = "adminoff@mail.com",
                            EmailConfirmed = false,
                            FirstName = "Admin",
                            LastName = "Adminov",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMINOFF@MAIL.COM",
                            NormalizedUserName = "ADMINOFF@MAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEBHMaUi19XqQbxOv1Sy/Y0RgkH5wIV6wyWK24TO7xRQXg/tySiv5SPbLHSMsuOu+zg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "bdf8018b-70fe-454b-9788-a2c296b5a632",
                            TwoFactorEnabled = false,
                            UserName = "adminoff@mail.com"
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

                    b.HasKey("Id");

                    b.ToTable("BetaPrograms");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f47b6e5c-46b8-4961-a809-787515b7d37e"),
                            Description = "This is the official beta testing program for Facebook",
                            ImageUrl = "https://store-images.s-microsoft.com/image/apps.37935.9007199266245907.b029bd80-381a-4869-854f-bac6f359c5c9.91f8693c-c75b-4050-a796-63e1314d18c9?h=464",
                            Name = "Facebook Beta Program"
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

                    b.Property<string>("Motivation")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.HasIndex("BetaProgramId");

                    b.HasIndex("CandidateId");

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

                    b.HasIndex("CategoryName")
                        .IsUnique();

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

                    b.Property<bool>("IsPaidFor")
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
                            Id = new Guid("0df6eea5-bc28-499e-9882-70058fcba1bb"),
                            Approval = 1,
                            AssignDate = new DateTime(2024, 4, 16, 22, 19, 8, 791, DateTimeKind.Local).AddTicks(6216),
                            CategoryId = 2,
                            CreatorId = new Guid("38885cfb-4b65-4503-9958-6389ac64eb1a"),
                            Description = "Users can't properly create a new post is now fixed",
                            IsPaidFor = false,
                            Name = "Posts issue fix",
                            ProgramId = new Guid("f47b6e5c-46b8-4961-a809-787515b7d37e"),
                            Reward = 20m,
                            State = 3
                        },
                        new
                        {
                            Id = new Guid("e05f4064-cd72-4ed9-82c0-8a147ec9f655"),
                            Approval = 1,
                            AssignDate = new DateTime(2024, 4, 16, 22, 19, 8, 791, DateTimeKind.Local).AddTicks(6261),
                            CategoryId = 1,
                            CreatorId = new Guid("dac439da-96ea-4ca5-aa3b-f059bd94c92c"),
                            Description = "Added a new feature where users can chat with friends",
                            IsPaidFor = false,
                            Name = "Added chat groups",
                            ProgramId = new Guid("f47b6e5c-46b8-4961-a809-787515b7d37e"),
                            Reward = 30m,
                            State = 3
                        },
                        new
                        {
                            Id = new Guid("99af6dc4-7983-43b8-b802-2c3b1a0a1801"),
                            Approval = 1,
                            AssignDate = new DateTime(2024, 4, 16, 22, 19, 8, 791, DateTimeKind.Local).AddTicks(6264),
                            CategoryId = 3,
                            CreatorId = new Guid("38885cfb-4b65-4503-9958-6389ac64eb1a"),
                            Description = "Check if the update profile feature works properly",
                            IsPaidFor = false,
                            Name = "Check profile update",
                            ProgramId = new Guid("f47b6e5c-46b8-4961-a809-787515b7d37e"),
                            Reward = 15m,
                            State = 3
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
                            ConcurrencyStamp = "6a454538-aa95-433b-8a2c-002412205744",
                            Name = "default user",
                            NormalizedName = "DEFAULT USER"
                        },
                        new
                        {
                            Id = new Guid("b280f152-005b-49b2-a82a-7a1a142f898a"),
                            ConcurrencyStamp = "99e707cf-7c81-43c7-8ccd-02b1c1311c18",
                            Name = "moderator",
                            NormalizedName = "MODERATOR"
                        },
                        new
                        {
                            Id = new Guid("cd3cbaa6-1e80-45a4-a2ef-6de3fee4ed59"),
                            ConcurrencyStamp = "bf004a91-b079-4bea-b9e3-e75c2a0027fb",
                            Name = "owner",
                            NormalizedName = "OWNER"
                        },
                        new
                        {
                            Id = new Guid("521aa62a-965e-44e7-a258-784118befe1c"),
                            ConcurrencyStamp = "f24e4f1c-6150-44b1-8051-da99c8d48ab9",
                            Name = "administrator",
                            NormalizedName = "ADMINISTRATOR"
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

                    b.HasData(
                        new
                        {
                            Id = 2,
                            ClaimType = "user:fullname",
                            ClaimValue = "User Userov",
                            UserId = new Guid("f903f113-d659-4848-87c5-97f49082ba46")
                        },
                        new
                        {
                            Id = 3,
                            ClaimType = "user:fullname",
                            ClaimValue = "Moderator Modov",
                            UserId = new Guid("38885cfb-4b65-4503-9958-6389ac64eb1a")
                        },
                        new
                        {
                            Id = 4,
                            ClaimType = "user:fullname",
                            ClaimValue = "Owner Ownerov",
                            UserId = new Guid("dac439da-96ea-4ca5-aa3b-f059bd94c92c")
                        },
                        new
                        {
                            Id = 1011,
                            ClaimType = "user:fullname",
                            ClaimValue = "Admin Adminov",
                            UserId = new Guid("7051fdf0-f598-412c-8d48-3a0c65f0ceac")
                        });
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
                        },
                        new
                        {
                            UserId = new Guid("7051fdf0-f598-412c-8d48-3a0c65f0ceac"),
                            RoleId = new Guid("521aa62a-965e-44e7-a258-784118befe1c")
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
                        .WithMany("Users")
                        .HasForeignKey("BetaProgramId");

                    b.Navigation("BetaProgram");
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

                    b.Navigation("BetaProgram");

                    b.Navigation("Candidate");
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
                        .WithMany("Tasks")
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

                    b.Navigation("SentPayments");

                    b.Navigation("Tasks");

                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("BetaTesters.Infrastructure.Data.Models.BetaProgram", b =>
                {
                    b.Navigation("Applications");

                    b.Navigation("Tasks");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("BetaTesters.Infrastructure.Data.Models.Category", b =>
                {
                    b.Navigation("Tasks");
                });
#pragma warning restore 612, 618
        }
    }
}
