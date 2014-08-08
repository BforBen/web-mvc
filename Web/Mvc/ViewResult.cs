using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
