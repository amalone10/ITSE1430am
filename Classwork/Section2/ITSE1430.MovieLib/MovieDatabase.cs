using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITSE1430.MovieLib
{
    public abstract class MovieDatabase
    {
        public IEnumerable<Movie> GetAll()
        {
            return GetAllCore();
        }

        public void Add(Movie movie)
        {
            //todo: validate
            if (movie == null)
                return;

            AddCore(movie);
        }

        public void Remove( string name )
        {
            //todo validate
            if (string.IsNullOrEmpty(name))
                return;

            RemoveCore(name);
        }

        public void EditCore ( string name, Movie movie )
        {
            //todo validate
            if (String.IsNullOrEmpty(name))
                return;
            if (movie == null)
                return;

            //find movie by name
            var exsisting = FindByName(name);
            if (exsisting == null)
                return;

            EditCore(exsisting, movie);
        }

        protected abstract IEnumerable<Movie> GetAllCore();

        protected abstract void AddCore(Movie movie);

        protected abstract void RemoveCore(string name);

        protected abstract Movie FindByName(string name);

        protected abstract void EditCore(Movie oldMovie, Movie newMovie);

        private List<Movie> _items = new List<Movie>();
    }
}
