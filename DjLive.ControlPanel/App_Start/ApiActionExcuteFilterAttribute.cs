using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace DjLive.ControlPanel
{
    public class ApiActionExcuteFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            //����Action���Խ��д���
            base.OnActionExecuting(actionContext);
        }

        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            base.OnActionExecuted(actionExecutedContext);
        }
    }
}