using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ForumMotor.Data.Migrations
{
    /// <inheritdoc />
    public partial class mssqllocal_migration_328 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Guli",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "LinganGuli",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Guli",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LinganGuli",
                table: "AspNetUsers");
        }
    }
}
