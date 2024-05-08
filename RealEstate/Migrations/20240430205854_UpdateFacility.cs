using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RealEstate.Migrations
{
    /// <inheritdoc />
    public partial class UpdateFacility : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Facilities_Agents_AgentId",
                table: "Facilities");

            migrationBuilder.DropIndex(
                name: "IX_Facilities_AgentId",
                table: "Facilities");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Facilities_AgentId",
                table: "Facilities",
                column: "AgentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Facilities_Agents_AgentId",
                table: "Facilities",
                column: "AgentId",
                principalTable: "Agents",
                principalColumn: "_Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
