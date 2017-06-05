using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutions.Beta
{
    using System;
    using System.Collections.Generic;

    public class Movie
    {
        public DateTime Start { get; private set; }
        public DateTime End { get; private set; }

        public Movie(DateTime start, DateTime end)
        {
            this.Start = start;
            this.End = end;
        }
    }

    public static class MovieNight
    {
        public static bool CanViewAll(IEnumerable<Movie> movies)
        {
            var moviesArray = movies.OrderBy(m => m.Start).ToArray();

            return !Enumerable.Range(0, movies.Count() - 1).Any(x => moviesArray[x].Start < moviesArray[x + 1].End && moviesArray[x + 1].Start < moviesArray[x].End);

            
        }

        public static void Main(string[] args)
        {
            var format = System.Globalization.CultureInfo.InvariantCulture.DateTimeFormat;

            Movie[] movies = new Movie[]
            {
            new Movie(DateTime.Parse("1/1/2015 20:00", format), DateTime.Parse("1/1/2015 21:30", format)),
            new Movie(DateTime.Parse("1/1/2015 21:30", format), DateTime.Parse("1/1/2015 23:30", format)),
            new Movie(DateTime.Parse("1/1/2015 23:10", format), DateTime.Parse("1/1/2015 23:30", format))
            };

            Console.WriteLine(MovieNight.CanViewAll(movies));
        }
    }
}
