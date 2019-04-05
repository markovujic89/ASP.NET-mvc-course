using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PluralSightMVC_App.Models
{
    public class MockPieRepository : IPieRepository
    {
        private List<Pie> pies;

        public MockPieRepository()
        {
            if(pies==null)
            {
                InitilazePies();
            }
        }

        private void InitilazePies()
        {
            pies = new List<Pie>
            {
                new Pie {Id=1, Name="Apple Pie", Price=12.95M, ShortDescription="Apple Pie", LongDescription="...Long Desc of Pie", ImageThumbnailUrl="https://www.google.rs/url?sa=i&source=images&cd=&cad=rja&uact=8&ved=2ahUKEwjztcDEurPhAhXDLlAKHUZoCLgQjRx6BAgBEAU&url=https%3A%2F%2Fwww.landolakes.com%2Frecipe%2F16800%2Fblue-ribbon-apple-pie%2F&psig=AOvVaw2DigSB4hJdBLs6oMaF5YkS&ust=1554364873649589"},
                new Pie {Id=2, Name="Chees Cake", Price=15.95M, ShortDescription="Chees Cake", LongDescription="...Long Desc of Pie"},
                new Pie {Id=3, Name="Bluberry Chees Cake", Price=17.95M, ShortDescription="Bluberry Chees Cake", LongDescription="...Long Desc of Pie"},
                new Pie {Id=4, Name="Cherry Pie", Price=13.95M, ShortDescription="Cherry Pie", LongDescription="...Long Desc of Pie"},
            };
        }

        public IEnumerable<Pie> GetAllPies()
        {
            return pies;
        }

        public Pie GetPieById(int pieId)
        {
            return pies.FirstOrDefault(x => x.Id == pieId); 
        }
    }
}
