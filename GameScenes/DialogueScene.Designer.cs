namespace GUI.GameScenes
{
    partial class DialogueScene
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MainGame = new System.Windows.Forms.Panel();
            this.LinesDisplayArea = new System.Windows.Forms.GroupBox();
            this.lblNextLine = new System.Windows.Forms.Label();
            this.labelSpeakerName = new System.Windows.Forms.Label();
            this.SpeakerLines = new System.Windows.Forms.TextBox();
            this.anim_clouds = new System.Windows.Forms.TableLayoutPanel();
            this.picClouds = new System.Windows.Forms.PictureBox();
            this.picClouds2 = new System.Windows.Forms.PictureBox();
            this.TimerAnimClouds = new System.Windows.Forms.Timer(this.components);
            this.MainGame.SuspendLayout();
            this.LinesDisplayArea.SuspendLayout();
            this.anim_clouds.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClouds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClouds2)).BeginInit();
            this.SuspendLayout();
            // 
            // MainGame
            // 
            this.MainGame.BackgroundImage = global::GUI.Properties.Resources.no_clouds_sky;
            this.MainGame.Controls.Add(this.LinesDisplayArea);
            this.MainGame.Controls.Add(this.anim_clouds);
            this.MainGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainGame.Location = new System.Drawing.Point(0, 0);
            this.MainGame.Name = "MainGame";
            this.MainGame.Size = new System.Drawing.Size(1274, 837);
            this.MainGame.TabIndex = 17;
            this.MainGame.Click += new System.EventHandler(this.LineIncrement);
            // 
            // LinesDisplayArea
            // 
            this.LinesDisplayArea.Controls.Add(this.lblNextLine);
            this.LinesDisplayArea.Controls.Add(this.labelSpeakerName);
            this.LinesDisplayArea.Controls.Add(this.SpeakerLines);
            this.LinesDisplayArea.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LinesDisplayArea.Location = new System.Drawing.Point(0, 638);
            this.LinesDisplayArea.Margin = new System.Windows.Forms.Padding(0);
            this.LinesDisplayArea.Name = "LinesDisplayArea";
            this.LinesDisplayArea.Size = new System.Drawing.Size(1274, 199);
            this.LinesDisplayArea.TabIndex = 15;
            this.LinesDisplayArea.TabStop = false;
            this.LinesDisplayArea.MouseCaptureChanged += new System.EventHandler(this.LineIncrement);
            // 
            // lblNextLine
            // 
            this.lblNextLine.AutoSize = true;
            this.lblNextLine.Font = new System.Drawing.Font("Showcard Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNextLine.ForeColor = System.Drawing.Color.Brown;
            this.lblNextLine.Location = new System.Drawing.Point(1239, 159);
            this.lblNextLine.Name = "lblNextLine";
            this.lblNextLine.Size = new System.Drawing.Size(30, 37);
            this.lblNextLine.TabIndex = 3;
            this.lblNextLine.Text = ">";
            this.lblNextLine.Click += new System.EventHandler(this.LineIncrement);
            // 
            // labelSpeakerName
            // 
            this.labelSpeakerName.AutoSize = true;
            this.labelSpeakerName.Enabled = false;
            this.labelSpeakerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSpeakerName.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.labelSpeakerName.Location = new System.Drawing.Point(9, -2);
            this.labelSpeakerName.Name = "labelSpeakerName";
            this.labelSpeakerName.Size = new System.Drawing.Size(102, 36);
            this.labelSpeakerName.TabIndex = 0;
            this.labelSpeakerName.Text = "Michel";
            this.labelSpeakerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSpeakerName.Click += new System.EventHandler(this.LineIncrement);
            // 
            // SpeakerLines
            // 
            this.SpeakerLines.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SpeakerLines.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.SpeakerLines.Enabled = false;
            this.SpeakerLines.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SpeakerLines.Location = new System.Drawing.Point(49, 37);
            this.SpeakerLines.MaxLength = 500;
            this.SpeakerLines.Multiline = true;
            this.SpeakerLines.Name = "SpeakerLines";
            this.SpeakerLines.ReadOnly = true;
            this.SpeakerLines.Size = new System.Drawing.Size(1168, 150);
            this.SpeakerLines.TabIndex = 2;
            this.SpeakerLines.Text = "OUI BAGUETTE";
            this.SpeakerLines.Click += new System.EventHandler(this.LineIncrement);
            // 
            // anim_clouds
            // 
            this.anim_clouds.BackColor = System.Drawing.Color.Transparent;
            this.anim_clouds.ColumnCount = 2;
            this.anim_clouds.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.anim_clouds.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.anim_clouds.Controls.Add(this.picClouds, 1, 0);
            this.anim_clouds.Controls.Add(this.picClouds2, 0, 0);
            this.anim_clouds.Location = new System.Drawing.Point(-1298, 488);
            this.anim_clouds.Name = "anim_clouds";
            this.anim_clouds.RowCount = 1;
            this.anim_clouds.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.anim_clouds.Size = new System.Drawing.Size(2580, 140);
            this.anim_clouds.TabIndex = 16;
            // 
            // picClouds
            // 
            this.picClouds.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picClouds.BackColor = System.Drawing.Color.Transparent;
            this.picClouds.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picClouds.Image = global::GUI.Properties.Resources.clouds;
            this.picClouds.InitialImage = null;
            this.picClouds.Location = new System.Drawing.Point(1290, 0);
            this.picClouds.Margin = new System.Windows.Forms.Padding(0);
            this.picClouds.Name = "picClouds";
            this.picClouds.Size = new System.Drawing.Size(1290, 140);
            this.picClouds.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClouds.TabIndex = 12;
            this.picClouds.TabStop = false;
            this.picClouds.Click += new System.EventHandler(this.LineIncrement);
            // 
            // picClouds2
            // 
            this.picClouds2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picClouds2.BackColor = System.Drawing.Color.Transparent;
            this.picClouds2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picClouds2.Image = global::GUI.Properties.Resources.clouds;
            this.picClouds2.Location = new System.Drawing.Point(8, 0);
            this.picClouds2.Margin = new System.Windows.Forms.Padding(0);
            this.picClouds2.Name = "picClouds2";
            this.picClouds2.Size = new System.Drawing.Size(1274, 140);
            this.picClouds2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClouds2.TabIndex = 13;
            this.picClouds2.TabStop = false;
            this.picClouds2.Click += new System.EventHandler(this.LineIncrement);
            // 
            // TimerAnimClouds
            // 
            this.TimerAnimClouds.Enabled = true;
            this.TimerAnimClouds.Tick += new System.EventHandler(this.AnimClouds);
            // 
            // DialogueScene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainGame);
            this.Name = "DialogueScene";
            this.Size = new System.Drawing.Size(1274, 837);
            this.Click += new System.EventHandler(this.LineIncrement);
            this.MainGame.ResumeLayout(false);
            this.LinesDisplayArea.ResumeLayout(false);
            this.LinesDisplayArea.PerformLayout();
            this.anim_clouds.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picClouds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClouds2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainGame;
        private System.Windows.Forms.GroupBox LinesDisplayArea;
        private System.Windows.Forms.Label lblNextLine;
        private System.Windows.Forms.Label labelSpeakerName;
        private System.Windows.Forms.TextBox SpeakerLines;
        private System.Windows.Forms.TableLayoutPanel anim_clouds;
        private System.Windows.Forms.PictureBox picClouds;
        private System.Windows.Forms.PictureBox picClouds2;
        private System.Windows.Forms.Timer TimerAnimClouds;
    }
}
