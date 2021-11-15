using System.Collections.Generic;
using BUS_Dienthoai.IServices;
using Solution.Data.Entities;
using Solution.Data.Services;

namespace BUS_Dienthoai.Services
{
    public class ServicesQlKhachHang : IServicesQlKhachHang
    {
        
        private  ServicesKhachHang _iServicesKhachHang;
        private List<Khachhang> _khachhangs;

        public ServicesQlKhachHang()
        {
            _iServicesKhachHang = new ServicesKhachHang();

            _khachhangs = new List<Khachhang>();
            _khachhangs = _iServicesKhachHang.LayDataKh();
        }
        public void getlisDb()
        {
            _khachhangs = new List<Khachhang>();
            _khachhangs = _iServicesKhachHang.LayDataKh();

        }

        public List<Khachhang> listkh()
        {
            return _khachhangs;
        }
        public string ThemKh(Khachhang khachHang)
        {
            return _iServicesKhachHang.ThemKh(khachHang);
        }

        public string XoaKh(Khachhang khachHang)
        {
            return _iServicesKhachHang.XoaKh(khachHang);
        }

        public string SuaKh(Khachhang khachHang)
        {
            return _iServicesKhachHang.SuaKh(khachHang);
        }

        public string LuuKh()
        {
            return _iServicesKhachHang.LuuKh();
        }
        public List<Khachhang> TimKiem(string ten)
        {
            return _iServicesKhachHang.GetlstAccounts(ten);
        }
    }
}