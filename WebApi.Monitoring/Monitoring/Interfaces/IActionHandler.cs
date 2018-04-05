using System;

namespace WebApi.Monitoring.Monitoring.Interfaces
{
    interface IActionHandler<TInput, TResult>
    {
        Tuple<bool, TResult> CanHandle(TInput input);
    }
}
