using System;
using WebApi.Monitoring.Monitoring.Interfaces;

namespace WebApi.Monitoring.Monitoring.Handlers
{
    public class API_PostHandler : IActionHandler<int, string>
    {
        public Tuple<bool, string> CanHandle(int input)
        {
            throw new NotImplementedException();
        }
    }
}
