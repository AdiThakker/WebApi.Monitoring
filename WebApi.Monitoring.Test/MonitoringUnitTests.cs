using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApi.Monitoring.Domain;
using WebApi.Monitoring.Domain.Entities;
using WebApi.Monitoring.Domain.Enums;
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
        public void Verify_ApiConfiguration_DoesNot_Exist()
        {
            var configRepository = DependencyFactory.Get<IApiConfigurationRepository>();
            var configuration = configRepository.GetApiConfiguration(APIAction.API_Get);
            Assert.IsNull(configuration);
        }

        [TestMethod]
        public void Verify_ApiConfiguration_Exists()
        {
            var configRepository = DependencyFactory.Get<IApiConfigurationRepository>();
            configRepository.Add(new ApiConfiguration() { ApiAction = APIAction.API_Get, ApiInterval = APITimeInterval.Day, Limit = 2 });
            var configuration = configRepository.GetApiConfiguration(APIAction.API_Get);
            Assert.IsTrue(configuration.Limit == 2);
        }
    }
}
