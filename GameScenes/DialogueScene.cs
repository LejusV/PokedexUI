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
    public partial class DialogueScene : UserControl
    {
        private int line = 0;

        private int charIndex = 0;

        private static DialogueScene? _instance = null;
        public static DialogueScene Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DialogueScene();
                }
                return _instance;
            }
        }

        public DialogueScene()
        {
            InitializeComponent();
            Visible = false;
            Dock = DockStyle.Fill;

        }


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


        private void AnimClouds(object sender, EventArgs e)
        {
            anim_clouds.Left += 5;
            if (anim_clouds.Left > -8)
            {
                anim_clouds.Left -= 1290;
            }
        }


        async void LineIncrement(object sender, EventArgs e)
        {
            if (charIndex == lines[line].Length || charIndex == 0)
            {
                if (++line < lines.Count)
                {
                    lblNextLine.Visible = false;
                    SpeakerLines.Text = "";
                    for (charIndex = 0; charIndex < lines[line].Length; charIndex++)
                    {
                        await Task.Delay(20);
                        SpeakerLines.Text += lines[line][charIndex];
                    }
                    lblNextLine.Visible = true;
                }
            }
        }


    }
}
