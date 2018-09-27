using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITSE1430.MovieLib
{
    public class Movie
    {
        //public System.String Name;
        public string GetName()
        {
            return _name ?? "";
        }
        public void SetName(string value)
        {
            _name = value;
        }

        public string GetDescription()
        {
            return _description ?? "";
        }
        public void SetDescription(string value)
        {
            _description = value;
        }

        public int getReleaseYear()
        {
            return _releaseYear;
        }
        public void SetReleaseYear(int value)
        {
            if(value >=1900)
                _releaseYear = value;
        }

        public int GetRunLength()
        {
            return _runLength;
        }
        public void SetRunLength(int value)
        {
            if(value >=0)
                _runLength = value;
        }

        private string _name;
        private string _description;
        private int _releaseYear;
        private int _runLength;

        /*void Foo()
        {
            var x = RunLength;

            var isLong = x > 100;
        }*/
    }
}
