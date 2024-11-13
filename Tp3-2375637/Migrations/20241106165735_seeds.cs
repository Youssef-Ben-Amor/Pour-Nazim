using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Tp3_2375637.Migrations
{
    /// <inheritdoc />
    public partial class seeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "40745596-da83-4e03-811f-4dc310ca83ee", 0, "8345950c-8607-4323-a7d8-6380b82590e3", "Bassemsniper@gmail.com", false, false, null, "BASSEMSNIPER@GMAIL.COM", "BASSEM", "AQAAAAIAAYagAAAAELQpzRbgC7tiaXthvpk0kX5HhiciiUVRkbbnbMG922LkANOUTLxpfy5H95R3s+DThQ==", null, false, "5c7010a3-f437-4d44-b87a-1649e23e915e", false, "Bassem" },
                    { "dba8dd7c-5003-45c8-b22c-7b7d7c0a0b9e", 0, "3431d456-a541-41aa-ac46-dc60f1611912", "Nizarsniper@gmail.com", false, false, null, "NIZARSNIPER@GMAIL.COM", "NIZAR", "AQAAAAIAAYagAAAAEGdAeB2fVPNQUghwsUnJrxQ+c1J714XpJjvKAn66cFIXGkszfh8q5Jf4/AqC7tSmeg==", null, false, "8c2c973a-e125-498d-ba99-4f4fca0fb4ef", false, "Nizar" }
                });

            migrationBuilder.InsertData(
                table: "Score",
                columns: new[] { "id", "Date", "IsPublic", "Pseudo", "ScoreValue", "TimeInSeconds", "UserId" },
                values: new object[,]
                {
                    { 1, "Mar 26, 2024", true, "Nizar", "12", "62", null },
                    { 2, "Mar 26, 2024", false, "Nizar", "6", "12", null },
                    { 3, "Mar 26, 2024", true, "Bassem", "6", "12", null },
                    { 4, "Mar 26, 2024", false, "Bassem", "9", "31", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "40745596-da83-4e03-811f-4dc310ca83ee");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dba8dd7c-5003-45c8-b22c-7b7d7c0a0b9e");

            migrationBuilder.DeleteData(
                table: "Score",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Score",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Score",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Score",
                keyColumn: "id",
                keyValue: 4);
        }
    }
}
