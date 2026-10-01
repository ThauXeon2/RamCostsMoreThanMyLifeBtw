using System;
using System.Collections.Generic;
using System.Text;

namespace Rec2
{
    record Series(string Title, string Genre, string Studio)
    {
        private int _episodes;
        private double _rating;
        public void AddEp(int episodes) => _episodes += episodes;
        public bool IsLong() => _episodes >= 40;
        public void NewRating(double rating) => _rating = rating > 0 && rating <= 10 ? rating : _rating;
        public int EpCount() => _episodes;
        public double Rating() => _rating;
        public static string? GetTitle(string studio, List<Series> series)=>series.Where(s => s.Studio == studio).Select(x => x.Title).FirstOrDefault();
    }
}
