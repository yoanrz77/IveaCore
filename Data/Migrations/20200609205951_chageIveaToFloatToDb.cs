using Microsoft.EntityFrameworkCore.Migrations;

namespace IVEACore.Data.Migrations
{
    public partial class chageIveaToFloatToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "IVEA",
                table: "FarmSampling",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "IVEA",
                table: "FarmSampling",
                type: "int",
                nullable: false,
                oldClrType: typeof(float));
        }
    }
}
