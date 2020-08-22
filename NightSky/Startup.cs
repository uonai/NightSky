using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace NightSky
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }

        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            //  var connection = Configuration.GetConnectionString("DefaultConnection") ?? "testingconnection";
            var connection = "";
            services.AddDbContext<MyDbContext>(options => options.UseSqlServer("Server=DESKTOP-32N87F3\\MSSQLSERVER01;Database=master;Trusted_Connection=True;MultipleActiveResultSets=true"));
            return services.BuildServiceProvider();
        }


        public void Configure(IServiceProvider serviceProvider)
        {

            serviceProvider.GetService<MyDbContext>();

        }
    }


}


