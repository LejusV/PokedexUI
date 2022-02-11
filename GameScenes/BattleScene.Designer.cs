namespace GUI.GameScenes
{
    partial class BattleScene
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
            this.panelBattle = new System.Windows.Forms.Panel();
            this.LinesDisplayArea = new System.Windows.Forms.GroupBox();
            this.lblNextLine = new System.Windows.Forms.Label();
            this.labelSpeakerName = new System.Windows.Forms.Label();
            this.SpeakerLines = new System.Windows.Forms.TextBox();
            this.pokPikachu = new System.Windows.Forms.PictureBox();
            this.panelBattle.SuspendLayout();
            this.LinesDisplayArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pokPikachu)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBattle
            // 
            this.panelBattle.BackgroundImage = global::GUI.Properties.Resources.battle_background;
            this.panelBattle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBattle.Controls.Add(this.LinesDisplayArea);
            this.panelBattle.Controls.Add(this.pokPikachu);
            this.panelBattle.Location = new System.Drawing.Point(0, 0);
            this.panelBattle.Name = "panelBattle";
            this.panelBattle.Size = new System.Drawing.Size(1274, 837);
            this.panelBattle.TabIndex = 0;
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
            this.LinesDisplayArea.TabIndex = 16;
            this.LinesDisplayArea.TabStop = false;
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
            // 
            // pokPikachu
            // 
            this.pokPikachu.BackColor = System.Drawing.Color.Transparent;
            this.pokPikachu.Image = global::GUI.Properties.Resources.Spr_b_5b_025_m;
            this.pokPikachu.Location = new System.Drawing.Point(266, 396);
            this.pokPikachu.Name = "pokPikachu";
            this.pokPikachu.Size = new System.Drawing.Size(343, 309);
            this.pokPikachu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pokPikachu.TabIndex = 17;
            this.pokPikachu.TabStop = false;
            // 
            // BattleScene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelBattle);
            this.Name = "BattleScene";
            this.Size = new System.Drawing.Size(1274, 837);
            this.panelBattle.ResumeLayout(false);
            this.LinesDisplayArea.ResumeLayout(false);
            this.LinesDisplayArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pokPikachu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBattle;
        private System.Windows.Forms.GroupBox LinesDisplayArea;
        private System.Windows.Forms.Label lblNextLine;
        private System.Windows.Forms.Label labelSpeakerName;
        private System.Windows.Forms.TextBox SpeakerLines;
        private System.Windows.Forms.PictureBox pokPikachu;
    }
}
