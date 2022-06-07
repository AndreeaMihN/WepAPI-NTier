using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace A2Mac1.Costino.DataAccess.Migrations
{
    public partial class updateModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Projects",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "EquipmentID",
                table: "Equipments",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Projects",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Equipments",
                newName: "EquipmentID");
        }
    }
}
