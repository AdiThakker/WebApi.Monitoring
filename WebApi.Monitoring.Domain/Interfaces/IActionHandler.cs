using System;

namespace WebApi.Monitoring.Domain.Interfaces
{
    interface IActionHandler<TInput, TResult>
    {
        Tuple<bool, TResult> Handle(TInput input);
    }
}
