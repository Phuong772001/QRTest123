using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_Dienthoai.IServices
{
    public interface ILoginService
    {
        public bool login(string email, string pass);
    }
}
