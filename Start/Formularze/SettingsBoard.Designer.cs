namespace SaperGame
{
    partial class SettingsBoard
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
            this.levelDifficul_gb = new System.Windows.Forms.GroupBox();
            this.hard_rb = new System.Windows.Forms.RadioButton();
            this.normal_rb = new System.Windows.Forms.RadioButton();
            this.esey_rb = new System.Windows.Forms.RadioButton();
            this.play_b = new System.Windows.Forms.Button();
            this.sizeBoard_gb = new System.Windows.Forms.GroupBox();
            this.big_rb = new System.Windows.Forms.RadioButton();
            this.medium_rb = new System.Windows.Forms.RadioButton();
            this.small_rb = new System.Windows.Forms.RadioButton();
            this.levelDifficul_gb.SuspendLayout();
            this.sizeBoard_gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // levelDifficul_gb
            // 
            this.levelDifficul_gb.Controls.Add(this.hard_rb);
            this.levelDifficul_gb.Controls.Add(this.normal_rb);
            this.levelDifficul_gb.Controls.Add(this.esey_rb);
            this.levelDifficul_gb.Location = new System.Drawing.Point(12, 12);
            this.levelDifficul_gb.Name = "levelDifficul_gb";
            this.levelDifficul_gb.Size = new System.Drawing.Size(170, 93);
            this.levelDifficul_gb.TabIndex = 2;
            this.levelDifficul_gb.TabStop = false;
            this.levelDifficul_gb.Text = "Poziom trudności";
            // 
            // hard_rb
            // 
            this.hard_rb.AutoSize = true;
            this.hard_rb.Location = new System.Drawing.Point(9, 65);
            this.hard_rb.Name = "hard_rb";
            this.hard_rb.Size = new System.Drawing.Size(58, 17);
            this.hard_rb.TabIndex = 2;
            this.hard_rb.TabStop = true;
            this.hard_rb.Text = "Trudny";
            this.hard_rb.UseVisualStyleBackColor = true;
            // 
            // normal_rb
            // 
            this.normal_rb.AutoSize = true;
            this.normal_rb.Location = new System.Drawing.Point(9, 42);
            this.normal_rb.Name = "normal_rb";
            this.normal_rb.Size = new System.Drawing.Size(69, 17);
            this.normal_rb.TabIndex = 1;
            this.normal_rb.TabStop = true;
            this.normal_rb.Text = "Normalny";
            this.normal_rb.UseVisualStyleBackColor = true;
            // 
            // esey_rb
            // 
            this.esey_rb.AutoSize = true;
            this.esey_rb.Location = new System.Drawing.Point(9, 19);
            this.esey_rb.Name = "esey_rb";
            this.esey_rb.Size = new System.Drawing.Size(54, 17);
            this.esey_rb.TabIndex = 0;
            this.esey_rb.TabStop = true;
            this.esey_rb.Text = "Łatwy";
            this.esey_rb.UseVisualStyleBackColor = true;
            // 
            // play_b
            // 
            this.play_b.Location = new System.Drawing.Point(107, 207);
            this.play_b.Name = "play_b";
            this.play_b.Size = new System.Drawing.Size(75, 23);
            this.play_b.TabIndex = 3;
            this.play_b.Text = "Graj";
            this.play_b.UseVisualStyleBackColor = true;
            this.play_b.Click += new System.EventHandler(this.play_b_Click);
            // 
            // sizeBoard_gb
            // 
            this.sizeBoard_gb.Controls.Add(this.big_rb);
            this.sizeBoard_gb.Controls.Add(this.medium_rb);
            this.sizeBoard_gb.Controls.Add(this.small_rb);
            this.sizeBoard_gb.Location = new System.Drawing.Point(12, 111);
            this.sizeBoard_gb.Name = "sizeBoard_gb";
            this.sizeBoard_gb.Size = new System.Drawing.Size(170, 90);
            this.sizeBoard_gb.TabIndex = 4;
            this.sizeBoard_gb.TabStop = false;
            this.sizeBoard_gb.Text = "Rozmiary planszy";
            // 
            // big_rb
            // 
            this.big_rb.AutoSize = true;
            this.big_rb.Location = new System.Drawing.Point(6, 65);
            this.big_rb.Name = "big_rb";
            this.big_rb.Size = new System.Drawing.Size(50, 17);
            this.big_rb.TabIndex = 2;
            this.big_rb.TabStop = true;
            this.big_rb.Text = "Duża";
            this.big_rb.UseVisualStyleBackColor = true;
            // 
            // medium_rb
            // 
            this.medium_rb.AutoSize = true;
            this.medium_rb.Location = new System.Drawing.Point(6, 42);
            this.medium_rb.Name = "medium_rb";
            this.medium_rb.Size = new System.Drawing.Size(61, 17);
            this.medium_rb.TabIndex = 1;
            this.medium_rb.TabStop = true;
            this.medium_rb.Text = "Średnia";
            this.medium_rb.UseVisualStyleBackColor = true;
            // 
            // small_rb
            // 
            this.small_rb.AutoSize = true;
            this.small_rb.Checked = true;
            this.small_rb.Location = new System.Drawing.Point(6, 19);
            this.small_rb.Name = "small_rb";
            this.small_rb.Size = new System.Drawing.Size(50, 17);
            this.small_rb.TabIndex = 0;
            this.small_rb.TabStop = true;
            this.small_rb.Text = "Mała";
            this.small_rb.UseVisualStyleBackColor = true;
            // 
            // SettingsBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 240);
            this.Controls.Add(this.sizeBoard_gb);
            this.Controls.Add(this.play_b);
            this.Controls.Add(this.levelDifficul_gb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(210, 279);
            this.MinimumSize = new System.Drawing.Size(210, 279);
            this.Name = "SettingsBoard";
            this.Text = "Saper";

            this.levelDifficul_gb.ResumeLayout(false);
            this.levelDifficul_gb.PerformLayout();
            this.sizeBoard_gb.ResumeLayout(false);
            this.sizeBoard_gb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox levelDifficul_gb;
        private System.Windows.Forms.RadioButton hard_rb;
        private System.Windows.Forms.RadioButton normal_rb;
        private System.Windows.Forms.RadioButton esey_rb;
        private System.Windows.Forms.Button play_b;
        private System.Windows.Forms.GroupBox sizeBoard_gb;
        private System.Windows.Forms.RadioButton big_rb;
        private System.Windows.Forms.RadioButton medium_rb;
        private System.Windows.Forms.RadioButton small_rb;
    }
}