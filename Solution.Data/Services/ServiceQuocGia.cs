using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SellingPhone.Aplication.DBContext;
using SellingPhone.Aplication.Entities;
using Solution.Data.Entities;
using Solution.Data.IServices;

namespace Solution.Data.Services
{
   public class ServiceQuocGia : IServiceQuocGia
    {
        private DBSellingP _DBcontext;
        private List<Quocgia> _lst;

        public ServiceQuocGia()
        {
            _lst = new List<Quocgia>();
            _DBcontext = new DBSellingP();
        }

        public string Add(Quocgia hang)
        {
            try
            {
                _DBcontext.Quocgias.Add(hang);
                _lst.Add(hang);
                _DBcontext.SaveChanges();
                return "Thêm hàng thành công ";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public string Delete(Quocgia MaHang)
        {
            try
            {
                _lst.RemoveAt(_lst.FindIndex(c => c.Id == MaHang.Id));
                _DBcontext.Quocgias.Remove(MaHang); Save();
                return "Xóa hàng thành công ";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public List<Quocgia> GetlstBD()
        {
            try
            {
                return _lst = _DBcontext.Quocgias.ToList();
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

        public string Update(Quocgia hang)
        {
            try
            {
                _DBcontext.Quocgias.Update(hang);
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
