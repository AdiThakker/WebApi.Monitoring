using System;
using WebApi.Monitoring.Domain.Enums;
using WebApi.Monitoring.Domain.Interfaces;
using WebApi.Monitoring.Domain.Interfaces.Repositories;

namespace WebApi.Monitoring.Domain.Handlers
{
    public class API_GetHandler : IActionHandler<int, string>
    {
        public Tuple<bool, string> Handle(int input)
        {
            var handleLimit = DependencyFactory.Get<IApiConfigurationRepository>().GetApiConfiguration(APIAction.API_Get)?.Limit;

            if (handleLimit != null)
                return new Tuple<bool, string>(true, $"Request handled. Limit returned {handleLimit}");

            return new Tuple<bool, string>(false, "Nothing yet!");
        }
    }
}
