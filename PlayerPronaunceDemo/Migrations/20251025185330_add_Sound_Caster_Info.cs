using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlayerPronaunceDemo.Migrations
{
    /// <inheritdoc />
    public partial class add_Sound_Caster_Info : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SoundPath",
                table: "Sounds",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "SoundNation",
                table: "Sounds",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "CasterImageUrl",
                table: "Sounds",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CasterName",
                table: "Sounds",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CasterNationImageUrl",
                table: "Sounds",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CasterImageUrl",
                table: "Sounds");

            migrationBuilder.DropColumn(
                name: "CasterName",
                table: "Sounds");

            migrationBuilder.DropColumn(
                name: "CasterNationImageUrl",
                table: "Sounds");

            migrationBuilder.AlterColumn<string>(
                name: "SoundPath",
                table: "Sounds",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SoundNation",
                table: "Sounds",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
