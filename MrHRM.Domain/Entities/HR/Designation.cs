using MrHRM.Domain.Entities.Common;
using System.ComponentModel.DataAnnotations;

namespace MrHRM.Domain.Entities.HR
{
    public class Designation : AuditableBaseEntity
    {
        [Key]
        public int DesignationId { get; set; }

        [Required]
        [StringLength(100)]
        public string DesignationName { get; set; } = null!;
        public int CompanyID { get; set; }

        public ICollection<Employee> Employees { get; set; }

        public Company Company { get; set; }
    }
}
