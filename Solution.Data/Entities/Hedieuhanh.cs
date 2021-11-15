using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellingPhone.Aplication.Entities
{
    [Table("Hedieuhanhs")]
   public class Hedieuhanh
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Chitietsanpham> Chitietsanphams { get; set; }
    }
}
