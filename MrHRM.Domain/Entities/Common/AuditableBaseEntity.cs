namespace MrHRM.Domain.Entities.Common
{
    public abstract class AuditableBaseEntity
    {
        public string? CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public string? LastModifiedBy { get; set; }
        public DateTime LastModified { get; set; } = DateTime.UtcNow;
    }
}
