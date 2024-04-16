using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BetaTesters.Infrastructure.Migrations
{
    public partial class FixedAdminClaim : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("24c3faf7-0316-4933-b23f-96d587e668e7"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("b4b04335-41d3-4f03-913f-d4ed30d3e0df"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("c4f33bc4-7678-481a-86da-cdb47329fbc9"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1c69a1cd-0a41-4e4d-a00a-a08d18c2cea9"),
                column: "ConcurrencyStamp",
                value: "ea0c287f-f776-4d89-a622-70c9d40c4550");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("521aa62a-965e-44e7-a258-784118befe1c"),
                column: "ConcurrencyStamp",
                value: "7e90867f-842a-4d60-8824-f97ccae049a2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b280f152-005b-49b2-a82a-7a1a142f898a"),
                column: "ConcurrencyStamp",
                value: "75967090-56ad-4d86-83e1-e79e48549286");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("cd3cbaa6-1e80-45a4-a2ef-6de3fee4ed59"),
                column: "ConcurrencyStamp",
                value: "2fef9abd-b0e4-4bd4-bbe2-ede656b2c423");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 1011,
                column: "ClaimValue",
                value: "Admin Adminov");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("38885cfb-4b65-4503-9958-6389ac64eb1a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ce264ed3-a574-436a-baef-c985ac6e3bfc", "AQAAAAEAACcQAAAAEGEI2uArmsRJ5fClD/mVsvvG73nkQ53cGrQgrdVkJrcCYwhK9norSOybKqgQOeWYvA==", "ba1d8e57-7c93-4856-ae4c-4d840aab09f3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7051fdf0-f598-412c-8d48-3a0c65f0ceac"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b79fbbc3-5287-442d-831e-3a9f8dfc3179", "AQAAAAEAACcQAAAAEGhwgMBtrk5i6Eff//zM9Mh0H6S/JOGvihOOcl8UbwndqxRwMPyQw8yZosJ+U+7Rmg==", "850e9d9f-9496-4d35-bce3-80f6b7cc00d5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("dac439da-96ea-4ca5-aa3b-f059bd94c92c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e14b95c9-035b-4a15-9a98-55328b2c30c0", "AQAAAAEAACcQAAAAEGHTAOieIfX5K9A+nF/XHLsHiB5zXqvVnhsg57mgT+BG6FTz1O3WajAS6oLvVeNQWQ==", "de74e492-bae0-47b8-a7fe-0087c32fec5b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f903f113-d659-4848-87c5-97f49082ba46"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5ed62f31-0997-4760-8fc6-2dc5a8bfd871", "AQAAAAEAACcQAAAAEBAVNlVsptsObBzztgCWIHvBXTf7Xrg7tww++qoNYgXo+4zS1cbmfEzmPr8rVLNv6A==", "a2840126-879c-45d2-a318-d00e84c1017f" });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "Approval", "AssignDate", "CategoryId", "ContractorId", "CreatorId", "Description", "FinishDate", "IsPaidFor", "Name", "ProgramId", "Reward", "State" },
                values: new object[,]
                {
                    { new Guid("3c4d061a-4943-485d-8f72-2931995c54f3"), 1, new DateTime(2024, 4, 16, 21, 13, 57, 685, DateTimeKind.Local).AddTicks(1353), 2, null, new Guid("38885cfb-4b65-4503-9958-6389ac64eb1a"), "Users can't properly create a new post is now fixed", null, false, "Posts issue fix", new Guid("f47b6e5c-46b8-4961-a809-787515b7d37e"), 20m, 3 },
                    { new Guid("42f51c26-cde8-4f57-bf5d-329a561a1e43"), 1, new DateTime(2024, 4, 16, 21, 13, 57, 685, DateTimeKind.Local).AddTicks(1391), 1, null, new Guid("dac439da-96ea-4ca5-aa3b-f059bd94c92c"), "Added a new feature where users can chat with friends", null, false, "Added chat groups", new Guid("f47b6e5c-46b8-4961-a809-787515b7d37e"), 30m, 3 },
                    { new Guid("f8892ba1-6145-4588-9370-5cdf57eb714c"), 1, new DateTime(2024, 4, 16, 21, 13, 57, 685, DateTimeKind.Local).AddTicks(1395), 3, null, new Guid("38885cfb-4b65-4503-9958-6389ac64eb1a"), "Check if the update profile feature works properly", null, false, "Check profile update", new Guid("f47b6e5c-46b8-4961-a809-787515b7d37e"), 15m, 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("3c4d061a-4943-485d-8f72-2931995c54f3"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("42f51c26-cde8-4f57-bf5d-329a561a1e43"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("f8892ba1-6145-4588-9370-5cdf57eb714c"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1c69a1cd-0a41-4e4d-a00a-a08d18c2cea9"),
                column: "ConcurrencyStamp",
                value: "96a8a98d-6a93-482b-a08a-feecee9b2b83");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("521aa62a-965e-44e7-a258-784118befe1c"),
                column: "ConcurrencyStamp",
                value: "67b4a0fa-11c8-4765-bb0f-f2e078136ffd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b280f152-005b-49b2-a82a-7a1a142f898a"),
                column: "ConcurrencyStamp",
                value: "c2c8d571-eb64-4995-afa3-2e210e750653");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("cd3cbaa6-1e80-45a4-a2ef-6de3fee4ed59"),
                column: "ConcurrencyStamp",
                value: "e2af2702-f078-425f-a84b-eb3f9ca31621");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 1011,
                column: "ClaimValue",
                value: "Owner Ownerov");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("38885cfb-4b65-4503-9958-6389ac64eb1a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2a66126a-e5a0-4315-a335-3187071c4a4d", "AQAAAAEAACcQAAAAEFdKmnaQl5pcCeS/J6g+IBYDik2d0vjDNx+C9kn56cHgadct5AR7oLwJWsYqrDzGng==", "d280c093-7e5d-4076-9466-0922a103a8ea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7051fdf0-f598-412c-8d48-3a0c65f0ceac"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "21712f13-0f97-4de8-a50c-832ff7968d0c", "AQAAAAEAACcQAAAAEP6CVqPgQVu+3YsmuNZcHUy5qXEW2SwEPMnB3TG4eX7JNhUwFMWZnGKZRJvJexO5UA==", "61027a66-3514-41bd-84b6-bcaeefc64ed5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("dac439da-96ea-4ca5-aa3b-f059bd94c92c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4e712c7b-0979-45f1-bcc6-fc7bb404c1a5", "AQAAAAEAACcQAAAAEOhJhFyE2Jl7bJsp36SjMrTV6A7OYXjHE1i9G52CT2mURDWjIkMrL94m3LFHwAvZ3Q==", "e0125494-5404-481f-9d7b-b69bc2a97ac6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f903f113-d659-4848-87c5-97f49082ba46"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "746b2611-3860-46be-8a17-61f018e0a83e", "AQAAAAEAACcQAAAAEP326henxwuQ4K3uOER9sRcIbTDdYX5AaqtDKOGpV7h2MfS3gab+3mHki5U0444h9g==", "f9aa01a2-f244-46a8-a442-ed161cd2696a" });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "Approval", "AssignDate", "CategoryId", "ContractorId", "CreatorId", "Description", "FinishDate", "IsPaidFor", "Name", "ProgramId", "Reward", "State" },
                values: new object[,]
                {
                    { new Guid("24c3faf7-0316-4933-b23f-96d587e668e7"), 1, new DateTime(2024, 4, 16, 19, 35, 48, 599, DateTimeKind.Local).AddTicks(1279), 2, null, new Guid("38885cfb-4b65-4503-9958-6389ac64eb1a"), "Users can't properly create a new post is now fixed", null, false, "Posts issue fix", new Guid("f47b6e5c-46b8-4961-a809-787515b7d37e"), 20m, 3 },
                    { new Guid("b4b04335-41d3-4f03-913f-d4ed30d3e0df"), 1, new DateTime(2024, 4, 16, 19, 35, 48, 599, DateTimeKind.Local).AddTicks(1323), 1, null, new Guid("dac439da-96ea-4ca5-aa3b-f059bd94c92c"), "Added a new feature where users can chat with friends", null, false, "Added chat groups", new Guid("f47b6e5c-46b8-4961-a809-787515b7d37e"), 30m, 3 },
                    { new Guid("c4f33bc4-7678-481a-86da-cdb47329fbc9"), 1, new DateTime(2024, 4, 16, 19, 35, 48, 599, DateTimeKind.Local).AddTicks(1326), 3, null, new Guid("38885cfb-4b65-4503-9958-6389ac64eb1a"), "Check if the update profile feature works properly", null, false, "Check profile update", new Guid("f47b6e5c-46b8-4961-a809-787515b7d37e"), 15m, 3 }
                });
        }
    }
}
