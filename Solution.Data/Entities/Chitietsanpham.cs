using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solution.Data.Entities;

namespace SellingPhone.Aplication.Entities
{
    [Table("Chitietsanphams")]
   public class Chitietsanpham
    {
        [Key]
        public int IDChitietsp { get; set; }
        [Key]
        public int IDSanPham { get; set; }
        [Key]
        public int IDQuocgia { get; set; }
        [Key]
        public int IDMausac { get; set; }
        [Key]
        public int IDBonho { get; set; }
        [Key]
        public int IDDophangiai { get; set; }
        [Key]
        public int IDHedieuhanh { get; set; }
        public float Gia { get; set; }
        public int Soluong { get; set; }
        //[ForeignKey("IDSanPham")]
        public virtual Sanpham Sanphams { get; set; }
       // [ForeignKey("IDQuocgia")]
        public virtual Quocgia Quocgias { get; set; }
        //[ForeignKey("IDMausac")]
        public virtual Mausac Mausacs { get; set; }
       // [ForeignKey("IDBonho")]
        public virtual Bonho Bonhos { get; set; }
        //[ForeignKey("IDDophangiai")]
        public virtual DoPhanGiai DoPhanGiais { get; set; }
       // [ForeignKey("IDHedieuhanh")]
        public virtual Hedieuhanh Hedieuhanhs { get; set; }
        public virtual ICollection<Chitiethoadon> Chitiethoadons { get; set; }
    }
}
