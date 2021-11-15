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
  public  class ServiceHangDienThoai : IServiceHangDienThoai
    {
        private DBSellingP _DBcontext;
        private List<HangDT> _lst;

        public ServiceHangDienThoai()
        {
            _lst = new List<HangDT>();
            _DBcontext = new DBSellingP();
            GetlstBD();

        }

        public string Add(HangDT hang)
        {
            try
            {
                _DBcontext.HangDts.Add(hang);
                _lst.Add(hang);
                _DBcontext.SaveChanges();
                return "Thêm hàng thành công ";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public string Delete(HangDT MaHang)
        {
            try
            {
                _lst.RemoveAt(_lst.FindIndex(c => c.Id == MaHang.Id));
                _DBcontext.HangDts.Remove(MaHang); Save();
                return "Xóa hàng thành công ";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public List<HangDT> GetlstBD()
        {
            try
            {
                return _lst = _DBcontext.HangDts.ToList();
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

        public string Update(HangDT hang)
        {
            try
            {
                _DBcontext.HangDts.Update(hang);
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
