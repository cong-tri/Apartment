using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTDK_CanHo_DaoCongTri.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeId { get; set; }

        [Required]
        [StringLength(255)]
        public string EmployeeName { get; set; } = string.Empty;

        [Required]
        [StringLength(255)]
        public string EmployeePosition { get; set; } = string.Empty;

        [Required]
        [StringLength(255)]
        public string EmployeePhone { get; set; } = string.Empty;

        [Required]
        [StringLength(255)]
        [EmailAddress]
        public string EmployeeEmail { get; set; } = string.Empty;

        [Required]
        public string EmployeeHireDate { get; set; } = string.Empty;

        [Required]
        public decimal EmployeeSalary { get; set; }

        [Required]
        [StringLength(255)]
        public string EmployeeDepartment { get; set; } = string.Empty;
    }
}
