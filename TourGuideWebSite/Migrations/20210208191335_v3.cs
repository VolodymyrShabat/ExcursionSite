using Microsoft.EntityFrameworkCore.Migrations;

namespace TourGuideWebSite.Migrations
{
    public partial class v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Events",
                newName: "Href");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Href",
                table: "Events",
                newName: "Description");
        }
    }
}
