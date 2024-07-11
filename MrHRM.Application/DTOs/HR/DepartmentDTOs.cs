using MrHRM.Application.DTOs.Common;

namespace MrHRM.Application.DTOs.HR
{
    public class DepartmentDTOs : AuditableBaseEntityDTOs
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; } = string.Empty;
        public int CompanyID { get; set; }


    }
}
