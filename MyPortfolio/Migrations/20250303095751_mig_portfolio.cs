using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPortfolio.Migrations
{
    /// <inheritdoc />
    public partial class mig_portfolio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SubTitle",
                table: "Portfolios",
                newName: "Technology");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Portfolios",
                newName: "Date");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Technology",
                table: "Portfolios",
                newName: "SubTitle");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Portfolios",
                newName: "ImageUrl");
        }
    }
}
