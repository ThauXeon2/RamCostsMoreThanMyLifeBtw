using System;
using System.Collections.Generic;
using System.Text;

namespace Rec2
{
    record SmartPhone(string Brand, string Model, int ReleaseYear)
    {
        private int _releaseYear { get; init; } = ReleaseYear;
        private int _price;
        public double Rating;
        public int YearBack() => _releaseYear;
        public void PriceSet(int price) => _price = price;
        public double Off(int percent) => _price * (1 - (percent / 100.0));
        public int BrandCount(string brand,List<SmartPhone> smartPhones) => smartPhones.Count(p => p.Brand == brand);
    }
}
