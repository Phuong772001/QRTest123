using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solution.Data.Entities;

namespace Solution.Data.IServices
{
   public interface IServiceQuocGia
    {
        List<Quocgia> GetlstBD();
        string Add(Quocgia hang);
        string Update(Quocgia hang);
        string Delete(Quocgia hang);
        string Save();
    }
}
