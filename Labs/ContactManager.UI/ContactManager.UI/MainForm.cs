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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //load
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            _listContacts.DisplayMember = "Name";
            RefreshContact();
            _listMessages.DisplayMember = "Subject";
            RefreshMessage();
        }

        //exit
        private void OnFileExit(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?",
                "Close", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            Close();
        }

        //about
        private void OnHelpAbout(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Alex Malone\nITSE1430\nContact Manager",
                "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //new contact
        private void OnContactsNew(object sender, EventArgs e)
        {
            var form = new NewContactForm();

            if (form.ShowDialog(this) == DialogResult.Cancel)
                return;

            _database.AddContact(form.Contact);
            RefreshContact();
        }

        //edit
        private void OnContactsEdit(object sender, EventArgs e)
        {
            EditContact();
        }

        //double click listed character
        private void ListContactsDoubleClick(object sender, EventArgs e)
        {
            EditContact();
        }

        //send
        private void OnContactsSend(object sender, EventArgs e)
        {
            SendMessage();
        }

        //double click listed character
        private void ListMessagesDoubleClick(object sender, EventArgs e)
        {
            SendMessage();
        }

        //delete
        private void OnContactsDelete(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this character?",
                "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;

            DeleteContact();
        }

        //helpers
        private void EditContact()
        {
            var item = GetSelectedContact();
            if (item == null)
                return;

            var form = new NewContactForm();
            form.Contact = item;
            if (form.ShowDialog(this) == DialogResult.Cancel)
                return;

            _database.EditContact(item.Name, form.Contact);
            RefreshContact();
        }

        private void SendMessage()
        {
            var item = GetSelectedMessage();
            if (item == null)
                return;

            var form = new SendMessageForm();
            form.Contact = item;
            if (form.ShowDialog(this) == DialogResult.Cancel)
                return;

            _database.EditContact(item.Body, form.Contact);
            RefreshMessage();
        }

        private void DeleteContact()
        {
            var item = GetSelectedContact();
            if (item == null)
                return;

            _database.RemoveContact(item.Name);
            RefreshContact();
        }

        private void RefreshContact()
        {
            var contact = _database.GetAll();

            _listContacts.Items.Clear();
            _listContacts.Items.AddRange(contact);
        }

        private Contact GetSelectedContact()
        {
            return _listContacts.SelectedItem as Contact;
        }

        private void RefreshMessage()
        {
            var contact = _database.GetAll();

            _listMessages.Items.Clear();
            _listMessages.Items.AddRange(contact);
        }

        private Contact GetSelectedMessage()
        {
            return _listMessages.SelectedItem as Contact;
        }

        private ContactData _database = new ContactData();
    }
}
