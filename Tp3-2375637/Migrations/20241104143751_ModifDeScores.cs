using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tp3_2375637.Migrations
{
    /// <inheritdoc />
    public partial class ModifDeScores : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Visibilité",
                table: "Score",
                newName: "IsPublic");

            migrationBuilder.RenameColumn(
                name: "Temps",
                table: "Score",
                newName: "TimeInSeconds");

            migrationBuilder.RenameColumn(
                name: "Pointage",
                table: "Score",
                newName: "ScoreValue");

            migrationBuilder.AddColumn<string>(
                name: "Pseudo",
                table: "Score",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pseudo",
                table: "Score");

            migrationBuilder.RenameColumn(
                name: "TimeInSeconds",
                table: "Score",
                newName: "Temps");

            migrationBuilder.RenameColumn(
                name: "ScoreValue",
                table: "Score",
                newName: "Pointage");

            migrationBuilder.RenameColumn(
                name: "IsPublic",
                table: "Score",
                newName: "Visibilité");
        }
    }
}
