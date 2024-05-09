using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CIDM_3312___Final_Project.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Regions",
                columns: table => new
                {
                    RegionId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    MacroRegionId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regions", x => x.RegionId);
                    table.ForeignKey(
                        name: "FK_Regions_Regions_MacroRegionId",
                        column: x => x.MacroRegionId,
                        principalTable: "Regions",
                        principalColumn: "RegionId");
                });

            migrationBuilder.CreateTable(
                name: "WildfireAdvisories",
                columns: table => new
                {
                    WildfireAdvisoryId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    IssueDateAndTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    IssuingAuthority = table.Column<string>(type: "TEXT", nullable: false),
                    ContactPhoneNumber = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WildfireAdvisories", x => x.WildfireAdvisoryId);
                });

            migrationBuilder.CreateTable(
                name: "Reports",
                columns: table => new
                {
                    ReportId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Type = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    Location = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    DiscoveryDateandTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    RiskStatus = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    ReporterName = table.Column<string>(type: "TEXT", nullable: true),
                    ReporterPhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    ReporterEmail = table.Column<string>(type: "TEXT", nullable: true),
                    RegionId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reports", x => x.ReportId);
                    table.ForeignKey(
                        name: "FK_Reports_Regions_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Regions",
                        principalColumn: "RegionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RegionWildfireAdvisories",
                columns: table => new
                {
                    WildfireAdvisoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    RegionId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegionWildfireAdvisories", x => new { x.WildfireAdvisoryId, x.RegionId });
                    table.ForeignKey(
                        name: "FK_RegionWildfireAdvisories_Regions_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Regions",
                        principalColumn: "RegionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RegionWildfireAdvisories_WildfireAdvisories_WildfireAdvisoryId",
                        column: x => x.WildfireAdvisoryId,
                        principalTable: "WildfireAdvisories",
                        principalColumn: "WildfireAdvisoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReportImages",
                columns: table => new
                {
                    ReportImageId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Bytes = table.Column<byte[]>(type: "BLOB", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Size = table.Column<decimal>(type: "TEXT", nullable: false),
                    ReportId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportImages", x => x.ReportImageId);
                    table.ForeignKey(
                        name: "FK_ReportImages_Reports_ReportId",
                        column: x => x.ReportId,
                        principalTable: "Reports",
                        principalColumn: "ReportId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "RegionId", "MacroRegionId", "Name" },
                values: new object[,]
                {
                    { 30, null, "Texas Panhandle" },
                    { 1, 30, "Randall County, TX" },
                    { 7, 30, "Potter County, TX" },
                    { 13, 30, "Carson County, TX" },
                    { 19, 30, "Armstrong County, TX" },
                    { 24, 30, "Moore County, TX" },
                    { 2, 1, "Canyon, TX" },
                    { 3, 1, "Palo Duro Canyon State Park, TX" },
                    { 4, 1, "Zita, TX" },
                    { 5, 1, "Lake Tanglewood, TX" },
                    { 6, 1, "Umbarger, TX" },
                    { 8, 7, "Amarillo, TX" },
                    { 9, 7, "Gentry, TX" },
                    { 10, 7, "Gluck, TX" },
                    { 11, 7, "Ady, TX" },
                    { 12, 7, "Bishop Hills, TX" },
                    { 14, 13, "Skellytown, TX" },
                    { 15, 13, "Wilhelm, TX" },
                    { 16, 13, "Abell, TX" },
                    { 17, 13, "Panhandle, TX" },
                    { 18, 13, "White Deer, TX" },
                    { 20, 19, "Washburn, TX" },
                    { 21, 19, "Claude, TX" },
                    { 22, 19, "Wayside, TX" },
                    { 23, 19, "Goodnight, TX" },
                    { 25, 24, "Dumas, TX" },
                    { 26, 24, "Masterson, TX" },
                    { 27, 24, "Bryden, TX" },
                    { 28, 24, "Sunray, TX" },
                    { 29, 24, "Cactus, TX" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Regions_MacroRegionId",
                table: "Regions",
                column: "MacroRegionId");

            migrationBuilder.CreateIndex(
                name: "IX_RegionWildfireAdvisories_RegionId",
                table: "RegionWildfireAdvisories",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_ReportImages_ReportId",
                table: "ReportImages",
                column: "ReportId");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_RegionId",
                table: "Reports",
                column: "RegionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RegionWildfireAdvisories");

            migrationBuilder.DropTable(
                name: "ReportImages");

            migrationBuilder.DropTable(
                name: "WildfireAdvisories");

            migrationBuilder.DropTable(
                name: "Reports");

            migrationBuilder.DropTable(
                name: "Regions");
        }
    }
}
