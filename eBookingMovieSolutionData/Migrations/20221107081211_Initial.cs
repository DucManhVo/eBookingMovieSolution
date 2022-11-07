using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eBookingMovieSolutionData.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppConfigs",
                columns: table => new
                {
                    Key = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppConfigs", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "DonHang",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Thoigiantao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonHang", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ghe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Loaighe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soghe = table.Column<int>(type: "int", nullable: false),
                    Thoigian = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Trangthai = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ghe", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KhuyenMai",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tensukien = table.Column<int>(type: "int", maxLength: 200, nullable: false),
                    Ngaybatdau = table.Column<int>(type: "int", nullable: false),
                    Ngayketthuc = table.Column<int>(type: "int", nullable: false),
                    Tylekhuyenmai = table.Column<int>(type: "int", nullable: false),
                    Giatrikhuyenmai = table.Column<int>(type: "int", nullable: false),
                    VeId = table.Column<int>(type: "int", nullable: false),
                    PhanloaiId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhuyenMai", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LienHe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Sodienthoai = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Tinnhan = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LienHe", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PhanLoai",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Sapxep = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhanLoai", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Phim",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Anh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tenphim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ngayphathanh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Soluotxem = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phim", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PhimInPhanloai",
                columns: table => new
                {
                    PhimId = table.Column<int>(type: "int", nullable: false),
                    PhanloaiId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhimInPhanloai", x => new { x.PhimId, x.PhanloaiId });
                    table.ForeignKey(
                        name: "FK_PhimInPhanloai_PhanLoai_PhanloaiId",
                        column: x => x.PhanloaiId,
                        principalTable: "PhanLoai",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhimInPhanloai_Phim_PhimId",
                        column: x => x.PhimId,
                        principalTable: "Phim",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ve",
                columns: table => new
                {
                    PhimId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GheId = table.Column<int>(type: "int", nullable: false),
                    Gia = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Giagoc = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Soluong = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    Trangthai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ve", x => x.PhimId);
                    table.ForeignKey(
                        name: "FK_Ve_Ghe_GheId",
                        column: x => x.GheId,
                        principalTable: "Ghe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ve_Phim_PhimId",
                        column: x => x.PhimId,
                        principalTable: "Phim",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietDonHang",
                columns: table => new
                {
                    DonhangId = table.Column<int>(type: "int", nullable: false),
                    VeId = table.Column<int>(type: "int", nullable: false),
                    Soluong = table.Column<int>(type: "int", nullable: false),
                    Gia = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietDonHang", x => new { x.DonhangId, x.VeId });
                    table.ForeignKey(
                        name: "FK_ChiTietDonHang_DonHang_DonhangId",
                        column: x => x.DonhangId,
                        principalTable: "DonHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietDonHang_Ve_VeId",
                        column: x => x.VeId,
                        principalTable: "Ve",
                        principalColumn: "PhimId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Giohangs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VeId = table.Column<int>(type: "int", nullable: false),
                    Soluong = table.Column<int>(type: "int", nullable: false),
                    Gia = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Giohangs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Giohangs_Ve_VeId",
                        column: x => x.VeId,
                        principalTable: "Ve",
                        principalColumn: "PhimId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietDonHang_VeId",
                table: "ChiTietDonHang",
                column: "VeId");

            migrationBuilder.CreateIndex(
                name: "IX_Giohangs_VeId",
                table: "Giohangs",
                column: "VeId");

            migrationBuilder.CreateIndex(
                name: "IX_PhimInPhanloai_PhanloaiId",
                table: "PhimInPhanloai",
                column: "PhanloaiId");

            migrationBuilder.CreateIndex(
                name: "IX_Ve_GheId",
                table: "Ve",
                column: "GheId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppConfigs");

            migrationBuilder.DropTable(
                name: "ChiTietDonHang");

            migrationBuilder.DropTable(
                name: "Giohangs");

            migrationBuilder.DropTable(
                name: "KhuyenMai");

            migrationBuilder.DropTable(
                name: "LienHe");

            migrationBuilder.DropTable(
                name: "PhimInPhanloai");

            migrationBuilder.DropTable(
                name: "DonHang");

            migrationBuilder.DropTable(
                name: "Ve");

            migrationBuilder.DropTable(
                name: "PhanLoai");

            migrationBuilder.DropTable(
                name: "Ghe");

            migrationBuilder.DropTable(
                name: "Phim");
        }
    }
}
