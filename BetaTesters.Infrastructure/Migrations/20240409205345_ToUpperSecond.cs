using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BetaTesters.Infrastructure.Migrations
{
    public partial class ToUpperSecond : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "c8320320-35bd-4a2f-9c64-e864f748620e", "DEFAULT USER" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b280f152-005b-49b2-a82a-7a1a142f898a"),
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "56d591ee-f95e-4ea5-949a-8a5a43687795", "MODERATOR" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("cd3cbaa6-1e80-45a4-a2ef-6de3fee4ed59"),
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "95b9da22-a42d-451c-a0da-8fda54f2dbfa", "OWNER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("38885cfb-4b65-4503-9958-6389ac64eb1a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "618a51e3-c229-49fe-8f84-079b11007d76", "AQAAAAEAACcQAAAAEHeEAWOBsPdJLJho//DmfnwyAldksr1dbDEbwnxIN9OVu0pOuctKR/6UjYnrH6TI8g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("dac439da-96ea-4ca5-aa3b-f059bd94c92c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6a978913-7bc1-4a67-b377-5b8d2445df74", "AQAAAAEAACcQAAAAENNXOSrUpNXxwxzWl0ynnQpC+BHfXVrWhzC8zgXDa/nQjw/GCyow7WgmnFWZqu59kw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f903f113-d659-4848-87c5-97f49082ba46"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "47353093-e64c-49d1-966a-a901694e7d24", "AQAAAAEAACcQAAAAEN6CV5HQuzJlMkOQZ0YMfp54JVy8tbk2r08bEtQusu4s+RrcOJZGOY53EajlmP+huQ==" });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "Approval", "AssignDate", "CategoryId", "ContractorId", "CreatorId", "Description", "FinishDate", "IsDeleted", "Name", "ProgramId", "Reward", "State" },
                values: new object[,]
                {
                    { new Guid("04eb7728-e1ea-447a-bf56-af491a1cdca6"), 1, null, 2, null, new Guid("38885cfb-4b65-4503-9958-6389ac64eb1a"), "Users can't properly create a new post is now fixed", null, false, "Posts issue fix", new Guid("f47b6e5c-46b8-4961-a809-787515b7d37e"), 20m, 3 },
                    { new Guid("2a2b1400-27df-45a3-9ef1-b50658450f29"), 1, new DateTime(2024, 4, 9, 23, 53, 44, 759, DateTimeKind.Local).AddTicks(3849), 1, new Guid("f903f113-d659-4848-87c5-97f49082ba46"), new Guid("dac439da-96ea-4ca5-aa3b-f059bd94c92c"), "Added a new feature where users can chat with friends", null, false, "Added chat groups", new Guid("f47b6e5c-46b8-4961-a809-787515b7d37e"), 30m, 2 },
                    { new Guid("a094befb-efae-45e1-8c99-634974e54eae"), 1, new DateTime(2024, 4, 9, 23, 53, 44, 759, DateTimeKind.Local).AddTicks(3922), 3, new Guid("f903f113-d659-4848-87c5-97f49082ba46"), new Guid("38885cfb-4b65-4503-9958-6389ac64eb1a"), "Check if the update profile feature works properly", null, false, "Check profile update", new Guid("f47b6e5c-46b8-4961-a809-787515b7d37e"), 15m, 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("04eb7728-e1ea-447a-bf56-af491a1cdca6"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("2a2b1400-27df-45a3-9ef1-b50658450f29"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("a094befb-efae-45e1-8c99-634974e54eae"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1c69a1cd-0a41-4e4d-a00a-a08d18c2cea9"),
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "56fdbcdd-18f2-4dc7-b4b3-afa95fd32b9e", "default user" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b280f152-005b-49b2-a82a-7a1a142f898a"),
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "54a538d5-f112-41ff-96d7-796bc416bc19", "moderator" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("cd3cbaa6-1e80-45a4-a2ef-6de3fee4ed59"),
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "010078cd-98ac-42eb-8581-21bd9afa7acb", "owner" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("38885cfb-4b65-4503-9958-6389ac64eb1a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fd4cd467-43e4-4d58-ab88-730d3d730bc4", "AQAAAAEAACcQAAAAEFSMz1ntXJn+qIPLhLkD8itWKd9p40Y9KVz23dcwlwHHooyPS6E75GDgqz5PU2MEqQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("dac439da-96ea-4ca5-aa3b-f059bd94c92c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c2315ded-8e62-46be-b88b-f866bcb0a972", "AQAAAAEAACcQAAAAEAw76b+xKqMzgmSkViDW20JQPVO+r2HfSyokMiC+bitDMtz7Xyf3tvWAdotI65OVsw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f903f113-d659-4848-87c5-97f49082ba46"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c4307c76-c676-4751-bd1a-49e49a543817", "AQAAAAEAACcQAAAAEDr3v8BQc5V1si79jSb25euvujbz3e/UnAZwt9BeaGynBsAKkjjWO+lA9LA8wFeKvA==" });

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
    }
}
