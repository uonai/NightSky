using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NightSkyPopulateDatabase;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace NightSky
{
   public  class DbInitializer
    {

     
        public static void Initialize(MyDbContext context, IServiceProvider services)
        {
            var logger = services.GetRequiredService<ILogger<DbInitializer>>();

            context.Database.EnsureCreated();
        //    var stars = File.ReadLines(@"StarData.csv").Select(a => a.Split(';'));
       //     logger.LogInformation(stars.ToString());

            if (context.Universe.Any() && context.Users.Any())
            {
                logger.LogInformation("Db already seeded");
                return;
            }

            logger.LogInformation("Begin seeding db");

            string csvFile = @"C:\Users\csmcc\source\repos\NightSky\NightSky\StarData.csv";
            string[] lines = File.ReadAllLines(csvFile); 

            var query = from star in lines
                        let data = star.Split(',')
                        select new Star
                        {

                            //hip = Int32.Parse(data[1]),
                            //hd = Int32.Parse(data[2]),
                            hr = data[3],
                            gl = data[4],
                            bf = data[5],
                            proper = data[6],
                            //ra = Int32.Parse(data[7]),
                            //dec = Int32.Parse(data[8]),
                            //dist = Int32.Parse(data[9]),
                            //pmra = Int32.Parse(data[10]),
                            //pmdec = Int32.Parse(data[11]),
                            //rv = Int32.Parse(data[12]),
                            //mag = Int32.Parse(data[13]),
                            //absmag = Int32.Parse(data[14]),
                            //spect = Int32.Parse(data[15]),
                            //ci = Int32.Parse(data[16]),
                            //x = Int32.Parse(data[17]),
                            //y = Int32.Parse(data[18]),
                            //z = Int32.Parse(data[19]),
                            //vx = Int32.Parse(data[20]),
                            //vy = Int32.Parse(data[21]),
                            //vz = Int32.Parse(data[22]),
                            //rarad = Int32.Parse(data[23]),
                            //decrad = Int32.Parse(data[24]),
                            //pmrarad = Int32.Parse(data[25]),
                            //pmdecrad = Int32.Parse(data[26]),
                            //bayer = data[27],
                            //flam = data[28],
                            //con = data[29],
                            //comp = Int32.Parse(data[30]),
                            //comp_primary = Int32.Parse(data[31]),
                            //lum = Int32.Parse(data[32]),
                            //var_min = Int32.Parse(data[33]),
                            //var_max = Int32.Parse(data[34]),
                         };

            foreach (Star star in query)
            {
                context.Universe.Add(star);
                Console.WriteLine(star);
            }

            var user = new User
            {
                emailAddress = "testuser@gmail.com",
                password = "test123",
                role = 1
            };

            context.Users.Add(user);

          //  context.Universe.Add(star);
          //  context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[Universe] ON");

            context.SaveChanges();

          //  context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[Universe] OFF");


            logger.LogInformation("Done seeding db");

        }
    }
}
