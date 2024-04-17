using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BetaTesters.Infrastructure.Migrations
{
    public partial class AddedSessionIdForTransaction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("0df6eea5-bc28-499e-9882-70058fcba1bb"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("99af6dc4-7983-43b8-b802-2c3b1a0a1801"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("e05f4064-cd72-4ed9-82c0-8a147ec9f655"));

            migrationBuilder.AddColumn<string>(
                name: "SessionId",
                table: "Transactions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1c69a1cd-0a41-4e4d-a00a-a08d18c2cea9"),
                column: "ConcurrencyStamp",
                value: "7f6350c4-39e4-417f-aeed-335941720f98");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("521aa62a-965e-44e7-a258-784118befe1c"),
                column: "ConcurrencyStamp",
                value: "c0e683e7-2d9c-4f81-9cb3-d51f5e06c0c0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b280f152-005b-49b2-a82a-7a1a142f898a"),
                column: "ConcurrencyStamp",
                value: "68de5456-0e68-42f6-b829-2b7896ed281c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("cd3cbaa6-1e80-45a4-a2ef-6de3fee4ed59"),
                column: "ConcurrencyStamp",
                value: "699beb6c-75f1-44dc-9b26-ae3ea1d18676");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("38885cfb-4b65-4503-9958-6389ac64eb1a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7a97ee74-b0dd-4573-80f4-e9f6908a6e55", "AQAAAAEAACcQAAAAEEJnEmgu+Yh8unvZBE1IsjAz8dCyUNY2YphMjjVGi3EQaQ9nDv/gcDO/tjlqupSbPA==", "74516227-c400-4bb8-bd05-73b8db6acabd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7051fdf0-f598-412c-8d48-3a0c65f0ceac"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5cc06d7c-b49d-46ef-99e5-0616e1a420bf", "AQAAAAEAACcQAAAAEE+H8mvIjMz/YskGkB689JjIhb82RQNrsOAc6R1kcHmHMM2SyPzWkIHaKOXhFi24pQ==", "9ec5555c-7679-418e-becd-4b733872803c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("dac439da-96ea-4ca5-aa3b-f059bd94c92c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7ad9c7cf-14bb-44b7-b9b3-db25ee014268", "AQAAAAEAACcQAAAAEOto630YRUjh2h2NuSdoYj3dsPLKS0ZIr30wxXa9rY09X+Vy8p7k0DhCze2XtMrDgg==", "2e928e95-5a3a-4678-b9ff-cc28c1964976" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f903f113-d659-4848-87c5-97f49082ba46"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1edce717-b961-43b3-8046-138049f83674", "AQAAAAEAACcQAAAAEKTd/GINIPnN1vTWolPMmxzEtx416+lJQzhTsBp2wsG+NJ4ajRHIyVpbBhfa46OKQw==", "c4b131de-f1d9-4ceb-9115-ca1296a2811f" });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "Approval", "AssignDate", "CategoryId", "ContractorId", "CreatorId", "Description", "FinishDate", "IsPaidFor", "Name", "ProgramId", "Reward", "State" },
                values: new object[,]
                {
                    { new Guid("1e66a3f8-045d-406e-89aa-8a059e77d225"), 1, new DateTime(2024, 4, 17, 12, 46, 1, 566, DateTimeKind.Local).AddTicks(4950), 2, null, new Guid("38885cfb-4b65-4503-9958-6389ac64eb1a"), "Users can't properly create a new post is now fixed", null, false, "Posts issue fix", new Guid("f47b6e5c-46b8-4961-a809-787515b7d37e"), 20m, 3 },
                    { new Guid("c5d09533-12c8-45f2-a10b-300b005b83cc"), 1, new DateTime(2024, 4, 17, 12, 46, 1, 566, DateTimeKind.Local).AddTicks(5017), 3, null, new Guid("38885cfb-4b65-4503-9958-6389ac64eb1a"), "Check if the update profile feature works properly", null, false, "Check profile update", new Guid("f47b6e5c-46b8-4961-a809-787515b7d37e"), 15m, 3 },
                    { new Guid("de0665e9-ee22-4be4-8f6c-1e2e9c822bd3"), 1, new DateTime(2024, 4, 17, 12, 46, 1, 566, DateTimeKind.Local).AddTicks(5013), 1, null, new Guid("dac439da-96ea-4ca5-aa3b-f059bd94c92c"), "Added a new feature where users can chat with friends", null, false, "Added chat groups", new Guid("f47b6e5c-46b8-4961-a809-787515b7d37e"), 30m, 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("1e66a3f8-045d-406e-89aa-8a059e77d225"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("c5d09533-12c8-45f2-a10b-300b005b83cc"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("de0665e9-ee22-4be4-8f6c-1e2e9c822bd3"));

            migrationBuilder.DropColumn(
                name: "SessionId",
                table: "Transactions");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1c69a1cd-0a41-4e4d-a00a-a08d18c2cea9"),
                column: "ConcurrencyStamp",
                value: "6a454538-aa95-433b-8a2c-002412205744");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("521aa62a-965e-44e7-a258-784118befe1c"),
                column: "ConcurrencyStamp",
                value: "f24e4f1c-6150-44b1-8051-da99c8d48ab9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b280f152-005b-49b2-a82a-7a1a142f898a"),
                column: "ConcurrencyStamp",
                value: "99e707cf-7c81-43c7-8ccd-02b1c1311c18");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("cd3cbaa6-1e80-45a4-a2ef-6de3fee4ed59"),
                column: "ConcurrencyStamp",
                value: "bf004a91-b079-4bea-b9e3-e75c2a0027fb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("38885cfb-4b65-4503-9958-6389ac64eb1a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a8e559d3-35cc-4a9a-b47f-11f38e586799", "AQAAAAEAACcQAAAAEE4yPDVARqlFGPOLplTx+QhKjrZPsCSeFgsw7Q/yzmB4ILE1m+SYUG/uXuVvVe8gDw==", "12b0ca84-c0e6-422e-b997-82887e4bb10f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7051fdf0-f598-412c-8d48-3a0c65f0ceac"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "55ee2bd4-ff69-4ffc-b7b6-5d7686599e46", "AQAAAAEAACcQAAAAEBHMaUi19XqQbxOv1Sy/Y0RgkH5wIV6wyWK24TO7xRQXg/tySiv5SPbLHSMsuOu+zg==", "bdf8018b-70fe-454b-9788-a2c296b5a632" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("dac439da-96ea-4ca5-aa3b-f059bd94c92c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "53f40176-d940-4d37-a40e-0939c52f05c0", "AQAAAAEAACcQAAAAEHaerl4YKth068FT8nPSn5kb0oxCpo8uxnwLMWLOxtddtLrl5SynYIPkVsEio+VBrg==", "72377f23-f6de-4bf1-bd1b-68950a9e96e0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f903f113-d659-4848-87c5-97f49082ba46"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bbe47911-7b46-42d7-9798-a467b12b935c", "AQAAAAEAACcQAAAAEC9mpenXZRfheIl05iQVyIS91DNnh/R4BcEQpf4/6gVHtX9PCAtikmo6MZk0Af2Rhg==", "14ae61bc-343b-486c-8bd5-5558ca8842a9" });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "Approval", "AssignDate", "CategoryId", "ContractorId", "CreatorId", "Description", "FinishDate", "IsPaidFor", "Name", "ProgramId", "Reward", "State" },
                values: new object[,]
                {
                    { new Guid("0df6eea5-bc28-499e-9882-70058fcba1bb"), 1, new DateTime(2024, 4, 16, 22, 19, 8, 791, DateTimeKind.Local).AddTicks(6216), 2, null, new Guid("38885cfb-4b65-4503-9958-6389ac64eb1a"), "Users can't properly create a new post is now fixed", null, false, "Posts issue fix", new Guid("f47b6e5c-46b8-4961-a809-787515b7d37e"), 20m, 3 },
                    { new Guid("99af6dc4-7983-43b8-b802-2c3b1a0a1801"), 1, new DateTime(2024, 4, 16, 22, 19, 8, 791, DateTimeKind.Local).AddTicks(6264), 3, null, new Guid("38885cfb-4b65-4503-9958-6389ac64eb1a"), "Check if the update profile feature works properly", null, false, "Check profile update", new Guid("f47b6e5c-46b8-4961-a809-787515b7d37e"), 15m, 3 },
                    { new Guid("e05f4064-cd72-4ed9-82c0-8a147ec9f655"), 1, new DateTime(2024, 4, 16, 22, 19, 8, 791, DateTimeKind.Local).AddTicks(6261), 1, null, new Guid("dac439da-96ea-4ca5-aa3b-f059bd94c92c"), "Added a new feature where users can chat with friends", null, false, "Added chat groups", new Guid("f47b6e5c-46b8-4961-a809-787515b7d37e"), 30m, 3 }
                });
        }
    }
}
