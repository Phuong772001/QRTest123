using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using BUS_Dienthoai.IServices;
using SellingPhone.Aplication.Entities;
using Solution.Data.Entities;
using Solution.Data.IServices;
using Solution.Data.Services;

namespace BUS_Dienthoai.Services
{
    public class ServiceQuanLiNhanVien:IserviceQuanLiNhanVien
    {
        private IServiceNhanVien _nhanVien;
        private List<Nhanvien> _lstNhanViens;
        private List<Role> _lstRoles;

        public ServiceQuanLiNhanVien()
        {
            _nhanVien = new ServiceNhanVien();
            _lstNhanViens = new List<Nhanvien>();
            _lstNhanViens = _nhanVien.GetlistnvNhanviens();
            _lstRoles = _nhanVien.Getlistroles();
        }

        public void getlistDB()
        {
            _lstNhanViens = new List<Nhanvien>();
            _lstNhanViens = _nhanVien.GetlistnvNhanviens();
            _lstRoles = new List<Role>();
            _lstRoles = _nhanVien.Getlistroles();
        }
        public List<Nhanvien> getlistNV()
        {
            return _lstNhanViens;
        }
        public List<Role> GetlistRoles()
        {
            return _lstRoles;
        }
        public bool ThemNV(Nhanvien nv)
        {
            _nhanVien.AddHnhanvien(nv);
            return true;
        }
        public string Sua(Nhanvien nv)
        {
            _nhanVien.Updatenhanvien(nv);
            return "sửa thành công";
        }

        public string Xoa(int temp)
        {
            var nv = _nhanVien.GetlistnvNhanviens().Where(c => c.IdNhanVien == temp).FirstOrDefault();
            _nhanVien.Deletenv(nv);
            return "Xoa thành công";
        }

        public List<Nhanvien> TimKiem(string ten)
        {
            return _nhanVien.GetlstAccounts(ten);
        }
        public string GetHash(string plainText)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            // Compute hash from the bytes of text
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(plainText));
            // Get hash result after compute it
            byte[] result = md5.Hash;
            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                strBuilder.Append(result[i].ToString("x2"));
            }
            return strBuilder.ToString();
        }
    }
}
