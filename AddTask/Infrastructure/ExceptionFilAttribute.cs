using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace AddTask.Infrastructure
{
    public class ExceptionFilAttribute : ExceptionFilterAttribute
    {
        public override async Task OnExceptionAsync(ExceptionContext context)
        {
            var stream = new StreamWriter("File/text.txt", append: true);
            await stream.WriteLineAsync($"Произошла ошибка {context.Exception.Message} - {context.Exception.StackTrace} ");

            stream.Close();

            context.Result = new ViewResult() { ViewName = "Err" };
        }

    }
}
