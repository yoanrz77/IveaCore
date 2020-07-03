using Microsoft.EntityFrameworkCore.Migrations;

namespace IVEACore.Data.Migrations
{
    public partial class addIveaToFarmSamplingToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IVEA",
                table: "FarmSampling",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IVEA",
                table: "FarmSampling");
        }
    }
}
