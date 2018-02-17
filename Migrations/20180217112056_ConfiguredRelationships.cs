using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace WebApiJwt.Migrations
{
    public partial class ConfiguredRelationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Schools_SchoolId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Events_EventId1",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_EventId1",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "EventId1",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "TicketId",
                table: "Events");

            migrationBuilder.AlterColumn<Guid>(
                name: "EventId",
                table: "Tickets",
                type: "char(36)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "SchoolId",
                table: "Events",
                type: "char(36)",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_EventId",
                table: "Tickets",
                column: "EventId");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Schools_SchoolId",
                table: "Events",
                column: "SchoolId",
                principalTable: "Schools",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Events_EventId",
                table: "Tickets",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Schools_SchoolId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Events_EventId",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_EventId",
                table: "Tickets");

            migrationBuilder.AlterColumn<string>(
                name: "EventId",
                table: "Tickets",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "char(36)");

            migrationBuilder.AddColumn<Guid>(
                name: "EventId1",
                table: "Tickets",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<Guid>(
                name: "SchoolId",
                table: "Events",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "char(36)",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "TicketId",
                table: "Events",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_EventId1",
                table: "Tickets",
                column: "EventId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Schools_SchoolId",
                table: "Events",
                column: "SchoolId",
                principalTable: "Schools",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Events_EventId1",
                table: "Tickets",
                column: "EventId1",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
