using System;
using WebApi.Monitoring.Domain.Interfaces.Base;

namespace WebApi.Monitoring.Domain.Entities.Base
{
    public class EntityBase<T> : IEntity
    {
        public T Id { get; set; }

        public Byte[] TimeStamp { get; set; }
    }
}
