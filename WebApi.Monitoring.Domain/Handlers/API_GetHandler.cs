using System;
using WebApi.Monitoring.Domain.Interfaces;

namespace WebApi.Monitoring.Domain.Handlers
{
    public class API_GetHandler : IActionHandler<int, string>
    {
        public Tuple<bool, string> CanHandle(int input)
        {
            return new Tuple<bool, string>(false, "Nothing yet!");
        }
    }
}
