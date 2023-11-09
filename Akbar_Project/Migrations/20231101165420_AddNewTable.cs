using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Akbar_Project.Migrations
{
    /// <inheritdoc />
    public partial class AddNewTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
            name: "YourNewTable",
            columns: table => new
        {
            Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
            Status = table.Column<string>(type: "TEXT", nullable: false),
            PhoneNumber = table.Column<int>(type: "INTEGER", nullable: true),
            HomeAddress = table.Column<string>(type: "TEXT", nullable: true)
        },
            constraints: table =>
        {
            table.PrimaryKey("PK_YourNewTable", x => x.Id);
        });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
            name: "YourNewTable");
        }
    }
}
