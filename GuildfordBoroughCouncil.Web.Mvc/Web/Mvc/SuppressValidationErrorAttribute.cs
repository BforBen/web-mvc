using System.Web.Mvc;

namespace GuildfordBoroughCouncil.Web.Mvc
{
    public class SuppressValidationErrorAttribute : ActionFilterAttribute
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
