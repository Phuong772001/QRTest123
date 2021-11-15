using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Solution.Data.Migrations
{
    public partial class nmmm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bonhos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bonhos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DoPhanGiais",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoPhanGiais", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HangDTs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HangDTs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hedieuhanhs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hedieuhanhs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Khachhangs",
                columns: table => new
                {
                    MaKH = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Hoten = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diachi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sdt = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Khachhangs", x => x.MaKH);
                });

            migrationBuilder.CreateTable(
                name: "Lichsus",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaNV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tenNV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoigianBatdau = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ThoigianketT = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lichsus", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Mausacs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mausacs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Quocgias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quocgias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sanphams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdHang = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mota = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Imei = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hinhanh = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sanphams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sanphams_HangDTs_IdHang",
                        column: x => x.IdHang,
                        principalTable: "HangDTs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NhanViens",
                columns: table => new
                {
                    IdNhanVien = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaNV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IDRole = table.Column<int>(type: "int", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diachi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phonenumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hinhanh = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Sex = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanViens", x => x.IdNhanVien);
                    table.ForeignKey(
                        name: "FK_NhanViens_Roles_IDRole",
                        column: x => x.IDRole,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Chitietsanphams",
                columns: table => new
                {
                    IDChitietsp = table.Column<int>(type: "int", nullable: false),
                    IDSanPham = table.Column<int>(type: "int", nullable: false),
                    IDQuocgia = table.Column<int>(type: "int", nullable: false),
                    IDMausac = table.Column<int>(type: "int", nullable: false),
                    IDBonho = table.Column<int>(type: "int", nullable: false),
                    IDDophangiai = table.Column<int>(type: "int", nullable: false),
                    IDHedieuhanh = table.Column<int>(type: "int", nullable: false),
                    Gia = table.Column<float>(type: "real", nullable: false),
                    Soluong = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chitietsanphams", x => new { x.IDBonho, x.IDChitietsp, x.IDDophangiai, x.IDHedieuhanh, x.IDMausac, x.IDSanPham, x.IDQuocgia });
                    table.UniqueConstraint("AK_Chitietsanphams_IDChitietsp", x => x.IDChitietsp);
                    table.ForeignKey(
                        name: "FK_Chitietsanphams_Bonhos_IDBonho",
                        column: x => x.IDBonho,
                        principalTable: "Bonhos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Chitietsanphams_DoPhanGiais_IDDophangiai",
                        column: x => x.IDDophangiai,
                        principalTable: "DoPhanGiais",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Chitietsanphams_Hedieuhanhs_IDHedieuhanh",
                        column: x => x.IDHedieuhanh,
                        principalTable: "Hedieuhanhs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Chitietsanphams_Mausacs_IDMausac",
                        column: x => x.IDMausac,
                        principalTable: "Mausacs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Chitietsanphams_Quocgias_IDQuocgia",
                        column: x => x.IDQuocgia,
                        principalTable: "Quocgias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Chitietsanphams_Sanphams_IDSanPham",
                        column: x => x.IDSanPham,
                        principalTable: "Sanphams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Hoadons",
                columns: table => new
                {
                    MaHD = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdKhachhang = table.Column<int>(type: "int", nullable: false),
                    IdnhanVien = table.Column<int>(type: "int", nullable: false),
                    Ngaylaphoadon = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hoadons", x => x.MaHD);
                    table.ForeignKey(
                        name: "FK_Hoadons_Khachhangs_IdKhachhang",
                        column: x => x.IdKhachhang,
                        principalTable: "Khachhangs",
                        principalColumn: "MaKH",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Hoadons_NhanViens_IdnhanVien",
                        column: x => x.IdnhanVien,
                        principalTable: "NhanViens",
                        principalColumn: "IdNhanVien",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Chitiethoadons",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaHD = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Idchitiet = table.Column<int>(type: "int", nullable: false),
                    Soluong = table.Column<int>(type: "int", nullable: false),
                    Dongiaban = table.Column<int>(type: "int", nullable: false),
                    Tongtien = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chitiethoadons", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Chitiethoadons_Chitietsanphams_Idchitiet",
                        column: x => x.Idchitiet,
                        principalTable: "Chitietsanphams",
                        principalColumn: "IDChitietsp",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Chitiethoadons_Hoadons_MaHD",
                        column: x => x.MaHD,
                        principalTable: "Hoadons",
                        principalColumn: "MaHD",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Chitiethoadons_Idchitiet",
                table: "Chitiethoadons",
                column: "Idchitiet");

            migrationBuilder.CreateIndex(
                name: "IX_Chitiethoadons_MaHD",
                table: "Chitiethoadons",
                column: "MaHD");

            migrationBuilder.CreateIndex(
                name: "IX_Chitietsanphams_IDDophangiai",
                table: "Chitietsanphams",
                column: "IDDophangiai");

            migrationBuilder.CreateIndex(
                name: "IX_Chitietsanphams_IDHedieuhanh",
                table: "Chitietsanphams",
                column: "IDHedieuhanh");

            migrationBuilder.CreateIndex(
                name: "IX_Chitietsanphams_IDMausac",
                table: "Chitietsanphams",
                column: "IDMausac");

            migrationBuilder.CreateIndex(
                name: "IX_Chitietsanphams_IDQuocgia",
                table: "Chitietsanphams",
                column: "IDQuocgia");

            migrationBuilder.CreateIndex(
                name: "IX_Chitietsanphams_IDSanPham",
                table: "Chitietsanphams",
                column: "IDSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_Hoadons_IdKhachhang",
                table: "Hoadons",
                column: "IdKhachhang");

            migrationBuilder.CreateIndex(
                name: "IX_Hoadons_IdnhanVien",
                table: "Hoadons",
                column: "IdnhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_NhanViens_IDRole",
                table: "NhanViens",
                column: "IDRole");

            migrationBuilder.CreateIndex(
                name: "IX_Sanphams_IdHang",
                table: "Sanphams",
                column: "IdHang");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Chitiethoadons");

            migrationBuilder.DropTable(
                name: "Lichsus");

            migrationBuilder.DropTable(
                name: "Chitietsanphams");

            migrationBuilder.DropTable(
                name: "Hoadons");

            migrationBuilder.DropTable(
                name: "Bonhos");

            migrationBuilder.DropTable(
                name: "DoPhanGiais");

            migrationBuilder.DropTable(
                name: "Hedieuhanhs");

            migrationBuilder.DropTable(
                name: "Mausacs");

            migrationBuilder.DropTable(
                name: "Quocgias");

            migrationBuilder.DropTable(
                name: "Sanphams");

            migrationBuilder.DropTable(
                name: "Khachhangs");

            migrationBuilder.DropTable(
                name: "NhanViens");

            migrationBuilder.DropTable(
                name: "HangDTs");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
