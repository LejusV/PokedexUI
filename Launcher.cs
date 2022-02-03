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
            long loading = 0;
            while (loading++ < 2000000) LoadingProgressBar.Value = (int)(loading / 20000);
            LoadingStatusBar.Text = "Complete";
        }

        private void LaunchGame(object sender, EventArgs e)
        {
            this.Hide();
            Game game = new Game();
            game.ShowDialog();
            this.Close();
        }
    }
}
