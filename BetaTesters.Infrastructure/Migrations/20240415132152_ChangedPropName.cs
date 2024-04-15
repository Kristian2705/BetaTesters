using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BetaTesters.Infrastructure.Migrations
{
    public partial class ChangedPropName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "Tasks",
                newName: "IsPaidFor");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "31828cde-5eba-4093-be16-00bc70ae1bb5", "AQAAAAEAACcQAAAAEF9mZY4vx4qXaEOpEp8mthY8+9Zu84gzibKsgrrRf/vIGTxMG4LEw0RiGKL2Y3/Swg==", "d96c8a55-fd52-41ee-8d9e-f4465e816063" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("dac439da-96ea-4ca5-aa3b-f059bd94c92c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2a28f591-8fc4-422c-8996-0d41423b42c4", "AQAAAAEAACcQAAAAEKDG5cJ1ffSmUKvIDpYwKU3EhDMCjMZUN6zdf/ecfVO3GOpK1aE6YsuGsyjtaLBiXQ==", "594a05aa-e782-4178-a99e-5c98d86571d8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f903f113-d659-4848-87c5-97f49082ba46"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1672ea0d-1668-4d92-b324-24ca7bcd72d7", "AQAAAAEAACcQAAAAEGxgngsG7+k+V4/pd4rhpBc6TTmDurjb9mA9mM/PTqn19icrf32XYgOTlfBhi6G0Sg==", "1ea931e7-13a4-4d83-9b45-0599ead4d9b7" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "IsPaidFor",
                table: "Tasks",
                newName: "IsDeleted");

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
    }
}
