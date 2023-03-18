using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarProgram.Migrations
{
    /// <inheritdoc />
    public partial class Convention : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "theEquipment",
                table: "Equipment",
                newName: "TheEquipment");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TheEquipment",
                table: "Equipment",
                newName: "theEquipment");
        }
    }
}
