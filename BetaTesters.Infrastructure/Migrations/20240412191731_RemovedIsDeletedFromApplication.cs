using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BetaTesters.Infrastructure.Migrations
{
    public partial class RemovedIsDeletedFromApplication : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("08747fa7-57b0-439b-99a4-d4c17e94e867"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("809aa0a8-4cc9-4496-88e2-21dbdeae4659"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("87651f1e-7674-4a0c-9358-682d03aec694"));

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "CandidateApplications");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1c69a1cd-0a41-4e4d-a00a-a08d18c2cea9"),
                column: "ConcurrencyStamp",
                value: "642fc64b-4733-479c-96f9-d2c3eedde7e3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b280f152-005b-49b2-a82a-7a1a142f898a"),
                column: "ConcurrencyStamp",
                value: "c2dd4834-d04a-4014-8eb9-3944c645fe3c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("cd3cbaa6-1e80-45a4-a2ef-6de3fee4ed59"),
                column: "ConcurrencyStamp",
                value: "b7b963bd-1426-4d36-be97-9fbe4eb50152");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("38885cfb-4b65-4503-9958-6389ac64eb1a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8e8aa891-ba5f-48ce-b52d-7ce340f9c62b", "AQAAAAEAACcQAAAAELNQD1fDfkMueDDyyGDlhkcBedMxr1bQ86FCjSBfmKu3MrO+QZgWw2QIBpy04BBQ3w==", "5bbd4dad-01d4-41a4-a970-d620a3916df1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("dac439da-96ea-4ca5-aa3b-f059bd94c92c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "45ac48dd-2095-44e6-826d-52bd0c83c989", "AQAAAAEAACcQAAAAEDFg7tybIv7vcbCebqJbtLVewB1vREynzi2wqNzL6RP/r0gPfVOEdlNfwZay/+l5rA==", "a9bdcabf-5444-4aaa-aa04-d95f44c96884" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f903f113-d659-4848-87c5-97f49082ba46"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5be7acc8-e960-4ee5-9f8c-0188f03e365e", "AQAAAAEAACcQAAAAEEIqzQ2Kxp7XvUXM8EQ3KVYUfO1a0cjflTUg6MJcuSC0zeCSQcyc7zbKAeuz1DKRag==", "0a4497f4-6e35-4afa-a228-7f627661ba0f" });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "Approval", "AssignDate", "CategoryId", "ContractorId", "CreatorId", "Description", "FinishDate", "IsDeleted", "Name", "ProgramId", "Reward", "State" },
                values: new object[,]
                {
                    { new Guid("772a5840-f376-4525-9de1-b213a22a0e16"), 1, null, 2, null, new Guid("38885cfb-4b65-4503-9958-6389ac64eb1a"), "Users can't properly create a new post is now fixed", null, false, "Posts issue fix", new Guid("f47b6e5c-46b8-4961-a809-787515b7d37e"), 20m, 3 },
                    { new Guid("8c5236e0-a889-4201-90b2-4afc763a836d"), 1, null, 1, null, new Guid("dac439da-96ea-4ca5-aa3b-f059bd94c92c"), "Added a new feature where users can chat with friends", null, false, "Added chat groups", new Guid("f47b6e5c-46b8-4961-a809-787515b7d37e"), 30m, 3 },
                    { new Guid("d9e44f7a-9f82-4c65-84aa-80808e962b21"), 1, null, 3, null, new Guid("38885cfb-4b65-4503-9958-6389ac64eb1a"), "Check if the update profile feature works properly", null, false, "Check profile update", new Guid("f47b6e5c-46b8-4961-a809-787515b7d37e"), 15m, 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("772a5840-f376-4525-9de1-b213a22a0e16"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("8c5236e0-a889-4201-90b2-4afc763a836d"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("d9e44f7a-9f82-4c65-84aa-80808e962b21"));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "CandidateApplications",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1c69a1cd-0a41-4e4d-a00a-a08d18c2cea9"),
                column: "ConcurrencyStamp",
                value: "606a66f1-8587-4f5a-b8a5-7af77e9d76dd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b280f152-005b-49b2-a82a-7a1a142f898a"),
                column: "ConcurrencyStamp",
                value: "88256f67-c620-400e-9e3c-9646c8f8e5d7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("cd3cbaa6-1e80-45a4-a2ef-6de3fee4ed59"),
                column: "ConcurrencyStamp",
                value: "8446bb88-242f-402b-8f61-b55a77589255");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("38885cfb-4b65-4503-9958-6389ac64eb1a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "82fbead4-e507-4f81-84dd-52ff9c068fe3", "AQAAAAEAACcQAAAAEDoJmv4iAeSyekLZilcDOxpmX2zduvToLt1prJ3pf1kO3mnBQ8egCl1E4iya2M0vrQ==", "9f733548-de69-4361-a41c-1072fa2c8fbd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("dac439da-96ea-4ca5-aa3b-f059bd94c92c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d0731660-9026-4413-a652-63f01271aa39", "AQAAAAEAACcQAAAAEJmo9suTn3VZe2hAmuRb4gNARPOe2XlwoG/5zehWGtlvAKJl021nTutiYWiNeWkcLQ==", "643dae24-9ba9-4804-b7f4-c6f30526dce7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f903f113-d659-4848-87c5-97f49082ba46"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4ad57924-c709-4824-9d12-8ed04607abae", "AQAAAAEAACcQAAAAEDzlKaq0RA9rvQbCex7GtJY51YE2VhMMC95iMdqGD+oe1qIzWMiK+Y7tHvc6cjV7kQ==", "8ade1e25-ffb5-4253-b1e0-1dc75c493dc8" });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "Approval", "AssignDate", "CategoryId", "ContractorId", "CreatorId", "Description", "FinishDate", "IsDeleted", "Name", "ProgramId", "Reward", "State" },
                values: new object[,]
                {
                    { new Guid("08747fa7-57b0-439b-99a4-d4c17e94e867"), 1, null, 3, null, new Guid("38885cfb-4b65-4503-9958-6389ac64eb1a"), "Check if the update profile feature works properly", null, false, "Check profile update", new Guid("f47b6e5c-46b8-4961-a809-787515b7d37e"), 15m, 3 },
                    { new Guid("809aa0a8-4cc9-4496-88e2-21dbdeae4659"), 1, null, 2, null, new Guid("38885cfb-4b65-4503-9958-6389ac64eb1a"), "Users can't properly create a new post is now fixed", null, false, "Posts issue fix", new Guid("f47b6e5c-46b8-4961-a809-787515b7d37e"), 20m, 3 },
                    { new Guid("87651f1e-7674-4a0c-9358-682d03aec694"), 1, null, 1, null, new Guid("dac439da-96ea-4ca5-aa3b-f059bd94c92c"), "Added a new feature where users can chat with friends", null, false, "Added chat groups", new Guid("f47b6e5c-46b8-4961-a809-787515b7d37e"), 30m, 3 }
                });
        }
    }
}
