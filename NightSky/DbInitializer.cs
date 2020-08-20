using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace NightSky
{
    class DbInitializer
    {
        public static void Initialize(MyDbContext context, IServiceProvider services)
        {
            var logger = services.GetRequiredService<ILogger<DbInitializer>>();

            context.Database.EnsureCreated();

            if (context.Universe.Any())
            {
                logger.LogInformation("Db already seeded");
                return;
            }

            logger.LogInformation("Begin seeding db");

            var star = new Star
            {
                id = 123,
                hip = 1234
            };

            context.Universe.Add(star);
            context.SaveChanges();

            logger.LogInformation("Done seeding db");

        }
    }
}
