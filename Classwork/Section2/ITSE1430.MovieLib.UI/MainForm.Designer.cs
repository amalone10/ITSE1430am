﻿namespace ITSE1430.MovieLib.UI
{
    partial class MainForm
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
            this._mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._miFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.movieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._miMovieAdd = new System.Windows.Forms.ToolStripMenuItem();
            this._miMovieEdit = new System.Windows.Forms.ToolStripMenuItem();
            this._miMovieDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._miHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this._listMovies = new System.Windows.Forms.ListBox();
            this._mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // _mainMenu
            // 
            this._mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.movieToolStripMenuItem,
            this.helpToolStripMenuItem});
            this._mainMenu.Location = new System.Drawing.Point(0, 0);
            this._mainMenu.Name = "_mainMenu";
            this._mainMenu.Size = new System.Drawing.Size(684, 24);
            this._mainMenu.TabIndex = 0;
            this._mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._miFileExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // _miFileExit
            // 
            this._miFileExit.Name = "_miFileExit";
            this._miFileExit.Size = new System.Drawing.Size(180, 22);
            this._miFileExit.Text = "E&xit";
            this._miFileExit.Click += new System.EventHandler(this.OnFileExit);
            // 
            // movieToolStripMenuItem
            // 
            this.movieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._miMovieAdd,
            this._miMovieEdit,
            this._miMovieDelete});
            this.movieToolStripMenuItem.Name = "movieToolStripMenuItem";
            this.movieToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.movieToolStripMenuItem.Text = "&Movie";
            // 
            // _miMovieAdd
            // 
            this._miMovieAdd.Name = "_miMovieAdd";
            this._miMovieAdd.ShortcutKeys = System.Windows.Forms.Keys.Insert;
            this._miMovieAdd.Size = new System.Drawing.Size(180, 22);
            this._miMovieAdd.Text = "Add";
            this._miMovieAdd.Click += new System.EventHandler(this.OnMovieAdd);
            // 
            // _miMovieEdit
            // 
            this._miMovieEdit.Name = "_miMovieEdit";
            this._miMovieEdit.Size = new System.Drawing.Size(180, 22);
            this._miMovieEdit.Text = "Edit";
            this._miMovieEdit.Click += new System.EventHandler(this.OnMovieEdit);
            // 
            // _miMovieDelete
            // 
            this._miMovieDelete.Name = "_miMovieDelete";
            this._miMovieDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this._miMovieDelete.Size = new System.Drawing.Size(180, 22);
            this._miMovieDelete.Text = "Delete";
            this._miMovieDelete.Click += new System.EventHandler(this.OnMovieDelete);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._miHelpAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // _miHelpAbout
            // 
            this._miHelpAbout.Name = "_miHelpAbout";
            this._miHelpAbout.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this._miHelpAbout.Size = new System.Drawing.Size(126, 22);
            this._miHelpAbout.Text = "About";
            this._miHelpAbout.Click += new System.EventHandler(this.OnHelpAbout);
            // 
            // _listMovies
            // 
            this._listMovies.Dock = System.Windows.Forms.DockStyle.Fill;
            this._listMovies.FormattingEnabled = true;
            this._listMovies.Location = new System.Drawing.Point(0, 24);
            this._listMovies.Name = "_listMovies";
            this._listMovies.Size = new System.Drawing.Size(684, 437);
            this._listMovies.TabIndex = 1;
            this._listMovies.DoubleClick += new System.EventHandler(this.OnMovieDoubleClick);
            this._listMovies.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnListKeyUp);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this._listMovies);
            this.Controls.Add(this._mainMenu);
            this.MainMenuStrip = this._mainMenu;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movie Library";
            this._mainMenu.ResumeLayout(false);
            this._mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip _mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _miFileExit;
        private System.Windows.Forms.ToolStripMenuItem _miMovieAdd;
        private System.Windows.Forms.ToolStripMenuItem _miMovieEdit;
        private System.Windows.Forms.ToolStripMenuItem _miMovieDelete;
        private System.Windows.Forms.ToolStripMenuItem _miHelpAbout;
        private System.Windows.Forms.ListBox _listMovies;
    }
}

