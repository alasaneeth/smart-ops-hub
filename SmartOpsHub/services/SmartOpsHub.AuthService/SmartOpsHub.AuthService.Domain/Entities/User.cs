using SmartOpsHub.AuthService.Domain.Common;
using SmartOpsHub.AuthService.Domain.Enums;

namespace SmartOpsHub.AuthService.Domain.Entities;

public class User : BaseEntity
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
    public UserRole Role { get; set; } = UserRole.User;
    public bool IsActive { get; set; } = true;
    public string? ProfilePicture { get; set; }
    public DateTime? LastLoginAt { get; set; }
}