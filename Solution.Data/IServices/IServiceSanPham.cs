using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SellingPhone.Aplication.Entities;

namespace Solution.Data.IServices
{
   public interface IServiceSanPham
    {
        List<Sanpham> GetlstBD();
        string Add(Sanpham hang);
        string Update(Sanpham hang);
        string Delete(Sanpham hang);
        string Save();
    }
}
