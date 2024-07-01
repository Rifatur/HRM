using MrHRM.Application.DTOs.Common;

namespace MrHRM.Application.DTOs.HR
{
    public class CompanyDTOs : AuditableBaseEntityDTOs
    {
        public int CompanyID { get; set; }
        public string CompanyName { get; set; } = null!;
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? ZipCode { get; set; }
        public string? Country { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? Website { get; set; }
        public string? Industry { get; set; }
        public DateTime? FoundedDate { get; set; }

        public ICollection<EmployeeDTOs> Employees { get; set; }
        public ICollection<DepartmentDTOs> Departments { get; set; }
        public ICollection<DesignationDTOs> Designations { get; set; }
        //public ICollection<ProjectDTOs> Projects { get; set; }
        public ICollection<ClientDTOs> Clients { get; set; }
    }
}
