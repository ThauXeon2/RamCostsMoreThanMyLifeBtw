using System;
using System.Collections.Generic;
using System.Text;

namespace Rec2
{
    record Restaurant(string Name, string City, string Category)
    {
        private int _averagePrice;
        private double _rating;
        public void NewRating(double rating) => _rating = rating > 0 && rating <= 10 ? rating : _rating;
        public void SetAveragePrice(int price) => _averagePrice = price;
        public bool Expensive() => _averagePrice > 12000;
        public int AvgPrice() => _averagePrice;
        public double Rating() => _rating;
        public static List<string> CategoryFind(string category, List<Restaurant> restaurants) => restaurants.Where(r => r.Category == category).Select(x => x.Name).ToList();
    }
}
