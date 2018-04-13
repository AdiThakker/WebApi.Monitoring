using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApi.Monitoring.Domain;
using WebApi.Monitoring.Domain.Entities;
using WebApi.Monitoring.Domain.Enums;
using WebApi.Monitoring.Domain.Interfaces;
using WebApi.Monitoring.Domain.Interfaces.Repositories;
using WebApi.Monitoring.Infrastructure.Repositories;

namespace WebApi.Monitoring.Test
{
    [TestClass]
    public class MonitoringUnitTests
    {
        [TestInitialize]
        public void RegisterDependencies()
        {
            DependencyFactory.Set<ApiConfigurationRepository>(typeof(IApiConfigurationRepository), () => new ApiConfigurationRepository());
        }

        [TestMethod]
        public void Test_ApiGetActionIsHandled()
        {
            var apiConfigRepo = DependencyFactory.Get<IApiConfigurationRepository>();
            apiConfigRepo.Add(new ApiConfiguration() { ApiAction = APIAction.API_Get, ApiInterval = APITimeInterval.Day, Limit = 2 });
            
        }
    }
}
