using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace KTDK_CanHo_DaoCongTri.Models
{
    [Table("Users")]
    public class Users
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        [Required]
        public int CustomerId { get; set; }

        [Required]
        [StringLength(255)]
        public string Username { get; set; } = string.Empty;

        [Required]
        [StringLength(255)]
        public string Password { get; set; } = string.Empty;

        [Required]
        [StringLength(10)]
        public string Role { get; set; } = string.Empty;

        [Required]
        [StringLength(255)]
        public string Fullname { get; set; } = string.Empty;

        [Required]
        [StringLength(255)]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string LastLoginDate { get; set; } = string.Empty;

        [ForeignKey("CustomerId")]
        public virtual DbSet<Models.Customer> Customers { get; set; }
    }
}
