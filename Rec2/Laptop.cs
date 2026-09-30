using System;
using System.Collections.Generic;
using System.Text;

namespace Rec2
{
    record Laptop(string Brand, string Model, string Processor)
    {
        private string _processor { get; init; } = Processor;
        private int _price;
        public int Memory;
        public string ProcessorType() => _processor;
        public void PriceSet(int price) => _price = price;
        public int PriceNum() => _price;
        public void MoreMemoryRahhhChrisGiveMeYourKidneys(int memory) => Memory += memory;
    }
}
