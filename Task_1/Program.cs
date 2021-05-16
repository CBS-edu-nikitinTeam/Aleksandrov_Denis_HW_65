using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

/*
          Задание 1
       Создайте фильтр, который будет считать количество уникальных пользователей, выполнивших
       запрос к веб приложению. Информацию о количестве пользователей фильтр должен 
       записывать в файл.
 */

namespace Task_1
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
