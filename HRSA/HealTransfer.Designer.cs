namespace HRSA
{
    partial class HealTransfer
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
            this.openHealDataBtn = new System.Windows.Forms.Button();
            this.healDataBox = new System.Windows.Forms.TextBox();
            this.hrsaDataBox = new System.Windows.Forms.TextBox();
            this.openHrsaDataBtn = new System.Windows.Forms.Button();
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
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Heal Records:";
            // 
            // openHealDataBtn
            // 
            this.openHealDataBtn.Location = new System.Drawing.Point(16, 30);
            this.openHealDataBtn.Name = "openHealDataBtn";
            this.openHealDataBtn.Size = new System.Drawing.Size(105, 23);
            this.openHealDataBtn.TabIndex = 1;
            this.openHealDataBtn.Text = "Open File";
            this.openHealDataBtn.UseVisualStyleBackColor = true;
            this.openHealDataBtn.Click += new System.EventHandler(this.openHealDataBtn_Click);
            // 
            // healDataBox
            // 
            this.healDataBox.Location = new System.Drawing.Point(127, 32);
            this.healDataBox.Name = "healDataBox";
            this.healDataBox.Size = new System.Drawing.Size(251, 20);
            this.healDataBox.TabIndex = 2;
            // 
            // hrsaDataBox
            // 
            this.hrsaDataBox.Location = new System.Drawing.Point(127, 75);
            this.hrsaDataBox.Name = "hrsaDataBox";
            this.hrsaDataBox.Size = new System.Drawing.Size(251, 20);
            this.hrsaDataBox.TabIndex = 5;
            // 
            // openHrsaDataBtn
            // 
            this.openHrsaDataBtn.Location = new System.Drawing.Point(16, 73);
            this.openHrsaDataBtn.Name = "openHrsaDataBtn";
            this.openHrsaDataBtn.Size = new System.Drawing.Size(105, 23);
            this.openHrsaDataBtn.TabIndex = 4;
            this.openHrsaDataBtn.Text = "Open File";
            this.openHrsaDataBtn.UseVisualStyleBackColor = true;
            this.openHrsaDataBtn.Click += new System.EventHandler(this.openHrsaDataBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select existing HRSA member data;";
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(16, 100);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(51, 23);
            this.closeBtn.TabIndex = 6;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // generateBtn
            // 
            this.generateBtn.Location = new System.Drawing.Point(265, 100);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(113, 23);
            this.generateBtn.TabIndex = 7;
            this.generateBtn.Text = "Generate";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // HealTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 135);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.hrsaDataBox);
            this.Controls.Add(this.openHrsaDataBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.healDataBox);
            this.Controls.Add(this.openHealDataBtn);
            this.Controls.Add(this.label1);
            this.Name = "HealTransfer";
            this.Text = "HRSA Batch Compiler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button openHealDataBtn;
        private System.Windows.Forms.TextBox healDataBox;
        private System.Windows.Forms.TextBox hrsaDataBox;
        private System.Windows.Forms.Button openHrsaDataBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button generateBtn;
    }
}