using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Data.Entities
{
    [Table("Lichsus")]
   public class Lichsu
    {
        [Key]
        public int id { get; set; }
        public string MaNV { get; set; }
        public string Email { get; set; }
        public string tenNV { get; set; }
        public DateTime ThoigianBatdau { get; set; }
        public DateTime ThoigianketT { get; set; }
    }
}
