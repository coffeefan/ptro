namespace PTRO
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.labText = new System.Windows.Forms.Label();
            this.labScore = new System.Windows.Forms.Label();
            this.labLevel = new System.Windows.Forms.Label();
            this.pBar = new System.Windows.Forms.ProgressBar();
            this.labtop = new System.Windows.Forms.Label();
            this.pbGameOver = new System.Windows.Forms.PictureBox();
            this.pBoxStartscreen = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.labGameOverBackground = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbGameOver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxStartscreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // labText
            // 
            this.labText.AutoSize = true;
            this.labText.BackColor = System.Drawing.Color.Black;
            this.labText.Font = new System.Drawing.Font("Rockwell Extra Bold", 500F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labText.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labText.Location = new System.Drawing.Point(68, 82);
            this.labText.Name = "labText";
            this.labText.Size = new System.Drawing.Size(1813, 783);
            this.labText.TabIndex = 1;
            this.labText.Text = "test";
            this.labText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labText.Click += new System.EventHandler(this.label1_Click);
            // 
            // labScore
            // 
            this.labScore.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labScore.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labScore.Font = new System.Drawing.Font("Ravie", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labScore.Location = new System.Drawing.Point(198, 0);
            this.labScore.Name = "labScore";
            this.labScore.Size = new System.Drawing.Size(297, 82);
            this.labScore.TabIndex = 2;
            this.labScore.Text = "0";
            this.labScore.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.labScore.Click += new System.EventHandler(this.labScore_Click);
            // 
            // labLevel
            // 
            this.labLevel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labLevel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labLevel.Font = new System.Drawing.Font("Ravie", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labLevel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labLevel.Location = new System.Drawing.Point(640, 9);
            this.labLevel.Name = "labLevel";
            this.labLevel.Size = new System.Drawing.Size(440, 82);
            this.labLevel.TabIndex = 3;
            this.labLevel.Text = "0";
            this.labLevel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pBar
            // 
            this.pBar.Location = new System.Drawing.Point(14, 502);
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(100, 23);
            this.pBar.TabIndex = 4;
            this.pBar.Value = 100;
            // 
            // labtop
            // 
            this.labtop.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labtop.Location = new System.Drawing.Point(-3, 0);
            this.labtop.Name = "labtop";
            this.labtop.Size = new System.Drawing.Size(1058, 108);
            this.labtop.TabIndex = 6;
            this.labtop.Text = "label1";
            // 
            // pbGameOver
            // 
            this.pbGameOver.Image = global::PTRO.Properties.Resources.GameoverSMB;
            this.pbGameOver.Location = new System.Drawing.Point(72, 100);
            this.pbGameOver.Name = "pbGameOver";
            this.pbGameOver.Size = new System.Drawing.Size(508, 296);
            this.pbGameOver.TabIndex = 8;
            this.pbGameOver.TabStop = false;
            // 
            // pBoxStartscreen
            // 
            this.pBoxStartscreen.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pBoxStartscreen.Image = ((System.Drawing.Image)(resources.GetObject("pBoxStartscreen.Image")));
            this.pBoxStartscreen.Location = new System.Drawing.Point(1, 0);
            this.pBoxStartscreen.Name = "pBoxStartscreen";
            this.pBoxStartscreen.Size = new System.Drawing.Size(192, 108);
            this.pBoxStartscreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxStartscreen.TabIndex = 5;
            this.pBoxStartscreen.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Image = global::PTRO.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(1, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.BackColor = System.Drawing.Color.Black;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(419, 181);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // labGameOverBackground
            // 
            this.labGameOverBackground.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labGameOverBackground.Location = new System.Drawing.Point(-2, 0);
            this.labGameOverBackground.Name = "labGameOverBackground";
            this.labGameOverBackground.Size = new System.Drawing.Size(1058, 20);
            this.labGameOverBackground.TabIndex = 9;
            this.labGameOverBackground.Text = "label1";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 567);
            this.Controls.Add(this.pbGameOver);
            this.Controls.Add(this.labGameOverBackground);
            this.Controls.Add(this.pBoxStartscreen);
            this.Controls.Add(this.pBar);
            this.Controls.Add(this.labLevel);
            this.Controls.Add(this.labText);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.labScore);
            this.Controls.Add(this.labtop);
            this.Name = "FrmMain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMain_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbGameOver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxStartscreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label labText;
        private System.Windows.Forms.Label labScore;
        private System.Windows.Forms.Label labLevel;
        private System.Windows.Forms.ProgressBar pBar;
        private System.Windows.Forms.PictureBox pBoxStartscreen;
        private System.Windows.Forms.Label labtop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbGameOver;
        private System.Windows.Forms.Label labGameOverBackground;
    }
}

