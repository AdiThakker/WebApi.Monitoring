using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace WebApi.Monitoring.Domain.Interfaces.Base
{
    public interface IRepository<T> : IDisposable where T : IEntity
    {
        T GetById(int id);

        T GetSingleWhere(Expression<Func<T, bool>> matchExpression);

        IEnumerable<T> GetAll();

        IEnumerable<T> GetAllWhere(Expression<Func<T, bool>> matchExpression);

        T Add(T entity);

        void Update(T entity);

        void Delete(T entity);
    }
}
