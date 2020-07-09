using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Concedii.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departamente",
                columns: table => new
                {
                    DepartamentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeDepartament = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamente", x => x.DepartamentId);
                });

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    StatusId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusCerere = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.StatusId);
                });

            migrationBuilder.CreateTable(
                name: "Personal",
                columns: table => new
                {
                    PersonalId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nume = table.Column<string>(nullable: true),
                    Prenume = table.Column<string>(nullable: true),
                    NrZileConcediuFolosite = table.Column<int>(nullable: false),
                    DepartamentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personal", x => x.PersonalId);
                    table.ForeignKey(
                        name: "FK_Personal_Departamente_DepartamentId",
                        column: x => x.DepartamentId,
                        principalTable: "Departamente",
                        principalColumn: "DepartamentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cereri",
                columns: table => new
                {
                    CerereId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cereri", x => x.CerereId);
                    table.ForeignKey(
                        name: "FK_Cereri_Status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Status",
                        principalColumn: "StatusId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Concedii",
                columns: table => new
                {
                    ConcediuId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipConcediu = table.Column<string>(nullable: true),
                    Inceput = table.Column<DateTime>(nullable: false),
                    Sfarsit = table.Column<DateTime>(nullable: false),
                    PersonalId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Concedii", x => x.ConcediuId);
                    table.ForeignKey(
                        name: "FK_Concedii_Personal_PersonalId",
                        column: x => x.PersonalId,
                        principalTable: "Personal",
                        principalColumn: "PersonalId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cereri_StatusId",
                table: "Cereri",
                column: "StatusId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Concedii_PersonalId",
                table: "Concedii",
                column: "PersonalId");

            migrationBuilder.CreateIndex(
                name: "IX_Personal_DepartamentId",
                table: "Personal",
                column: "DepartamentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cereri");

            migrationBuilder.DropTable(
                name: "Concedii");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DropTable(
                name: "Personal");

            migrationBuilder.DropTable(
                name: "Departamente");
        }
    }
}
