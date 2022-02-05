using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Launcher : Form
    {
        public Launcher()
        {
            InitializeComponent(); LoadingStatusBar.Text = "Loading";
            LoadingProgressBar.Value = 0;
            btnPlay.Enabled = false;
            LoadingTimer.Start();
        }

        private void LaunchGame(object sender, EventArgs e)
        {
            this.Hide();
            Game game = new Game();
            game.ShowDialog();
            this.Close();
        }

        int percentage = 0;

        private void LoadingTick(object sender, EventArgs e)
        {
            LoadingProgressBar.Value = percentage++;

            if (LoadingProgressBar.Value >= 100)
            {
                LoadingTimer.Stop();
                LoadingStatusBar.Text = "Complete";
                btnPlay.Enabled = true;
            }
        }
    }
}
