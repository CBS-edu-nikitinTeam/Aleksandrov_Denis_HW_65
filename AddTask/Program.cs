using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

/*
        Задание
    Создайте веб приложение и фильтр действия, который будет записывать в файл имя метода 
    действия и время обращения к нему. При этом фильтр может быть применен к любому методу 
    действия приложения.
*/

namespace AddTask
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
