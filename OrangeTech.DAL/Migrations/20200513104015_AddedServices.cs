using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OrangeTech.DAL.Migrations
{
    public partial class AddedServices : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Works_WorkId",
                table: "Images");

            migrationBuilder.AlterColumn<Guid>(
                name: "WorkId",
                table: "Images",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ServiceId",
                table: "Images",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    ServiceId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ShortDescription = table.Column<string>(nullable: true),
                    FullDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.ServiceId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Images_ServiceId",
                table: "Images",
                column: "ServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Services_ServiceId",
                table: "Images",
                column: "ServiceId",
                principalTable: "Services",
                principalColumn: "ServiceId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Works_WorkId",
                table: "Images",
                column: "WorkId",
                principalTable: "Works",
                principalColumn: "WorkId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Services_ServiceId",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_Works_WorkId",
                table: "Images");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropIndex(
                name: "IX_Images_ServiceId",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "ServiceId",
                table: "Images");

            migrationBuilder.AlterColumn<Guid>(
                name: "WorkId",
                table: "Images",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Works_WorkId",
                table: "Images",
                column: "WorkId",
                principalTable: "Works",
                principalColumn: "WorkId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
