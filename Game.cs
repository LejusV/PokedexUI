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
        private List<string> lines = new List<string>()
        {
            "Welcome to Pokedex, a little game developped by LejusVDP for a private usage.",
            "For now the game concept resides in pokemon 1v1 battles",
            "What is your Trainer Name ? ",
            "aaaaaaaaaaaaaaaaaa",
            "bbbbbbbbbbbbbbb",
            "cccccccccccccccc",
            "ddddddddd dddddddd d dddddddd   ddd",
            "eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee",
            "f f f f f f f f f f f f f f f f"
        };

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
            MainMenu.Visible = false;
            MainGame.Visible = true;
            GameMain();
        }

        private void AnimClouds(object sender, EventArgs e)
        {
            anim_clouds.Left += 5;
            if (anim_clouds.Left > -8)
            {
                anim_clouds.Left -= 1290;
            }
        }

        private void FormClick(object sender, EventArgs e)
        {
        }

        private void GameMain()
        {

            SpeakerLines.Text = lines[line];
            LinesDisplayArea.Visible = true;
        }

        int charIndex = 0;

        async void LineIncrement(object sender, EventArgs e)
        {
            if (charIndex == lines[line].Length || charIndex == 0)
            {
                if (++line < lines.Count)
                {
                    SpeakerLines.Text = "";
                    for (charIndex = 0; charIndex < lines[line].Length; charIndex++)
                    {
                        await Task.Delay(20);
                        SpeakerLines.Text += lines[line][charIndex];
                    }
                    lblNextLine.Visible = false;
                }
            }
        }


        private void ExitGame(object sender, EventArgs e)
        {
            this.Hide();
            Launcher launcher = new Launcher();
            launcher.ShowDialog();
            this.Close();
        }

        private void NextLineLabelDisplay(object sender, EventArgs e)
        {
            lblNextLine.Visible = true;
        }
    }
}
