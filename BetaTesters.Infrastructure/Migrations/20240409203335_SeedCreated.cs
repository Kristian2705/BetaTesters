using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BetaTesters.Infrastructure.Migrations
{
    public partial class SeedCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CategoryName",
                table: "Categories",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "BetaPrograms",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("1c69a1cd-0a41-4e4d-a00a-a08d18c2cea9"), "9f3c2d46-2307-40fb-8d76-fa9e91438507", "default user", "default user" },
                    { new Guid("b280f152-005b-49b2-a82a-7a1a142f898a"), "09aeae2e-a0d8-41d0-a355-bddb2df53884", "moderator", "moderator" },
                    { new Guid("cd3cbaa6-1e80-45a4-a2ef-6de3fee4ed59"), "cf3db21b-2a21-4f16-88e2-4534134acb78", "owner", "owner" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Age", "Balance", "BetaProgramId", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("38885cfb-4b65-4503-9958-6389ac64eb1a"), 0, 22, 0m, null, "2c7c49ff-9db0-450b-a47e-997f9fa9907c", "modoff@mail.com", false, "Moderator", "Modov", false, null, "modoff@mail.com", "ModeratorModov", "AQAAAAEAACcQAAAAEIPF0mgOdbp/mbNUK69TtwQyxHDx+VJVOcPnMV6G9gtxWoakTXI9/GISJk5VH8l/2A==", "0891234561", false, null, false, "ModeratorModov" },
                    { new Guid("dac439da-96ea-4ca5-aa3b-f059bd94c92c"), 0, 31, 0m, null, "f3a37324-3722-4412-a419-036287ef7efd", "owneroff@mail.com", false, "Owner", "Ownerov", false, null, "owneroff@mail.com", "OwnerOnwerov", null, "0891234561", false, null, false, "OwnerOnwerov" },
                    { new Guid("f903f113-d659-4848-87c5-97f49082ba46"), 0, 18, 0m, null, "cb9549f6-e147-4697-82b4-89739404e45f", "useroff@mail.com", false, "User", "Userov", false, null, "useroff@mail.com", "UserUserov", "AQAAAAEAACcQAAAAEExlTEeEkbOxvSoCWbsQB5ZnG2rgkzKVuNzAv5bDbmfBMtCmqfgc9X60tCXNchpjJQ==", "0881234567", false, null, false, "UserUserov" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName" },
                values: new object[,]
                {
                    { 1, "New Feature" },
                    { 2, "Bug Fix" },
                    { 3, "Check State" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("b280f152-005b-49b2-a82a-7a1a142f898a"), new Guid("38885cfb-4b65-4503-9958-6389ac64eb1a") },
                    { new Guid("cd3cbaa6-1e80-45a4-a2ef-6de3fee4ed59"), new Guid("dac439da-96ea-4ca5-aa3b-f059bd94c92c") },
                    { new Guid("1c69a1cd-0a41-4e4d-a00a-a08d18c2cea9"), new Guid("f903f113-d659-4848-87c5-97f49082ba46") }
                });

            migrationBuilder.InsertData(
                table: "BetaPrograms",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "OwnerId" },
                values: new object[] { new Guid("f47b6e5c-46b8-4961-a809-787515b7d37e"), "This is the official beta testing program for Facebook", "https://store-images.s-microsoft.com/image/apps.37935.9007199266245907.b029bd80-381a-4869-854f-bac6f359c5c9.91f8693c-c75b-4050-a796-63e1314d18c9?h=464", "Facebook Beta Program", new Guid("dac439da-96ea-4ca5-aa3b-f059bd94c92c") });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "Approval", "AssignDate", "CategoryId", "ContractorId", "CreatorId", "Description", "FinishDate", "IsDeleted", "Name", "ProgramId", "Reward", "State" },
                values: new object[] { new Guid("1aaeb686-0953-46de-a43c-6600536ab8a8"), 1, null, 2, null, new Guid("38885cfb-4b65-4503-9958-6389ac64eb1a"), "Users can't properly create a new post is now fixed", null, false, "Posts issue fix", new Guid("f47b6e5c-46b8-4961-a809-787515b7d37e"), 20m, 3 });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "Approval", "AssignDate", "CategoryId", "ContractorId", "CreatorId", "Description", "FinishDate", "IsDeleted", "Name", "ProgramId", "Reward", "State" },
                values: new object[] { new Guid("4df6bfc4-4602-4f20-a516-948dbd8a5dda"), 1, new DateTime(2024, 4, 9, 23, 33, 35, 314, DateTimeKind.Local).AddTicks(9408), 3, new Guid("f903f113-d659-4848-87c5-97f49082ba46"), new Guid("38885cfb-4b65-4503-9958-6389ac64eb1a"), "Check if the update profile feature works properly", null, false, "Check profile update", new Guid("f47b6e5c-46b8-4961-a809-787515b7d37e"), 15m, 2 });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "Approval", "AssignDate", "CategoryId", "ContractorId", "CreatorId", "Description", "FinishDate", "IsDeleted", "Name", "ProgramId", "Reward", "State" },
                values: new object[] { new Guid("fa5ea050-bc36-463c-80b9-08619b857f3c"), 1, new DateTime(2024, 4, 9, 23, 33, 35, 314, DateTimeKind.Local).AddTicks(9256), 1, new Guid("f903f113-d659-4848-87c5-97f49082ba46"), new Guid("dac439da-96ea-4ca5-aa3b-f059bd94c92c"), "Added a new feature where users can chat with friends", null, false, "Added chat groups", new Guid("f47b6e5c-46b8-4961-a809-787515b7d37e"), 30m, 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("b280f152-005b-49b2-a82a-7a1a142f898a"), new Guid("38885cfb-4b65-4503-9958-6389ac64eb1a") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("cd3cbaa6-1e80-45a4-a2ef-6de3fee4ed59"), new Guid("dac439da-96ea-4ca5-aa3b-f059bd94c92c") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("1c69a1cd-0a41-4e4d-a00a-a08d18c2cea9"), new Guid("f903f113-d659-4848-87c5-97f49082ba46") });

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("1aaeb686-0953-46de-a43c-6600536ab8a8"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("4df6bfc4-4602-4f20-a516-948dbd8a5dda"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("fa5ea050-bc36-463c-80b9-08619b857f3c"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1c69a1cd-0a41-4e4d-a00a-a08d18c2cea9"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b280f152-005b-49b2-a82a-7a1a142f898a"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("cd3cbaa6-1e80-45a4-a2ef-6de3fee4ed59"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("38885cfb-4b65-4503-9958-6389ac64eb1a"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f903f113-d659-4848-87c5-97f49082ba46"));

            migrationBuilder.DeleteData(
                table: "BetaPrograms",
                keyColumn: "Id",
                keyValue: new Guid("f47b6e5c-46b8-4961-a809-787515b7d37e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("dac439da-96ea-4ca5-aa3b-f059bd94c92c"));

            migrationBuilder.AlterColumn<string>(
                name: "CategoryName",
                table: "Categories",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "BetaPrograms",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);
        }
    }
}
