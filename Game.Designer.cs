namespace GUI
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.lblMainMenu = new System.Windows.Forms.Label();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.LinesDisplayArea = new System.Windows.Forms.GroupBox();
            this.SpeakerLines = new System.Windows.Forms.TextBox();
            this.labelSpeakerName = new System.Windows.Forms.Label();
            this.picClouds = new System.Windows.Forms.PictureBox();
            this.picClouds2 = new System.Windows.Forms.PictureBox();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.LinesDisplayArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClouds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClouds2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMainMenu
            // 
            this.lblMainMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMainMenu.BackColor = System.Drawing.Color.Transparent;
            this.lblMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 54F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMainMenu.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblMainMenu.Location = new System.Drawing.Point(242, 12);
            this.lblMainMenu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMainMenu.MaximumSize = new System.Drawing.Size(420, 189);
            this.lblMainMenu.MinimumSize = new System.Drawing.Size(420, 189);
            this.lblMainMenu.Name = "lblMainMenu";
            this.lblMainMenu.Size = new System.Drawing.Size(420, 189);
            this.lblMainMenu.TabIndex = 1;
            this.lblMainMenu.Text = "POKEDEX";
            this.lblMainMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSettings.BackColor = System.Drawing.Color.DimGray;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Location = new System.Drawing.Point(364, 258);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSettings.MaximumSize = new System.Drawing.Size(175, 30);
            this.btnSettings.MinimumSize = new System.Drawing.Size(175, 30);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(175, 30);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExit.BackColor = System.Drawing.Color.DimGray;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(364, 312);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.MaximumSize = new System.Drawing.Size(175, 30);
            this.btnExit.MinimumSize = new System.Drawing.Size(175, 30);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(175, 30);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.ExitGame);
            // 
            // LinesDisplayArea
            // 
            this.LinesDisplayArea.Controls.Add(this.SpeakerLines);
            this.LinesDisplayArea.Controls.Add(this.labelSpeakerName);
            this.LinesDisplayArea.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LinesDisplayArea.Location = new System.Drawing.Point(0, 399);
            this.LinesDisplayArea.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LinesDisplayArea.Name = "LinesDisplayArea";
            this.LinesDisplayArea.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LinesDisplayArea.Size = new System.Drawing.Size(892, 103);
            this.LinesDisplayArea.TabIndex = 5;
            this.LinesDisplayArea.TabStop = false;
            this.LinesDisplayArea.Visible = false;
            // 
            // SpeakerLines
            // 
            this.SpeakerLines.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SpeakerLines.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.SpeakerLines.Enabled = false;
            this.SpeakerLines.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SpeakerLines.Location = new System.Drawing.Point(43, 25);
            this.SpeakerLines.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SpeakerLines.MaxLength = 500;
            this.SpeakerLines.Multiline = true;
            this.SpeakerLines.Name = "SpeakerLines";
            this.SpeakerLines.ReadOnly = true;
            this.SpeakerLines.Size = new System.Drawing.Size(805, 72);
            this.SpeakerLines.TabIndex = 1;
            this.SpeakerLines.Text = "OUI BAGUETTE";
            // 
            // labelSpeakerName
            // 
            this.labelSpeakerName.AutoSize = true;
            this.labelSpeakerName.Enabled = false;
            this.labelSpeakerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSpeakerName.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.labelSpeakerName.Location = new System.Drawing.Point(6, -1);
            this.labelSpeakerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSpeakerName.Name = "labelSpeakerName";
            this.labelSpeakerName.Size = new System.Drawing.Size(69, 25);
            this.labelSpeakerName.TabIndex = 0;
            this.labelSpeakerName.Text = "Michel";
            this.labelSpeakerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picClouds
            // 
            this.picClouds.BackColor = System.Drawing.Color.Transparent;
            this.picClouds.BackgroundImage = global::GUI.Properties.Resources.clouds;
            this.picClouds.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picClouds.Location = new System.Drawing.Point(0, 224);
            this.picClouds.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picClouds.Name = "picClouds";
            this.picClouds.Size = new System.Drawing.Size(892, 150);
            this.picClouds.TabIndex = 6;
            this.picClouds.TabStop = false;
            this.picClouds.Visible = false;
            // 
            // picClouds2
            // 
            this.picClouds2.BackColor = System.Drawing.Color.Transparent;
            this.picClouds2.BackgroundImage = global::GUI.Properties.Resources.clouds;
            this.picClouds2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picClouds2.Location = new System.Drawing.Point(-892, 224);
            this.picClouds2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picClouds2.Name = "picClouds2";
            this.picClouds2.Size = new System.Drawing.Size(892, 150);
            this.picClouds2.TabIndex = 7;
            this.picClouds2.TabStop = false;
            this.picClouds2.Visible = false;
            // 
            // btnStartGame
            // 
            this.btnStartGame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStartGame.BackColor = System.Drawing.Color.DimGray;
            this.btnStartGame.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStartGame.ForeColor = System.Drawing.Color.White;
            this.btnStartGame.Location = new System.Drawing.Point(364, 203);
            this.btnStartGame.Margin = new System.Windows.Forms.Padding(2);
            this.btnStartGame.MaximumSize = new System.Drawing.Size(175, 30);
            this.btnStartGame.MinimumSize = new System.Drawing.Size(175, 30);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(175, 30);
            this.btnStartGame.TabIndex = 8;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.UseVisualStyleBackColor = false;
            this.btnStartGame.Click += new System.EventHandler(this.StartGame);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.forestPokemon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(892, 502);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.LinesDisplayArea);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.lblMainMenu);
            this.Controls.Add(this.picClouds);
            this.Controls.Add(this.picClouds2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Game";
            this.Text = "Pokedex";
            this.Click += new System.EventHandler(this.FormClick);
            this.LinesDisplayArea.ResumeLayout(false);
            this.LinesDisplayArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClouds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClouds2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblMainMenu;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox LinesDisplayArea;
        private System.Windows.Forms.TextBox SpeakerLines;
        private System.Windows.Forms.Label labelSpeakerName;
        private System.Windows.Forms.PictureBox picClouds;
        private System.Windows.Forms.PictureBox picClouds2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnStartGame;
    }
}