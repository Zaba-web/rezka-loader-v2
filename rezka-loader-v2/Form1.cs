using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rezka_loader_v2
{
    public partial class Main : Form
    {
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        public Main()
        {
            InitializeComponent();
            updateTimer.Start();
            
        }

        private void Main_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = pictureBox1.InitialImage;
            label2.Text = Versioning.CURRENT_VESION;

            var ver = Versioning.CheckUpdate();
            if (ver != null)
            {
                var updateAvailableForm = new UpdateAvailable();
                updateAvailableForm.versionData = ver;
                updateAvailableForm.Show(this);
            }

            DownloadStatus.Get().InitFromHistory();
            UpdateDownloadsList();
        }
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form searchForm = new Search();
            searchForm.Show();
        }

        public void UpdateDownloadsList()
        {
            downloadsList.Items.Clear();
            foreach (var file in DownloadStatus.Get().GetFiles())
            {
                ListViewItem movieListItem = new ListViewItem(file.Key);
                movieListItem.SubItems.Add(file.Value[1]);
                downloadsList.Items.Add(movieListItem);
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void updateTimer_Tick(object sender, EventArgs e)
        {
            UpdateDownloadsList();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (downloadClientAlto.Checked)
            {
                DownloadStatus.DownloadClient = DownloadStatus.ALTO;
            }
        }

        private void downloadClient_CheckedChanged(object sender, EventArgs e)
        {
            if (downloadClient.Checked)
            {
                DownloadStatus.DownloadClient = DownloadStatus.NATIVE;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void downloadsList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void downloadsList_DoubleClick(object sender, EventArgs e)
        {
            var selectedItems = downloadsList.SelectedItems;

            if (selectedItems.Count == 0)
            {
                return;
            }

            var subitems = selectedItems[0].SubItems;

            if (subitems.Count == 0)
            {
                return;
            }

            String filename = subitems[0].Text;
            foreach (var file in DownloadStatus.Get().GetFiles()) {
                if (file.Key == filename)
                {
                    String[] parts = file.Value[0].Split('\\').Reverse().Skip(1).Reverse().ToArray();
                    String path = String.Join("\\", parts);

                    Process.Start(path);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DownloadStatus.Get().ClearHistory();
                UpdateDownloadsList();
            } catch {
                MessageBox.Show("Error", "Error occured while clearing history.");
            }
        }
    }
}
