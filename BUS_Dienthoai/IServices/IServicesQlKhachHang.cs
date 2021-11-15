using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solution.Data.Entities;

namespace BUS_Dienthoai.IServices
{
    public interface IServicesQlKhachHang
    {
        public List<Khachhang> TimKiem(string ten);
        public void getlisDb();
        public List<Khachhang> listkh();
        public string ThemKh(Khachhang khachHang);
        public string XoaKh(Khachhang khachHang);
        public string SuaKh(Khachhang khachHang);
        public string LuuKh();
    }
}
