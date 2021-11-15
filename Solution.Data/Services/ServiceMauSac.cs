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
   public class ServiceMauSac : IServiceMauSac
    {
        private DBSellingP _DBcontext;
        private List<Mausac> _lst;

        public ServiceMauSac()
        {
            _lst = new List<Mausac>();
            _DBcontext = new DBSellingP();
        }

        public string Add(Mausac hang)
        {
            try
            {
                _DBcontext.Mausacs.Add(hang);
                _lst.Add(hang);
                _DBcontext.SaveChanges();
                return "Thêm hàng thành công ";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public string Delete(Mausac MaHang)
        {
            try
            {
                _lst.RemoveAt(_lst.FindIndex(c => c.Id == MaHang.Id));
                _DBcontext.Mausacs.Remove(MaHang); Save();
                return "Xóa hàng thành công ";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public List<Mausac> GetlstBD()
        {
            try
            {
                return _lst = _DBcontext.Mausacs.ToList();
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

        public string Update(Mausac hang)
        {
            try
            {
                _DBcontext.Mausacs.Update(hang);
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
