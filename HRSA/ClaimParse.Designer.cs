namespace HRSA
{
    partial class ClaimParse
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
            this.label1 = new System.Windows.Forms.Label();
            this.ecwClaimsBox = new System.Windows.Forms.TextBox();
            this.ecwClaimsBtn = new System.Windows.Forms.Button();
            this.hrsaMemberBtn = new System.Windows.Forms.Button();
            this.hrsaMemberBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.generateBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select ECW claims records:";
            // 
            // ecwClaimsBox
            // 
            this.ecwClaimsBox.Location = new System.Drawing.Point(142, 33);
            this.ecwClaimsBox.Name = "ecwClaimsBox";
            this.ecwClaimsBox.Size = new System.Drawing.Size(274, 20);
            this.ecwClaimsBox.TabIndex = 1;
            // 
            // ecwClaimsBtn
            // 
            this.ecwClaimsBtn.Location = new System.Drawing.Point(13, 31);
            this.ecwClaimsBtn.Name = "ecwClaimsBtn";
            this.ecwClaimsBtn.Size = new System.Drawing.Size(123, 23);
            this.ecwClaimsBtn.TabIndex = 2;
            this.ecwClaimsBtn.Text = "Open File";
            this.ecwClaimsBtn.UseVisualStyleBackColor = true;
            this.ecwClaimsBtn.Click += new System.EventHandler(this.ecwClaimsBtn_Click);
            // 
            // hrsaMemberBtn
            // 
            this.hrsaMemberBtn.Location = new System.Drawing.Point(13, 78);
            this.hrsaMemberBtn.Name = "hrsaMemberBtn";
            this.hrsaMemberBtn.Size = new System.Drawing.Size(123, 23);
            this.hrsaMemberBtn.TabIndex = 4;
            this.hrsaMemberBtn.Text = "Open File";
            this.hrsaMemberBtn.UseVisualStyleBackColor = true;
            this.hrsaMemberBtn.Click += new System.EventHandler(this.hrsaMemberBtn_Click);
            // 
            // hrsaMemberBox
            // 
            this.hrsaMemberBox.Location = new System.Drawing.Point(142, 80);
            this.hrsaMemberBox.Name = "hrsaMemberBox";
            this.hrsaMemberBox.Size = new System.Drawing.Size(274, 20);
            this.hrsaMemberBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select HRSA member data (optional):";
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(12, 107);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(55, 23);
            this.closeBtn.TabIndex = 6;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // generateBtn
            // 
            this.generateBtn.Location = new System.Drawing.Point(279, 108);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(137, 23);
            this.generateBtn.TabIndex = 7;
            this.generateBtn.Text = "Generate";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // ClaimParse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 137);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hrsaMemberBtn);
            this.Controls.Add(this.hrsaMemberBox);
            this.Controls.Add(this.ecwClaimsBtn);
            this.Controls.Add(this.ecwClaimsBox);
            this.Controls.Add(this.label1);
            this.Name = "ClaimParse";
            this.Text = "ECW Claims Parse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ecwClaimsBox;
        private System.Windows.Forms.Button ecwClaimsBtn;
        private System.Windows.Forms.Button hrsaMemberBtn;
        private System.Windows.Forms.TextBox hrsaMemberBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button generateBtn;
    }
}