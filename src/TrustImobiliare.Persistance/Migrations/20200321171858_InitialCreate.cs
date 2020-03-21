using Microsoft.EntityFrameworkCore.Migrations;

namespace TrustImobiliare.Persistance.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Agents",
                columns: table => new
                {
                    AgentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 20, nullable: false),
                    LastName = table.Column<string>(maxLength: 15, nullable: false),
                    PhotoLink = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agents", x => x.AgentId);
                });

            migrationBuilder.CreateTable(
                name: "Types",
                columns: table => new
                {
                    TypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Types", x => x.TypeID);
                });

            migrationBuilder.CreateTable(
                name: "Properties",
                columns: table => new
                {
                    PropertyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "65536, 427"),
                    AgentID = table.Column<int>(nullable: false),
                    TypeID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 60, nullable: false),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    Status = table.Column<string>(maxLength: 13, nullable: false),
                    Price = table.Column<decimal>(type: "money", nullable: false),
                    Surface = table.Column<int>(nullable: false),
                    PrimaryPhotoLink = table.Column<string>(maxLength: 200, nullable: false),
                    PhotoLinks = table.Column<string>(nullable: true),
                    Rooms = table.Column<int>(nullable: true),
                    Bathrooms = table.Column<int>(nullable: true),
                    Year = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Properties", x => x.PropertyID);
                    table.ForeignKey(
                        name: "FK_Properties_Agents",
                        column: x => x.AgentID,
                        principalTable: "Agents",
                        principalColumn: "AgentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Properties_Types",
                        column: x => x.TypeID,
                        principalTable: "Types",
                        principalColumn: "TypeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    AddressID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PropertyID = table.Column<int>(nullable: false),
                    Country = table.Column<string>(maxLength: 15, nullable: true),
                    Region = table.Column<string>(maxLength: 20, nullable: false),
                    City = table.Column<string>(maxLength: 20, nullable: false),
                    Neighborhood = table.Column<string>(nullable: true),
                    AddressDetail = table.Column<string>(maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.AddressID);
                    table.ForeignKey(
                        name: "FK_Properties_Addresses",
                        column: x => x.PropertyID,
                        principalTable: "Properties",
                        principalColumn: "PropertyID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Features",
                columns: table => new
                {
                    FeatureID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PropertyID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Features", x => x.FeatureID);
                    table.ForeignKey(
                        name: "FK_Features_Properties",
                        column: x => x.PropertyID,
                        principalTable: "Properties",
                        principalColumn: "PropertyID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_PropertyID",
                table: "Addresses",
                column: "PropertyID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Features_PropertyID",
                table: "Features",
                column: "PropertyID");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_AgentID",
                table: "Properties",
                column: "AgentID");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_TypeID",
                table: "Properties",
                column: "TypeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Features");

            migrationBuilder.DropTable(
                name: "Properties");

            migrationBuilder.DropTable(
                name: "Agents");

            migrationBuilder.DropTable(
                name: "Types");
        }
    }
}
