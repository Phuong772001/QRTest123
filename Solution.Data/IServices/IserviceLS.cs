using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solution.Data.Entities;

namespace Solution.Data.IServices
{
    public interface IserviceLS
    {
        public void GetlistformDBH();
        public List<Lichsu> GetlistnvNhanviens();
        public string AddHLS(Lichsu ls);
        public string Deletenv(Lichsu id);
        public string Savenv();
        public string updateHLS(Lichsu ls);
    }
}
