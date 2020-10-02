﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace final_poject.Migrations
{
    public partial class ChatHubMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Userİd",
                table: "Messages");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Userİd",
                table: "Messages",
                nullable: true);
        }
    }
}
