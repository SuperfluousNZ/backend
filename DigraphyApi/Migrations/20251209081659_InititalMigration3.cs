using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DigraphyApi.Migrations
{
    /// <inheritdoc />
    public partial class InititalMigration3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FactoidsImportance_Factoids_FactoidId",
                table: "FactoidsImportance");

            migrationBuilder.DropForeignKey(
                name: "FK_FactoidsImportance_Titles_TitleId",
                table: "FactoidsImportance");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderTitle_Orders_OrderId",
                table: "OrderTitle");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderTitle_Titles_TitleId",
                table: "OrderTitle");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderTitle",
                table: "OrderTitle");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FactoidsImportance",
                table: "FactoidsImportance");

            migrationBuilder.RenameTable(
                name: "OrderTitle",
                newName: "OrderTitles");

            migrationBuilder.RenameTable(
                name: "FactoidsImportance",
                newName: "FactoidsImportances");

            migrationBuilder.RenameIndex(
                name: "IX_OrderTitle_TitleId",
                table: "OrderTitles",
                newName: "IX_OrderTitles_TitleId");

            migrationBuilder.RenameIndex(
                name: "IX_FactoidsImportance_TitleId",
                table: "FactoidsImportances",
                newName: "IX_FactoidsImportances_TitleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderTitles",
                table: "OrderTitles",
                columns: new[] { "OrderId", "TitleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_FactoidsImportances",
                table: "FactoidsImportances",
                columns: new[] { "FactoidId", "TitleId" });

            migrationBuilder.AddForeignKey(
                name: "FK_FactoidsImportances_Factoids_FactoidId",
                table: "FactoidsImportances",
                column: "FactoidId",
                principalTable: "Factoids",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FactoidsImportances_Titles_TitleId",
                table: "FactoidsImportances",
                column: "TitleId",
                principalTable: "Titles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderTitles_Orders_OrderId",
                table: "OrderTitles",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderTitles_Titles_TitleId",
                table: "OrderTitles",
                column: "TitleId",
                principalTable: "Titles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FactoidsImportances_Factoids_FactoidId",
                table: "FactoidsImportances");

            migrationBuilder.DropForeignKey(
                name: "FK_FactoidsImportances_Titles_TitleId",
                table: "FactoidsImportances");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderTitles_Orders_OrderId",
                table: "OrderTitles");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderTitles_Titles_TitleId",
                table: "OrderTitles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderTitles",
                table: "OrderTitles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FactoidsImportances",
                table: "FactoidsImportances");

            migrationBuilder.RenameTable(
                name: "OrderTitles",
                newName: "OrderTitle");

            migrationBuilder.RenameTable(
                name: "FactoidsImportances",
                newName: "FactoidsImportance");

            migrationBuilder.RenameIndex(
                name: "IX_OrderTitles_TitleId",
                table: "OrderTitle",
                newName: "IX_OrderTitle_TitleId");

            migrationBuilder.RenameIndex(
                name: "IX_FactoidsImportances_TitleId",
                table: "FactoidsImportance",
                newName: "IX_FactoidsImportance_TitleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderTitle",
                table: "OrderTitle",
                columns: new[] { "OrderId", "TitleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_FactoidsImportance",
                table: "FactoidsImportance",
                columns: new[] { "FactoidId", "TitleId" });

            migrationBuilder.AddForeignKey(
                name: "FK_FactoidsImportance_Factoids_FactoidId",
                table: "FactoidsImportance",
                column: "FactoidId",
                principalTable: "Factoids",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FactoidsImportance_Titles_TitleId",
                table: "FactoidsImportance",
                column: "TitleId",
                principalTable: "Titles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderTitle_Orders_OrderId",
                table: "OrderTitle",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderTitle_Titles_TitleId",
                table: "OrderTitle",
                column: "TitleId",
                principalTable: "Titles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
