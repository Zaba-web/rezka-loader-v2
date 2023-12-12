using System;
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
    public partial class DownloadConfigurationForm : Form
    {
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;
        private String url = "";
        private int movieId = -1;
        private CDNService cdnService;

        public DownloadConfigurationForm(String url)
        {
            InitializeComponent();
            this.url = url;
            this.cdnService = new CDNService();
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private void DownloadConfigurationForm_Load(object sender, EventArgs e)
        {
            MoviePageData data = this.cdnService.GetMovieDownloadOptions(url);

            if (data == null)
            {
                MessageBox.Show("Couldn't fetch movie data", "Error");
                return;
            }

            this.movieId = data.MovieId;

            foreach (Translator translator in data.Translations)
            {
                translationSelector.Items.Add(translator.getName() + " [" + translator.getId() + "]");
            }
            translationSelector.SelectedIndex = 0; 

            if (data.Seasons == null || data.Seasons.Count == 0)
            {
                seasonSelector.Enabled = false;
            } else
            {
                foreach (Season season in data.Seasons)
                {
                    seasonSelector.Items.Add(season.GetSeasonTitle() + " [" + season.GetSeasonId() + "]");
                }
                seasonSelector.SelectedIndex = seasonSelector.Items.Count - 1;
            }

            if (data.Episodes == null || data.Episodes.Count == 0)
            {
                episodeSelector.Enabled = false;
            }
            else
            {
                foreach (Episode episode in data.Episodes)
                {
                    episodeSelector.Items.Add(episode.GetEpisodeTitle() + " [" + episode.GetEpisodeId() + "]");
                }
                episodeSelector.SelectedIndex = episodeSelector.Items.Count - 1;
            }
        }

        private void searchLabel_Click(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            int translatorId = GetId(this.translationSelector.Items[translationSelector.SelectedIndex].ToString());
            System.Collections.Generic.Dictionary<string, string> links = null;

            if (!seasonSelector.Enabled)
            {
                links = cdnService.GetCDNLinks(this.movieId, translatorId);
            } else
            {
                int season = GetId(this.seasonSelector.Items[seasonSelector.SelectedIndex].ToString());
                int episode = GetId(this.episodeSelector.Items[episodeSelector.SelectedIndex].ToString());

                links = cdnService.GetCDNLinks(this.movieId, translatorId, season, episode);
            }

            if (links != null)
            {
                nextBtn.Visible = false;
                downloadBtn.Visible = true;
                qualityLabel.Visible = true;

                qualityList.DataSource = new BindingSource(links, null);
                qualityList.DisplayMember = "Key";
                qualityList.ValueMember = "Value";

                qualityList.Visible = true;
            }
        }

        private int GetId(String str)
        {
            return Int32.Parse(str.Split('[')[1].Split(']')[0]);
        }

        private void downloadBtn_Click(object sender, EventArgs e)
        {
            String link = qualityList.SelectedValue.ToString();
            string fileName = "";

            SaveFileDialog oSaveFileDialog = new SaveFileDialog();
            oSaveFileDialog.Filter = "All files (*.*) | *.*";
            oSaveFileDialog.FileName = link.Split('/').Last();

            if (oSaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    fileName = oSaveFileDialog.FileName;
                    new RezkaClient().DownloadFile(link, fileName);
                } catch (Exception ex)
                {
                    MessageBox.Show("Unknown error occured. Please try again.", "Error");
                }
                this.Close();
            }
        }
    }
}
