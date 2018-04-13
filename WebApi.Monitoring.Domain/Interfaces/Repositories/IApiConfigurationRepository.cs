using WebApi.Monitoring.Domain.Entities;
using WebApi.Monitoring.Domain.Enums;
using WebApi.Monitoring.Domain.Interfaces.Base;

namespace WebApi.Monitoring.Domain.Interfaces.Repositories
{
    public interface IApiConfigurationRepository : IRepository<ApiConfiguration>
    {
        ApiConfiguration GetApiConfiguration(APIAction action);
    }
}
