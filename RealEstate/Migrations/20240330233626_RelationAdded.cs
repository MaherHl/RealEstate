using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RealEstate.Migrations
{
    /// <inheritdoc />
    public partial class RelationAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Facilities_Agents_Agent_Id",
                table: "Facilities");

            migrationBuilder.DropIndex(
                name: "IX_Facilities_Agent_Id",
                table: "Facilities");

            migrationBuilder.DropColumn(
                name: "Agent_Id",
                table: "Facilities");

            migrationBuilder.RenameColumn(
                name: "VendorId",
                table: "Facilities",
                newName: "AgentId");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Facilities_Agents_AgentId",
                table: "Facilities");

            migrationBuilder.DropIndex(
                name: "IX_Facilities_AgentId",
                table: "Facilities");

            migrationBuilder.RenameColumn(
                name: "AgentId",
                table: "Facilities",
                newName: "VendorId");

            migrationBuilder.AddColumn<int>(
                name: "Agent_Id",
                table: "Facilities",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Facilities_Agent_Id",
                table: "Facilities",
                column: "Agent_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Facilities_Agents_Agent_Id",
                table: "Facilities",
                column: "Agent_Id",
                principalTable: "Agents",
                principalColumn: "_Id");
        }
    }
}
