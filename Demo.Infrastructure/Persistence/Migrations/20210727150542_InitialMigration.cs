using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Demo.Infrastructure.Persistence.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Government",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GovName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Government", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "NVARCHAR(20)", maxLength: 20, nullable: false),
                    MiddleName = table.Column<string>(type: "NVARCHAR(40)", maxLength: 40, nullable: true),
                    LastName = table.Column<string>(type: "NVARCHAR(20)", maxLength: 20, nullable: false),
                    Gender = table.Column<int>(type: "int", maxLength: 6, nullable: false, defaultValue: 0),
                    MobileNo = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "DATE", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    GovernmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.Id);
                    table.ForeignKey(
                        name: "FK_City_Government_GovernmentId",
                        column: x => x.GovernmentId,
                        principalTable: "Government",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    BuildingNumber = table.Column<int>(type: "int", nullable: false),
                    FlatNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Address_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Address_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Government",
                columns: new[] { "Id", "GovName" },
                values: new object[,]
                {
                    { 1, "Cairo" },
                    { 2, "Giza" },
                    { 3, "Alexandria" },
                    { 4, "Banha" },
                    { 5, "Domiate" },
                    { 6, "Matroh" },
                    { 7, "Sohag" },
                    { 8, "Qena" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "BirthDate", "Email", "FirstName", "LastName", "MiddleName", "MobileNo" },
                values: new object[] { 1, new DateTime(1998, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ahmed@gmail.com", "Ahmed", "Ibrahim", "Ali", "01007095896" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "BirthDate", "Email", "FirstName", "Gender", "LastName", "MiddleName", "MobileNo" },
                values: new object[,]
                {
                    { 2, new DateTime(1992, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Salma@gmail.com", "Salma", 1, "Ibrahim", "Amr", "01006958968" },
                    { 3, new DateTime(1995, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lila@gmail.com", "Lila", 1, "Hassan", "Omar", "01009085896" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "BirthDate", "Email", "FirstName", "LastName", "MiddleName", "MobileNo" },
                values: new object[] { 4, new DateTime(1990, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "yousef@gmail.com", "yousef", "Ibrahim", "mohamed", "01007096066" });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "CityName", "GovernmentId" },
                values: new object[,]
                {
                    { 1, "Helioplies", 1 },
                    { 2, "Obor", 1 },
                    { 3, "Nasr City", 1 },
                    { 4, "Tagmoaa", 1 },
                    { 5, "Maadi", 1 },
                    { 6, "Abassia", 1 },
                    { 7, "Shobra", 1 },
                    { 8, "6 Octobar", 2 },
                    { 9, "Haram", 2 },
                    { 10, "Fiasel", 2 },
                    { 11, "EL shekhzaid", 2 }
                });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "BuildingNumber", "CityId", "FlatNumber", "Street", "UserId" },
                values: new object[,]
                {
                    { 1, 1, 1, 11, " Abbsia Street", 1 },
                    { 3, 12, 1, 44, " Agoza Street", 3 },
                    { 4, 6, 1, 30, " Nasr City Street", 2 },
                    { 2, 11, 2, 51, "Giza Street", 2 },
                    { 5, 10, 2, 1, "Haram Street", 3 },
                    { 6, 4, 2, 10, "6 Octobar Street", 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Address_CityId",
                table: "Address",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Address_UserId",
                table: "Address",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_City_GovernmentId",
                table: "City",
                column: "GovernmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Government");
        }
    }
}
