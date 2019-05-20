using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarStoreServer.API.Migrations
{
    public partial class AddSeedFeature : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Features",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Features", x => x.Id);
                });

            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('ABS Brakes')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Panoramic Roof')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('All Season Tires')");


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Features");

            migrationBuilder.Sql("DELETE FROM Features WHERE Name IN ('ABS Brakes', 'Panoramic Roof', 'All Season Tires')");    
        }
    }
}
