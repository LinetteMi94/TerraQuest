using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TerraQuest.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCountryDataModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InterestingFact",
                table: "Countries");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "InterestingFact",
                table: "Countries",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
