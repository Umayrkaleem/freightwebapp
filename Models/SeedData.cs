using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using freightWebApp.Data;
using System;
using System.Linq;

namespace freightWebApp.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new freightWebAppContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<freightWebAppContext>>()))
            {
                // Look for any freight.
                if (context.Freight.Any())
                {
                    return;   // DB has been seeded
                }

                context.Freight.AddRange(
                    new Freight
                    {
                        BrokerName = "Landstar",
                        Date = DateTime.Parse("2020-2-12"),
                        Commodity = "Oil pump",
                        Linehaul = 1500
                    },

                    new Freight
                    {
                        BrokerName = "XPO Logistics",
                        Date = DateTime.Parse("2020-3-13"),
                        Commodity = "Military Aircraft",
                        Linehaul = 1200
                    },

                    new Freight
                    {
                        BrokerName = "Schneider",
                        Date = DateTime.Parse("2020-2-23"),
                        Commodity = "Boeing turbine",
                        Linehaul = 5400
                    },

                    new Freight
                    {
                        BrokerName = "J.B Hunt",
                        Date = DateTime.Parse("2020-4-15"),
                        Commodity = "Construction material",
                        Linehaul = 3900
                    }
                );
                context.SaveChanges();
            }
        }
    }
}