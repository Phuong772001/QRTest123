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
    [Table("Roles")]
   public class Role
    {
        [Key]
        public int Id { get; set; }
        [StringLength(30)]
        public string Name { get; set; }
        public virtual ICollection<Nhanvien> Nhanviens { get; set; }
    }
}
