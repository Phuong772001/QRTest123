using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SellingPhone.Aplication.Entities;
using Solution.Data.Entities;

namespace Solution.Data.IServices
{
    public interface IServiceNhanVien
    {
        public void GetlistformDBH();
        public List<Nhanvien> GetlistnvNhanviens();
        public string Deletenv(Nhanvien id);
        public string Updatenhanvien(Nhanvien hang);
        public string AddHnhanvien(Nhanvien hang);
        public List<Nhanvien> GetlstAccounts(string acc);
        public List<Role> Getlistroles();

    }
}
