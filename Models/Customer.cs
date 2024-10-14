using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTDK_CanHo_DaoCongTri.Models
{
    [Table("Customers")]
    public class Customer
    {
        [Key]

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerId { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [StringLength(255)]
        public string Phone { get; set; } = string.Empty;

        [Required]
        [StringLength(255)]
        public string Email { get; set; } = string.Empty;

        [Required]
        [StringLength(255)]
        public string Address { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        public string Dateofbirth { get; set; } = string.Empty;

        [Required]
        [StringLength(255)]
        public string IdentificationNumber { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        public string Customersince { get; set; } = string.Empty;
        public virtual ICollection<Models.Users> Users { get; set; }
    }
}
