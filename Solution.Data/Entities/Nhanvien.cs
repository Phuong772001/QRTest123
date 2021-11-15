using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using SellingPhone.Aplication.Entities;

namespace Solution.Data.Entities
{
    [Table("NhanViens")]
    public class Nhanvien
    {
        [Key]
        public int IdNhanVien { get; set; }
        public string MaNV { get; set; }
        public int IDRole { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Diachi { get; set; }
        public string Phonenumber { get; set; }
        public byte[] Hinhanh { get; set; }
        public bool Sex { get; set; }
        public virtual Role Roles { get; set; }
        public virtual ICollection<HoaDon> HoaDons { get; set; }

    }
}
