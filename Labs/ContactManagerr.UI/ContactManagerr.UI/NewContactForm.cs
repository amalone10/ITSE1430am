using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManager.UI
{
    public partial class NewContactForm : Form
    {
        public Contact Contact { get; set; }

        public NewContactForm()
        {
            InitializeComponent();
        }

        //load
        private void NewContactForm_Load(object sender, EventArgs e)
        {
            if (Contact != null)
            {
                _txtName.Text = Contact.Name;
                _txtEmail.Text = Contact.Email;
            }

            ValidateChildren();
        }

        //save
        private void OnSave(object sender, EventArgs e)
        {
            if (!ValidateChildren())
                return;

            var contact = new Contact()
            {
                Name = _txtName.Text,
                Email = _txtEmail.Text,
            };

            Contact = contact;

            DialogResult = DialogResult.OK;
            Close();
        }

        //cancel
        private void OnCancel(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        //validation
        private void OnValidatingName(object sender, CancelEventArgs e)
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
    }
}
