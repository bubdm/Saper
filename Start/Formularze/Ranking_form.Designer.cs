namespace SaperGame
{
    partial class Ranking_form
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
            this.ranking_rtb = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // ranking_rtb
            // 
            this.ranking_rtb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ranking_rtb.Location = new System.Drawing.Point(0, 0);
            this.ranking_rtb.Name = "ranking_rtb";
            this.ranking_rtb.ReadOnly = true;
            this.ranking_rtb.Size = new System.Drawing.Size(430, 507);
            this.ranking_rtb.TabIndex = 0;
            this.ranking_rtb.Text = "";
            // 
            // Ranking_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 507);
            this.Controls.Add(this.ranking_rtb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(446, 546);
            this.MinimumSize = new System.Drawing.Size(446, 546);
            this.Name = "Ranking_form";
            this.Text = "Ranking";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox ranking_rtb;
    }
}