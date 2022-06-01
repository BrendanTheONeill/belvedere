using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BelvedereServices.Migrations
{
    public partial class addedGrassCutting : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateTime",
                table: "ServiceOrders",
                newName: "Datetime");

            migrationBuilder.AddColumn<bool>(
                name: "GrassCutting",
                table: "ServiceOrders",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GrassCutting",
                table: "ServiceOrders");

            migrationBuilder.RenameColumn(
                name: "Datetime",
                table: "ServiceOrders",
                newName: "DateTime");
        }
    }
}
