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
  public  class ServiceDoPhanGiai : IServiceDoPhanGiai
    {
        private DBSellingP _DBcontext;
        private List<DoPhanGiai> _lst;

        public ServiceDoPhanGiai()
        {
            _lst = new List<DoPhanGiai>();
            _DBcontext = new DBSellingP();
        }

        public string Add(DoPhanGiai hang)
        {
            try
            {
                _DBcontext.DoPhanGiais.Add(hang);
                _lst.Add(hang);
                _DBcontext.SaveChanges();
                return "Thêm hàng thành công ";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public string Delete(DoPhanGiai MaHang)
        {
            try
            {
                _lst.RemoveAt(_lst.FindIndex(c => c.Id == MaHang.Id));
                _DBcontext.DoPhanGiais.Remove(MaHang);
                Save();
                return "Xóa hàng thành công ";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public List<DoPhanGiai> GetlstBD()
        {
            try
            {
                return _lst = _DBcontext.DoPhanGiais.ToList();
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

        public string Update(DoPhanGiai hang)
        {
            try
            {
                _DBcontext.DoPhanGiais.Update(hang);
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
