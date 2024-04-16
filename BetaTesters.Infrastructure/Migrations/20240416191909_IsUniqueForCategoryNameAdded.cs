using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BetaTesters.Infrastructure.Migrations
{
    public partial class IsUniqueForCategoryNameAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateIndex(
                name: "IX_Categories_CategoryName",
                table: "Categories",
                column: "CategoryName",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Categories_CategoryName",
                table: "Categories");

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
    }
}
