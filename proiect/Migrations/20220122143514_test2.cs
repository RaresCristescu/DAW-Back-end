using Microsoft.EntityFrameworkCore.Migrations;

namespace proiect.Migrations
{
    public partial class test2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Models1",
                newName: "Title");

            migrationBuilder.AddColumn<int>(
                name: "Order",
                table: "Models1",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Order",
                table: "Models1");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Models1",
                newName: "Name");
        }
    }
}
