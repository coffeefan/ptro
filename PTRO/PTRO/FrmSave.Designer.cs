namespace PTRO
{
    partial class FrmSave
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
            this.savePanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.tbMobile = new System.Windows.Forms.TextBox();
            this.labMobile = new System.Windows.Forms.Label();
            this.tbNickname = new System.Windows.Forms.TextBox();
            this.labNickname = new System.Windows.Forms.Label();
            this.pHighscore = new System.Windows.Forms.Panel();
            this.labRang = new System.Windows.Forms.Label();
            this.labHighscore = new System.Windows.Forms.Label();
            this.savePanel.SuspendLayout();
            this.pHighscore.SuspendLayout();
            this.SuspendLayout();
            // 
            // savePanel
            // 
            this.savePanel.Controls.Add(this.button1);
            this.savePanel.Controls.Add(this.tbMobile);
            this.savePanel.Controls.Add(this.labMobile);
            this.savePanel.Controls.Add(this.tbNickname);
            this.savePanel.Controls.Add(this.labNickname);
            this.savePanel.Location = new System.Drawing.Point(167, 35);
            this.savePanel.Name = "savePanel";
            this.savePanel.Size = new System.Drawing.Size(537, 519);
            this.savePanel.TabIndex = 0;
            this.savePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Ravie", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(126, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(266, 65);
            this.button1.TabIndex = 7;
            this.button1.Text = "Speichern";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmSave_KeyDown);
            // 
            // tbMobile
            // 
            this.tbMobile.Font = new System.Drawing.Font("Ravie", 48F, System.Drawing.FontStyle.Bold);
            this.tbMobile.Location = new System.Drawing.Point(0, 299);
            this.tbMobile.Name = "tbMobile";
            this.tbMobile.Size = new System.Drawing.Size(536, 93);
            this.tbMobile.TabIndex = 6;
            this.tbMobile.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmSave_KeyDown);
            // 
            // labMobile
            // 
            this.labMobile.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labMobile.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labMobile.Font = new System.Drawing.Font("Ravie", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMobile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labMobile.Location = new System.Drawing.Point(0, 214);
            this.labMobile.Name = "labMobile";
            this.labMobile.Size = new System.Drawing.Size(537, 82);
            this.labMobile.TabIndex = 5;
            this.labMobile.Text = "Mobile";
            this.labMobile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbNickname
            // 
            this.tbNickname.Font = new System.Drawing.Font("Ravie", 48F, System.Drawing.FontStyle.Bold);
            this.tbNickname.Location = new System.Drawing.Point(0, 97);
            this.tbNickname.Name = "tbNickname";
            this.tbNickname.Size = new System.Drawing.Size(536, 93);
            this.tbNickname.TabIndex = 4;
            this.tbNickname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmSave_KeyDown);
            // 
            // labNickname
            // 
            this.labNickname.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labNickname.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labNickname.Font = new System.Drawing.Font("Ravie", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNickname.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labNickname.Location = new System.Drawing.Point(0, 12);
            this.labNickname.Name = "labNickname";
            this.labNickname.Size = new System.Drawing.Size(537, 82);
            this.labNickname.TabIndex = 3;
            this.labNickname.Text = "Nickname";
            this.labNickname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labNickname.Click += new System.EventHandler(this.labNickname_Click);
            // 
            // pHighscore
            // 
            this.pHighscore.Controls.Add(this.labRang);
            this.pHighscore.Controls.Add(this.labHighscore);
            this.pHighscore.Location = new System.Drawing.Point(27, 14);
            this.pHighscore.Name = "pHighscore";
            this.pHighscore.Size = new System.Drawing.Size(936, 511);
            this.pHighscore.TabIndex = 1;
            // 
            // labRang
            // 
            this.labRang.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labRang.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labRang.Font = new System.Drawing.Font("Ravie", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labRang.ForeColor = System.Drawing.Color.White;
            this.labRang.Location = new System.Drawing.Point(3, 360);
            this.labRang.Name = "labRang";
            this.labRang.Size = new System.Drawing.Size(885, 107);
            this.labRang.TabIndex = 8;
            this.labRang.Text = "Rang 1";
            this.labRang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labRang.Click += new System.EventHandler(this.labRang_Click);
            // 
            // labHighscore
            // 
            this.labHighscore.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labHighscore.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labHighscore.Font = new System.Drawing.Font("Ravie", 99.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labHighscore.ForeColor = System.Drawing.Color.Khaki;
            this.labHighscore.Location = new System.Drawing.Point(19, 21);
            this.labHighscore.Name = "labHighscore";
            this.labHighscore.Size = new System.Drawing.Size(904, 186);
            this.labHighscore.TabIndex = 7;
            this.labHighscore.Text = "Highscore";
            this.labHighscore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmSave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1018, 585);
            this.Controls.Add(this.savePanel);
            this.Controls.Add(this.pHighscore);
            this.Name = "FrmSave";
            this.Text = "FrmSave";
            this.Load += new System.EventHandler(this.FrmSave_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmSave_KeyDown);
            this.savePanel.ResumeLayout(false);
            this.savePanel.PerformLayout();
            this.pHighscore.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel savePanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbMobile;
        private System.Windows.Forms.Label labMobile;
        private System.Windows.Forms.TextBox tbNickname;
        private System.Windows.Forms.Label labNickname;
        private System.Windows.Forms.Panel pHighscore;
        private System.Windows.Forms.Label labRang;
        private System.Windows.Forms.Label labHighscore;
    }
}