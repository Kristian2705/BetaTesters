using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BetaTesters.Infrastructure.Migrations
{
    public partial class AddedAssignDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("0e0de2ba-f7af-4c9f-9522-d6ca2eebb7fc"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("157dd33f-55ef-445f-b998-c343b7798076"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("8fdd31e7-96b6-4eb7-8389-4ca52face0a8"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1c69a1cd-0a41-4e4d-a00a-a08d18c2cea9"),
                column: "ConcurrencyStamp",
                value: "0602c350-a7d4-4aac-afae-fb2d2fd1021e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b280f152-005b-49b2-a82a-7a1a142f898a"),
                column: "ConcurrencyStamp",
                value: "225cc628-db39-427c-9028-dcf0d56d2337");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("cd3cbaa6-1e80-45a4-a2ef-6de3fee4ed59"),
                column: "ConcurrencyStamp",
                value: "8d690fc4-4c27-4f3a-91a2-5b29fe7d9f9f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("38885cfb-4b65-4503-9958-6389ac64eb1a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "29777a26-27ec-4f73-9ad2-19a2bb49b587", "AQAAAAEAACcQAAAAEFgADKwscJ+bcDoE58j2l0YBF3fqEXWXeA3fieqD41obTlnxpbSFKJ2CdTi7OzTvlA==", "1956aa0e-6479-407d-b1ff-810b782aeb7b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("dac439da-96ea-4ca5-aa3b-f059bd94c92c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "953e2db8-41e9-4829-9a74-3447a8387bd4", "AQAAAAEAACcQAAAAEO3HeKu02YuyKBz/SVBGSi2FLBj/m9Yo4y1cpwBzWq24KzcVX041wMxX2uCQN9vH+g==", "a7869425-6210-4b6a-a150-befcbeef4656" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f903f113-d659-4848-87c5-97f49082ba46"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bb1453f4-67ec-4105-9f2c-9fd2cd671206", "AQAAAAEAACcQAAAAEHUVWPJcBVb2isCJxflGwyE5OmTm2cEpHQBQVtLWIH1ilomH6aUIVOWCpex+0nrLkw==", "7702f65d-c90a-46cd-8598-f25413be73fd" });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "Approval", "AssignDate", "CategoryId", "ContractorId", "CreatorId", "Description", "FinishDate", "IsDeleted", "Name", "ProgramId", "Reward", "State" },
                values: new object[,]
                {
                    { new Guid("31375b35-7ed7-47be-91b5-a62bd01105b4"), 1, new DateTime(2024, 4, 14, 14, 8, 29, 708, DateTimeKind.Local).AddTicks(9358), 2, null, new Guid("38885cfb-4b65-4503-9958-6389ac64eb1a"), "Users can't properly create a new post is now fixed", null, false, "Posts issue fix", new Guid("f47b6e5c-46b8-4961-a809-787515b7d37e"), 20m, 3 },
                    { new Guid("4de2b252-3306-440f-aca2-57b79fa9f0a3"), 1, new DateTime(2024, 4, 14, 14, 8, 29, 708, DateTimeKind.Local).AddTicks(9441), 3, null, new Guid("38885cfb-4b65-4503-9958-6389ac64eb1a"), "Check if the update profile feature works properly", null, false, "Check profile update", new Guid("f47b6e5c-46b8-4961-a809-787515b7d37e"), 15m, 3 },
                    { new Guid("906ceb55-93e8-42b3-8593-af1e7427b048"), 1, new DateTime(2024, 4, 14, 14, 8, 29, 708, DateTimeKind.Local).AddTicks(9434), 1, null, new Guid("dac439da-96ea-4ca5-aa3b-f059bd94c92c"), "Added a new feature where users can chat with friends", null, false, "Added chat groups", new Guid("f47b6e5c-46b8-4961-a809-787515b7d37e"), 30m, 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("31375b35-7ed7-47be-91b5-a62bd01105b4"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("4de2b252-3306-440f-aca2-57b79fa9f0a3"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("906ceb55-93e8-42b3-8593-af1e7427b048"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1c69a1cd-0a41-4e4d-a00a-a08d18c2cea9"),
                column: "ConcurrencyStamp",
                value: "050a0a38-9031-4d46-84cf-41d110d2aae2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b280f152-005b-49b2-a82a-7a1a142f898a"),
                column: "ConcurrencyStamp",
                value: "7b821133-4ba7-40c4-941e-ccb00dccd2a5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("cd3cbaa6-1e80-45a4-a2ef-6de3fee4ed59"),
                column: "ConcurrencyStamp",
                value: "344c4c8a-db0f-47e8-8a31-169ebac2821d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("38885cfb-4b65-4503-9958-6389ac64eb1a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3e41155f-8e50-4e82-a803-791ef36884e9", "AQAAAAEAACcQAAAAEEjDJIrCdG0deitGc2u+yhOgCJ+Sos3hjEypoCMii2kYJ7dG99kKxRxk1Zr7cgHqMQ==", "d63334ce-9e22-48f6-8169-b9e1a1a4196c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("dac439da-96ea-4ca5-aa3b-f059bd94c92c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7fc2e727-5a32-4c74-b768-2470b37849fb", "AQAAAAEAACcQAAAAECU6DjGRhzE+z1du37P/kIEUWyIVNJ9UJ/ClNF6jb7mYBkHFOHJz01Dda8T8n6a23A==", "c74a872e-08c7-4e0e-a5ec-1d1c7b0e9f5d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f903f113-d659-4848-87c5-97f49082ba46"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3e2f7ddf-0cca-4bca-982f-9362effec98c", "AQAAAAEAACcQAAAAEIDvkSDx1Y4AhnzuyHZQIHbIo8c3NYac3OUsbB1qvxLacWENZIXHpA/m6CwRqBSScw==", "9f835258-dac0-4af5-985f-6165a38f497e" });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "Approval", "AssignDate", "CategoryId", "ContractorId", "CreatorId", "Description", "FinishDate", "IsDeleted", "Name", "ProgramId", "Reward", "State" },
                values: new object[,]
                {
                    { new Guid("0e0de2ba-f7af-4c9f-9522-d6ca2eebb7fc"), 1, null, 2, null, new Guid("38885cfb-4b65-4503-9958-6389ac64eb1a"), "Users can't properly create a new post is now fixed", null, false, "Posts issue fix", new Guid("f47b6e5c-46b8-4961-a809-787515b7d37e"), 20m, 3 },
                    { new Guid("157dd33f-55ef-445f-b998-c343b7798076"), 1, null, 1, null, new Guid("dac439da-96ea-4ca5-aa3b-f059bd94c92c"), "Added a new feature where users can chat with friends", null, false, "Added chat groups", new Guid("f47b6e5c-46b8-4961-a809-787515b7d37e"), 30m, 3 },
                    { new Guid("8fdd31e7-96b6-4eb7-8389-4ca52face0a8"), 1, null, 3, null, new Guid("38885cfb-4b65-4503-9958-6389ac64eb1a"), "Check if the update profile feature works properly", null, false, "Check profile update", new Guid("f47b6e5c-46b8-4961-a809-787515b7d37e"), 15m, 3 }
                });
        }
    }
}
