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
        }
    }
}
