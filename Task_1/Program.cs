using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

/*
          ������� 1
       �������� ������, ������� ����� ������� ���������� ���������� �������������, �����������
       ������ � ��� ����������. ���������� � ���������� ������������� ������ ������ 
       ���������� � ����.
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
