using Microsoft.EntityFrameworkCore.Migrations;

namespace Kwanso.Api.Migrations
{
    public partial class addisdeletebutton : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "tasks",
                type: "bit",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "tasks");
        }
    }
}
