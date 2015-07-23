using System.Web.Mvc;

namespace GuildfordBoroughCouncil.Web.Mvc
{
    public class CustomViewResult : PartialViewResult
    {
        protected override ViewEngineResult FindView(ControllerContext context)
        {
            ViewEngineResult result = ViewEngines.Engines.FindView(context, "", null);

            if (result.View != null)
            {
                return result;
            }

            return base.FindView(context);
        }
    }
}
