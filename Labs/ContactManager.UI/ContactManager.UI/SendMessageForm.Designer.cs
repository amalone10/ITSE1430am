namespace ContactManager.UI
{
    partial class SendMessageForm
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
            this.label2 = new System.Windows.Forms.Label();
            this._txtEmail = new System.Windows.Forms.TextBox();
            this._txtSubject = new System.Windows.Forms.TextBox();
            this._txtBody = new System.Windows.Forms.TextBox();
            this._btnSend = new System.Windows.Forms.Button();
            this._btnCancel = new System.Windows.Forms.Button();
            this._errors = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._errors)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Subject";
            // 
            // _txtEmail
            // 
            this._txtEmail.Location = new System.Drawing.Point(12, 34);
            this._txtEmail.Name = "_txtEmail";
            this._txtEmail.Size = new System.Drawing.Size(250, 20);
            this._txtEmail.TabIndex = 1;
            // 
            // _txtSubject
            // 
            this._txtSubject.Location = new System.Drawing.Point(12, 82);
            this._txtSubject.Name = "_txtSubject";
            this._txtSubject.Size = new System.Drawing.Size(250, 20);
            this._txtSubject.TabIndex = 2;
            this._txtSubject.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingSubject);
            // 
            // _txtBody
            // 
            this._txtBody.Location = new System.Drawing.Point(12, 108);
            this._txtBody.Multiline = true;
            this._txtBody.Name = "_txtBody";
            this._txtBody.Size = new System.Drawing.Size(260, 178);
            this._txtBody.TabIndex = 3;
            // 
            // _btnSend
            // 
            this._btnSend.Location = new System.Drawing.Point(15, 376);
            this._btnSend.Name = "_btnSend";
            this._btnSend.Size = new System.Drawing.Size(75, 23);
            this._btnSend.TabIndex = 4;
            this._btnSend.Text = "Send";
            this._btnSend.UseVisualStyleBackColor = true;
            this._btnSend.Click += new System.EventHandler(this.OnSend);
            // 
            // _btnCancel
            // 
            this._btnCancel.Location = new System.Drawing.Point(197, 376);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(75, 23);
            this._btnCancel.TabIndex = 5;
            this._btnCancel.Text = "Cancel";
            this._btnCancel.UseVisualStyleBackColor = true;
            this._btnCancel.Click += new System.EventHandler(this.OnCancel);
            // 
            // _errors
            // 
            this._errors.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this._errors.ContainerControl = this;
            // 
            // SendMessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 411);
            this.ControlBox = false;
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._btnSend);
            this.Controls.Add(this._txtBody);
            this.Controls.Add(this._txtSubject);
            this.Controls.Add(this._txtEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(350, 500);
            this.MinimumSize = new System.Drawing.Size(250, 400);
            this.Name = "SendMessageForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Compose Message";
            this.Load += new System.EventHandler(this.SendMessageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._errors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _txtEmail;
        private System.Windows.Forms.TextBox _txtSubject;
        private System.Windows.Forms.TextBox _txtBody;
        private System.Windows.Forms.Button _btnSend;
        private System.Windows.Forms.Button _btnCancel;
        private System.Windows.Forms.ErrorProvider _errors;
    }
}