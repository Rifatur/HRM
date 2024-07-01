using MrHRM.Domain.Entities.Common;
using System.ComponentModel.DataAnnotations;

namespace MrHRM.Domain.Entities.HR
{
    public class Department : AuditableBaseEntity
    {
        [Key]
        public int DepartmentId { get; set; }

        [Required]
        [StringLength(100)]
        public string DepartmentName { get; set; } = string.Empty;
        public int CompanyID { get; set; }

        public ICollection<Employee> Employees { get; set; }

        public Company Company { get; set; }
    }
}
