using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SellingPhone.Aplication.Entities;

namespace BUS_Dienthoai.Model
{
   public class ChiTietSanPhamBUS
    {

        public Chitietsanpham Chitietsanpham { get; set; }

        public Sanpham Sanpham { get; set; }
        public string TenCTSP { get; set; }
        public string TenHangDT { get; set; }
        public string TenHeDieuHanh { get; set; }
        public string TenBoNho { get; set; }
        public string TenDoPhanGiai { get; set; }
        public string TenMau { get; set; }
        public string TenQuocGia { get; set; }



        public ChiTietSanPhamBUS()
        {
            
        }

        public ChiTietSanPhamBUS(Chitietsanpham chitietsanpham, Sanpham sanpham, string tenCtsp, string tenHangDt, string tenHeDieuHanh, string tenBoNho, string tenDoPhanGiai, string tenMau, string tenQuocGia)
        {
            Chitietsanpham = chitietsanpham;
            Sanpham = sanpham;
            TenCTSP = tenCtsp;
            TenHangDT = tenHangDt;
            TenHeDieuHanh = tenHeDieuHanh;
            TenBoNho = tenBoNho;
            TenDoPhanGiai = tenDoPhanGiai;
            TenMau = tenMau;
            TenQuocGia = tenQuocGia;
        }
    }
}
