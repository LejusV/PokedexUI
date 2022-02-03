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
    public partial class Game : Form
    {
        private int line = 0;

        class MainMenuButton : Button
        {
            public MainMenuButton() : base()
            {
                this.Left = 0;
                this.Top = 0;
                this.Width = 250;
                this.Height = 50;
                this.ForeColor = Color.White;
                this.BackColor = Color.DimGray;
                this.Text = "Bouton";
            }
        }

        public Game()
        {
            InitializeComponent();

        }

        private void StartGame(object sender, EventArgs e)
        {
            btnStartGame.Visible = false;
            btnSettings.Visible = false;
            btnExit.Visible = false;
            lblMainMenu.Visible = false;
            this.BackgroundImage = Properties.Resources.no_clouds_sky;
            picClouds.Visible = true;
            AnimClouds();
            MainGame();
        }

        private async void AnimClouds()
        {
            while (true)
            {
                await Task.Delay(3);
                picClouds.Left += 10;
                picClouds2.Left += 10;
                if (picClouds.Left > 1274) picClouds.Left -= picClouds.Width + picClouds2.Width;
                if (picClouds2.Left > 1274) picClouds2.Left -= picClouds.Width + picClouds2.Width;
            }
        }

        private void FormClick(object sender, EventArgs e)
        {
        }

        private void MainGame()
        {

            bool isWaitingForNextLine = false;

            

            List<string> lines = new List<string>()
            {
                "Welcome to Pokedex, a little game developped by LejusVDP for a private usage.",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                ""
            };
            SpeakerLines.Text = lines[0];
            LinesDisplayArea.Visible = true;
            isWaitingForNextLine = true;
            SpeakerLines.Text = "What is your Trainer Name ? ";

            isWaitingForNextLine = true;


        }

        private void ExitGame(object sender, EventArgs e)
        {
            this.Hide();
            Launcher launcher = new Launcher();
            launcher.ShowDialog();
            this.Close();
        }
    }
}
