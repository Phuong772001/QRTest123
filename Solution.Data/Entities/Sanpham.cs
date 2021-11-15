using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellingPhone.Aplication.Entities
{
    [Table("Sanphams")]
    public class Sanpham
    {
        [Key]
        public int Id { get; set; }
        public int IdHang { get; set; }
        public virtual HangDT HangDts { get; set; }
        public string Name { get; set; }
        public string Mota { get; set; }
        public string Imei { get; set; }
        public byte[] Hinhanh { get; set; }
        public virtual ICollection<Chitietsanpham> Chitietsanphams { get; set; }
    }
}
