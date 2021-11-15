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
   public class ServiceBoNho : IServiceBoNho
    {
        private DBSellingP _DBcontext;
        private List<Bonho> _lst;

        public ServiceBoNho()
        {
            _lst = new List<Bonho>();
            _DBcontext = new DBSellingP();
        }

        public string Add(Bonho hang)
        {
            try
            {
                _DBcontext.Bonhos.Add(hang);
                _lst.Add(hang);
                _DBcontext.SaveChanges();
                return "Thêm hàng thành công ";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public string Delete(Bonho MaHang)
        {
            try
            {
                _lst.RemoveAt(_lst.FindIndex(c => c.Id == MaHang.Id));
                _DBcontext.Bonhos.Remove(MaHang);
                Save();
                return "Xóa hàng thành công ";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public List<Bonho> GetlstBD()
        {
            try
            {
                return _lst = _DBcontext.Bonhos.ToList();
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

        public string Update(Bonho hang)
        {
            try
            {
                _DBcontext.Bonhos.Update(hang);
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
