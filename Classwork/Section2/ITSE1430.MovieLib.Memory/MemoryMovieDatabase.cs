using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITSE1430.MovieLib.Memory
{
    public class MemoryMovieDatabase : MovieDatabase
    {
        protected override IEnumerable<Movie> GetAllCore()
        {
            return _items;
        }

        protected override Movie FindByName (string name)
        {
            var pairs = new Dictionary<string, Movie>();

            foreach (var movie in _items)
            {
                if (String.Compare(name, movie.Name, true) == 0)
                    return movie;
            };

            return null;
        }

        protected override void AddCore(Movie movie)
        {
            _items.Add(movie);
        }

        protected override void RemoveCore ( string name )
        {
            var movie = FindByName(name);
            if (movie != null)
                _items.Remove(movie);
        }

        protected override void EditCore ( Movie oldMovie, Movie newMovie )
        {
            _items.Remove(oldMovie);

            _items.Add(newMovie);
        }

        private List<Movie> _items = new List<Movie>();
    }
}
