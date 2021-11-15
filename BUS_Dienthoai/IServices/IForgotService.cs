using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_Dienthoai.IServices
{
    public interface IForgotService
    {
        public string RandomString(int size, bool lowerCase);
        public int randomNumber(int min, int max);
        public string maHoa(string pass);
        public bool SendMail(string email, string pass);
        public void updatePass(string email, string newpass);
    }
}
