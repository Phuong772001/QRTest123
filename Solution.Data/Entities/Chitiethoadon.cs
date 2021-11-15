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
    [Table("Chitiethoadons")]
   public class Chitiethoadon
    {
        [Key]
        public int ID { get; set; }
        public string MaHD { get; set; }
        public int Idchitiet { get; set; }
        public virtual HoaDon HoaDons { get; set; }
        public int Soluong { get; set; }
        public int Dongiaban { get; set; }
        public float Tongtien { get; set; }
        public virtual Chitietsanpham Chitietsanphams { get; set; }
        

    }
}
