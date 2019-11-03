using Microsoft.EntityFrameworkCore.Migrations;

namespace AllinOneForDummies.Core.Migrations
{
    public partial class AddForeignKeyProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Moons_Planets_PlanetId",
                table: "Moons");

            migrationBuilder.DropForeignKey(
                name: "FK_Planets_Stars_StarId",
                table: "Planets");

            migrationBuilder.AlterColumn<int>(
                name: "StarId",
                table: "Planets",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PlanetId",
                table: "Moons",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Moons_Planets_PlanetId",
                table: "Moons",
                column: "PlanetId",
                principalTable: "Planets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Planets_Stars_StarId",
                table: "Planets",
                column: "StarId",
                principalTable: "Stars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Moons_Planets_PlanetId",
                table: "Moons");

            migrationBuilder.DropForeignKey(
                name: "FK_Planets_Stars_StarId",
                table: "Planets");

            migrationBuilder.AlterColumn<int>(
                name: "StarId",
                table: "Planets",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "PlanetId",
                table: "Moons",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Moons_Planets_PlanetId",
                table: "Moons",
                column: "PlanetId",
                principalTable: "Planets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Planets_Stars_StarId",
                table: "Planets",
                column: "StarId",
                principalTable: "Stars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
