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
                    RiskLevel = table.Column<string>(type: "TEXT", nullable: true),
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
                columns: new[] { "RegionId", "MacroRegionId", "Name", "RiskLevel" },
                values: new object[,]
                {
                    { 30, null, "Texas Panhandle", "Medium" },
                    { 1, 30, "Randall County, TX", "Low" },
                    { 7, 30, "Potter County, TX", "Low" },
                    { 13, 30, "Carson County, TX", "Medium" },
                    { 19, 30, "Armstrong County, TX", "Medium" },
                    { 24, 30, "Moore County, TX", "High" },
                    { 2, 1, "Canyon, TX", "Low" },
                    { 3, 1, "Palo Duro Canyon State Park, TX", "Low" },
                    { 4, 1, "Zita, TX", "Low" },
                    { 5, 1, "Lake Tanglewood, TX", "Low" },
                    { 6, 1, "Umbarger, TX", "Low" },
                    { 8, 7, "Amarillo, TX", "Low" },
                    { 9, 7, "Gentry, TX", "Low" },
                    { 10, 7, "Gluck, TX", "Low" },
                    { 11, 7, "Ady, TX", "Low" },
                    { 12, 7, "Bishop Hills, TX", "Low" },
                    { 14, 13, "Skellytown, TX", "Medium" },
                    { 15, 13, "Wilhelm, TX", "Low" },
                    { 16, 13, "Abell, TX", "Low" },
                    { 17, 13, "Panhandle, TX", "Medium" },
                    { 18, 13, "White Deer, TX", "Medium" },
                    { 20, 19, "Washburn, TX", "Medium" },
                    { 21, 19, "Claude, TX", "Medium" },
                    { 22, 19, "Wayside, TX", "Medium" },
                    { 23, 19, "Goodnight, TX", "High" },
                    { 25, 24, "Dumas, TX", "High" },
                    { 26, 24, "Masterson, TX", "High" },
                    { 27, 24, "Bryden, TX", "High" },
                    { 28, 24, "Sunray, TX", "High" },
                    { 29, 24, "Cactus, TX", "High" }
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
