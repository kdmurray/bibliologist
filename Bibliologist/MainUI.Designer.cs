namespace Bibliologist
{
    partial class MainUI
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
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.listView1 = new System.Windows.Forms.ListView();
            this.VolumeFormat = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.VolumeLocation = new System.Windows.Forms.ComboBox();
            this.Authors = new System.Windows.Forms.TextBox();
            this.Rating = new System.Windows.Forms.TextBox();
            this.Isbn = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.TextBox();
            this.Publisher = new System.Windows.Forms.TextBox();
            this.PublishedYear = new System.Windows.Forms.TextBox();
            this.Synopsis = new System.Windows.Forms.TextBox();
            this.Comments = new System.Windows.Forms.TextBox();
            this.VolumeStatus = new System.Windows.Forms.ComboBox();
            this.Editors = new System.Windows.Forms.TextBox();
            this.Translators = new System.Windows.Forms.TextBox();
            this.Genres = new System.Windows.Forms.CheckedListBox();
            this.People = new System.Windows.Forms.GroupBox();
            this.Details = new System.Windows.Forms.GroupBox();
            this.Subtitle = new System.Windows.Forms.TextBox();
            this.mainMenu.SuspendLayout();
            this.People.SuspendLayout();
            this.Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(919, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // statusBar
            // 
            this.statusBar.Location = new System.Drawing.Point(0, 503);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(919, 22);
            this.statusBar.TabIndex = 1;
            this.statusBar.Text = "statusStrip1";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(12, 42);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(288, 458);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // VolumeFormat
            // 
            this.VolumeFormat.FormattingEnabled = true;
            this.VolumeFormat.Location = new System.Drawing.Point(6, 19);
            this.VolumeFormat.Name = "VolumeFormat";
            this.VolumeFormat.Size = new System.Drawing.Size(176, 21);
            this.VolumeFormat.TabIndex = 3;
            this.VolumeFormat.Text = "Format";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(751, 477);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(832, 477);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // VolumeLocation
            // 
            this.VolumeLocation.FormattingEnabled = true;
            this.VolumeLocation.Location = new System.Drawing.Point(6, 45);
            this.VolumeLocation.Name = "VolumeLocation";
            this.VolumeLocation.Size = new System.Drawing.Size(176, 21);
            this.VolumeLocation.TabIndex = 6;
            this.VolumeLocation.Text = "Location";
            // 
            // Authors
            // 
            this.Authors.Location = new System.Drawing.Point(6, 19);
            this.Authors.Multiline = true;
            this.Authors.Name = "Authors";
            this.Authors.Size = new System.Drawing.Size(270, 68);
            this.Authors.TabIndex = 7;
            this.Authors.Text = "Authors";
            // 
            // Rating
            // 
            this.Rating.Location = new System.Drawing.Point(6, 99);
            this.Rating.Name = "Rating";
            this.Rating.Size = new System.Drawing.Size(100, 20);
            this.Rating.TabIndex = 8;
            this.Rating.Text = "Rating";
            // 
            // Isbn
            // 
            this.Isbn.Location = new System.Drawing.Point(306, 42);
            this.Isbn.Name = "Isbn";
            this.Isbn.Size = new System.Drawing.Size(234, 20);
            this.Isbn.TabIndex = 9;
            this.Isbn.Text = "ISBN";
            // 
            // Title
            // 
            this.Title.Location = new System.Drawing.Point(306, 68);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(234, 20);
            this.Title.TabIndex = 10;
            this.Title.Text = "Title";
            // 
            // Publisher
            // 
            this.Publisher.Location = new System.Drawing.Point(753, 43);
            this.Publisher.Name = "Publisher";
            this.Publisher.Size = new System.Drawing.Size(100, 20);
            this.Publisher.TabIndex = 14;
            this.Publisher.Text = "Publisher";
            // 
            // PublishedYear
            // 
            this.PublishedYear.Location = new System.Drawing.Point(753, 69);
            this.PublishedYear.Name = "PublishedYear";
            this.PublishedYear.Size = new System.Drawing.Size(100, 20);
            this.PublishedYear.TabIndex = 15;
            this.PublishedYear.Text = "PubYear";
            // 
            // Synopsis
            // 
            this.Synopsis.Location = new System.Drawing.Point(306, 316);
            this.Synopsis.Multiline = true;
            this.Synopsis.Name = "Synopsis";
            this.Synopsis.Size = new System.Drawing.Size(224, 61);
            this.Synopsis.TabIndex = 16;
            this.Synopsis.Text = "Synopsis";
            // 
            // Comments
            // 
            this.Comments.Location = new System.Drawing.Point(306, 383);
            this.Comments.Multiline = true;
            this.Comments.Name = "Comments";
            this.Comments.Size = new System.Drawing.Size(224, 61);
            this.Comments.TabIndex = 17;
            this.Comments.Text = "Comments";
            // 
            // VolumeStatus
            // 
            this.VolumeStatus.FormattingEnabled = true;
            this.VolumeStatus.Location = new System.Drawing.Point(6, 72);
            this.VolumeStatus.Name = "VolumeStatus";
            this.VolumeStatus.Size = new System.Drawing.Size(176, 21);
            this.VolumeStatus.TabIndex = 18;
            this.VolumeStatus.Text = "Status";
            // 
            // Editors
            // 
            this.Editors.Location = new System.Drawing.Point(6, 93);
            this.Editors.Multiline = true;
            this.Editors.Name = "Editors";
            this.Editors.Size = new System.Drawing.Size(270, 68);
            this.Editors.TabIndex = 20;
            this.Editors.Text = "Editors";
            // 
            // Translators
            // 
            this.Translators.Location = new System.Drawing.Point(6, 167);
            this.Translators.Multiline = true;
            this.Translators.Name = "Translators";
            this.Translators.Size = new System.Drawing.Size(270, 68);
            this.Translators.TabIndex = 21;
            this.Translators.Text = "Translators";
            // 
            // Genres
            // 
            this.Genres.FormattingEnabled = true;
            this.Genres.Location = new System.Drawing.Point(571, 383);
            this.Genres.Name = "Genres";
            this.Genres.Size = new System.Drawing.Size(282, 79);
            this.Genres.TabIndex = 22;
            // 
            // People
            // 
            this.People.Controls.Add(this.Authors);
            this.People.Controls.Add(this.Editors);
            this.People.Controls.Add(this.Translators);
            this.People.Location = new System.Drawing.Point(571, 121);
            this.People.Name = "People";
            this.People.Size = new System.Drawing.Size(282, 243);
            this.People.TabIndex = 23;
            this.People.TabStop = false;
            this.People.Text = "People";
            // 
            // Details
            // 
            this.Details.Controls.Add(this.VolumeFormat);
            this.Details.Controls.Add(this.VolumeLocation);
            this.Details.Controls.Add(this.Rating);
            this.Details.Controls.Add(this.VolumeStatus);
            this.Details.Location = new System.Drawing.Point(306, 180);
            this.Details.Name = "Details";
            this.Details.Size = new System.Drawing.Size(195, 130);
            this.Details.TabIndex = 24;
            this.Details.TabStop = false;
            this.Details.Text = "Details";
            // 
            // Subtitle
            // 
            this.Subtitle.Location = new System.Drawing.Point(306, 94);
            this.Subtitle.Name = "Subtitle";
            this.Subtitle.Size = new System.Drawing.Size(234, 20);
            this.Subtitle.TabIndex = 25;
            this.Subtitle.Text = "Subtitle";
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 525);
            this.Controls.Add(this.Subtitle);
            this.Controls.Add(this.Details);
            this.Controls.Add(this.People);
            this.Controls.Add(this.Genres);
            this.Controls.Add(this.Comments);
            this.Controls.Add(this.Synopsis);
            this.Controls.Add(this.PublishedYear);
            this.Controls.Add(this.Publisher);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Isbn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainUI";
            this.Text = "Bibliologist";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.People.ResumeLayout(false);
            this.People.PerformLayout();
            this.Details.ResumeLayout(false);
            this.Details.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ComboBox VolumeFormat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox VolumeLocation;
        private System.Windows.Forms.TextBox Authors;
        private System.Windows.Forms.TextBox Rating;
        private System.Windows.Forms.TextBox Isbn;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.TextBox Publisher;
        private System.Windows.Forms.TextBox PublishedYear;
        private System.Windows.Forms.TextBox Synopsis;
        private System.Windows.Forms.TextBox Comments;
        private System.Windows.Forms.ComboBox VolumeStatus;
        private System.Windows.Forms.TextBox Editors;
        private System.Windows.Forms.TextBox Translators;
        private System.Windows.Forms.CheckedListBox Genres;
        private System.Windows.Forms.GroupBox People;
        private System.Windows.Forms.GroupBox Details;
        private System.Windows.Forms.TextBox Subtitle;
    }
}