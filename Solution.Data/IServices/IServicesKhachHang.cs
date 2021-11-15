using System.Collections.Generic;
using Solution.Data.Entities;

namespace Solution.Data.IDALServices
{
    public interface IServicesKhachHang
    {

        public List<Khachhang> GetlstAccounts(string acc);
        public void DbDataKh();
        public List<Khachhang> LayDataKh();
        public string ThemKh(Khachhang khachHang);
        public string SuaKh(Khachhang khachHang);
        public string XoaKh(Khachhang khachHang);
        public string LuuKh();
    }
}