using FufuLauncher.Models;

namespace FufuLauncher.Contracts.Services;

public interface IUnifiedCheckinService
{
    Task<UnifiedCheckinResult> ExecuteAllCheckinsAsync();
}
