using MrHRM.Domain.Entities.Common;
using System.ComponentModel.DataAnnotations;

namespace MrHRM.Domain.Entities.HR
{
    public class Project : AuditableBaseEntity
    {
        [Key]
        public int ProjectID { get; set; }
        public int CompanyID { get; set; }
        [Required]
        [StringLength(200)]
        public string ProjectName { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Budget { get; set; }
        public int DepartmentID { get; set; }
        public int ProjectManagerID { get; set; }
        public string Status { get; set; } = null!;
        [Required]
        [StringLength(200)]
        public string Description { get; set; } = null!;
        public int ClientID { get; set; }
        public decimal CompletionPercentage { get; set; }

        public Company Company { get; set; }
        public Department Department { get; set; }
        public Employee ProjectManager { get; set; }
        public Client Client { get; set; }
    }
}
