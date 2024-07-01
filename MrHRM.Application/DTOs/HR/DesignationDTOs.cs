using MrHRM.Application.DTOs.Common;

namespace MrHRM.Application.DTOs.HR
{
    public class DesignationDTOs : AuditableBaseEntityDTOs
    {
        public int DesignationId { get; set; }

        public string DesignationName { get; set; } = null!;
        public int CompanyID { get; set; }

        public ICollection<EmployeeDTOs> Employees { get; set; }

        public CompanyDTOs Company { get; set; }
    }
}
