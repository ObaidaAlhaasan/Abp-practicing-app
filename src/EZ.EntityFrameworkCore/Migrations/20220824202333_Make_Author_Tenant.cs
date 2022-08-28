using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EZ.Migrations
{
    public partial class Make_Author_Tenant : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "TenantId",
                table: "Authors",
                type: "uuid",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "Authors");
        }
    }
}
