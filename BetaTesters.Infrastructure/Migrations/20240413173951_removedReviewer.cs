using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BetaTesters.Infrastructure.Migrations
{
    public partial class removedReviewer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CandidateApplications_AspNetUsers_ReviewerId",
                table: "CandidateApplications");

            migrationBuilder.DropIndex(
                name: "IX_CandidateApplications_ReviewerId",
                table: "CandidateApplications");

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

            migrationBuilder.DropColumn(
                name: "ReviewerId",
                table: "CandidateApplications");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<Guid>(
                name: "ReviewerId",
                table: "CandidateApplications",
                type: "uniqueidentifier",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_CandidateApplications_ReviewerId",
                table: "CandidateApplications",
                column: "ReviewerId");

            migrationBuilder.AddForeignKey(
                name: "FK_CandidateApplications_AspNetUsers_ReviewerId",
                table: "CandidateApplications",
                column: "ReviewerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
