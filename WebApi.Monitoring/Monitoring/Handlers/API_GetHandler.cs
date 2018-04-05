using System;
using WebApi.Monitoring.Monitoring.Interfaces;

namespace WebApi.Monitoring.Monitoring.Handlers
{
    public class API_GetHandler : IActionHandler<int, string>
    {
        public Tuple<bool, string> CanHandle(int input)
        {
            throw new NotImplementedException();
        }
    }
}
