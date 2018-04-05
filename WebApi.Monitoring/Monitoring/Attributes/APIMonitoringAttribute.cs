using Microsoft.AspNetCore.Mvc.Filters;
using WebApi.Monitoring.Monitoring.Enums;
using WebApi.Monitoring.Monitoring.Logic;

namespace WebApi.Monitoring.Monitoring.Attributes
{
    public class APIMonitoringAttribute : ActionFilterAttribute
    {
        public APIActions ApiAction { get; private set; }

        public APIMonitoringAttribute(APIActions apiAction)
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
