using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DigraphyApi.Migrations
{
    /// <inheritdoc />
    public partial class FixSpellingAndMissingDescription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FactoidTopic_Factoids_AffiliatedFactoidsId",
                table: "FactoidTopic");

            migrationBuilder.RenameColumn(
                name: "ReleasedAtUrc",
                table: "Titles",
                newName: "ReleasedAtUtc");

            migrationBuilder.RenameColumn(
                name: "AffiliatedFactoidsId",
                table: "FactoidTopic",
                newName: "FactoidsId");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Orders",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_FactoidTopic_Factoids_FactoidsId",
                table: "FactoidTopic",
                column: "FactoidsId",
                principalTable: "Factoids",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FactoidTopic_Factoids_FactoidsId",
                table: "FactoidTopic");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "ReleasedAtUtc",
                table: "Titles",
                newName: "ReleasedAtUrc");

            migrationBuilder.RenameColumn(
                name: "FactoidsId",
                table: "FactoidTopic",
                newName: "AffiliatedFactoidsId");

            migrationBuilder.AddForeignKey(
                name: "FK_FactoidTopic_Factoids_AffiliatedFactoidsId",
                table: "FactoidTopic",
                column: "AffiliatedFactoidsId",
                principalTable: "Factoids",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
