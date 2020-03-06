using Microsoft.EntityFrameworkCore.Migrations;

namespace HC_WEB_FINALPROJECT.Migrations
{
    public partial class editpaging : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StatusPage",
                table: "Pagings",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StatusPage",
                table: "Pagings");
        }
    }
}
