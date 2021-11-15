using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Data.Entities
{
    public class Class1: Nhanvien
    {
        public override string ToString()
        {
            StringBuilder qrStr = new StringBuilder();
            qrStr.Append(Email);
            qrStr.Append(Password);
            return qrStr.ToString();
        }
    }
}
