using WebApi.Monitoring.Domain.Entities.Base;
using WebApi.Monitoring.Domain.Enums;
using WebApi.Monitoring.Domain.Interfaces.Base;

namespace WebApi.Monitoring.Domain.Entities
{
    public class ApiConfiguration : EntityBase<int>, IEntity
    {
        public APIAction ApiAction { get; private set; }

        public APITimeInterval ApiInterval { get; set; }

        public int Limit { get; set; }
    }
}
