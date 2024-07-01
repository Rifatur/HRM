using MrHRM.Domain.Entities.Common;
using MrHRM.Domain.Entities.HR;
using System.ComponentModel.DataAnnotations;

namespace MrHRM.Domain.Entities
{
    public class Company : AuditableBaseEntity
    {
        public int CompanyID { get; set; }
        [Required]
        [Length(3, 100)]
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

        public ICollection<Employee> Employees { get; set; }
        public ICollection<Department> Departments { get; set; }
        public ICollection<Designation> Designations { get; set; }
        public ICollection<Project> Projects { get; set; }
        public ICollection<Client> Clients { get; set; }

    }
}
