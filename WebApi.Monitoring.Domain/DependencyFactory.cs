using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace WebApi.Monitoring.Domain
{
    public static class DependencyFactory
    {
        private static ConcurrentDictionary<Type, Func<object>> _lookup = new ConcurrentDictionary<Type, Func<object>>();

        public static void Set<TType>(Type key, Func<TType> create) where TType : class, new()
        {
            if (key == null)
                throw new ArgumentNullException(nameof(key));

            if (create == null)
                throw new ArgumentNullException(nameof(create));


            _lookup.AddOrUpdate(key, create, (index, createFunc) => createFunc);
        }

        public static TResult Get<TResult>() where TResult : Type
        {
            var func = _lookup.GetValueOrDefault(typeof(TResult));

            if (func == null)
                throw new InvalidOperationException($"No dependency registered for {typeof(TResult)}");

            return (TResult)func();
        }
    }
}
