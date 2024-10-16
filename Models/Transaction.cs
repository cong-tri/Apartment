using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTDK_CanHo_DaoCongTri.Models
{
    [Table("Transaction")]
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }
        public int ContractId { get; set; }
        public decimal Amount { get; set; }
        public string TransactionDate { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string TransactionType { get; set; } = string.Empty;
        public string PaymentMethod { get; set; } = string.Empty;
        public int IssuedBy { get; set; }

        [ForeignKey("ContractId")]
        public virtual Models.Contract Contract { get; set; }
    }
}
