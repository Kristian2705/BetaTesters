using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BetaTesters.Infrastructure.Migrations
{
    public partial class ToUpperUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                value: "56fdbcdd-18f2-4dc7-b4b3-afa95fd32b9e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b280f152-005b-49b2-a82a-7a1a142f898a"),
                column: "ConcurrencyStamp",
                value: "54a538d5-f112-41ff-96d7-796bc416bc19");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("cd3cbaa6-1e80-45a4-a2ef-6de3fee4ed59"),
                column: "ConcurrencyStamp",
                value: "010078cd-98ac-42eb-8581-21bd9afa7acb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("38885cfb-4b65-4503-9958-6389ac64eb1a"),
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash" },
                values: new object[] { "fd4cd467-43e4-4d58-ab88-730d3d730bc4", "MODOFF@MAIL.COM", "MODERATORMODOV", "AQAAAAEAACcQAAAAEFSMz1ntXJn+qIPLhLkD8itWKd9p40Y9KVz23dcwlwHHooyPS6E75GDgqz5PU2MEqQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("dac439da-96ea-4ca5-aa3b-f059bd94c92c"),
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash" },
                values: new object[] { "c2315ded-8e62-46be-b88b-f866bcb0a972", "OWNEROFF@MAIL.COM", "OWNERONWEROV", "AQAAAAEAACcQAAAAEAw76b+xKqMzgmSkViDW20JQPVO+r2HfSyokMiC+bitDMtz7Xyf3tvWAdotI65OVsw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f903f113-d659-4848-87c5-97f49082ba46"),
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash" },
                values: new object[] { "c4307c76-c676-4751-bd1a-49e49a543817", "USEROFF@MAIL.COM", "USERUSEROV", "AQAAAAEAACcQAAAAEDr3v8BQc5V1si79jSb25euvujbz3e/UnAZwt9BeaGynBsAKkjjWO+lA9LA8wFeKvA==" });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "Approval", "AssignDate", "CategoryId", "ContractorId", "CreatorId", "Description", "FinishDate", "IsDeleted", "Name", "ProgramId", "Reward", "State" },
                values: new object[,]
                {
                    { new Guid("1047656a-df91-40d2-af79-c5611484660d"), 1, null, 2, null, new Guid("38885cfb-4b65-4503-9958-6389ac64eb1a"), "Users can't properly create a new post is now fixed", null, false, "Posts issue fix", new Guid("f47b6e5c-46b8-4961-a809-787515b7d37e"), 20m, 3 },
                    { new Guid("54fc2296-7656-4aa9-aab7-afbe7a90fcea"), 1, new DateTime(2024, 4, 9, 23, 51, 12, 54, DateTimeKind.Local).AddTicks(3482), 3, new Guid("f903f113-d659-4848-87c5-97f49082ba46"), new Guid("38885cfb-4b65-4503-9958-6389ac64eb1a"), "Check if the update profile feature works properly", null, false, "Check profile update", new Guid("f47b6e5c-46b8-4961-a809-787515b7d37e"), 15m, 2 },
                    { new Guid("5733b9e5-5cce-4007-b400-8bc3aed03d1c"), 1, new DateTime(2024, 4, 9, 23, 51, 12, 54, DateTimeKind.Local).AddTicks(3343), 1, new Guid("f903f113-d659-4848-87c5-97f49082ba46"), new Guid("dac439da-96ea-4ca5-aa3b-f059bd94c92c"), "Added a new feature where users can chat with friends", null, false, "Added chat groups", new Guid("f47b6e5c-46b8-4961-a809-787515b7d37e"), 30m, 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("1047656a-df91-40d2-af79-c5611484660d"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("54fc2296-7656-4aa9-aab7-afbe7a90fcea"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("5733b9e5-5cce-4007-b400-8bc3aed03d1c"));

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
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash" },
                values: new object[] { "9ce97230-95da-4abc-b36a-a9f1009ccef7", "modoff@mail.com", "ModeratorModov", "AQAAAAEAACcQAAAAEItB+yAG+Q5KbG/skihi9ZDeas3UgvgSq9p442iVnfKJH1Yxf3eQqBLvEmJnER8E5w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("dac439da-96ea-4ca5-aa3b-f059bd94c92c"),
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash" },
                values: new object[] { "2602c739-781e-4c76-bab7-46efa992bd3d", "owneroff@mail.com", "OwnerOnwerov", "AQAAAAEAACcQAAAAEBJ5ylF2RTcVCFbgTkgvW1AFlUXVjFZnftbnKKUMnvm2WxFl6cpm9+ey66Iah3vvSg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f903f113-d659-4848-87c5-97f49082ba46"),
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash" },
                values: new object[] { "b1984fdd-fd49-400d-ab0a-4e1d48589ce2", "useroff@mail.com", "UserUserov", "AQAAAAEAACcQAAAAEErjkZGp543CqfEZ4yPapFOdFqa5NidtobebsvcooEEcQFz6ZRvXegTjd8BD/exrsQ==" });

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
    }
}
