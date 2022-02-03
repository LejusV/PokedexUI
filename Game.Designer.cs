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
            this.LinesDisplayArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClouds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClouds2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMainMenu
            // 
            this.lblMainMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMainMenu.BackColor = System.Drawing.Color.Transparent;
            this.lblMainMenu.Font = new System.Drawing.Font("Pokemon Solid", 54F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMainMenu.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblMainMenu.Location = new System.Drawing.Point(345, 20);
            this.lblMainMenu.MaximumSize = new System.Drawing.Size(600, 315);
            this.lblMainMenu.MinimumSize = new System.Drawing.Size(600, 315);
            this.lblMainMenu.Name = "lblMainMenu";
            this.lblMainMenu.Size = new System.Drawing.Size(600, 315);
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
            this.btnSettings.Location = new System.Drawing.Point(520, 430);
            this.btnSettings.MaximumSize = new System.Drawing.Size(250, 50);
            this.btnSettings.MinimumSize = new System.Drawing.Size(250, 50);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(250, 50);
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
            this.btnExit.Location = new System.Drawing.Point(520, 520);
            this.btnExit.MaximumSize = new System.Drawing.Size(250, 50);
            this.btnExit.MinimumSize = new System.Drawing.Size(250, 50);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(250, 50);
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
            this.LinesDisplayArea.Location = new System.Drawing.Point(0, 665);
            this.LinesDisplayArea.Name = "LinesDisplayArea";
            this.LinesDisplayArea.Size = new System.Drawing.Size(1274, 171);
            this.LinesDisplayArea.TabIndex = 5;
            this.LinesDisplayArea.TabStop = false;
            this.LinesDisplayArea.Visible = false;
            // 
            // SpeakerLines
            // 
            this.SpeakerLines.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SpeakerLines.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.SpeakerLines.Enabled = false;
            this.SpeakerLines.Font = new System.Drawing.Font("PenultimateLight", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SpeakerLines.Location = new System.Drawing.Point(62, 42);
            this.SpeakerLines.MaxLength = 500;
            this.SpeakerLines.Multiline = true;
            this.SpeakerLines.Name = "SpeakerLines";
            this.SpeakerLines.ReadOnly = true;
            this.SpeakerLines.Size = new System.Drawing.Size(1150, 120);
            this.SpeakerLines.TabIndex = 1;
            this.SpeakerLines.Text = "OUI BAGUETTE";
            // 
            // labelSpeakerName
            // 
            this.labelSpeakerName.AutoSize = true;
            this.labelSpeakerName.Enabled = false;
            this.labelSpeakerName.Font = new System.Drawing.Font("RowdyHeavy", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSpeakerName.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.labelSpeakerName.Location = new System.Drawing.Point(9, -1);
            this.labelSpeakerName.Name = "labelSpeakerName";
            this.labelSpeakerName.Size = new System.Drawing.Size(122, 40);
            this.labelSpeakerName.TabIndex = 0;
            this.labelSpeakerName.Text = "Michel";
            this.labelSpeakerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picClouds
            // 
            this.picClouds.BackColor = System.Drawing.Color.Transparent;
            this.picClouds.BackgroundImage = global::GUI.Properties.Resources.clouds;
            this.picClouds.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picClouds.Location = new System.Drawing.Point(0, 373);
            this.picClouds.Name = "picClouds";
            this.picClouds.Size = new System.Drawing.Size(1274, 250);
            this.picClouds.TabIndex = 6;
            this.picClouds.TabStop = false;
            this.picClouds.Visible = false;
            // 
            // picClouds2
            // 
            this.picClouds2.BackColor = System.Drawing.Color.Transparent;
            this.picClouds2.BackgroundImage = global::GUI.Properties.Resources.clouds;
            this.picClouds2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picClouds2.Location = new System.Drawing.Point(-1274, 373);
            this.picClouds2.Name = "picClouds2";
            this.picClouds2.Size = new System.Drawing.Size(1274, 250);
            this.picClouds2.TabIndex = 7;
            this.picClouds2.TabStop = false;
            this.picClouds2.Visible = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.forestPokemon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1274, 836);
            this.Controls.Add(this.LinesDisplayArea);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.lblMainMenu);
            this.Controls.Add(this.picClouds);
            this.Controls.Add(this.picClouds2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
    }
}