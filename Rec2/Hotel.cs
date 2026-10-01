using System;
using System.Collections.Generic;
using System.Text;

namespace Rec2
{
    record Hotel(string Name, string City, int Stars) 
    {
        private int _stars { get; init; } = Stars;
        private int _pricePerNight;
        public double Rating;
        public bool StarsRating() => Stars >= 4.0;
        public void PriceSet(int price) => _pricePerNight = price;
        public double PriceCount(int nights) => _pricePerNight * nights;
        public static List<string> Hotels(string city, List<Hotel> hotels) => hotels.Where(h => h.City == city).Select(x=>x.Name).ToList();
        public static List<string> BestRating3(List<Hotel> hotels)=>hotels.OrderBy(h=>h.Rating).Take(3).Select(x=>x.Name).ToList();
    }
}
