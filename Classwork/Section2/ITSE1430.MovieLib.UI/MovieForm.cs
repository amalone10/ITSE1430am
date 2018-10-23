using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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

        private void OnCancel(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void OnSave(object sender, EventArgs e)
        {
            if (!ValidateChildren())
                return;

            var movie = new Movie()
            {
                Name = _txtName.Text,
                Description = _txtDescription.Text,
                ReleaseYear = GetInt32(_txtReleaseYear),
                RunLength = GetInt32(_txtRunLength),
                isOwned = _chkOwned.Checked,
            };

            var results = ObjectValidator.Validate(movie);
            foreach (var result in results)
            {
                MessageBox.Show(this, result.ErrorMessage, "Validation Failed", MessageBoxButtons.OK);
            }

            Movie = movie;
            DialogResult = DialogResult.OK;
            Close();
        }

        private int GetInt32  (TextBox textBox)
        {
            if (String.IsNullOrEmpty(textBox.Text))
                return -1;

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

            ValidateChildren();
        }

        private void OnValidateName(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var control = sender as TextBox;

            if (String.IsNullOrEmpty(control.Text))
            {
                _errors.SetError(control, "Name is required");
                e.Cancel = true;
            }
            else
                _errors.SetError(control, "");
        }

        private void OnValidatingReleaseYear(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var control = sender as TextBox;
            var result = GetInt32(control);

            if (result < 1900)
            {
                _errors.SetError(control, "Release year must be over 1900");
                e.Cancel = true;
            } else
                _errors.SetError(control, "");
        }

        private void OnValidatingRunLength(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var control = sender as TextBox;
            var result = GetInt32(control);

            if (result < 0)
            {
                _errors.SetError(control, "Runtime must be over 0");
                e.Cancel = true;
            } else
                _errors.SetError(control, "");
        }
    }
}