using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FirstMVCApp.Controllers
{
    public class LogCallActionFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            Debug.WriteLine("On action Executing " + DateTime.Now);
            Debug.WriteLine(context.Controller.ToString());
            Debug.WriteLine("-------------------");
        }
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            Debug.WriteLine("On action Executed " + DateTime.Now);
            Debug.WriteLine(context.Result.ToString());
            Debug.WriteLine("--------Over-----------");
        }
    }
}
