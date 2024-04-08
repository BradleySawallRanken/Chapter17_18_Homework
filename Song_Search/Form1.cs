using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Song_Search
{
    public partial class frmSongSearch : Form
    {
        const string NOTHINGINPUTTED = "No Value Was Inputted";
        const string NOSONGTITLEFOUND = "No Matching Song Title Found";
        const string NOSONGARTISTFOUND = "No Matching Song Artist Found";
        const string NOSONGGENREFOUND = "No Matching Song Genre Found";

        static List<Song> songs = SongManager.LoadData();

        public frmSongSearch()
        {
            InitializeComponent();
        }

        public class Song
        {
            public string SongTitle { get; set; }
            public string SongArtist { get; set; }
            public string SongGenre { get; set; }

            public override string ToString()
            {
                return "Song Title: " + SongTitle + "\n" +
                    "Song Artist: " + SongArtist + "\n" +
                    "Song Genre: " + SongGenre + "\n";

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DecideWhichFunctionToCall();
        }

        private void DecideWhichFunctionToCall()
        {
            int option = ddlSongSearch.SelectedIndex;

            switch (option)
            {
                case -1:
                    ShowErrorMessage(NOTHINGINPUTTED);
                    break;
                    // Add more cases for different search options
            }
        }

        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            lvSongSearch.Items.Clear();
            ddlSongSearch.SelectedIndex = -1;
            ddlSongSearch.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit the program?", "Exit Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

    }
}