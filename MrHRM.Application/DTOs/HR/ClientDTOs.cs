using MrHRM.Application.DTOs.Common;

namespace MrHRM.Application.DTOs.HR
{
    public class ClientDTOs : AuditableBaseEntityDTOs
    {
        public int ClientID { get; set; }
        public int CompanyID { get; set; }
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
        public CompanyDTOs Company { get; set; }

    }
}
