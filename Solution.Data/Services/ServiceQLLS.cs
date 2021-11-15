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
   public class ServiceQLLS:IserviceLS
    {
        private List<Lichsu> _lstLichsus;
        private DBSellingP _dbcontext;

        public ServiceQLLS()
        {
            _lstLichsus = new List<Lichsu>();
            _dbcontext = new DBSellingP();
            GetlistformDBH();
        }

        public void GetlistformDBH()
        {
            _lstLichsus = _dbcontext.Lichsus.ToList();

        }

        public List<Lichsu> GetlistnvNhanviens()
        {
            return _lstLichsus;
        }
       
        public string AddHLS(Lichsu ls)
        {
            _lstLichsus.Add(ls);
            _dbcontext.Add(ls);
            _dbcontext.SaveChanges();
            return "Thêm thành công";
        }
        public string updateHLS(Lichsu ls)
        {
            _dbcontext.Update(ls);
            _dbcontext.SaveChanges();
            return "Sửa thành công";
        }
        public string Deletenv(Lichsu id)
        {
            _lstLichsus.RemoveAt(_lstLichsus.FindIndex(c => c.Email == id.Email));
            _dbcontext.Remove(id);
            return "Xóa thành công";
        }
        public string Savenv()
        {
            _dbcontext.SaveChanges();
            return "luu thanh cong";
        }
    }
}
