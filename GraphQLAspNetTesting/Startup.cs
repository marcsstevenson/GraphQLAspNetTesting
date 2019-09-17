using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQLAspNetTesting.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace GraphQLAspNetTesting
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddDbContext<OrderingContext>(options =>
                //options.UseSqlServer("")
                options.UseInMemoryDatabase("GraphQlTesting")
                );
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, OrderingContext orderingContext)
        {
            app.UseMvc();
            orderingContext.Seed();

            var productCount = orderingContext.Products.Count();
            var ordersCount = orderingContext.Orders.Count();
            var customerCount = orderingContext.Customers.Count();

            var test = orderingContext.Customers.ToList();
        }
    }
}
