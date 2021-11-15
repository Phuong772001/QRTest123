using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SellingPhone.Aplication.Entities;

namespace Solution.Data.IServices
{
   public interface IServiceHeDieuHanh
    {
        List<Hedieuhanh> GetlstBD();
        string Add(Hedieuhanh hang);
        string Update(Hedieuhanh hang);
        string Delete(Hedieuhanh hang);
        string Save();
    }
}
