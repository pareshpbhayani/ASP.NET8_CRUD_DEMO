using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASP.NET8_CRUD_DEMO.Migrations
{
    /// <inheritdoc />
    public partial class UpdateColumnNameMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Phont",
                table: "Students",
                newName: "Phone");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Students",
                newName: "Phont");
        }
    }
}
