using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace health_declaration.Migrations
{
    public partial class InitDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "connections",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vehicle = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_connections", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "districts",
                columns: table => new
                {
                    DistrictId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DistrictName = table.Column<string>(nullable: false),
                    Prefix = table.Column<string>(nullable: false),
                    ProvinceId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_districts", x => x.DistrictId);
                });

            migrationBuilder.CreateTable(
                name: "gates",
                columns: table => new
                {
                    GateId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GateName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gates", x => x.GateId);
                });

            migrationBuilder.CreateTable(
                name: "medicals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GateId = table.Column<int>(nullable: false),
                    UserName = table.Column<string>(nullable: false),
                    Dob = table.Column<DateTime>(nullable: false),
                    Gender = table.Column<bool>(nullable: false),
                    Phone = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    PassportNumber = table.Column<int>(nullable: false),
                    ProvinceId = table.Column<int>(nullable: false),
                    DistrictId = table.Column<int>(nullable: false),
                    WardId = table.Column<int>(nullable: false),
                    SymptonId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_medicals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "provinces",
                columns: table => new
                {
                    ProvinceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProvinceName = table.Column<string>(nullable: false),
                    Code = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_provinces", x => x.ProvinceId);
                });

            migrationBuilder.CreateTable(
                name: "symptoms",
                columns: table => new
                {
                    SymptomId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fever = table.Column<bool>(nullable: false),
                    Cough = table.Column<bool>(nullable: false),
                    Sob = table.Column<bool>(nullable: false),
                    Sorethroat = table.Column<bool>(nullable: false),
                    Nausea = table.Column<bool>(nullable: false),
                    Diarhea = table.Column<bool>(nullable: false),
                    Bots = table.Column<bool>(nullable: false),
                    Skinrash = table.Column<bool>(nullable: false),
                    medical = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_symptoms", x => x.SymptomId);
                });

            migrationBuilder.CreateTable(
                name: "vehicles",
                columns: table => new
                {
                    VehicleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleName = table.Column<string>(nullable: false),
                    Seats = table.Column<int>(nullable: false),
                    Departureday = table.Column<DateTime>(nullable: false),
                    Departure_location = table.Column<string>(nullable: false),
                    Destinetion = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vehicles", x => x.VehicleId);
                });

            migrationBuilder.CreateTable(
                name: "wards",
                columns: table => new
                {
                    WardId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WardName = table.Column<string>(nullable: false),
                    Prefix = table.Column<string>(nullable: false),
                    ProvinceId = table.Column<int>(nullable: false),
                    DistrictId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wards", x => x.WardId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "connections");

            migrationBuilder.DropTable(
                name: "districts");

            migrationBuilder.DropTable(
                name: "gates");

            migrationBuilder.DropTable(
                name: "medicals");

            migrationBuilder.DropTable(
                name: "provinces");

            migrationBuilder.DropTable(
                name: "symptoms");

            migrationBuilder.DropTable(
                name: "vehicles");

            migrationBuilder.DropTable(
                name: "wards");
        }
    }
}
