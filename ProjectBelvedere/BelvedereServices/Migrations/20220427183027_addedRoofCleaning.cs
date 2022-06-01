using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BelvedereServices.Migrations
{
    public partial class addedRoofCleaning : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "ClutterRemoval",
                table: "ServiceOrders",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HousePainting",
                table: "ServiceOrders",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PoolInstallation",
                table: "ServiceOrders",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Powerwashing",
                table: "ServiceOrders",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ProblemSolving",
                table: "ServiceOrders",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "RoofCleaning",
                table: "ServiceOrders",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "TreePlanting",
                table: "ServiceOrders",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClutterRemoval",
                table: "ServiceOrders");

            migrationBuilder.DropColumn(
                name: "HousePainting",
                table: "ServiceOrders");

            migrationBuilder.DropColumn(
                name: "PoolInstallation",
                table: "ServiceOrders");

            migrationBuilder.DropColumn(
                name: "Powerwashing",
                table: "ServiceOrders");

            migrationBuilder.DropColumn(
                name: "ProblemSolving",
                table: "ServiceOrders");

            migrationBuilder.DropColumn(
                name: "RoofCleaning",
                table: "ServiceOrders");

            migrationBuilder.DropColumn(
                name: "TreePlanting",
                table: "ServiceOrders");
        }
    }
}
