namespace Song_Search
{
    partial class frmSongSearch
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
            this.ddlLinqQueries = new System.Windows.Forms.ComboBox();
            this.lstSongList = new System.Windows.Forms.ListView();
            this.songTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.songArtist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.songGenre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ddlLinqQueries
            // 
            this.ddlLinqQueries.FormattingEnabled = true;
            this.ddlLinqQueries.Items.AddRange(new object[] {
            "Show SongList By Title Ascending",
            "Show SongList By Artist Ascending",
            "Show SongList By Genre Ascending",
            "Show SongList By Title Criteria",
            "Show SongList By Artist Criteria",
            "Show SongList By Genre Criteria"});
            this.ddlLinqQueries.Location = new System.Drawing.Point(860, 24);
            this.ddlLinqQueries.Margin = new System.Windows.Forms.Padding(2);
            this.ddlLinqQueries.Name = "ddlLinqQueries";
            this.ddlLinqQueries.Size = new System.Drawing.Size(370, 21);
            this.ddlLinqQueries.TabIndex = 1;
            // 
            // lstSongList
            // 
            this.lstSongList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.songTitle,
            this.songArtist,
            this.songGenre});
            this.lstSongList.HideSelection = false;
            this.lstSongList.Location = new System.Drawing.Point(87, 48);
            this.lstSongList.Margin = new System.Windows.Forms.Padding(2);
            this.lstSongList.Name = "lstSongList";
            this.lstSongList.Size = new System.Drawing.Size(675, 565);
            this.lstSongList.TabIndex = 2;
            this.lstSongList.UseCompatibleStateImageBehavior = false;
            // 
            // songTitle
            // 
            this.songTitle.Text = "Song Title";
            this.songTitle.Width = 250;
            // 
            // songArtist
            // 
            this.songArtist.Text = "Song Artist";
            this.songArtist.Width = 250;
            // 
            // songGenre
            // 
            this.songGenre.Text = "Song Genre";
            this.songGenre.Width = 250;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(893, 333);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(314, 71);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(893, 460);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(314, 71);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(893, 584);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(314, 71);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(84, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(656, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // frmSongSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 677);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lstSongList);
            this.Controls.Add(this.ddlLinqQueries);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmSongSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Song Search";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox ddlLinqQueries;
        private System.Windows.Forms.ListView lstSongList;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ColumnHeader songTitle;
        private System.Windows.Forms.ColumnHeader songArtist;
        private System.Windows.Forms.ColumnHeader songGenre;
        private System.Windows.Forms.Label label1;
    }
}

