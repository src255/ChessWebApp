using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChessWebApp.Data.Migrations
{
    public partial class renamePostContent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Content",
                table: "Post",
                newName: "PostContent");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PostContent",
                table: "Post",
                newName: "Content");
        }
    }
}
