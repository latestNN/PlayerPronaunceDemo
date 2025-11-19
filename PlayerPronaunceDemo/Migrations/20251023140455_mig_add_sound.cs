using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlayerPronaunceDemo.Migrations
{
    /// <inheritdoc />
    public partial class mig_add_sound : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Mp3Path",
                table: "FootbalPlayers");

            migrationBuilder.CreateTable(
                name: "Sounds",
                columns: table => new
                {
                    SoundId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SoundPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsEpic = table.Column<bool>(type: "bit", nullable: false),
                    SoundNation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FootballPlayerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sounds", x => x.SoundId);
                    table.ForeignKey(
                        name: "FK_Sounds_FootbalPlayers_FootballPlayerId",
                        column: x => x.FootballPlayerId,
                        principalTable: "FootbalPlayers",
                        principalColumn: "FootbalPlayerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sounds_FootballPlayerId",
                table: "Sounds",
                column: "FootballPlayerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sounds");

            migrationBuilder.AddColumn<string>(
                name: "Mp3Path",
                table: "FootbalPlayers",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
