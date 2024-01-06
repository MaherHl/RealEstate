using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RealState2.Data.Migrations
{
    /// <inheritdoc />
    public partial class realtions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Facilities_Vendors_owner_Id",
                table: "Facilities");

            migrationBuilder.RenameColumn(
                name: "owner_Id",
                table: "Facilities",
                newName: "VendorId");

            migrationBuilder.RenameIndex(
                name: "IX_Facilities_owner_Id",
                table: "Facilities",
                newName: "IX_Facilities_VendorId");

            migrationBuilder.AddColumn<string>(
                name: "amenities",
                table: "Facilities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Facilities_Vendors_VendorId",
                table: "Facilities",
                column: "VendorId",
                principalTable: "Vendors",
                principalColumn: "_Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Facilities_Vendors_VendorId",
                table: "Facilities");

            migrationBuilder.DropColumn(
                name: "amenities",
                table: "Facilities");

            migrationBuilder.RenameColumn(
                name: "VendorId",
                table: "Facilities",
                newName: "owner_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Facilities_VendorId",
                table: "Facilities",
                newName: "IX_Facilities_owner_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Facilities_Vendors_owner_Id",
                table: "Facilities",
                column: "owner_Id",
                principalTable: "Vendors",
                principalColumn: "_Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
