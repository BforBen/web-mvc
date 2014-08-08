using System;
using System.Web;
using System.Web.Mvc;
using System.Linq;

namespace GuildfordBoroughCouncil.Web.Mvc
{
    public class SuppressValidationErrorAttribute : System.Web.Mvc.ActionFilterAttribute
    {
        public string For { get; set; }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var modelState = filterContext.Controller.ViewData.ModelState;

            string[] Values = For.Split(',');

            foreach (var key in Values)
                modelState[key].Errors.Clear();
        }
    }
}
