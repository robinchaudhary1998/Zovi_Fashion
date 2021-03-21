using System;
using System.IO;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Zovi_Fashion.Data.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Studios",
                columns: table => new
                {
                    StudioID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 100, nullable: false),
                    StudioDesc = table.Column<string>(maxLength: 1000, nullable: false),
                    PostDate = table.Column<DateTime>(nullable: false),
                    Extension = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Studios", x => x.StudioID);
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    BrandID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandName = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.BrandID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(maxLength: 200, nullable: false),
                    Fabric = table.Column<string>(maxLength: 400, nullable: true),
                    ManufacturingYear = table.Column<string>(maxLength: 400, nullable: true),
                    Description = table.Column<string>(maxLength: 400, nullable: true),
                    Color = table.Column<string>(maxLength: 400, nullable: true),
                    Fit = table.Column<string>(maxLength: 400, nullable: true),
                    SleveLength = table.Column<string>(maxLength: 400, nullable: true),
                    Occasion = table.Column<string>(maxLength: 400, nullable: true),
                    PatternType = table.Column<string>(maxLength: 400, nullable: true),
                    Size = table.Column<string>(maxLength: 400, nullable: true),
                    Neck = table.Column<string>(maxLength: 400, nullable: true),
                    WashCare = table.Column<string>(maxLength: 400, nullable: true),
                    SoldBy = table.Column<string>(maxLength: 400, nullable: true),
                    Price = table.Column<string>(maxLength: 400, nullable: true),
                    Extension = table.Column<string>(maxLength: 20, nullable: false),
                    BrandID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_Products_Brands_BrandID",
                        column: x => x.BrandID,
                        principalTable: "Brands",
                        principalColumn: "BrandID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductReviews",
                columns: table => new
                {
                    ReviewID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Rating = table.Column<int>(nullable: false),
                    ReviewText = table.Column<string>(maxLength: 1000, nullable: false),
                    ProductID = table.Column<int>(nullable: false),
                    ReviewDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductReviews", x => x.ReviewID);
                    table.ForeignKey(
                        name: "FK_ProductReviews_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductReviews_ProductID",
                table: "ProductReviews",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_BrandID",
                table: "Products",
                column: "BrandID");

            var sqlFile = Path.Combine(".\\Scripts", @"records.sql");

            migrationBuilder.Sql(File.ReadAllText(sqlFile));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Studios");

            migrationBuilder.DropTable(
                name: "ProductReviews");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Brands");
        }
    }
}
