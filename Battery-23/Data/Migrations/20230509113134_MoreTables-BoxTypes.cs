using Microsoft.EntityFrameworkCore.Migrations;

namespace Battery_23.Data.Migrations
{
    public partial class MoreTablesBoxTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Batteries_BoxType_BoxTypeId",
                table: "Batteries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BoxType",
                table: "BoxType");

            migrationBuilder.RenameTable(
                name: "BoxType",
                newName: "BoxTypes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BoxTypes",
                table: "BoxTypes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Batteries_BoxTypes_BoxTypeId",
                table: "Batteries",
                column: "BoxTypeId",
                principalTable: "BoxTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Batteries_BoxTypes_BoxTypeId",
                table: "Batteries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BoxTypes",
                table: "BoxTypes");

            migrationBuilder.RenameTable(
                name: "BoxTypes",
                newName: "BoxType");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BoxType",
                table: "BoxType",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Batteries_BoxType_BoxTypeId",
                table: "Batteries",
                column: "BoxTypeId",
                principalTable: "BoxType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
