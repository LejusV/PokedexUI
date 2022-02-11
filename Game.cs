using GUI.GameScenes;
using GUI.LauncherScenes;
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

        public Game()
        {
            InitializeComponent();
            Controls.Add(DialogueScene.Instance);
            Controls.Add(MainMenu.Instance);
        }

        public static void GameStart()
        {
            /*DialogueScene.Instance.BackColor = Color.Blue;*/
            DialogueScene.Instance.Visible = true;
        }
    }
}