using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTDK_CanHo_DaoCongTri.Models
{
    [Table("Apartment")]
    public class Apartment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ApartmentId { get; set; }

        [Required]
        //[ForeignKey("Type")]
        public int TypeId { get; set; }

        [Required]
        [StringLength(255)]
        public string ApartmentNumber { get; set; } = string.Empty;

        [Required]
        [StringLength(255)]
        public string ApartmentName { get; set; } = string.Empty;

        [Required]
        public int ApartmentFloor { get; set; }

        [Required]
        public double ApartmentArea { get; set; } 

        [Required]
        [StringLength(255)]
        public string ApartmentStatus { get; set; } = string.Empty;

        [Required]
        public int ApartmentRoomCount { get; set; }

        [Required]
        [StringLength(2)]
        [RegularExpression("^[FT]$", ErrorMessage = "Must be 'F' or 'T'")]
        public string ApartmentHasBalcony { get; set; } = string.Empty;

        [Required]
        public decimal ApartmentMonthlyRentPrice { get; set; }

        [ForeignKey("TypeId")]
        public virtual DbSet<Models.Type> Type { get; set; }

    }
}
