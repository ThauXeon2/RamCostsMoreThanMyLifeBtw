using System.Runtime.CompilerServices;

namespace Rec2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<SmartPhone> smartPhones = new List<SmartPhone>()
            {
                new SmartPhone("Samsung", "Galaxy S24", 2024){Rating=9.1},
                new SmartPhone("Apple", "iPhone 15", 2023){Rating=9.3},
                new SmartPhone("Xiaomi", "Redmi Note 13", 2024){Rating=8.4},
                new SmartPhone("Google", "Pixel 8", 2023){Rating=9.0},
                new SmartPhone("Samsung", "Galaxy A55", 2024){Rating=8.6},
                new SmartPhone("OnePlus", "OnePlus 12", 2024){Rating=8.9},
                new SmartPhone("Apple", "iPhone 14", 2022){Rating=8.8},
                new SmartPhone("Xiaomi", "Xiaomi 14", 2024){Rating=9.2}
            };
            smartPhones[0].PriceSet(329000);
            smartPhones[1].PriceSet(349000);
            smartPhones[2].PriceSet(119000);
            smartPhones[3].PriceSet(279000);
            smartPhones[4].PriceSet(169000);
            smartPhones[5].PriceSet(299000);
            smartPhones[6].PriceSet(289000);
            smartPhones[7].PriceSet(319000);
            var phones2024 = smartPhones.Where(p => p.ReleaseYear == 2024).ToList();
            var bestRating = smartPhones.OrderByDescending(p => p.Rating).FirstOrDefault();
            List<Hotel> hotels = new List<Hotel>()
            {
                new Hotel("Grand Palace", "Budapest", 5){Rating = 9.4},
                new Hotel("City Hotel", "Budapest", 3){Rating = 8.2},
                new Hotel("Blue Sea Resort", "Split", 4){Rating = 9.1},
                new Hotel("Royal Beach", "Barcelona", 5){Rating = 9.3},
                new Hotel("Mountain View", "Salzburg", 4){Rating = 8.8},
                new Hotel("Central Stay", "Prague", 3){Rating = 8.5},
                new Hotel("Luxury Garden", "Vienna", 5){Rating = 9.2},
                new Hotel("Sunset Hotel", "Split", 4){Rating = 8.9}
            };
            hotels[0].PriceSet(68000);
            hotels[1].PriceSet(32000);
            hotels[2].PriceSet(54000);
            hotels[3].PriceSet(82000);
            hotels[4].PriceSet(46000);
            hotels[5].PriceSet(28000);
            hotels[6].PriceSet(75000);
            hotels[7].PriceSet(49000);
            var cheapestHotel=hotels.OrderBy(x=>x.PriceCount(1)).Select(y=>y.Name).FirstOrDefault();
            List<Laptop> laptops = new List<Laptop>()
            {
                new Laptop("Lenovo", "ThinkPad E14", "Intel i5"){Memory=16 },
                new Laptop("Apple", "MacBook Air M3", "Apple M3"){Memory=16 },
                new Laptop("Asus", "ROG Strix G16", "Intel i7"){Memory=32 },
                new Laptop("Acer", "Aspire 5", "AMD Ryzen 5"){Memory=16 },
                new Laptop("HP", "ProBook 450", "Intel i5"){Memory=16 },
                new Laptop("Dell", "Inspiron 15", "Intel i7"){Memory=32 },
                new Laptop("Lenovo", "IdeaPad Slim 3", "AMD Ryzen 5"){Memory=8 },
                new Laptop("Asus", "VivoBook 15", "Intel i5"){Memory=8 },
                new Laptop("Apple", "MacBook Pro M3", "Apple M3 Pro"){Memory=36 },
                new Laptop("Acer", "Nitro 5", "Intel i7"){Memory=32 }
            };
            laptops[0].PriceSet(319000);
            laptops[1].PriceSet(489000);
            laptops[2].PriceSet(649000);
            laptops[3].PriceSet(279000);
            laptops[4].PriceSet(349000);
            laptops[5].PriceSet(399000);
            laptops[6].PriceSet(249000);
            laptops[7].PriceSet(289000);
            laptops[8].PriceSet(799000);
            laptops[9].PriceSet(519000);
            var avgPrice = laptops.Average(l => l.PriceNum());
            var underAvg = laptops.Where(l => l.PriceNum() < avgPrice).Select(x => x.Model); 
            var mostMemory = laptops.OrderByDescending(l => l.Memory).Select(x=>x.Brand).FirstOrDefault();
            List<Restaurant> restaurants = new List<Restaurant>()
            {
                new Restaurant("Bella Italia", "Budapest", "Italian"),
                new Restaurant("Burger House", "Budapest", "Burger"),
                new Restaurant("Sakura", "Budapest", "Japanese"),
                new Restaurant("Pasta Roma", "Rome", "Italian"),
                new Restaurant("Tokyo Garden", "Vienna", "Japanese"),
                new Restaurant("Steak Corner", "Budapest", "Steak"),
                new Restaurant("Pizza Napoli", "Rome", "Italian"),
                new Restaurant("Grill House", "Vienna", "Steak"),
                new Restaurant("Sushi World", "Prague", "Japanese"),
                new Restaurant("Street Burger", "Prague", "Burger")
            };
            restaurants[0].NewRating(9.1);
            restaurants[0].SetAveragePrice(8500);
            restaurants[1].NewRating(8.4);
            restaurants[1].SetAveragePrice(5500);
            restaurants[2].NewRating(9.4);
            restaurants[2].SetAveragePrice(12000);
            restaurants[3].NewRating(8.9);
            restaurants[3].SetAveragePrice(9500);
            restaurants[4].NewRating(9.2);
            restaurants[4].SetAveragePrice(13500);
            restaurants[5].NewRating(9.0);
            restaurants[5].SetAveragePrice(15000);
            restaurants[6].NewRating(8.7);
            restaurants[6].SetAveragePrice(7000);
            restaurants[7].NewRating(8.8);
            restaurants[7].SetAveragePrice(14000);
            restaurants[8].NewRating(9.3);
            restaurants[8].SetAveragePrice(11000);
            restaurants[9].NewRating(8.2);
            restaurants[9].SetAveragePrice(5000);
            int rating = restaurants.Count(r => r.Rating() >= 9.0);
            var expensiveRes= restaurants.OrderByDescending(r=>r.AvgPrice()).Select(x=> x.Name).FirstOrDefault();
            var cities = restaurants.Select(r => r.City).Distinct();
            List<Series> series = new List<Series>()
            {
                new Series("Breaking Bad", "Drama", "AMC"),
                new Series("Stranger Things", "SciFi", "Netflix"),
                new Series("The Boys", "Action", "Amazon"),
                new Series("Dark", "SciFi", "Netflix"),
                new Series("The Crown", "Drama", "Netflix"),
                new Series("Reacher", "Action", "Amazon"),
                new Series("Wednesday", "Fantasy", "Netflix"),
                new Series("House of the Dragon", "Fantasy", "HBO"),
                new Series("The Last of Us", "Drama", "HBO"),
                new Series("Fallout", "SciFi", "Amazon"),
                new Series("Better Call Saul", "Drama", "AMC"),
                new Series("Loki", "Fantasy", "Disney")
            };
            series[0].AddEp(62);
            series[0].NewRating(9.5);
            series[1].AddEp(34);
            series[1].NewRating(8.7);
            series[2].AddEp(32);
            series[2].NewRating(8.7);
            series[3].AddEp(26);
            series[3].NewRating(8.8);
            series[4].AddEp(60);
            series[4].NewRating(8.6);
            series[5].AddEp(24);
            series[5].NewRating(8.5);
            series[6].AddEp(16);
            series[6].NewRating(8.1);
            series[7].AddEp(18);
            series[7].NewRating(8.4);
            series[8].AddEp(18);
            series[8].NewRating(8.8);
            series[9].AddEp(16);
            series[9].NewRating(8.6);
            series[10].AddEp(63);
            series[10].NewRating(9.0);
            series[11].AddEp(12);
            series[11].NewRating(8.2);
            var eps = series.OrderByDescending(s => s.EpCount()).Select(x => x.Title).FirstOrDefault();
            var avgRE=series.Where(s=>s.EpCount()>20).Average(s => s.Rating()); 
            var genres = series.Select(s => s.Genre).Distinct();
            /*Schrodinger's code, nem fogjuk tudni hogy mi megy, mert nincs cw.
            Console.WriteLine(UInt128.MaxValue);*/
            List<Product> products = new List<Product>()
            {
                new Product("Galaxy S24", "Phone", "Samsung"),
                new Product("iPhone 15", "Phone", "Apple"),
                new Product("Pixel 8", "Phone", "Google"),
                new Product("ThinkPad E14", "Laptop", "Lenovo"),
                new Product("MacBook Air", "Laptop", "Apple"),
                new Product("ROG Strix", "Laptop", "Asus"),
                new Product("Galaxy Tab S9", "Tablet", "Samsung"),
                new Product("iPad Air", "Tablet", "Apple"),
                new Product("MatePad 11", "Tablet", "Huawei"),
                new Product("WH1000XM5", "Headphone", "Sony"),
                new Product("AirPods Pro", "Headphone", "Apple"),
                new Product("Galaxy Buds", "Headphone", "Samsung")
            };
            products[0].Price(329000);
            products[0].Stock(15);
            products[1].Price(349000);
            products[1].Stock(12);
            products[2].Price(279000);
            products[2].Stock(8);
            products[3].Price(319000);
            products[3].Stock(10);
            products[4].Price(489000);
            products[4].Stock(7);
            products[5].Price(649000);
            products[5].Stock(5);
            products[6].Price(299000);
            products[6].Stock(9);
            products[7].Price(319000);
            products[7].Stock(11);
            products[8].Price(199000);
            products[8].Stock(14);
            products[9].Price(149000);
            products[9].Stock(18);
            products[10].Price(109000);
            products[10].Stock(25);
            products[11].Price(69000);
            products[11].Stock(20);
            var CategoryStock = products.GroupBy(p => p.Category).ToDictionary(x => x.Key, y => y.Sum(z => z.StockAm()));
            var ManAvg=products.GroupBy(p=>p.Manufacturer).ToDictionary(x => x.Key, y => y.Average(z => z.PriceAm()));
            var CatME = products.GroupBy(p => p.Category).ToDictionary(x => x.Key, x => x.OrderByDescending(y=>y.PriceAm()).Select(z=>z.Name).FirstOrDefault());
            var CatMS = products.GroupBy(p => p.Category).ToDictionary(x => x.Key, x => x.OrderByDescending(y=>y.StockAm()).Select(z => z.Category).FirstOrDefault());

        }
    }
}
