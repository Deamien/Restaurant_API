using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LAB1_HT2024.Migrations
{
    /// <inheritdoc />
    public partial class anotherchange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Passwordhash",
                table: "Admin",
                newName: "PasswordHash");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PasswordHash",
                table: "Admin",
                newName: "Passwordhash");
        }
    }
}
