using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tp3_2375637.Migrations
{
    /// <inheritdoc />
    public partial class bbbb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "40745596-da83-4e03-811f-4dc310ca83ee",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1bbe576f-6228-4219-872b-017de5e3415b", "AQAAAAIAAYagAAAAEEq2srvEO3qhn8/bNCsCiPlQj4YNuHsDeCP0K5kJr59mvbEnWT85fvAMxTkRXBeDqg==", "a3e2dc68-0195-4ce6-993a-6f8187f625a2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dba8dd7c-5003-45c8-b22c-7b7d7c0a0b9e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f3214eaa-a61e-45d8-b079-252ea04b6775", "AQAAAAIAAYagAAAAEIBaY3ggvY35DasCBHun0u7mCsOan6gL9pNkOd4SHl0MQBzT0hAzb0krzcxB8JVLOg==", "695ff4ed-b2c9-4a70-9b63-3c90925beba1" });
        }
    }
}
