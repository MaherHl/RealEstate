using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RealState2.Data.Migrations
{
    /// <inheritdoc />
    public partial class update1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "amenities",
                table: "Facilities");

            migrationBuilder.DropColumn(
                name: "baths",
                table: "Facilities");

            migrationBuilder.AlterColumn<double>(
                name: "rate",
                table: "Facilities",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "rate",
                table: "Facilities",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "amenities",
                table: "Facilities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "baths",
                table: "Facilities",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
