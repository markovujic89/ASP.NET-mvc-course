using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PluralSightMVC_App.Models
{
    public static class DBInitializer
    {
        public static void Seed(AppDbContext context)
        {
            if(!context.Pies.Any())
            {
                context.AddRange(
                    new Pie { Name = "Apple Pie", Price = 12.95M, ShortDescription = "Apple Pie", LongDescription = "...Long Desc of Pie" },
                    new Pie { Name = "Chees Cake", Price = 15.95M, ShortDescription = "Chees Cake", LongDescription = "...Long Desc of Pie" },
                    new Pie { Name = "Bluberry Chees Cake", Price = 17.95M, ShortDescription = "Bluberry Chees Cake", LongDescription = "...Long Desc of Pie" },
                    new Pie { Name = "Cherry Pie", Price = 13.95M, ShortDescription = "Cherry Pie", LongDescription = "...Long Desc of Pie" }   
                    );

                context.SaveChanges();
            }
        }
    }
}
