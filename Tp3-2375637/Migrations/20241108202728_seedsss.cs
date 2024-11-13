using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tp3_2375637.Migrations
{
    /// <inheritdoc />
    public partial class seedsss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "40745596-da83-4e03-811f-4dc310ca83ee",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bbd7176f-42cb-445e-8dbd-e1c4f2fd4e85", "AQAAAAIAAYagAAAAELBwaBgxj3cAU7qMQXps3uxqvldO/qBeBTCK3hJRoPTGMQVwYElyGJ6DXuXUgxch0g==", "7a7bbcf0-fea6-46af-b682-b72aa2b77cec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dba8dd7c-5003-45c8-b22c-7b7d7c0a0b9e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "afc15ac9-5542-4894-81a7-c736d762f33d", "AQAAAAIAAYagAAAAEI3oruHa4cEm19mgVU1GJtsSq9HbtveC84PWv3AgOi4kPIfpBJHvyXT2BSGZUIA1kw==", "f37b1591-225f-446d-9f56-abba1ea82456" });

            migrationBuilder.UpdateData(
                table: "Score",
                keyColumn: "id",
                keyValue: 1,
                column: "UserId",
                value: "dba8dd7c-5003-45c8-b22c-7b7d7c0a0b9e");

            migrationBuilder.UpdateData(
                table: "Score",
                keyColumn: "id",
                keyValue: 2,
                column: "UserId",
                value: "dba8dd7c-5003-45c8-b22c-7b7d7c0a0b9e");

            migrationBuilder.UpdateData(
                table: "Score",
                keyColumn: "id",
                keyValue: 3,
                column: "UserId",
                value: "40745596-da83-4e03-811f-4dc310ca83ee");

            migrationBuilder.UpdateData(
                table: "Score",
                keyColumn: "id",
                keyValue: 4,
                column: "UserId",
                value: "40745596-da83-4e03-811f-4dc310ca83ee");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "40745596-da83-4e03-811f-4dc310ca83ee",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c944271d-b696-4f70-89da-c83993c1667e", "AQAAAAIAAYagAAAAECWxtsXj1XdW89SHrRmqhjllTDYnw2rEKDidkCj9CU3mBQ7PFkAPw2EsBL2pEtxEDg==", "a939ac99-c41c-41ee-92d7-dca57604fad0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dba8dd7c-5003-45c8-b22c-7b7d7c0a0b9e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "37f32b58-2d8f-4d4a-9e44-a29d1959df03", "AQAAAAIAAYagAAAAEBgeek1CwF8oORumsncC3SvMi7xSafHXLDF8L5GhMmzBISEmRP5JeIiZFfgN2igTFA==", "5d9a9ba8-eecc-4426-ac8d-d5cfeff5359a" });

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
        }
    }
}
