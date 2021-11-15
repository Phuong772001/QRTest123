using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BUS_Dienthoai.IServices;
using SellingPhone.Aplication.Entities;
using Solution.Data.Entities;
using Solution.Data.IServices;
using Solution.Data.Services;

namespace BUS_Dienthoai.Services
{
    public class ServiceQuanLiLichSu:IserviceQLLS
    {
        private IserviceLS _serviceLs;
        private List<Lichsu> _lstLichsus;

        public ServiceQuanLiLichSu()
        {
            _serviceLs = new ServiceQLLS();
            _lstLichsus = new List<Lichsu>();
            getlistDB();
        }


        public void getlistDB()
        {
            _lstLichsus = new List<Lichsu>();
            _lstLichsus = _serviceLs.GetlistnvNhanviens();
        }
        public List<Lichsu> getlistLS()
        {
            return _lstLichsus;
        }
        public string SaveLS()
        {
            return _serviceLs.Savenv();
        }
        public bool ThemNV(Lichsu nv)
        {
            _serviceLs.AddHLS(nv);
            return true;
        }
        public string Sua(Lichsu nv)
        {
            _serviceLs.updateHLS(nv);
            return "sửa thành công";
        }
        public string Xoa(int temp)
        {
            var nv = _serviceLs.GetlistnvNhanviens().Where(c => c.id == temp).FirstOrDefault();
            _serviceLs.Deletenv(nv);
            return "Xoa thành công";
        }

    }
}
