using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EZ.Migrations
{
    public partial class AddBookAsTenant : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "TenantId",
                table: "Books",
                type: "uuid",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "Books");
        }
    }
}
