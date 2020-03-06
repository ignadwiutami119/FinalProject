using Microsoft.EntityFrameworkCore.Migrations;

namespace HC_WEB_FINALPROJECT.Migrations
{
    public partial class editemployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Employee",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Employee");
        }
    }
}
