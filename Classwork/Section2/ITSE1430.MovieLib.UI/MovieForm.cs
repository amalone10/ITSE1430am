using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITSE1430.MovieLib.UI
{
    public partial class MovieForm : Form
    {
        public MovieForm()
        {
            InitializeComponent();
        }

        public Movie Movie { get; set; }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void OnCancel(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void OnSave(object sender, EventArgs e)
        {
            var movie = new Movie();

            //name required
            movie.Name = _txtName.Text;         //field for properties
            //movie.SetName(_txtName.Text);     //field for methods
            if (String.IsNullOrEmpty(movie.Name))
                return;

            movie.Description = _txtDescription.Text;
            //movie.SetDescription(_txtDescription.Text);

            //release year, if set
            movie.ReleaseYear = GetInt32(_txtReleaseYear);
            //movie.SetReleaseYear(GetInt32(_txtReleaseYear));
            //var releaseYear = GetInt32(_txtReleaseYear);
            if (movie.ReleaseYear < 0)
                return;

            //run length, if set
            movie.RunLength = GetInt32(_txtRunLength);
            //movie.SetRunLength(GetInt32(_txtRunLength));
            //var runLength = GetInt32(_txtRunLength);
            if (movie.RunLength < 0)
                return;

            movie.isOwned = _chkOwned.Checked;

            Movie = movie;

            DialogResult = DialogResult.OK;
            Close();
        }

        private int GetInt32  (TextBox textBox)
        {
            if (String.IsNullOrEmpty(textBox.Text))
                return 0;

            if (Int32.TryParse(textBox.Text, out var value))
                return value;

            return -1;
        }

        private void MovieForm_Load(object sender, EventArgs e)
        {
            if (Movie != null)
            {
                _txtName.Text = Movie.Name;
                _txtDescription.Text = Movie.Description;
                _txtReleaseYear.Text = Movie.ReleaseYear.ToString();
                _txtRunLength.Text = Movie.RunLength.ToString();
                _chkOwned.Checked = Movie.isOwned;
            }
        }
    }
}
