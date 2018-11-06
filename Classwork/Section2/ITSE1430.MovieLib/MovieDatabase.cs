using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITSE1430.MovieLib
{
    public abstract class MovieDatabase : IMovieDatabase
    {
        public IEnumerable<Movie> GetAll()
        {
            return GetAllCore();
        }

        public void Add(Movie movie)
        {
            if(movie == null)
                throw new ArgumentNullException(nameof(movie));
                ObjectValidator.Validate(movie);
            try
            {
                AddCore(movie);
            }
            catch (Exception e)
            {
                throw new Exception("Add Failed", e);
            };
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
            if (name == null)
                throw new ArgumentNullException(nameof(name));
            else if (name == "")
                throw new ArgumentException("Name cannot be empty.", nameof(name));

            if (movie == null)
                throw new ArgumentNullException(nameof(movie));
                ObjectValidator.Validate(movie);

            //find movie by name
            var exsisting = FindByName(name);
            if (exsisting == null)
                throw new Exception("Movie not found.");

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
