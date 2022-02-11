using GUI.GameScenes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.LauncherScenes
{
    public partial class LauncherMenu : UserControl
    {
        public LauncherMenu()
        {
            InitializeComponent();
            LoadingStatusBar.Text = "Loading";
            LoadingProgressBar.Value = 0;
            btnPlay.Enabled = false;
            LoadingTimer.Start();
        }
        private void LaunchGame(object sender, EventArgs e)
        {
            Game game = new Game();
            this.Parent.Hide();
            game.ShowDialog();
            this.Parent.Show();
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
