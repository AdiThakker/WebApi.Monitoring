using Microsoft.AspNetCore.Mvc.Filters;
using WebApi.Monitoring.Domain.Enums;
using WebApi.Monitoring.Domain.Logic;

namespace WebApi.Monitoring.Attributes
{
    public class APIMonitoringAttribute : ActionFilterAttribute
    {
        public APIAction ApiAction { get; private set; }

        public APIMonitoringAttribute(APIAction apiAction)
        {
            this.ApiAction = apiAction;
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            // Get Handler 
            APIHandlerLogic.Handle(this.ApiAction, 1);

            base.OnActionExecuting(context);
        }
    }
}
