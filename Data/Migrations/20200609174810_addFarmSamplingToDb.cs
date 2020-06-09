using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IVEACore.Data.Migrations
{
    public partial class addFarmSamplingToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FarmSampling",
                columns: table => new
                {
                    Id_FamSampling = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Farm = table.Column<int>(nullable: false),
                    DateSampling = table.Column<DateTime>(nullable: false),
                    Details = table.Column<string>(maxLength: 255, nullable: false),
                    Description_CFV = table.Column<string>(maxLength: 255, nullable: false),
                    Value_CFV = table.Column<float>(nullable: false),
                    Description_DAS = table.Column<string>(maxLength: 255, nullable: false),
                    Value_DAS = table.Column<float>(nullable: false),
                    Description_DFS = table.Column<string>(maxLength: 255, nullable: false),
                    Value_DFS = table.Column<float>(nullable: false),
                    Description_MPE = table.Column<string>(maxLength: 255, nullable: false),
                    Value_MPE = table.Column<float>(nullable: false),
                    Description_NCS = table.Column<string>(maxLength: 255, nullable: false),
                    Value_NCS = table.Column<float>(nullable: false),
                    Description_NES = table.Column<string>(maxLength: 255, nullable: false),
                    Value_NES = table.Column<float>(nullable: false),
                    Description_NRS = table.Column<string>(maxLength: 255, nullable: false),
                    Value_NRS = table.Column<float>(nullable: false),
                    Description_PES = table.Column<string>(maxLength: 255, nullable: false),
                    Value_PES = table.Column<float>(nullable: false),
                    Description_RCES = table.Column<string>(maxLength: 255, nullable: false),
                    Value_RCES = table.Column<float>(nullable: false),
                    Description_RCS = table.Column<string>(maxLength: 255, nullable: false),
                    Value_RCS = table.Column<float>(nullable: false),
                    Description_RES = table.Column<string>(maxLength: 255, nullable: false),
                    Value_RES = table.Column<float>(nullable: false),
                    Description_VBS = table.Column<string>(maxLength: 255, nullable: false),
                    Value_VBS = table.Column<float>(nullable: false),
                    Description_AF = table.Column<string>(maxLength: 255, nullable: false),
                    Value_AF = table.Column<float>(nullable: false),
                    AnimalsAmount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FarmSampling", x => x.Id_FamSampling);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FarmSampling");
        }
    }
}
