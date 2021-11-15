using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SellingPhone.Aplication.Entities;
using Solution.Data.Entities;

namespace BUS_Dienthoai.IServices
{
    public interface IserviceQuanLiNhanVien
    {
        public List<Role> GetlistRoles();
        public void getlistDB();
        public List<Nhanvien> getlistNV();
        public bool ThemNV(Nhanvien nv);
        public string Sua(Nhanvien nv);
        public string Xoa(int temp);
        public List<Nhanvien> TimKiem(string ten);
        public string GetHash(string plainText);
    }
}
