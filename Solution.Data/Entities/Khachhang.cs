using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Data.Entities
{
    [Table("Khachhangs")]
   public class Khachhang : IEnumerable
   {
        [Key]
        public int MaKH { get; set; }
        public string Hoten { get; set; }
        public string Diachi { get; set; }
        public string Sdt { get; set; }
        public virtual ICollection<HoaDon> HoaDons { get; set; }
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
   }
}
