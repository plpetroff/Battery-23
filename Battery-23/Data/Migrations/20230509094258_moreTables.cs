using Microsoft.EntityFrameworkCore.Migrations;

namespace Battery_23.Data.Migrations
{
    public partial class moreTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BoxTypeId",
                table: "Batteries",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TerminalId",
                table: "Batteries",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "BoxType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BoxTypeCode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoxType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Terminals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Terminals", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Batteries_BoxTypeId",
                table: "Batteries",
                column: "BoxTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Batteries_TerminalId",
                table: "Batteries",
                column: "TerminalId");

            migrationBuilder.AddForeignKey(
                name: "FK_Batteries_BoxType_BoxTypeId",
                table: "Batteries",
                column: "BoxTypeId",
                principalTable: "BoxType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Batteries_Terminals_TerminalId",
                table: "Batteries",
                column: "TerminalId",
                principalTable: "Terminals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Batteries_BoxType_BoxTypeId",
                table: "Batteries");

            migrationBuilder.DropForeignKey(
                name: "FK_Batteries_Terminals_TerminalId",
                table: "Batteries");

            migrationBuilder.DropTable(
                name: "BoxType");

            migrationBuilder.DropTable(
                name: "Terminals");

            migrationBuilder.DropIndex(
                name: "IX_Batteries_BoxTypeId",
                table: "Batteries");

            migrationBuilder.DropIndex(
                name: "IX_Batteries_TerminalId",
                table: "Batteries");

            migrationBuilder.DropColumn(
                name: "BoxTypeId",
                table: "Batteries");

            migrationBuilder.DropColumn(
                name: "TerminalId",
                table: "Batteries");
        }
    }
}
