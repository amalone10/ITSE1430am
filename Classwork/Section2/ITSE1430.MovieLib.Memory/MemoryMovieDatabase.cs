using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITSE1430.MovieLib.Memory
{
    public class MemoryMovieDatabase
    {
        public MemoryMovieDatabase() : this(true)
        { }

        public MemoryMovieDatabase( bool seed ) : this(GetSeedMovies(seed))
        { }

        public MemoryMovieDatabase(Movie[] movies)
        {
            _items.AddRange(movies);
        }

        private static Movie[] GetSeedMovies(bool seed)
        {
            if (!seed)
                return new Movie[0];

            return new Movie[] {
                new Movie()
                {
                    Name = "Jaws",
                    RunLength = 120,
                    ReleaseYear = 1977,
                },
                new Movie()
                {
                    Name = "What About Bob?",
                    RunLength = 96,
                    ReleaseYear = 2004,
                },
            };
        }

        public Movie[] GetAll()
        {
            var count = _items.Count;

            var temp = new Movie[count];
            var index = 0;
            foreach (var movie in _items)
            {
                temp[index++] = movie;
            };

            return temp;
        }

        private Movie FindMovie (string name)
        {
            var pairs = new Dictionary<string, Movie>();

            foreach (var movie in _items)
            {
                if (String.Compare(name, movie.Name, true) == 0)
                    return movie;
            };

            return null;
        }

        public void Add(Movie movie)
        {
            _items.Add(movie);
        }

        public void Remove ( string name )
        {
            var movie = FindMovie(name);
            if (movie != null)
                _items.Remove(movie);
        }

        public void Edit ( string name, Movie movie )
        {
            //find movie by name
            Remove(name);

            //replace it
            Add(movie);
        }

        private List<Movie> _items = new List<Movie>();
    }
}
