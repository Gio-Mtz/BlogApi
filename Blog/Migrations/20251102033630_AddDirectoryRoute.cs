using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.Migrations
{
    /// <inheritdoc />
    public partial class AddDirectoryRoute : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Categories",
                table: "Posts");

            migrationBuilder.AddColumn<string>(
                name: "DirectoryRoute",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DirectoryRoute",
                table: "Posts");

            migrationBuilder.AddColumn<string>(
                name: "Categories",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
