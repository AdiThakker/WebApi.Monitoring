using System;
using WebApi.Monitoring.Domain.Entities;
using WebApi.Monitoring.Domain.Enums;
using WebApi.Monitoring.Domain.Interfaces;
using WebApi.Monitoring.Infrastructure.EntityFramework;
using WebApi.Monitoring.Infrastructure.Repositories.Base;

namespace WebApi.Monitoring.Infrastructure.Repositories
{
    public class ApiConfigurationRepository : RepositoryBase<ApiConfiguration>, IApiConfigurationRepository
    {
        protected ApiConfigurationRepository(ApiContext context)
            : base(context)
        {
        }

        public ApiConfiguration GetApiConfiguration(APIAction action)
        {
            return this.GetSingleWhere(item => Enum.GetName(typeof(APIAction), item.ApiAction.ToString()).Equals(action.ToString()));
        }
    }
}
