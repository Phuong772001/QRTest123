using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SellingPhone.Aplication.Entities;

namespace Solution.Data.Entities
{
    [Table("Hoadons")]
    public class HoaDon
    {
        [Key]
        public string MaHD { get; set; }
        public int IdKhachhang { get; set; }
        public int IdnhanVien { get; set; }
        public virtual Khachhang Khachhangs { get; set; }
        public virtual Nhanvien Nhanviens { get; set; }
        public DateTime Ngaylaphoadon { get; set; }
        public virtual ICollection<Chitiethoadon> Chitiethoadons { get; set; }
    }
}
