using Microsoft.EntityFrameworkCore.Migrations;

namespace CarStoreServer.API.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into Makes (Name)  VALUES('BMW')");
            migrationBuilder.Sql("Insert into Makes (Name)  VALUES('AUDI')");
            migrationBuilder.Sql("Insert into Makes (Name)  VALUES('VolksWagen')");

            migrationBuilder.Sql("Insert into Models (Name, MakeId) VALUES('320', (SELECT Id FROM Makes where Name='BMW'))");
            migrationBuilder.Sql("Insert into Models (Name, MakeId) VALUES('320i', (SELECT Id FROM Makes where Name='BMW'))");
            migrationBuilder.Sql("Insert into Models (Name, MakeId) VALUES('320 xDrive', (SELECT Id FROM Makes where Name='BMW'))");

            migrationBuilder.Sql("Insert into Models (Name, MakeId) VALUES('A3', (SELECT Id FROM Makes where Name='AUDI'))");
            migrationBuilder.Sql("Insert into Models (Name, MakeId) VALUES('A4', (SELECT Id FROM Makes where Name='AUDI'))");
            migrationBuilder.Sql("Insert into Models (Name, MakeId) VALUES('A6', (SELECT Id FROM Makes where Name='AUDI'))");

            migrationBuilder.Sql("Insert into Models (Name, MakeId) VALUES('Jetta', (SELECT Id FROM Makes where Name='VolksWagen'))");
            migrationBuilder.Sql("Insert into Models (Name, MakeId) VALUES('Passat', (SELECT Id FROM Makes where Name='VolksWagen'))");
            migrationBuilder.Sql("Insert into Models (Name, MakeId) VALUES('Golf', (SELECT Id FROM Makes where Name='VolksWagen'))");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Makes");
        }
    }
}
