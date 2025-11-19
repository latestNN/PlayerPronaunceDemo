using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlayerPronaunceDemo.Migrations
{
    /// <inheritdoc />
    public partial class mig_add_mp3Path_and_nationFlasg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Mp3Path",
                table: "FootbalPlayers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NationFlagImageUrl",
                table: "FootbalPlayers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Mp3Path",
                table: "FootbalPlayers");

            migrationBuilder.DropColumn(
                name: "NationFlagImageUrl",
                table: "FootbalPlayers");
        }
    }
}
