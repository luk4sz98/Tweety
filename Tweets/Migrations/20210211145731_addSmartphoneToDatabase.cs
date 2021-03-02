using Microsoft.EntityFrameworkCore.Migrations;

namespace Tweets.Migrations
{
    public partial class addSmartphoneToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Smartphones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeviceName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Performance = table.Column<int>(type: "int", nullable: false),
                    ScreenSize = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    HardwareDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Popularity = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Smartphones", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Smartphones");
        }
    }
}
