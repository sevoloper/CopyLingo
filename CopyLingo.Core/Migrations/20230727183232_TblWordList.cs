using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CopyLingo.Core.Migrations
{
    /// <inheritdoc />
    public partial class TblWordList : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TblWorldList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    English = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Turkish = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 7, 27, 18, 32, 32, 27, DateTimeKind.Utc).AddTicks(5867))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblWorldList", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TblWorldList");
        }
    }
}
