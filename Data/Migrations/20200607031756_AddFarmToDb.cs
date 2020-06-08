using Microsoft.EntityFrameworkCore.Migrations;

namespace IVEACore.Data.Migrations
{
    public partial class AddFarmToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Farm",
                columns: table => new
                {
                    Id_Farm = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameFarm = table.Column<string>(maxLength: 255, nullable: false),
                    FirstNameFarmer = table.Column<string>(maxLength: 255, nullable: false),
                    LastNameFarmer = table.Column<string>(maxLength: 255, nullable: false),
                    AddressFarm = table.Column<string>(maxLength: 255, nullable: false),
                    FarmExtention = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Farm", x => x.Id_Farm);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Farm");
        }
    }
}
