using System;
using System.IO;
using Microsoft.AspNetCore.Mvc.Filters;

namespace AddTask.Infrastructure
{
    public class ActionFilAttribute : ActionFilterAttribute
    {
        private StreamWriter stream;
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            stream = new StreamWriter("File/text.txt", append: true);
            stream.WriteLine($"Время начала работы фильтра {DateTime.Now.ToLongTimeString()} ");
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            stream.WriteLine($"Время завершения работы фильтра {DateTime.Now.ToLongTimeString()} ");
            stream.Close();
        }
    }
}
