using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTDK_CanHo_DaoCongTri.Models
{
    [Table("Type")]
    public class Type
    {
        [Key]
        public int TypeId { get; set; }
        public string TypeName { get; set; } = string.Empty;
        public virtual ICollection<Apartment> Apartments { get; set; }
    }
}
