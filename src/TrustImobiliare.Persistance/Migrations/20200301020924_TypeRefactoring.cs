using Microsoft.EntityFrameworkCore.Migrations;

namespace TrustImobiliare.Persistance.Migrations
{
    public partial class TypeRefactoring : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Properties_Types",
                table: "Types");

            migrationBuilder.DropIndex(
                name: "IX_Types_PropertyID",
                table: "Types");

            migrationBuilder.DropColumn(
                name: "PropertyID",
                table: "Types");

            migrationBuilder.AddColumn<int>(
                name: "TypeID",
                table: "Properties",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Properties_TypeID",
                table: "Properties",
                column: "TypeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_Types",
                table: "Properties",
                column: "TypeID",
                principalTable: "Types",
                principalColumn: "TypeID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Properties_Types",
                table: "Properties");

            migrationBuilder.DropIndex(
                name: "IX_Properties_TypeID",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "TypeID",
                table: "Properties");

            migrationBuilder.AddColumn<int>(
                name: "PropertyID",
                table: "Types",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Types_PropertyID",
                table: "Types",
                column: "PropertyID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_Types",
                table: "Types",
                column: "PropertyID",
                principalTable: "Properties",
                principalColumn: "PropertyID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
