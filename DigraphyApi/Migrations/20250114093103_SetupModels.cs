using System;
using DigraphyApi.Models;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DigraphyApi.Migrations
{
    /// <inheritdoc />
    public partial class SetupModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("Npgsql:Enum:FactoidImportance", "could,must,should");

            migrationBuilder.CreateTable(
                name: "Collections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    IsVerified = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Collections", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Factoids",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Factoids", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Titles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    SmallPosterUrl = table.Column<string>(type: "text", nullable: false),
                    LargePosterUrl = table.Column<string>(type: "text", nullable: false),
                    ReleasedAtUrc = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    TmdbId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Titles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Topics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    TmdbId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    IsVerified = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedAtUtc = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EditedAtUtc = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CollectionId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Collections_CollectionId",
                        column: x => x.CollectionId,
                        principalTable: "Collections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CollectionTitle",
                columns: table => new
                {
                    CollectionsId = table.Column<int>(type: "integer", nullable: false),
                    TitlesId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CollectionTitle", x => new { x.CollectionsId, x.TitlesId });
                    table.ForeignKey(
                        name: "FK_CollectionTitle_Collections_CollectionsId",
                        column: x => x.CollectionsId,
                        principalTable: "Collections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CollectionTitle_Titles_TitlesId",
                        column: x => x.TitlesId,
                        principalTable: "Titles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FactoidsImportance",
                columns: table => new
                {
                    FactoidId = table.Column<int>(type: "integer", nullable: false),
                    TitleId = table.Column<int>(type: "integer", nullable: false),
                    Importance = table.Column<FactoidImportance>(type: "\"FactoidImportance\"", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FactoidsImportance", x => new { x.FactoidId, x.TitleId });
                    table.ForeignKey(
                        name: "FK_FactoidsImportance_Factoids_FactoidId",
                        column: x => x.FactoidId,
                        principalTable: "Factoids",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FactoidsImportance_Titles_TitleId",
                        column: x => x.TitleId,
                        principalTable: "Titles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FactoidTitle",
                columns: table => new
                {
                    AffilitatedTitlesId = table.Column<int>(type: "integer", nullable: false),
                    ContainedFactoidsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FactoidTitle", x => new { x.AffilitatedTitlesId, x.ContainedFactoidsId });
                    table.ForeignKey(
                        name: "FK_FactoidTitle_Factoids_ContainedFactoidsId",
                        column: x => x.ContainedFactoidsId,
                        principalTable: "Factoids",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FactoidTitle_Titles_AffilitatedTitlesId",
                        column: x => x.AffilitatedTitlesId,
                        principalTable: "Titles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FactoidTopic",
                columns: table => new
                {
                    AffiliatedFactoidsId = table.Column<int>(type: "integer", nullable: false),
                    TopicsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FactoidTopic", x => new { x.AffiliatedFactoidsId, x.TopicsId });
                    table.ForeignKey(
                        name: "FK_FactoidTopic_Factoids_AffiliatedFactoidsId",
                        column: x => x.AffiliatedFactoidsId,
                        principalTable: "Factoids",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FactoidTopic_Topics_TopicsId",
                        column: x => x.TopicsId,
                        principalTable: "Topics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderTitle",
                columns: table => new
                {
                    TitleId = table.Column<int>(type: "integer", nullable: false),
                    OrderId = table.Column<int>(type: "integer", nullable: false),
                    Index = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderTitle", x => new { x.OrderId, x.TitleId });
                    table.ForeignKey(
                        name: "FK_OrderTitle_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderTitle_Titles_TitleId",
                        column: x => x.TitleId,
                        principalTable: "Titles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CollectionTitle_TitlesId",
                table: "CollectionTitle",
                column: "TitlesId");

            migrationBuilder.CreateIndex(
                name: "IX_FactoidsImportance_TitleId",
                table: "FactoidsImportance",
                column: "TitleId");

            migrationBuilder.CreateIndex(
                name: "IX_FactoidTitle_ContainedFactoidsId",
                table: "FactoidTitle",
                column: "ContainedFactoidsId");

            migrationBuilder.CreateIndex(
                name: "IX_FactoidTopic_TopicsId",
                table: "FactoidTopic",
                column: "TopicsId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CollectionId",
                table: "Orders",
                column: "CollectionId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderTitle_TitleId",
                table: "OrderTitle",
                column: "TitleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CollectionTitle");

            migrationBuilder.DropTable(
                name: "FactoidsImportance");

            migrationBuilder.DropTable(
                name: "FactoidTitle");

            migrationBuilder.DropTable(
                name: "FactoidTopic");

            migrationBuilder.DropTable(
                name: "OrderTitle");

            migrationBuilder.DropTable(
                name: "Factoids");

            migrationBuilder.DropTable(
                name: "Topics");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Titles");

            migrationBuilder.DropTable(
                name: "Collections");

            migrationBuilder.AlterDatabase()
                .OldAnnotation("Npgsql:Enum:FactoidImportance", "could,must,should");
        }
    }
}
