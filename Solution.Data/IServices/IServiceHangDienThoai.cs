using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SellingPhone.Aplication.Entities;
using Solution.Data.Entities;

namespace Solution.Data.IServices
{
  public  interface IServiceHangDienThoai
    {
        List<HangDT> GetlstBD();
        string Add(HangDT hang);
        string Update(HangDT hang);
        string Delete(HangDT hang);
        string Save();
    }
}
