﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RicardoQuintana_ExamenP1.Migrations
{
    public partial class RicardoQuintanaDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RicardoQuintana_Tabla",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RicardoQuintana_Tabla", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RicardoQuintana_Tabla");
        }
    }
}
