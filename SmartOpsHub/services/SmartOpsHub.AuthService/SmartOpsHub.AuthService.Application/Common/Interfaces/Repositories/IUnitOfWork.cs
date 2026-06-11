using SmartOpsHub.AuthService.Application.Common.Interfaces.Repositories;

namespace SmartOpsHub.AuthService.Application.Common.Interfaces;

public interface IUnitOfWork : IDisposable
{
    IUserRepository Users { get; }
    IRefreshTokenRepository RefreshTokens { get; }
    Task<int> SaveChangesAsync();
}