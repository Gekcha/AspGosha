using Shop.Data.interfaces;
using Shop.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace Shop.Data.mocks
{
    public class MockWatches : IAllWatches
    {

        private readonly IWatchesCategory _categoryWatches = new MockCategory();

        public IEnumerable<Watch> Watches {
            get
            {
                return new List<Watch>
                {
                    new Watch 
                    {
                        name = "Tesla Model S", 
                        shortDesc = "Быстрый автомобиль", 
                        longDesc = "Красивый, быстрый и очень тихий автомобиль компании Tesla", 
                        img = "/img/tesla.png", 
                        price = 45000, 
                        isFavourite= true, 
                        available = true, 
                        Category = _categoryWatches.AllCategories.First()
                    },
                    new Watch
                    {
                        name = "Ford Fiesta",
                        shortDesc = "Тихий и спокойный",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "/img/fiesta.jpg",
                        price = 11000,
                        isFavourite= false,
                        available = true,
                        Category = _categoryWatches.AllCategories.Last()
                    },
                    new Watch
                    {
                        name = "BMW M3",
                        shortDesc = "Дерзкий и стильный",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "/img/bmw.jpg",
                        price = 65000,
                        isFavourite= true,
                        available = true,
                        Category = _categoryWatches.AllCategories.Last()
                    },
                    new Watch
                    {
                        name = "Mercedes C class",
                        shortDesc = "Уютный и большой",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "/img/mercedes.jpg",
                        price = 40000,
                        isFavourite= false,
                        available = false,
                        Category = _categoryWatches.AllCategories.Last()
                    },
                    new Watch
                    {
                        name = "Nissan Leaf",
                        shortDesc = "Бешумный и комфортный",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "/img/nissan.jpg",
                        price = 14000,
                        isFavourite= true,
                        available = true,
                        Category = _categoryWatches.AllCategories.First()
                    }
                };
            }
           }
        public IEnumerable<Watch> getFavWatches { get; set; }
        public Watch getObjectWatch(int watchId)
        {
            throw new System.NotImplementedException();
        }
    }
}
