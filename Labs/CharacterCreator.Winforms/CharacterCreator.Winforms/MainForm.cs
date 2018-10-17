using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterCreator.Winforms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            _listCharacter.DisplayMember = "Name";
            RefreshCharacter();
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
            MessageBox.Show(this, "Alex Malone\nITSE1430\nCharacter Creator",
            "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //new character
        private void OnCharacterNew(object sender, EventArgs e)
        {
            var form = new CharacterCreatorForm();

            if (form.ShowDialog(this) == DialogResult.Cancel)
                return;

            _database.AddCharacter(form.Character);
            RefreshCharacter();
        }

        //double click listed character
        private void OnCharacterDoubleClick(object sender, EventArgs e)
        {
            EditCharacter();
        }

        //edit
        private void OnCharacterEdit(object sender, EventArgs e)
        {
            EditCharacter();
        }

        //delete
        private void OnCharacterDelete(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this character?",
            "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;

            DeleteCharacter();
        }

        //cycle listbox
        private void OnListKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                DeleteCharacter();
            };
        }

        private void EditCharacter()
        {
            var item = GetSelectedCharacter();
            if (item == null)
                return;

            var form = new CharacterCreatorForm();
            form.Character = item;
            if (form.ShowDialog(this) == DialogResult.Cancel)
                return;

            _database.EditCharacter(item.Name, form.Character);
            RefreshCharacter();
        }

        private void DeleteCharacter()
        {
            var item = GetSelectedCharacter();
            if (item == null)
                return;

            _database.RemoveCharacter(item.Name);
            RefreshCharacter();
        }

        private void RefreshCharacter()
        {
            var character = _database.GetAll();

            _listCharacter.Items.Clear();
            _listCharacter.Items.AddRange(character);
        }

        private Character GetSelectedCharacter()
        {
            return _listCharacter.SelectedItem as Character;
        }

        private CharacterData _database = new CharacterData();
    }
}
