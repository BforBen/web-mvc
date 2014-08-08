using System;
using System.Web;
using System.Web.Mvc;
using System.Linq;

namespace GuildfordBoroughCouncil.Web.Mvc
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public class ReplaceValidationErrorAttribute : System.Web.Mvc.ActionFilterAttribute
    {
        /// <summary>
        /// Comma seperated list of properties to suppres the error for
        /// </summary>
        public string Suppress { get; set; }

        /// <summary>
        /// The property to highlight instead
        /// </summary>
        public string Highlight { get; set; }

        /// <summary>
        /// The error message to display
        /// </summary>
        public string ErrorMessage { get; set; }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            bool DisplayError = false;

            var modelState = filterContext.Controller.ViewData.ModelState;

            string[] Values = Suppress.Split(',');

            foreach (var key in Values)
            {
                if (modelState[key].Errors.Count > 0)
                {
                    DisplayError = true;
                }
                modelState[key].Errors.Clear();
            }

            if (DisplayError)
            {
                modelState.AddModelError(Highlight, ErrorMessage);
            }
        }
    }
}
