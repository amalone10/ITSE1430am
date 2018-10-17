namespace CharacterCreator.Winforms
{
    partial class CharacterCreatorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this._txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._comboProfession = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this._comboRace = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this._txtDescription = new System.Windows.Forms.TextBox();
            this._btnSave = new System.Windows.Forms.Button();
            this._btnCancel = new System.Windows.Forms.Button();
            this._txtStrength = new System.Windows.Forms.TextBox();
            this._txtCharisma = new System.Windows.Forms.TextBox();
            this._txtAgility = new System.Windows.Forms.TextBox();
            this._txtConstitution = new System.Windows.Forms.TextBox();
            this._txtIntelligence = new System.Windows.Forms.TextBox();
            this._errors = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._errors)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // _txtName
            // 
            this._txtName.Location = new System.Drawing.Point(73, 10);
            this._txtName.Name = "_txtName";
            this._txtName.Size = new System.Drawing.Size(168, 20);
            this._txtName.TabIndex = 1;
            this._txtName.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidateName);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Profession";
            // 
            // _comboProfession
            // 
            this._comboProfession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboProfession.FormattingEnabled = true;
            this._comboProfession.Items.AddRange(new object[] {
            "Fighter",
            "Hunter",
            "Priest",
            "Rogue",
            "Wizard"});
            this._comboProfession.Location = new System.Drawing.Point(73, 42);
            this._comboProfession.Name = "_comboProfession";
            this._comboProfession.Size = new System.Drawing.Size(121, 21);
            this._comboProfession.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Race";
            // 
            // _comboRace
            // 
            this._comboRace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboRace.FormattingEnabled = true;
            this._comboRace.Items.AddRange(new object[] {
            "Dwarf",
            "Elf",
            "Gnome",
            "Half Elf",
            "Human"});
            this._comboRace.Location = new System.Drawing.Point(73, 75);
            this._comboRace.Name = "_comboRace";
            this._comboRace.Size = new System.Drawing.Size(121, 21);
            this._comboRace.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Strength";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Constitution";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(115, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Intelligence";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Charisma";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Agility";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Description";
            // 
            // _txtDescription
            // 
            this._txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._txtDescription.Location = new System.Drawing.Point(73, 219);
            this._txtDescription.Multiline = true;
            this._txtDescription.Name = "_txtDescription";
            this._txtDescription.Size = new System.Drawing.Size(171, 100);
            this._txtDescription.TabIndex = 9;
            // 
            // _btnSave
            // 
            this._btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnSave.Location = new System.Drawing.Point(88, 351);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(75, 23);
            this._btnSave.TabIndex = 10;
            this._btnSave.Text = "Save";
            this._btnSave.UseVisualStyleBackColor = true;
            this._btnSave.Click += new System.EventHandler(this.OnSave);
            // 
            // _btnCancel
            // 
            this._btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnCancel.CausesValidation = false;
            this._btnCancel.Location = new System.Drawing.Point(169, 351);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(75, 23);
            this._btnCancel.TabIndex = 11;
            this._btnCancel.Text = "Cancel";
            this._btnCancel.UseVisualStyleBackColor = true;
            this._btnCancel.Click += new System.EventHandler(this.OnCancel);
            // 
            // _txtStrength
            // 
            this._txtStrength.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this._txtStrength.Location = new System.Drawing.Point(73, 109);
            this._txtStrength.Name = "_txtStrength";
            this._txtStrength.Size = new System.Drawing.Size(29, 20);
            this._txtStrength.TabIndex = 4;
            this._txtStrength.Text = "50";
            this._txtStrength.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidateStrength);
            // 
            // _txtCharisma
            // 
            this._txtCharisma.Location = new System.Drawing.Point(73, 185);
            this._txtCharisma.Name = "_txtCharisma";
            this._txtCharisma.Size = new System.Drawing.Size(29, 20);
            this._txtCharisma.TabIndex = 6;
            this._txtCharisma.Text = "50";
            this._txtCharisma.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidateCharisma);
            // 
            // _txtAgility
            // 
            this._txtAgility.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this._txtAgility.Location = new System.Drawing.Point(73, 146);
            this._txtAgility.Name = "_txtAgility";
            this._txtAgility.Size = new System.Drawing.Size(29, 20);
            this._txtAgility.TabIndex = 5;
            this._txtAgility.Text = "50";
            this._txtAgility.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidateAgility);
            // 
            // _txtConstitution
            // 
            this._txtConstitution.Location = new System.Drawing.Point(182, 146);
            this._txtConstitution.Name = "_txtConstitution";
            this._txtConstitution.Size = new System.Drawing.Size(29, 20);
            this._txtConstitution.TabIndex = 8;
            this._txtConstitution.Text = "50";
            this._txtConstitution.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidateConstitution);
            // 
            // _txtIntelligence
            // 
            this._txtIntelligence.Location = new System.Drawing.Point(182, 109);
            this._txtIntelligence.Name = "_txtIntelligence";
            this._txtIntelligence.Size = new System.Drawing.Size(29, 20);
            this._txtIntelligence.TabIndex = 7;
            this._txtIntelligence.Text = "50";
            this._txtIntelligence.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidateIntelligence);
            // 
            // _errors
            // 
            this._errors.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this._errors.ContainerControl = this;
            // 
            // CharacterCreatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 386);
            this.ControlBox = false;
            this.Controls.Add(this._txtIntelligence);
            this.Controls.Add(this._txtConstitution);
            this.Controls.Add(this._txtAgility);
            this.Controls.Add(this._txtCharisma);
            this.Controls.Add(this._txtStrength);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._btnSave);
            this.Controls.Add(this._txtDescription);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._comboRace);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._comboProfession);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._txtName);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(275, 425);
            this.MinimumSize = new System.Drawing.Size(275, 425);
            this.Name = "CharacterCreatorForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create New Character";
            this.Load += new System.EventHandler(this.CharacterCreatorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._errors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox _txtDescription;
        private System.Windows.Forms.Button _btnSave;
        private System.Windows.Forms.Button _btnCancel;
        private System.Windows.Forms.TextBox _txtStrength;
        private System.Windows.Forms.TextBox _txtCharisma;
        private System.Windows.Forms.TextBox _txtAgility;
        private System.Windows.Forms.TextBox _txtConstitution;
        private System.Windows.Forms.TextBox _txtIntelligence;
        private System.Windows.Forms.ErrorProvider _errors;
        private System.Windows.Forms.ComboBox _comboProfession;
        private System.Windows.Forms.ComboBox _comboRace;
    }
}