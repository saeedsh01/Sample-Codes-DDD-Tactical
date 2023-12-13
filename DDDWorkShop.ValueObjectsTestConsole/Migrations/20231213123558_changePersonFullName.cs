using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DDDWorkShop.ValueObjectsTestConsole.Migrations
{
    /// <inheritdoc />
    public partial class changePersonFullName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "People",
                newName: "PersonFullName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PersonFullName",
                table: "People",
                newName: "FullName");
        }
    }
}
