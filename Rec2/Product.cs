using System;
using System.Collections.Generic;
using System.Text;

namespace Rec2
{
    record Product(string Name, string Category, string Manufacturer)
    {
        private int _price;
        private int _stock;
        public void Stock(int stock) => _stock += stock;
        public void Price(int price) => _price = price;
        public int StockAm() => _stock;
        public int PriceAm() => _price;
        public int Inventory() => _stock * _price;
    }
}
