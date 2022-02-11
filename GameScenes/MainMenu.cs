using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.GameScenes
{
    public partial class MainMenu : UserControl
    {
        private static MainMenu? _instance = null;
        public static MainMenu Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MainMenu();
                }
                return _instance;
            }
        }

        public MainMenu()
        {
            InitializeComponent();
            Visible = true;
        }
        class MainMenuButton : Button
        {

            public MainMenuButton() : base()
            {
                this.Width = 250;
                this.Height = 50;
                this.ForeColor = Color.White;
                this.BackColor = Color.DimGray;
                this.Text = "Bouton";
            }
        }

        private void StartGame(object sender, EventArgs e)
        {
            //this.Visible = false;
            Game.GameStart();
        }




        private void ExitGame(object sender, EventArgs e)
        {
            this.Hide();
            Launcher launcher = new Launcher();
            launcher.ShowDialog();
        }
    }
}
