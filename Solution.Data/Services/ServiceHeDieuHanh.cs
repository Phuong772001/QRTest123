using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SellingPhone.Aplication.DBContext;
using SellingPhone.Aplication.Entities;
using Solution.Data.IServices;

namespace Solution.Data.Services
{
  public  class ServiceHeDieuHanh : IServiceHeDieuHanh
    {
        private DBSellingP _DBcontext;
        private List<Hedieuhanh> _lst;

        public ServiceHeDieuHanh()
        {
            _lst = new List<Hedieuhanh>();
            _DBcontext = new DBSellingP();
        }

        public string Add(Hedieuhanh hang)
        {
            try
            {
                _DBcontext.Hedieuhanhs.Add(hang);
                _lst.Add(hang);
                _DBcontext.SaveChanges();
                return "Thêm hàng thành công ";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public string Delete(Hedieuhanh MaHang)
        {
            try
            {
                _lst.RemoveAt(_lst.FindIndex(c => c.Id == MaHang.Id));
                _DBcontext.Hedieuhanhs.Remove(MaHang); Save();
                return "Xóa hàng thành công ";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public List<Hedieuhanh> GetlstBD()
        {
            try
            {
                return _lst = _DBcontext.Hedieuhanhs.ToList();
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

        public string Update(Hedieuhanh hang)
        {
            try
            {
                _DBcontext.Hedieuhanhs.Update(hang);
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
