using Microsoft.EntityFrameworkCore.Migrations;

namespace AllinOneForDummies.Core.Migrations
{
    public partial class ChangeInPlanetAndMoonModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Size",
                table: "Moons");

            migrationBuilder.RenameColumn(
                name: "Size",
                table: "Planets",
                newName: "Radius");

            migrationBuilder.AddColumn<decimal>(
                name: "Radius",
                table: "Moons",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Radius",
                table: "Moons");

            migrationBuilder.RenameColumn(
                name: "Radius",
                table: "Planets",
                newName: "Size");

            migrationBuilder.AddColumn<long>(
                name: "Size",
                table: "Moons",
                nullable: false,
                defaultValue: 0L);
        }
    }
}
