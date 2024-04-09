using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BetaTesters.Infrastructure.Migrations
{
    public partial class SeedClaims : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("d0807114-2c45-454e-b6f4-a733cec4ec19"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("d31fd8b2-beb4-4f93-a861-1655df58cfbb"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("d611141f-9b37-48e7-84e2-1b8a26a15195"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1c69a1cd-0a41-4e4d-a00a-a08d18c2cea9"),
                column: "ConcurrencyStamp",
                value: "c7ec694f-4332-4d79-8761-703c6907043f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b280f152-005b-49b2-a82a-7a1a142f898a"),
                column: "ConcurrencyStamp",
                value: "e63c1fe8-36c2-491b-bd86-d2a2ef02615d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("cd3cbaa6-1e80-45a4-a2ef-6de3fee4ed59"),
                column: "ConcurrencyStamp",
                value: "d2aec9f5-2c3a-4916-b863-028bbc2f8943");

            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[,]
                {
                    { 2, "user:fullname", "User Userov", new Guid("f903f113-d659-4848-87c5-97f49082ba46") },
                    { 3, "user:fullname", "Moderator Modov", new Guid("38885cfb-4b65-4503-9958-6389ac64eb1a") },
                    { 4, "user:fullname", "Owner Ownerov", new Guid("dac439da-96ea-4ca5-aa3b-f059bd94c92c") }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("38885cfb-4b65-4503-9958-6389ac64eb1a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8f9bec3e-4fb9-4da3-b2f1-028e3a08073d", "AQAAAAEAACcQAAAAEHxNWybGh64dPSD/otNcBrD7FK06v2F7o87fPXWYunpazUjdcITXV/+CChel0cNGpA==", "469de715-ddaa-43d9-80d1-d962f80329f0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("dac439da-96ea-4ca5-aa3b-f059bd94c92c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6d1ae0a9-df48-4bf2-acd4-5ad1b5a6a3fd", "AQAAAAEAACcQAAAAENXJorB+q6e6IYEShlaYvilf+DHeQIWppS5IEonI6RXWzhO1GPvUhAwuc0Rg3Kxd0w==", "0b4a2455-cb74-4f16-be2d-013c78a81933" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f903f113-d659-4848-87c5-97f49082ba46"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b5cf8be2-dfec-4abf-aafb-5edce1005104", "AQAAAAEAACcQAAAAEMO0CNIbuJ2aoimU3HmheFk7AmpeX/iuGlcAzyBwIqlXr07XPsMyVijGKNV0DW9ibg==", "112bdeb8-0da4-4c0b-b68b-478c28dda654" });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "Approval", "AssignDate", "CategoryId", "ContractorId", "CreatorId", "Description", "FinishDate", "IsDeleted", "Name", "ProgramId", "Reward", "State" },
                values: new object[,]
                {
                    { new Guid("4449b6db-47a4-4605-a13c-e17bc6f0c046"), 1, null, 2, null, new Guid("38885cfb-4b65-4503-9958-6389ac64eb1a"), "Users can't properly create a new post is now fixed", null, false, "Posts issue fix", new Guid("f47b6e5c-46b8-4961-a809-787515b7d37e"), 20m, 3 },
                    { new Guid("83a4bc34-bd7b-4913-98f6-58a7fca04bde"), 1, new DateTime(2024, 4, 10, 1, 44, 0, 220, DateTimeKind.Local).AddTicks(434), 1, new Guid("f903f113-d659-4848-87c5-97f49082ba46"), new Guid("dac439da-96ea-4ca5-aa3b-f059bd94c92c"), "Added a new feature where users can chat with friends", null, false, "Added chat groups", new Guid("f47b6e5c-46b8-4961-a809-787515b7d37e"), 30m, 2 },
                    { new Guid("ee0fcf1b-eb06-4394-a060-ef7841097d34"), 1, new DateTime(2024, 4, 10, 1, 44, 0, 220, DateTimeKind.Local).AddTicks(501), 3, new Guid("f903f113-d659-4848-87c5-97f49082ba46"), new Guid("38885cfb-4b65-4503-9958-6389ac64eb1a"), "Check if the update profile feature works properly", null, false, "Check profile update", new Guid("f47b6e5c-46b8-4961-a809-787515b7d37e"), 15m, 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("4449b6db-47a4-4605-a13c-e17bc6f0c046"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("83a4bc34-bd7b-4913-98f6-58a7fca04bde"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("ee0fcf1b-eb06-4394-a060-ef7841097d34"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1c69a1cd-0a41-4e4d-a00a-a08d18c2cea9"),
                column: "ConcurrencyStamp",
                value: "6c27bd6f-ef06-4490-a4d0-048194ba1e0e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b280f152-005b-49b2-a82a-7a1a142f898a"),
                column: "ConcurrencyStamp",
                value: "22370da1-58f6-4d16-8e0c-6efae66d3036");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("cd3cbaa6-1e80-45a4-a2ef-6de3fee4ed59"),
                column: "ConcurrencyStamp",
                value: "eac5d73f-b7d7-41dd-8c32-8226ff000f99");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("38885cfb-4b65-4503-9958-6389ac64eb1a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "84d915f3-7c14-4997-b28b-8aeacc76b20a", "AQAAAAEAACcQAAAAEPtJ/xNgrFs0p5VgHJuHPEEt6Rl8WoS/K1EBKa9y+1FyZdZnb8+jbLIYFRnLQp1ndQ==", "00f84320-ef1f-45ff-a735-a08b501192d0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("dac439da-96ea-4ca5-aa3b-f059bd94c92c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c54f6996-e6da-47f7-b70b-c0dfbf379fd7", "AQAAAAEAACcQAAAAEHUFyiUJ+OyCmKhS3tF5vmT3XhMtI1Pq+NtFVXHsXIhuJULhQa/6041uMian8Oqffg==", "bd182ca6-24d2-447e-ad34-6f0262187d33" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f903f113-d659-4848-87c5-97f49082ba46"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b24d7a1-b746-42ad-b57d-abc292f312b0", "AQAAAAEAACcQAAAAEPzYpPDQf8qiKVSQrEr+Wi3QX60dTMW3dFXBFqIYkgzXf1zokm1pRdEF2TSiHBf47g==", "2159bebc-3de2-42c6-bb77-97701d06d6f9" });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "Approval", "AssignDate", "CategoryId", "ContractorId", "CreatorId", "Description", "FinishDate", "IsDeleted", "Name", "ProgramId", "Reward", "State" },
                values: new object[,]
                {
                    { new Guid("d0807114-2c45-454e-b6f4-a733cec4ec19"), 1, new DateTime(2024, 4, 10, 1, 17, 42, 838, DateTimeKind.Local).AddTicks(2002), 3, new Guid("f903f113-d659-4848-87c5-97f49082ba46"), new Guid("38885cfb-4b65-4503-9958-6389ac64eb1a"), "Check if the update profile feature works properly", null, false, "Check profile update", new Guid("f47b6e5c-46b8-4961-a809-787515b7d37e"), 15m, 2 },
                    { new Guid("d31fd8b2-beb4-4f93-a861-1655df58cfbb"), 1, new DateTime(2024, 4, 10, 1, 17, 42, 838, DateTimeKind.Local).AddTicks(1901), 1, new Guid("f903f113-d659-4848-87c5-97f49082ba46"), new Guid("dac439da-96ea-4ca5-aa3b-f059bd94c92c"), "Added a new feature where users can chat with friends", null, false, "Added chat groups", new Guid("f47b6e5c-46b8-4961-a809-787515b7d37e"), 30m, 2 },
                    { new Guid("d611141f-9b37-48e7-84e2-1b8a26a15195"), 1, null, 2, null, new Guid("38885cfb-4b65-4503-9958-6389ac64eb1a"), "Users can't properly create a new post is now fixed", null, false, "Posts issue fix", new Guid("f47b6e5c-46b8-4961-a809-787515b7d37e"), 20m, 3 }
                });
        }
    }
}
