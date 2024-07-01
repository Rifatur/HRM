using MrHRM.Domain.Entities.Common;
using System.ComponentModel.DataAnnotations;

namespace MrHRM.Domain.Entities.HR
{
    public class Client : AuditableBaseEntity
    {
        [Key]
        public int ClientID { get; set; }
        public int CompanyID { get; set; }
        [Required]
        [StringLength(100)]
        public string ClientName { get; set; } = null!;
        public string ContactPerson { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? ZipCode { get; set; }
        public string? Industry { get; set; }
        public decimal? AnnualRevenue { get; set; }
        public int? NumberOfEmployees { get; set; }
        public DateTime? ContractStartDate { get; set; }
        public DateTime? ContractEndDate { get; set; }

        public Company Company { get; set; }
    }
}
