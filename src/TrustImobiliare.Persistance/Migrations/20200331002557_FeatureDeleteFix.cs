using Microsoft.EntityFrameworkCore.Migrations;

namespace TrustImobiliare.Persistance.Migrations
{
    public partial class FeatureDeleteFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Features_Properties",
                table: "Features");

            migrationBuilder.AddForeignKey(
                name: "FK_Features_Properties",
                table: "Features",
                column: "PropertyID",
                principalTable: "Properties",
                principalColumn: "PropertyID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Features_Properties",
                table: "Features");

            migrationBuilder.AddForeignKey(
                name: "FK_Features_Properties",
                table: "Features",
                column: "PropertyID",
                principalTable: "Properties",
                principalColumn: "PropertyID");
        }
    }
}
