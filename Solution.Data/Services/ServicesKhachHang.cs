using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SellingPhone.Aplication.DBContext;
using Solution.Data.Entities;

namespace Solution.Data.Services
{
    public class ServicesKhachHang
    {
        private List<Khachhang> _lstKhachHangs;
        private readonly DBSellingP _dbContext;
        public ServicesKhachHang()
        {

            _lstKhachHangs = new List<Khachhang>();
            _dbContext = new DBSellingP();
            DbDataKh();
        }
        public void DbDataKh()
        {
            _lstKhachHangs = _dbContext.Khachhangs.ToList();
        }

        public List<Khachhang> LayDataKh()
        {
            return _lstKhachHangs;
        }

        public string ThemKh(Khachhang khachHang)
        {
            _dbContext.Add(khachHang);
            _dbContext.SaveChanges();
            DbDataKh();
            return "Đã thêm!";
        }

        public string SuaKh(Khachhang khachHang)
        {
            _dbContext.Update(khachHang);
            _dbContext.SaveChanges();
            DbDataKh();
            return "Đã sửa!";
        }

        public string XoaKh(Khachhang khachHang)
        {
            _dbContext.Remove(khachHang);
            _dbContext.SaveChanges();
            DbDataKh();
            return "Đã xóa!";
        }

        public string LuuKh()
        {
            _dbContext.SaveChanges();
            DbDataKh();
            return "Đã lưu!";
        }
        public List<Khachhang> GetlstAccounts(string acc)
        {
            return _lstKhachHangs.Where(c => c.Hoten.StartsWith(acc)).ToList();
        }
    }
}
