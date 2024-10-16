using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTDK_CanHo_DaoCongTri.Models
{
    [Table("Contract")]
    public class Contract
    {
        [Key]
        public int ContractId { get; set; }
        public int ApartmentId { get; set; }
        public int CustomerId { get; set; }
        public string StartDate { get; set; } = string.Empty;
        public string EndDate { get; set; } = string.Empty;
        public decimal MonthlyRent { get; set; }
        public decimal DepositAmount { get; set; }
        public string ContractStatus { get; set; } = string.Empty;
        public bool RenewalOption { get; set; }

        [ForeignKey("ApartmentId")]
        public virtual Models.Apartment Apartment { get; set; }

        [ForeignKey("CustomerId")]
        public virtual Models.Customer Customer { get; set; }
    }
}
