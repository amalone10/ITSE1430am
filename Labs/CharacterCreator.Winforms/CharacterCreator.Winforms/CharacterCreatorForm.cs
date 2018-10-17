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
    public partial class CharacterCreatorForm : Form
    {
        public CharacterCreatorForm()
        {
            InitializeComponent();
        }

        public Character Character { get; set; }

        private void CharacterCreatorForm_Load(object sender, EventArgs e)
        {
            if (Character != null)
            {
                _txtName.Text = Character.Name;
                _comboProfession.Text = Character.Profession;
                _comboRace.Text = Character.Race;
                _txtStrength.Text = Character.Strength.ToString();
                _txtAgility.Text = Character.Agility.ToString();
                _txtCharisma.Text = Character.Charisma.ToString();
                _txtIntelligence.Text = Character.Intelligence.ToString();
                _txtConstitution.Text = Character.Constitution.ToString();
                _txtDescription.Text = Character.Description;
            }

            ValidateChildren();
        }

        private int GetInt32(TextBox textBox)
        {
            if (String.IsNullOrEmpty(textBox.Text))
                return -1;

            if (Int32.TryParse(textBox.Text, out var value))
                return value;

            return -1;
        }

        private void OnValidateName(object sender, CancelEventArgs e)
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

        private void OnCancel(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void OnSave(object sender, EventArgs e)
        {
            if (!ValidateChildren())
                return;

            var character = new Character()
            {
                Name = _txtName.Text,
                Profession = _comboProfession.Text,
                Race = _comboRace.Text,
                Strength = GetInt32(_txtStrength),
                Agility = GetInt32(_txtAgility),
                Charisma = GetInt32(_txtCharisma),
                Intelligence = GetInt32(_txtIntelligence),
                Constitution = GetInt32(_txtConstitution),
                Description = _txtDescription.Text,
            };

            Character = character;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
