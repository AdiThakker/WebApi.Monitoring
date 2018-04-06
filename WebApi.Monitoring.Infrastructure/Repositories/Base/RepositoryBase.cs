using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using WebApi.Monitoring.Domain.Interfaces.Base;
using WebApi.Monitoring.Infrastructure.EntityFramework;

namespace WebApi.Monitoring.Infrastructure.Repositories.Base
{
    public abstract class RepositoryBase<T> : IRepository<T> where T : class, IEntity
    {
        private bool disposed = false;
        protected readonly ApiContext ApiContext;

        protected RepositoryBase(ApiContext context) => this.ApiContext = context ?? throw new ArgumentNullException(nameof(context));

        public T Add(T entity)
        {
            this.ApiContext.Set<T>().Add(entity);
            this.ApiContext.SaveChanges();
            return entity;
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAllWhere(Expression<Func<T, bool>> matchExpression)
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public T GetSingleWhere(Expression<Func<T, bool>> matchExpression)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }

        #region IDisposable Support

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                this.ApiContext.Dispose();
                // Free any other managed objects here. (if any)

            }

            // Free any unmanaged objects here. (if any)

            disposed = true;
        }

        #endregion
    }
}
