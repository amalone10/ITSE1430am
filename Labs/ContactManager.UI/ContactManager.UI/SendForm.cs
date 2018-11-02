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
    public partial class SendForm : Form
    {
        public Contact Contact { get; set; }

        public SendForm()
        {
            InitializeComponent();
        }

        private void SendForm_Load(object sender, EventArgs e)
        {
            if (Contact != null)
            {
                _txtEmail.Text = Contact.Email;
                _txtSubject.Text = Contact.Subject;
                _txtBody.Text = Contact.Body;
            }

            ValidateChildren();
        }

        private void OnSend(object sender, EventArgs e)
        {
            if (!ValidateChildren())
                return;

            var contact = new Contact()
            {
                Email = _txtEmail.Text,
                Subject = _txtSubject.Text,
                Body = _txtBody.Text,
            };

            Contact = contact;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void OnCancel(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void OnValidatingSubject(object sender, CancelEventArgs e)
        {
            var control = sender as TextBox;

            if (String.IsNullOrEmpty(control.Text))
            {
                _errors.SetError(control, "Subject is required");
                e.Cancel = true;
            }
            else
                _errors.SetError(control, "");
        }
    }
}
