using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RealState2.Data.Migrations
{
    /// <inheritdoc />
    public partial class PictureAttributeAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfilePictute",
                table: "Vendors");

            migrationBuilder.AddColumn<byte[]>(
                name: "ProfilePicture",
                table: "Vendors",
                type: "varbinary(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfilePicture",
                table: "Vendors");

            migrationBuilder.AddColumn<string>(
                name: "ProfilePictute",
                table: "Vendors",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
