using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPIRegister.Migrations
{
    public partial class APIWL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Entity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nip = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StatusVat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Regon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Krs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResidenceAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkingAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegistrationLegalDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RegistrationDenialDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RegistrationDenialBasis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RestorationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RestorationBasis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RemovalDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RemovalBasis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HasVirtualAccounts = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Entity");
        }
    }
}
