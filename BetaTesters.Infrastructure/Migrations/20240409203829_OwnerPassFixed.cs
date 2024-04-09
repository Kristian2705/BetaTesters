using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BetaTesters.Infrastructure.Migrations
{
    public partial class OwnerPassFixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1c69a1cd-0a41-4e4d-a00a-a08d18c2cea9"),
                column: "ConcurrencyStamp",
                value: "0f25224b-6adc-4695-aae7-101b89aa848f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b280f152-005b-49b2-a82a-7a1a142f898a"),
                column: "ConcurrencyStamp",
                value: "d4fd22d8-c859-4d94-a6cb-a7b22e982022");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("cd3cbaa6-1e80-45a4-a2ef-6de3fee4ed59"),
                column: "ConcurrencyStamp",
                value: "cb596647-1780-4b47-ba0b-99ff51bd35ed");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("38885cfb-4b65-4503-9958-6389ac64eb1a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9ce97230-95da-4abc-b36a-a9f1009ccef7", "AQAAAAEAACcQAAAAEItB+yAG+Q5KbG/skihi9ZDeas3UgvgSq9p442iVnfKJH1Yxf3eQqBLvEmJnER8E5w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("dac439da-96ea-4ca5-aa3b-f059bd94c92c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2602c739-781e-4c76-bab7-46efa992bd3d", "AQAAAAEAACcQAAAAEBJ5ylF2RTcVCFbgTkgvW1AFlUXVjFZnftbnKKUMnvm2WxFl6cpm9+ey66Iah3vvSg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f903f113-d659-4848-87c5-97f49082ba46"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b1984fdd-fd49-400d-ab0a-4e1d48589ce2", "AQAAAAEAACcQAAAAEErjkZGp543CqfEZ4yPapFOdFqa5NidtobebsvcooEEcQFz6ZRvXegTjd8BD/exrsQ==" });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "Approval", "AssignDate", "CategoryId", "ContractorId", "CreatorId", "Description", "FinishDate", "IsDeleted", "Name", "ProgramId", "Reward", "State" },
                values: new object[,]
                {
                    { new Guid("56a6a48c-d609-4612-80ea-b03832db7bde"), 1, new DateTime(2024, 4, 9, 23, 38, 28, 856, DateTimeKind.Local).AddTicks(9648), 3, new Guid("f903f113-d659-4848-87c5-97f49082ba46"), new Guid("38885cfb-4b65-4503-9958-6389ac64eb1a"), "Check if the update profile feature works properly", null, false, "Check profile update", new Guid("f47b6e5c-46b8-4961-a809-787515b7d37e"), 15m, 2 },
                    { new Guid("ad26b6e3-aa9d-4616-a4cf-e974d28d5932"), 1, new DateTime(2024, 4, 9, 23, 38, 28, 856, DateTimeKind.Local).AddTicks(9593), 1, new Guid("f903f113-d659-4848-87c5-97f49082ba46"), new Guid("dac439da-96ea-4ca5-aa3b-f059bd94c92c"), "Added a new feature where users can chat with friends", null, false, "Added chat groups", new Guid("f47b6e5c-46b8-4961-a809-787515b7d37e"), 30m, 2 },
                    { new Guid("bdc3aee8-2907-4a22-b6a1-e17bb1c42a09"), 1, null, 2, null, new Guid("38885cfb-4b65-4503-9958-6389ac64eb1a"), "Users can't properly create a new post is now fixed", null, false, "Posts issue fix", new Guid("f47b6e5c-46b8-4961-a809-787515b7d37e"), 20m, 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("56a6a48c-d609-4612-80ea-b03832db7bde"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("ad26b6e3-aa9d-4616-a4cf-e974d28d5932"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("bdc3aee8-2907-4a22-b6a1-e17bb1c42a09"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1c69a1cd-0a41-4e4d-a00a-a08d18c2cea9"),
                column: "ConcurrencyStamp",
                value: "9f3c2d46-2307-40fb-8d76-fa9e91438507");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b280f152-005b-49b2-a82a-7a1a142f898a"),
                column: "ConcurrencyStamp",
                value: "09aeae2e-a0d8-41d0-a355-bddb2df53884");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("cd3cbaa6-1e80-45a4-a2ef-6de3fee4ed59"),
                column: "ConcurrencyStamp",
                value: "cf3db21b-2a21-4f16-88e2-4534134acb78");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("38885cfb-4b65-4503-9958-6389ac64eb1a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2c7c49ff-9db0-450b-a47e-997f9fa9907c", "AQAAAAEAACcQAAAAEIPF0mgOdbp/mbNUK69TtwQyxHDx+VJVOcPnMV6G9gtxWoakTXI9/GISJk5VH8l/2A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("dac439da-96ea-4ca5-aa3b-f059bd94c92c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f3a37324-3722-4412-a419-036287ef7efd", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f903f113-d659-4848-87c5-97f49082ba46"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cb9549f6-e147-4697-82b4-89739404e45f", "AQAAAAEAACcQAAAAEExlTEeEkbOxvSoCWbsQB5ZnG2rgkzKVuNzAv5bDbmfBMtCmqfgc9X60tCXNchpjJQ==" });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "Approval", "AssignDate", "CategoryId", "ContractorId", "CreatorId", "Description", "FinishDate", "IsDeleted", "Name", "ProgramId", "Reward", "State" },
                values: new object[,]
                {
                    { new Guid("1aaeb686-0953-46de-a43c-6600536ab8a8"), 1, null, 2, null, new Guid("38885cfb-4b65-4503-9958-6389ac64eb1a"), "Users can't properly create a new post is now fixed", null, false, "Posts issue fix", new Guid("f47b6e5c-46b8-4961-a809-787515b7d37e"), 20m, 3 },
                    { new Guid("4df6bfc4-4602-4f20-a516-948dbd8a5dda"), 1, new DateTime(2024, 4, 9, 23, 33, 35, 314, DateTimeKind.Local).AddTicks(9408), 3, new Guid("f903f113-d659-4848-87c5-97f49082ba46"), new Guid("38885cfb-4b65-4503-9958-6389ac64eb1a"), "Check if the update profile feature works properly", null, false, "Check profile update", new Guid("f47b6e5c-46b8-4961-a809-787515b7d37e"), 15m, 2 },
                    { new Guid("fa5ea050-bc36-463c-80b9-08619b857f3c"), 1, new DateTime(2024, 4, 9, 23, 33, 35, 314, DateTimeKind.Local).AddTicks(9256), 1, new Guid("f903f113-d659-4848-87c5-97f49082ba46"), new Guid("dac439da-96ea-4ca5-aa3b-f059bd94c92c"), "Added a new feature where users can chat with friends", null, false, "Added chat groups", new Guid("f47b6e5c-46b8-4961-a809-787515b7d37e"), 30m, 2 }
                });
        }
    }
}
