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
    [Table("Quocgias")]
   public class Quocgia
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Chitietsanpham> Chitietsanphams { get; set; }
    }
}
