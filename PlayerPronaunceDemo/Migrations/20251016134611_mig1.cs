using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlayerPronaunceDemo.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FootballTeams",
                columns: table => new
                {
                    FootballTeamId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Origin = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FootballTeams", x => x.FootballTeamId);
                });

            migrationBuilder.CreateTable(
                name: "FootbalPlayers",
                columns: table => new
                {
                    FootbalPlayerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FootballTeamId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FootbalPlayers", x => x.FootbalPlayerId);
                    table.ForeignKey(
                        name: "FK_FootbalPlayers_FootballTeams_FootballTeamId",
                        column: x => x.FootballTeamId,
                        principalTable: "FootballTeams",
                        principalColumn: "FootballTeamId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FootbalPlayers_FootballTeamId",
                table: "FootbalPlayers",
                column: "FootballTeamId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FootbalPlayers");

            migrationBuilder.DropTable(
                name: "FootballTeams");
        }
    }
}
