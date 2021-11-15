using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SellingPhone.Aplication.Entities;

namespace Solution.Data.IServices
{
   public interface IServiceChiTietSanPham
    {
        List<Chitietsanpham> GetlstBD();
        string Add(Chitietsanpham hang);
        string Update(Chitietsanpham hang);
        string Delete(Chitietsanpham hang);
        string Save();
    }
}
