using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SellingPhone.Aplication.Entities;

namespace Solution.Data.IServices
{
   public interface IServiceBoNho
    {
        List<Bonho> GetlstBD();
        string Add(Bonho hang);
        string Update(Bonho hang);
        string Delete(Bonho hang);
        string Save();
    }
}
