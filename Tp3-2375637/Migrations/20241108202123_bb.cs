using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tp3_2375637.Migrations
{
    /// <inheritdoc />
    public partial class bb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Score_AspNetUsers_UserId",
                table: "Score");

            migrationBuilder.DropIndex(
                name: "IX_Score_UserId",
                table: "Score");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Score",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "Score",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "40745596-da83-4e03-811f-4dc310ca83ee",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6df382fd-1ed7-44ec-b7bf-5df74a7ae30a", "AQAAAAIAAYagAAAAEOnpDmrpwP0UA29+lUHoHB2AoAGFZwJT6cZuBLDTKyO4KLoa5KM6ADK8zVMEnL7T5A==", "536ebce2-f180-436f-a89c-2937ce5921ce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dba8dd7c-5003-45c8-b22c-7b7d7c0a0b9e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7f29967b-c49c-449d-ba0f-d256d8f7e560", "AQAAAAIAAYagAAAAEKOM7g4qaz3S3J4zMlUqclUj5jF7gyvSJCUmzJwszoEe39rAQ5qMmrcKXIh/vPbsbw==", "1bb41d73-0e75-41da-90c8-42883cb50411" });

            migrationBuilder.UpdateData(
                table: "Score",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "UserId", "UserId1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Score",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "UserId", "UserId1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Score",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "UserId", "UserId1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Score",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "UserId", "UserId1" },
                values: new object[] { null, null });

            migrationBuilder.CreateIndex(
                name: "IX_Score_UserId1",
                table: "Score",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Score_AspNetUsers_UserId1",
                table: "Score",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Score_AspNetUsers_UserId1",
                table: "Score");

            migrationBuilder.DropIndex(
                name: "IX_Score_UserId1",
                table: "Score");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Score");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Score",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "40745596-da83-4e03-811f-4dc310ca83ee",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "586249eb-c4c3-4ad4-92aa-aef0e84a119c", "AQAAAAIAAYagAAAAEI2iCMLrjoybrF8DM47fMiMfp/WCYfKdfaSRQJQ79ATWkhVuf8JFRQAXRLeCBPyWjw==", "0c3fae80-bc7a-4ee6-b507-209a150d7fa5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dba8dd7c-5003-45c8-b22c-7b7d7c0a0b9e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2b250447-a3c0-41d8-8312-b36d4981a37b", "AQAAAAIAAYagAAAAEJVOGueZUw4tfMW7ZIAnHyw/vDt7TzrHoh+p2lY8AWZsg3/HcAhl1oLgfOqHaEh7VA==", "0f87f121-0311-4b70-a0f5-a845550d2cc5" });

            migrationBuilder.UpdateData(
                table: "Score",
                keyColumn: "id",
                keyValue: 1,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Score",
                keyColumn: "id",
                keyValue: 2,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Score",
                keyColumn: "id",
                keyValue: 3,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Score",
                keyColumn: "id",
                keyValue: 4,
                column: "UserId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Score_UserId",
                table: "Score",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Score_AspNetUsers_UserId",
                table: "Score",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
