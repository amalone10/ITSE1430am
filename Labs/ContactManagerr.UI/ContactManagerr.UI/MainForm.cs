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
            RefreshMessage();
        }

        //edit
        private void OnContactsEdit(object sender, EventArgs e)
        {
            EditContact();
        }

        //contact list click
        private void OnContactDoubleClick(object sender, EventArgs e)
        {
            EditContact();
        }

        //message list click
        private void OnMessagesDoubleClick(object sender, EventArgs e)
        {
            SendMessage();
        }

        //send
        private void OnContactsSend(object sender, EventArgs e)
        {
            SendMessage();
        }

        //delete contact
        private void OnContactsDelete(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this contact?",
                "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;

            DeleteContact();
        }

        //helper delete contact
        private void DeleteContact()
        {
            var item = GetSelectedContact();
            if (item == null)
                return;

            _database.RemoveContact(item.Name);
            RefreshContact();
        }

        //helper delete message
        private void DeleteMessage()
        {
            var item = GetSelectedMessage();
            if (item == null)
                return;

            _database.RemoveMessage(item.Body);
            RefreshMessage();
        }

        //helper edit 
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

        //helper send
        private void SendMessage()
        {
            var item = GetSelectedMessage();
            if (item == null)
                return;

            var form = new SendForm();
            form.Contact = item;
            if (form.ShowDialog(this) == DialogResult.Cancel)
                return;

            _database.SendMessage(item.Body, form.Contact);
            RefreshMessage();
        }

        //select contact
        private Contact GetSelectedContact()
        {
            return _listContacts.SelectedItem as Contact;
        }

        //helper refresh contact
        private void RefreshContact()
        {
            var contact = _database.GetAll();

            _listContacts.Items.Clear();
            _listContacts.Items.Add(contact);
        }

        //select message
        private Contact GetSelectedMessage()
        {
            return _listMessages.SelectedItem as Contact;
        }

        //helper refresh message
        private void RefreshMessage()
        {
            var message = _database.GetAll();

            _listMessages.Items.Clear();
            _listMessages.Items.Add(message);
        }

        private ContactData _database = new ContactData();
    }
}
