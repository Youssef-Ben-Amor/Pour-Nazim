using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tp3_2375637.Migrations
{
    /// <inheritdoc />
    public partial class aa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                column: "ScoreValue",
                value: "3");

            migrationBuilder.UpdateData(
                table: "Score",
                keyColumn: "id",
                keyValue: 2,
                column: "ScoreValue",
                value: "3");

            migrationBuilder.UpdateData(
                table: "Score",
                keyColumn: "id",
                keyValue: 3,
                column: "ScoreValue",
                value: "3");

            migrationBuilder.UpdateData(
                table: "Score",
                keyColumn: "id",
                keyValue: 4,
                column: "ScoreValue",
                value: "3");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "40745596-da83-4e03-811f-4dc310ca83ee",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8345950c-8607-4323-a7d8-6380b82590e3", "AQAAAAIAAYagAAAAELQpzRbgC7tiaXthvpk0kX5HhiciiUVRkbbnbMG922LkANOUTLxpfy5H95R3s+DThQ==", "5c7010a3-f437-4d44-b87a-1649e23e915e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dba8dd7c-5003-45c8-b22c-7b7d7c0a0b9e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3431d456-a541-41aa-ac46-dc60f1611912", "AQAAAAIAAYagAAAAEGdAeB2fVPNQUghwsUnJrxQ+c1J714XpJjvKAn66cFIXGkszfh8q5Jf4/AqC7tSmeg==", "8c2c973a-e125-498d-ba99-4f4fca0fb4ef" });

            migrationBuilder.UpdateData(
                table: "Score",
                keyColumn: "id",
                keyValue: 1,
                column: "ScoreValue",
                value: "12");

            migrationBuilder.UpdateData(
                table: "Score",
                keyColumn: "id",
                keyValue: 2,
                column: "ScoreValue",
                value: "6");

            migrationBuilder.UpdateData(
                table: "Score",
                keyColumn: "id",
                keyValue: 3,
                column: "ScoreValue",
                value: "6");

            migrationBuilder.UpdateData(
                table: "Score",
                keyColumn: "id",
                keyValue: 4,
                column: "ScoreValue",
                value: "9");
        }
    }
}
