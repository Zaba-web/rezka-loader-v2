using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rezka_loader_v2
{
 
    public partial class Search : Form
    {
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        private MovieSearch searcher;
        private String searchPlaceholder = "Enter movie name or page URL";

        public Search()
        {
            InitializeComponent();
            this.searcher = new MovieSearch();
        }

        private void Search_Load(object sender, EventArgs e)
        {
            searchBox.Text = searchPlaceholder;
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void findBtn_Click(object sender, EventArgs e)
        {
            this.displaySearchResults();
        }

        private void searchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.displaySearchResults();
            }
        }

        private void displaySearchResults()
        {
            moviestList.Clear();

            if (searchBox.Text.Length == 0)
            {
                MessageBox.Show("Enter the search request.", "Error");
                return;
            }

            if (searchBox.Text.Contains("https://"))
            {
                new DownloadConfigurationForm(searchBox.Text).Show();
                return;
            }

            ArrayList movies = searcher.PerformSearch(searchBox.Text);

            if (movies == null)
            {
                MessageBox.Show("Nothing is found.", "Error");
                return;
            }

            foreach (MovieLink movie in movies)
            {
                ListViewItem movieListItem = new ListViewItem(movie.GetTitle());
                movieListItem.SubItems.Add(movie.GetLink());
                moviestList.Items.Add(movieListItem);
            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchBox_Enter(object sender, EventArgs e)
        {
            if(searchBox.Text == searchPlaceholder)
            {
                searchBox.Text = "";
            }
        }

        private void downloadBtn_Click(object sender, EventArgs e)
        {
            if (moviestList.SelectedItems.Count < 1)
            {
                return;
            }

            ListViewItem item = moviestList.SelectedItems[0];
            String link = item.SubItems[1].Text;

            new DownloadConfigurationForm(link).Show();
        }
    }
}
