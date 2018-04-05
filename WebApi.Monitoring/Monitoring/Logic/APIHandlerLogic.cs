using System;
using System.Linq;
using System.Reflection;
using WebApi.Monitoring.Monitoring.Enums;
using WebApi.Monitoring.Monitoring.Interfaces;

namespace WebApi.Monitoring.Monitoring.Logic
{
    public class APIHandlerLogic
    {
        public static Tuple<bool, string> Handle(APIActions action, int input)
        {
            // Get the Handler
            var instance = GetHandler<int, string>(action);

            // Check can execute
            if (instance == null)
                throw new InvalidOperationException();

            return instance.CanHandle(input);
        }

        private static IActionHandler<TInput, TResult> GetHandler<TInput, TResult>(APIActions action)
        {
            var handlerType = Assembly
                                .GetExecutingAssembly()
                                .GetTypes()
                                .Where(type => type.IsClass && typeof(IActionHandler<TInput, TResult>).IsAssignableFrom(type))
                                .FirstOrDefault(type => type.Name.Equals(string.Concat(Enum.GetName(typeof(APIActions), action), "Handler")));

            if (handlerType == null)
                throw new InvalidOperationException($"Invalid API Action: {Enum.GetName(typeof(APIActions), action)}. No handler found.");

            return Activator.CreateInstance(handlerType) as IActionHandler<TInput, TResult>;

        }
    }
}
