using Microsoft.EntityFrameworkCore.Migrations;

namespace dotnetMultirotor.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
					migrationBuilder.Sql("INSERT INTO Users (Name,Email,Password) VALUES('David','tannerd@gmail.com','test')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
					migrationBuilder.Sql("DELETE FROM Users");
        }
    }
}
