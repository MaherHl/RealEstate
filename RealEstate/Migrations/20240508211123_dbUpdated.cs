using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RealEstate.Migrations
{
    /// <inheritdoc />
    public partial class dbUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointements_Facilities_FacilityId",
                table: "Appointements");

            migrationBuilder.DropIndex(
                name: "IX_Appointements_FacilityId",
                table: "Appointements");

            migrationBuilder.RenameColumn(
                name: "Clientname",
                table: "Appointements",
                newName: "ClientName");

            migrationBuilder.AddColumn<int>(
                name: "AgentId",
                table: "Appointements",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AgentId",
                table: "Appointements");

            migrationBuilder.RenameColumn(
                name: "ClientName",
                table: "Appointements",
                newName: "Clientname");

            migrationBuilder.CreateIndex(
                name: "IX_Appointements_FacilityId",
                table: "Appointements",
                column: "FacilityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointements_Facilities_FacilityId",
                table: "Appointements",
                column: "FacilityId",
                principalTable: "Facilities",
                principalColumn: "_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
