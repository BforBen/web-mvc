using System;
using System.Web;
using System.Web.Mvc;
using System.Linq;

namespace GuildfordBoroughCouncil.Web.Mvc
{
    // Source: http://blog.stevensanderson.com/2010/02/19/partial-validation-in-aspnet-mvc-2/
    public class ValidateOnlyIncomingValuesAttribute : System.Web.Mvc.ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var modelState = filterContext.Controller.ViewData.ModelState;
            var valueProvider = filterContext.Controller.ValueProvider;

            var keysWithNoIncomingValue = modelState.Keys.Where(x => !valueProvider.ContainsPrefix(x));
            foreach (var key in keysWithNoIncomingValue)
                modelState[key].Errors.Clear();
        }
    }
}
