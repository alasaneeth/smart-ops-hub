using SmartOpsHub.AuthService.Domain.Common;

namespace SmartOpsHub.AuthService.Domain.Entities;

public class AuditLog : BaseEntity
{
    public Guid UserId { get; set; }
    public string Action { get; set; } = string.Empty;
    public string? IpAddress { get; set; }
    public string? UserAgent { get; set; }
    public bool IsSuccess { get; set; } = true;

    // Navigation Property
    public User User { get; set; } = null!;
}