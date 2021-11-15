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
    public class ServiceNhanVien:IServiceNhanVien
    {
        private List<Nhanvien> _lstNhanviens;
        private List<Role> _lstrRoles;
        private DBSellingP _dbcontext;

        public ServiceNhanVien()
        {
            _lstNhanviens = new List<Nhanvien>();
            _dbcontext = new DBSellingP();
            _lstrRoles = new List<Role>();
            GetlistformDBH();
        }
        public void GetlistformDBH()
        {
            _lstNhanviens = _dbcontext.Nhanviens.ToList();
            _lstrRoles = _dbcontext.Roles.ToList();
            
        }

        public List<Nhanvien> GetlistnvNhanviens()
        {
            return _lstNhanviens;
        }
        public List<Role> Getlistroles()
        {
            return _lstrRoles;
        }
        public string AddHnhanvien(Nhanvien hang)
        {
            _lstNhanviens.Add(hang);
            _dbcontext.Add(hang);
            _dbcontext.SaveChanges();
            return "Thêm thành công";
        }
        public string Updatenhanvien(Nhanvien hang)
        {
            _dbcontext.Update(hang);
            _dbcontext.SaveChanges();
            return "sua thành công";
        }
        public string Deletenv(Nhanvien id)
        {
            _lstNhanviens.RemoveAt(_lstNhanviens.FindIndex(c => c.Email == id.Email));
            _dbcontext.Remove(id);
            _dbcontext.SaveChanges();
            return "Xóa thành công";
        }
        public List<Nhanvien> GetlstAccounts(string acc)
        {
            return _lstNhanviens.Where(c => c.FullName.Contains(acc)||c.Phonenumber.Contains(acc)).ToList();
        }
    }
}
