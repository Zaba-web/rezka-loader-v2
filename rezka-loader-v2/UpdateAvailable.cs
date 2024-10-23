using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rezka_loader_v2
{
    public partial class UpdateAvailable : Form
    {
        public VersionData versionData { get; set; }

        public UpdateAvailable()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void UpdateAvailable_Load(object sender, EventArgs e)
        {
            updates.Text = versionData.new_in_release;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(versionData.update_url);
        }
    }
}
