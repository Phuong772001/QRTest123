using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solution.Data.Entities;

namespace BUS_Dienthoai.IServices
{
    public interface IserviceQLLS
    {
        public void getlistDB();

        public List<Lichsu> getlistLS();

        public string SaveLS();

        public bool ThemNV(Lichsu nv);

        public string Xoa(int temp);
        public string Sua(Lichsu nv);

    }
}
