using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SellingPhone.Aplication.DBContext;
using SellingPhone.Aplication.Entities;
using Solution.Data.IServices;

namespace Solution.Data.Services
{
    public class ServiceSanPham : IServiceSanPham
    {
        private DBSellingP _DBcontext;
        private List<Sanpham> _lst;

        public ServiceSanPham()
        {
            _lst = new List<Sanpham>();
            _DBcontext = new DBSellingP();
            GetlstBD();

        }

        public string Add(Sanpham hang)
        {
            try
            {
                _DBcontext.Sanphams.Add(hang);
                _lst.Add(hang);
                _DBcontext.SaveChanges();
                return "Thêm hàng thành công ";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public string Delete(Sanpham MaHang)
        {
            try
            {
                _lst.RemoveAt(_lst.FindIndex(c => c.Id == MaHang.Id));
                _DBcontext.Sanphams.Remove(MaHang); Save();
                return "Xóa hàng thành công ";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public List<Sanpham> GetlstBD()
        {
            try
            {
                return _lst = _DBcontext.Sanphams.ToList();
            }
            catch (Exception e)
            {
                return null;
            }

        }
        public string Save()
        {
            try
            {
                _DBcontext.SaveChanges();
                return "Lưu dữ liệu thành công";
            }
            catch (Exception e)
            {
                return e + "";
            }
        }

        public string Update(Sanpham hang)
        {
            try
            {
                _DBcontext.Sanphams.Update(hang);
                _DBcontext.SaveChanges();
                return "Cập nhật thành công";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

    }
}
