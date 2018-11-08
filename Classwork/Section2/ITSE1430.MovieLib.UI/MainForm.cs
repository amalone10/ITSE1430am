using ITSE1430.MovieLib.Memory;
using ITSE1430.MovieLib.Sql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITSE1430.MovieLib.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //this method can be overridden in a derived type
        protected virtual void SomeFunction()
        { }

        //this method MUST BE degined in a derived type
        //protected abstract void SomeAbstractFunction();

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            var connString = ConfigurationManager.ConnectionStrings["Database"].ConnectionString;
            _database = new SqlMovieDatabase(connString);

            _listMovies.DisplayMember = "Name";
            RefreshMovies();
        }

        //event handler
        private void OnFileExit(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?",
                "Close", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            Close();
        }

        private void OnHelpAbout(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Better luck next time",
                "Help", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void OnMovieAdd(object sender, EventArgs e)
        {
            var form = new MovieForm();

            if (form.ShowDialog(this) == DialogResult.Cancel)
                return;

            try
            {
                _database.Add(form.Movie);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
        }

        private void OnMovieDelete(object sender, EventArgs e)
        {
            DeleteMovie();
        }

        private void OnMovieEdit(object sender, EventArgs e)
        {
            EditMovie();

        }

        private void OnMovieDoubleClick(object sender, EventArgs e)
        {
            EditMovie();
        }

        private void OnListKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                DeleteMovie();
            };
        }

        //private members
        private void DeleteMovie()
        {
            var item = GetSelectedMovie();
            if (item == null)
                return;

            try
            {
                _database.Remove(item.Name);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            };

            RefreshMovies();
        }

        private void EditMovie()
        {
            var item = GetSelectedMovie();
            if (item == null)
                return;

            var form = new MovieForm();
            form.Movie = item;
            if (form.ShowDialog(this) == DialogResult.Cancel)
                return;

            try
            {
                _database.EditCore(item.Name, form.Movie);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            };

            RefreshMovies();
        }

        private void RefreshMovies()
        {
            var movies = from m in _database.GetAll()
                         orderby m.Name
                         select m;

            _listMovies.Items.Clear();

            _listMovies.Items.AddRange(movies.ToArray());
        }

        private Movie GetSelectedMovie()
        {
            return _listMovies.SelectedItem as Movie;
        }

        private IMovieDatabase _database; //= new SqlMovieDatabase();
    }
}
