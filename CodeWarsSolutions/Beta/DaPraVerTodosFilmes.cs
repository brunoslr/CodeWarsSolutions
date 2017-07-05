using System.Linq;

namespace CodeWarsSolutions.Beta
{
    using System;
    using System.Collections.Generic;

    public class Filme
    {
        public DateTime Inicio { get; private set; }
        public DateTime Fim { get; private set; }

        public Filme(DateTime start, DateTime end)
        {
            this.Inicio = start;
            this.Fim = end;
        }
    }

    public static class NoiteDeFilmes
    {
        public static bool DaPraVerTodos(IEnumerable<Filme> movies)
        {
            var arranjoDeFilmes = movies.OrderBy(m => m.Inicio).ToArray();

            return !Enumerable.Range(0, movies.Count() - 1).Any(x => arranjoDeFilmes[x].Inicio < arranjoDeFilmes[x + 1].Fim && arranjoDeFilmes[x + 1].Inicio < arranjoDeFilmes[x].Fim);

            
        }

        public static void Main(string[] args)
        {
            var format = System.Globalization.CultureInfo.InvariantCulture.DateTimeFormat;

            Filme[] movies = new Filme[]
            {
            new Filme(DateTime.Parse("1/1/2015 20:00", format), DateTime.Parse("1/1/2015 21:30", format)),
            new Filme(DateTime.Parse("1/1/2015 21:30", format), DateTime.Parse("1/1/2015 23:30", format)),
            new Filme(DateTime.Parse("1/1/2015 23:10", format), DateTime.Parse("1/1/2015 23:30", format))
            };

            Console.WriteLine(NoiteDeFilmes.DaPraVerTodos(movies));
        }
    }
}
