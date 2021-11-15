using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BUS_Dienthoai.IServices;

namespace BUS_Dienthoai.Services
{
    public class LoginService:IServices.ILoginService
    {
        private IserviceQuanLiNhanVien _iQLyNhanVienService;

        public LoginService()
        {
            _iQLyNhanVienService = new ServiceQuanLiNhanVien();
            _iQLyNhanVienService.getlistDB();
        }

        public bool login(string email, string pass)
        {
            _iQLyNhanVienService.getlistDB();
            if (_iQLyNhanVienService.getlistNV().Any(c=>c.Email==email && c.Password==pass))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
