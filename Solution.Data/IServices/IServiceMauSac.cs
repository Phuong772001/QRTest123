using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SellingPhone.Aplication.Entities;
using Solution.Data.Entities;

namespace Solution.Data.IServices
{
   public interface IServiceMauSac
    {
        List<Mausac> GetlstBD();
        string Add(Mausac hang);
        string Update(Mausac hang);
        string Delete(Mausac hang);
        string Save();
    }
}
