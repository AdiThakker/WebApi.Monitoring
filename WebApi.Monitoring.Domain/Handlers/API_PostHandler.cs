using System;
using WebApi.Monitoring.Domain.Interfaces;

namespace WebApi.Monitoring.Domain.Handlers
{
    public class API_PostHandler : IActionHandler<int, string>
    {
        public Tuple<bool, string> Handle(int input)
        {
            return new Tuple<bool, string>(false, "Not allowed to Post!!!");
        }
    }
}
