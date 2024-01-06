using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RealState2.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "lastname",
                table: "Vendors",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Vendors",
                newName: "UserId");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Vendors",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "ProfilePictute",
                table: "Vendors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfilePictute",
                table: "Vendors");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Vendors",
                newName: "lastname");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Vendors",
                newName: "Password");

            migrationBuilder.AlterColumn<int>(
                name: "Phone",
                table: "Vendors",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
