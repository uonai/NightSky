using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace NightSky
{
    class DbInitializer
    {
        public static void Initialize(MyDbContext context, IServiceProvider services)
        {
            var logger = services.GetRequiredService<ILogger<DbInitializer>>();

            context.Database.EnsureCreated();
        //    var stars = File.ReadLines(@"StarData.csv").Select(a => a.Split(';'));
       //     logger.LogInformation(stars.ToString());

            //if (context.Universe.Any())
          //  {
         //       logger.LogInformation("Db already seeded");
          //      return;
         //   }

            logger.LogInformation("Begin seeding db");



            var star = new Star
            {
           
                hip = 1234
            };


            context.Universe.Add(star);
            context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[Universe] ON");

            context.SaveChanges();

        //    context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[Universe] OFF");


            logger.LogInformation("Done seeding db");

        }
    }
}
