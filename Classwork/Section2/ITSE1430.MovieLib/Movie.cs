using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITSE1430.MovieLib
{
    public class Movie
    {
        public string Name { get; set; }    //auto properties(properties should not have side effects)
        /*{
            get { return _name ?? ""; }     //string get ()
            set { _name = value; }          //viod set ( string value )
        }*/

        public string Description { get; set; }
        /*{
            get { return _description ?? ""; }
            set { _description = value; }
        }*/

        public int ReleaseYear { get; set; } = 1900;
        /*{
            get { return _releaseYear; }
            set
            {
                if (value >= 1900)
                    _releaseYear = value;
            }
        }*/

        public int RunLength { get; set; }
        /*{
            get { return _runLength; }
            set
            {
                if (value >= 0)
                    _runLength = value;
            }
        }*/

        public bool IsColor
        {
            get { return ReleaseYear > 1940;  }
        }

        public bool isOwned { get; set; }

        //protoyping for properties
        /*private string _name = "";
        //public System.String Name;
        private string _description;
        private int _releaseYear = 1900;
        private int _runLength;*/

        /*public string GetName()           //methods
        {
            return _name ?? "";
        }

        public string GetDescription()
        {
            return _description ?? "";
        }

        public int GetReleaseYear()
        {
            return _releaseYear;
        }

        public int GetRunLength()
        {
            return _runLength;
        }

        public void SetName(string value)
        {
            _name = value;
        }

        public void SetDescription(string value)
        {
            _description = value;
        }

        public void SetReleaseYear(int value)
        {
            if(value >=1900)
                _releaseYear = value;
        }

        public void SetRunLength(int value)
        {
            if(value >=0)
                _runLength = value;
        }*/

        /*mixed accessibility
        public int Id { get; private set; }

        public bool IsColor
        {
            get { return ReleaseYear > 1940; }
        }*/
    }
}
