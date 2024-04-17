﻿// <auto-generated />
using System;
using BetaTesters.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BetaTesters.Infrastructure.Migrations
{
    [DbContext(typeof(BetaTestersDbContext))]
    partial class BetaTestersDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                            ConcurrencyStamp = "1edce717-b961-43b3-8046-138049f83674",
                            Email = "useroff@mail.com",
                            EmailConfirmed = false,
                            FirstName = "User",
                            LastName = "Userov",
                            LockoutEnabled = false,
                            NormalizedEmail = "USEROFF@MAIL.COM",
                            NormalizedUserName = "USEROFF@MAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEKTd/GINIPnN1vTWolPMmxzEtx416+lJQzhTsBp2wsG+NJ4ajRHIyVpbBhfa46OKQw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "c4b131de-f1d9-4ceb-9115-ca1296a2811f",
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
                            ConcurrencyStamp = "7a97ee74-b0dd-4573-80f4-e9f6908a6e55",
                            Email = "modoff@mail.com",
                            EmailConfirmed = false,
                            FirstName = "Moderator",
                            LastName = "Modov",
                            LockoutEnabled = false,
                            NormalizedEmail = "MODOFF@MAIL.COM",
                            NormalizedUserName = "MODOFF@MAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEEJnEmgu+Yh8unvZBE1IsjAz8dCyUNY2YphMjjVGi3EQaQ9nDv/gcDO/tjlqupSbPA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "74516227-c400-4bb8-bd05-73b8db6acabd",
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
                            ConcurrencyStamp = "7ad9c7cf-14bb-44b7-b9b3-db25ee014268",
                            Email = "owneroff@mail.com",
                            EmailConfirmed = false,
                            FirstName = "Owner",
                            LastName = "Ownerov",
                            LockoutEnabled = false,
                            NormalizedEmail = "OWNEROFF@MAIL.COM",
                            NormalizedUserName = "OWNEROFF@MAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEOto630YRUjh2h2NuSdoYj3dsPLKS0ZIr30wxXa9rY09X+Vy8p7k0DhCze2XtMrDgg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "2e928e95-5a3a-4678-b9ff-cc28c1964976",
                            TwoFactorEnabled = false,
                            UserName = "owneroff@mail.com"
                        },
                        new
                        {
                            Id = new Guid("7051fdf0-f598-412c-8d48-3a0c65f0ceac"),
                            AccessFailedCount = 0,
                            Age = 25,
                            Balance = 0m,
                            ConcurrencyStamp = "5cc06d7c-b49d-46ef-99e5-0616e1a420bf",
                            Email = "adminoff@mail.com",
                            EmailConfirmed = false,
                            FirstName = "Admin",
                            LastName = "Adminov",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMINOFF@MAIL.COM",
                            NormalizedUserName = "ADMINOFF@MAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEE+H8mvIjMz/YskGkB689JjIhb82RQNrsOAc6R1kcHmHMM2SyPzWkIHaKOXhFi24pQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "9ec5555c-7679-418e-becd-4b733872803c",
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
                            Id = new Guid("1e66a3f8-045d-406e-89aa-8a059e77d225"),
                            Approval = 1,
                            AssignDate = new DateTime(2024, 4, 17, 12, 46, 1, 566, DateTimeKind.Local).AddTicks(4950),
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
                            Id = new Guid("de0665e9-ee22-4be4-8f6c-1e2e9c822bd3"),
                            Approval = 1,
                            AssignDate = new DateTime(2024, 4, 17, 12, 46, 1, 566, DateTimeKind.Local).AddTicks(5013),
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
                            Id = new Guid("c5d09533-12c8-45f2-a10b-300b005b83cc"),
                            Approval = 1,
                            AssignDate = new DateTime(2024, 4, 17, 12, 46, 1, 566, DateTimeKind.Local).AddTicks(5017),
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

                    b.Property<string>("SessionId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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
                            ConcurrencyStamp = "7f6350c4-39e4-417f-aeed-335941720f98",
                            Name = "default user",
                            NormalizedName = "DEFAULT USER"
                        },
                        new
                        {
                            Id = new Guid("b280f152-005b-49b2-a82a-7a1a142f898a"),
                            ConcurrencyStamp = "68de5456-0e68-42f6-b829-2b7896ed281c",
                            Name = "moderator",
                            NormalizedName = "MODERATOR"
                        },
                        new
                        {
                            Id = new Guid("cd3cbaa6-1e80-45a4-a2ef-6de3fee4ed59"),
                            ConcurrencyStamp = "699beb6c-75f1-44dc-9b26-ae3ea1d18676",
                            Name = "owner",
                            NormalizedName = "OWNER"
                        },
                        new
                        {
                            Id = new Guid("521aa62a-965e-44e7-a258-784118befe1c"),
                            ConcurrencyStamp = "c0e683e7-2d9c-4f81-9cb3-d51f5e06c0c0",
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
