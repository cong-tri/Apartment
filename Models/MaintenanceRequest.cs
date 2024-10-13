using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;

namespace KTDK_CanHo_DaoCongTri.Models
{
    [Table("MaintenanceRequest")]
    public class MaintenanceRequest
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RequestId { get; set; }

        [Required]
        //[ForeignKey("ApartmentId")]
        public int ApartmentId { get; set; }

        [Required]
        //[ForeignKey("EmployeeId")]
        public int EmployeeId { get; set; }

        [Required]
        [StringLength(255)]
        public string RequestDescription { get; set; } = string.Empty;

        [Required]
        [StringLength(255)]
        public string RequestDate { get; set; } = string.Empty;

        [Required]
        [StringLength(255)]
        public string RequestStatus { get; set; } = string.Empty;

        [Required]
        public DateTime RequestCompletionDate { get; set; }

        [Required]
        public decimal RequestCost { get; set; }

        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }

        [ForeignKey("ApartmentId")]
        public virtual Apartment Apartment { get; set; }
    }
}
