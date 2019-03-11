namespace SaperGame
{
    partial class Start
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
            this.next_b = new System.Windows.Forms.Button();
            this.nick_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // next_b
            // 
            this.next_b.Location = new System.Drawing.Point(100, 38);
            this.next_b.Name = "next_b";
            this.next_b.Size = new System.Drawing.Size(75, 23);
            this.next_b.TabIndex = 0;
            this.next_b.Text = "Dalej";
            this.next_b.UseVisualStyleBackColor = true;
            this.next_b.Click += new System.EventHandler(this.next_b_Click);
            // 
            // nick_tb
            // 
            this.nick_tb.Location = new System.Drawing.Point(75, 12);
            this.nick_tb.Name = "nick_tb";
            this.nick_tb.Size = new System.Drawing.Size(100, 20);
            this.nick_tb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Podaj nick:";
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(187, 73);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nick_tb);
            this.Controls.Add(this.next_b);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(203, 112);
            this.MinimumSize = new System.Drawing.Size(203, 112);
            this.Name = "Start";
            this.Text = "Start";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button next_b;
        private System.Windows.Forms.TextBox nick_tb;
        private System.Windows.Forms.Label label1;
    }
}