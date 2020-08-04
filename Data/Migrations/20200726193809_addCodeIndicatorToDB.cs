using Microsoft.EntityFrameworkCore.Migrations;

namespace IVEACore.Data.Migrations
{
    public partial class addCodeIndicatorToDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CodeIndicator",
                table: "Indicator",
                maxLength: 10,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CodeIndicator",
                table: "Indicator");
        }
    }
}
