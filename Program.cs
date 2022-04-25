using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication5x5
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
                    //webBuilder.UseStartup<Startup>();

                    int k = 1;
                    int direction = 0;
                    int iteration = 0;

                    int SIZE_X = 5, SIZE_Y = 5;

                    int[,] arr = new int[SIZE_Y, SIZE_X];

                    for (int n = 0; k <= SIZE_X * SIZE_Y; n++)
                    {
                        direction = n % 4;
                        iteration = n / 4;
                        switch (direction)
                        {
                            case 0:
                                for (int j = iteration; j < SIZE_X - iteration; j++, k++)
                                {
                                    arr[iteration, j] = k;
                                }
                                break;
                            case 1:
                                for (int i = iteration + 1; i < SIZE_Y - iteration; i++, k++)
                                {
                                    arr[i, SIZE_X - iteration - 1] = k;
                                }
                                break;
                            case 2:
                                for (int j = SIZE_X - iteration - 2; j >= iteration; j--, k++)
                                {
                                    arr[SIZE_Y - iteration - 1, j] = k;
                                }
                                break;
                            case 3:
                                for (int i = SIZE_Y - iteration - 2; i > iteration; i--, k++)
                                {
                                    arr[i, iteration] = k;
                                }
                                break;
                        }
                    }
                    for (int i = 0; i < SIZE_Y; i++)
                    {
                        int j = 0;
                        if (arr[i, j] < 10)
                        {
                            Console.Write("");
                        }
                        Console.Write(arr[i, j] + " ");
                    }
                    Console.WriteLine("");

                });



    }
}
