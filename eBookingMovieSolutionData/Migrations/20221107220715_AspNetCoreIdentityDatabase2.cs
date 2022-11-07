using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eBookingMovieSolutionData.Migrations
{
    public partial class AspNetCoreIdentityDatabase2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Thanhtoan_AppUsers_AppUserId",
                table: "Thanhtoan");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Thanhtoan",
                table: "Thanhtoan");

            migrationBuilder.DropIndex(
                name: "IX_Thanhtoan_AppUserId",
                table: "Thanhtoan");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Thanhtoan");

            migrationBuilder.RenameTable(
                name: "Thanhtoan",
                newName: "Thanhtoans");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Thanhtoans",
                table: "Thanhtoans",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Thanhtoans_UserId",
                table: "Thanhtoans",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Thanhtoans_AppUsers_UserId",
                table: "Thanhtoans",
                column: "UserId",
                principalTable: "AppUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Thanhtoans_AppUsers_UserId",
                table: "Thanhtoans");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Thanhtoans",
                table: "Thanhtoans");

            migrationBuilder.DropIndex(
                name: "IX_Thanhtoans_UserId",
                table: "Thanhtoans");

            migrationBuilder.RenameTable(
                name: "Thanhtoans",
                newName: "Thanhtoan");

            migrationBuilder.AddColumn<Guid>(
                name: "AppUserId",
                table: "Thanhtoan",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Thanhtoan",
                table: "Thanhtoan",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Thanhtoan_AppUserId",
                table: "Thanhtoan",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Thanhtoan_AppUsers_AppUserId",
                table: "Thanhtoan",
                column: "AppUserId",
                principalTable: "AppUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
