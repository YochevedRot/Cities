using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CityMaps.Data.Migrations
{
    /// <inheritdoc />
    public partial class deleteid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CitiesList",
                table: "CitiesList");

            migrationBuilder.DropColumn(
                name: "id",
                table: "CitiesList");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "id",
                table: "CitiesList",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CitiesList",
                table: "CitiesList",
                column: "id");
        }
    }
}
