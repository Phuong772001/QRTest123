using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SellingPhone.Aplication.Entities;

namespace Solution.Data.IServices
{
  public  interface IServiceDoPhanGiai
    {
        List<DoPhanGiai> GetlstBD();
        string Add(DoPhanGiai hang);
        string Update(DoPhanGiai hang);
        string Delete(DoPhanGiai hang);
        string Save();
    }
}
