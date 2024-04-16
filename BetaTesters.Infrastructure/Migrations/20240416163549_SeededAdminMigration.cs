using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BetaTesters.Infrastructure.Migrations
{
    public partial class SeededAdminMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("3d6fb974-357c-4440-80b3-5ef491651ab6"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("aef3d299-9fe6-483b-8a6a-11e80e2f2297"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("ba481249-2aa7-4463-bb58-c4b65a8627cc"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1c69a1cd-0a41-4e4d-a00a-a08d18c2cea9"),
                column: "ConcurrencyStamp",
                value: "96a8a98d-6a93-482b-a08a-feecee9b2b83");

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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("521aa62a-965e-44e7-a258-784118befe1c"), "67b4a0fa-11c8-4765-bb0f-f2e078136ffd", "administrator", "ADMINISTRATOR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("38885cfb-4b65-4503-9958-6389ac64eb1a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "2a66126a-e5a0-4315-a335-3187071c4a4d", "AQAAAAEAACcQAAAAEFdKmnaQl5pcCeS/J6g+IBYDik2d0vjDNx+C9kn56cHgadct5AR7oLwJWsYqrDzGng==", null, "d280c093-7e5d-4076-9466-0922a103a8ea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("dac439da-96ea-4ca5-aa3b-f059bd94c92c"),
                columns: new[] { "Balance", "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { 500.00m, "4e712c7b-0979-45f1-bcc6-fc7bb404c1a5", "AQAAAAEAACcQAAAAEOhJhFyE2Jl7bJsp36SjMrTV6A7OYXjHE1i9G52CT2mURDWjIkMrL94m3LFHwAvZ3Q==", null, "e0125494-5404-481f-9d7b-b69bc2a97ac6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f903f113-d659-4848-87c5-97f49082ba46"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "746b2611-3860-46be-8a17-61f018e0a83e", "AQAAAAEAACcQAAAAEP326henxwuQ4K3uOER9sRcIbTDdYX5AaqtDKOGpV7h2MfS3gab+3mHki5U0444h9g==", null, "f9aa01a2-f244-46a8-a442-ed161cd2696a" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Age", "Balance", "BetaProgramId", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("7051fdf0-f598-412c-8d48-3a0c65f0ceac"), 0, 25, 0m, null, "21712f13-0f97-4de8-a50c-832ff7968d0c", "adminoff@mail.com", false, "Admin", "Adminov", false, null, "ADMINOFF@MAIL.COM", "ADMINOFF@MAIL.COM", "AQAAAAEAACcQAAAAEP6CVqPgQVu+3YsmuNZcHUy5qXEW2SwEPMnB3TG4eX7JNhUwFMWZnGKZRJvJexO5UA==", null, false, "61027a66-3514-41bd-84b6-bcaeefc64ed5", false, "adminoff@mail.com" });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "Approval", "AssignDate", "CategoryId", "ContractorId", "CreatorId", "Description", "FinishDate", "IsPaidFor", "Name", "ProgramId", "Reward", "State" },
                values: new object[,]
                {
                    { new Guid("24c3faf7-0316-4933-b23f-96d587e668e7"), 1, new DateTime(2024, 4, 16, 19, 35, 48, 599, DateTimeKind.Local).AddTicks(1279), 2, null, new Guid("38885cfb-4b65-4503-9958-6389ac64eb1a"), "Users can't properly create a new post is now fixed", null, false, "Posts issue fix", new Guid("f47b6e5c-46b8-4961-a809-787515b7d37e"), 20m, 3 },
                    { new Guid("b4b04335-41d3-4f03-913f-d4ed30d3e0df"), 1, new DateTime(2024, 4, 16, 19, 35, 48, 599, DateTimeKind.Local).AddTicks(1323), 1, null, new Guid("dac439da-96ea-4ca5-aa3b-f059bd94c92c"), "Added a new feature where users can chat with friends", null, false, "Added chat groups", new Guid("f47b6e5c-46b8-4961-a809-787515b7d37e"), 30m, 3 },
                    { new Guid("c4f33bc4-7678-481a-86da-cdb47329fbc9"), 1, new DateTime(2024, 4, 16, 19, 35, 48, 599, DateTimeKind.Local).AddTicks(1326), 3, null, new Guid("38885cfb-4b65-4503-9958-6389ac64eb1a"), "Check if the update profile feature works properly", null, false, "Check profile update", new Guid("f47b6e5c-46b8-4961-a809-787515b7d37e"), 15m, 3 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[] { 1011, "user:fullname", "Owner Ownerov", new Guid("7051fdf0-f598-412c-8d48-3a0c65f0ceac") });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("521aa62a-965e-44e7-a258-784118befe1c"), new Guid("7051fdf0-f598-412c-8d48-3a0c65f0ceac") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 1011);

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("521aa62a-965e-44e7-a258-784118befe1c"), new Guid("7051fdf0-f598-412c-8d48-3a0c65f0ceac") });

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

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("521aa62a-965e-44e7-a258-784118befe1c"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7051fdf0-f598-412c-8d48-3a0c65f0ceac"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1c69a1cd-0a41-4e4d-a00a-a08d18c2cea9"),
                column: "ConcurrencyStamp",
                value: "cb98f35a-020a-4afe-9de9-2183739d1fd4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b280f152-005b-49b2-a82a-7a1a142f898a"),
                column: "ConcurrencyStamp",
                value: "338b8bed-7928-43e7-9d50-a326557ac015");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("cd3cbaa6-1e80-45a4-a2ef-6de3fee4ed59"),
                column: "ConcurrencyStamp",
                value: "0fcb1800-ae77-4d82-bb10-5bc562f01c30");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("38885cfb-4b65-4503-9958-6389ac64eb1a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "31828cde-5eba-4093-be16-00bc70ae1bb5", "AQAAAAEAACcQAAAAEF9mZY4vx4qXaEOpEp8mthY8+9Zu84gzibKsgrrRf/vIGTxMG4LEw0RiGKL2Y3/Swg==", "0891234561", "d96c8a55-fd52-41ee-8d9e-f4465e816063" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("dac439da-96ea-4ca5-aa3b-f059bd94c92c"),
                columns: new[] { "Balance", "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { 0m, "2a28f591-8fc4-422c-8996-0d41423b42c4", "AQAAAAEAACcQAAAAEKDG5cJ1ffSmUKvIDpYwKU3EhDMCjMZUN6zdf/ecfVO3GOpK1aE6YsuGsyjtaLBiXQ==", "0891231456", "594a05aa-e782-4178-a99e-5c98d86571d8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f903f113-d659-4848-87c5-97f49082ba46"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "1672ea0d-1668-4d92-b324-24ca7bcd72d7", "AQAAAAEAACcQAAAAEGxgngsG7+k+V4/pd4rhpBc6TTmDurjb9mA9mM/PTqn19icrf32XYgOTlfBhi6G0Sg==", "0881234567", "1ea931e7-13a4-4d83-9b45-0599ead4d9b7" });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "Approval", "AssignDate", "CategoryId", "ContractorId", "CreatorId", "Description", "FinishDate", "IsPaidFor", "Name", "ProgramId", "Reward", "State" },
                values: new object[,]
                {
                    { new Guid("3d6fb974-357c-4440-80b3-5ef491651ab6"), 1, new DateTime(2024, 4, 15, 16, 21, 51, 825, DateTimeKind.Local).AddTicks(4669), 3, null, new Guid("38885cfb-4b65-4503-9958-6389ac64eb1a"), "Check if the update profile feature works properly", null, false, "Check profile update", new Guid("f47b6e5c-46b8-4961-a809-787515b7d37e"), 15m, 3 },
                    { new Guid("aef3d299-9fe6-483b-8a6a-11e80e2f2297"), 1, new DateTime(2024, 4, 15, 16, 21, 51, 825, DateTimeKind.Local).AddTicks(4666), 1, null, new Guid("dac439da-96ea-4ca5-aa3b-f059bd94c92c"), "Added a new feature where users can chat with friends", null, false, "Added chat groups", new Guid("f47b6e5c-46b8-4961-a809-787515b7d37e"), 30m, 3 },
                    { new Guid("ba481249-2aa7-4463-bb58-c4b65a8627cc"), 1, new DateTime(2024, 4, 15, 16, 21, 51, 825, DateTimeKind.Local).AddTicks(4658), 2, null, new Guid("38885cfb-4b65-4503-9958-6389ac64eb1a"), "Users can't properly create a new post is now fixed", null, false, "Posts issue fix", new Guid("f47b6e5c-46b8-4961-a809-787515b7d37e"), 20m, 3 }
                });
        }
    }
}
