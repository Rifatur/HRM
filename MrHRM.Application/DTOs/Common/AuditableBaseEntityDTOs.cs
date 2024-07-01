namespace MrHRM.Application.DTOs.Common
{
    public class AuditableBaseEntityDTOs
    {
        public string? CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public string? LastModifiedBy { get; set; }
        public DateTime LastModified { get; set; } = DateTime.UtcNow;
    }
}
