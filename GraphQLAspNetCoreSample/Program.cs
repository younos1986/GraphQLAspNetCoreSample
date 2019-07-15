using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DomainModel.Models;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace GraphQLAspNetCoreSample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateWebHostBuilder(args).Build();



            //using (IServiceScope scope = host.Services.CreateScope())
            //{
            //    TestContext context = scope.ServiceProvider.GetRequiredService<TestContext>();

            //    var authorDbEntry = context.ProductCategories.Add(
            //      new ProductCategory
            //      {
            //          Id  = 1,
            //          Name = " First Category ",
            //      }
            //    );

            //    context.SaveChanges();

            //    context.Products.AddRange(
            //      new Product()
            //      {
            //          ProductCategoryId = 1  , 
            //          ProductName = "prodcutName 1"
            //      },
            //      new Product()
            //      {
            //          ProductCategoryId = 1,
            //          ProductName = "prodcutName 2"
            //      }
            //    );

            //    context.SaveChanges();
            //}



            host.Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
