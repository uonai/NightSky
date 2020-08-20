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
            var connection = "Server=localhost\\MSSQLSERVER01;Database=master;Trusted_Connection=True;";
            services.AddDbContext<MyDbContext>(options => options.UseSqlServer(connection));
            return services.BuildServiceProvider();
        }

        public void Configure(IServiceProvider serviceProvider)
        {

            serviceProvider.GetService<MyDbContext>();

        }
    }


}


