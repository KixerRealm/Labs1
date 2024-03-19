using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Application.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class V_3_0_create_models : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "TheatreShowId",
                table: "Ticket",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TheatreShow",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Place = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShowDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TheatreShow", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_TheatreShowId",
                table: "Ticket",
                column: "TheatreShowId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_TheatreShow_TheatreShowId",
                table: "Ticket",
                column: "TheatreShowId",
                principalTable: "TheatreShow",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_TheatreShow_TheatreShowId",
                table: "Ticket");

            migrationBuilder.DropTable(
                name: "TheatreShow");

            migrationBuilder.DropIndex(
                name: "IX_Ticket_TheatreShowId",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "TheatreShowId",
                table: "Ticket");
        }
    }
}
