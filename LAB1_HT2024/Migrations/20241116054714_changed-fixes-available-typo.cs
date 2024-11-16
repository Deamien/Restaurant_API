using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LAB1_HT2024.Migrations
{
    /// <inheritdoc />
    public partial class changedfixesavailabletypo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Availabile",
                table: "Menus",
                newName: "Available");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Available",
                table: "Menus",
                newName: "Availabile");
        }
    }
}
