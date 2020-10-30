namespace HRSA
{
    partial class HRSAParse
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
            this.hrsaDataBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.healRecordBtn = new System.Windows.Forms.Button();
            this.hrsaDataBox = new System.Windows.Forms.TextBox();
            this.healRecordBox = new System.Windows.Forms.TextBox();
            this.processMembersBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select HRSA member data:";
            // 
            // hrsaDataBtn
            // 
            this.hrsaDataBtn.Location = new System.Drawing.Point(13, 30);
            this.hrsaDataBtn.Name = "hrsaDataBtn";
            this.hrsaDataBtn.Size = new System.Drawing.Size(101, 23);
            this.hrsaDataBtn.TabIndex = 1;
            this.hrsaDataBtn.Text = "Open File";
            this.hrsaDataBtn.UseVisualStyleBackColor = true;
            this.hrsaDataBtn.Click += new System.EventHandler(this.hrsaDataBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select H36 records:";
            // 
            // healRecordBtn
            // 
            this.healRecordBtn.Location = new System.Drawing.Point(13, 77);
            this.healRecordBtn.Name = "healRecordBtn";
            this.healRecordBtn.Size = new System.Drawing.Size(101, 23);
            this.healRecordBtn.TabIndex = 3;
            this.healRecordBtn.Text = "Open File";
            this.healRecordBtn.UseVisualStyleBackColor = true;
            this.healRecordBtn.Click += new System.EventHandler(this.healRecordBtn_Click);
            // 
            // hrsaDataBox
            // 
            this.hrsaDataBox.Location = new System.Drawing.Point(120, 32);
            this.hrsaDataBox.Name = "hrsaDataBox";
            this.hrsaDataBox.Size = new System.Drawing.Size(254, 20);
            this.hrsaDataBox.TabIndex = 4;
            // 
            // healRecordBox
            // 
            this.healRecordBox.Location = new System.Drawing.Point(120, 79);
            this.healRecordBox.Name = "healRecordBox";
            this.healRecordBox.Size = new System.Drawing.Size(254, 20);
            this.healRecordBox.TabIndex = 5;
            // 
            // processMembersBtn
            // 
            this.processMembersBtn.Location = new System.Drawing.Point(239, 107);
            this.processMembersBtn.Name = "processMembersBtn";
            this.processMembersBtn.Size = new System.Drawing.Size(135, 23);
            this.processMembersBtn.TabIndex = 6;
            this.processMembersBtn.Text = "Process Member IDs";
            this.processMembersBtn.UseVisualStyleBackColor = true;
            this.processMembersBtn.Click += new System.EventHandler(this.processMembersBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(16, 107);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(47, 23);
            this.closeBtn.TabIndex = 7;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // HRSAParse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 142);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.processMembersBtn);
            this.Controls.Add(this.healRecordBox);
            this.Controls.Add(this.hrsaDataBox);
            this.Controls.Add(this.healRecordBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hrsaDataBtn);
            this.Controls.Add(this.label1);
            this.Name = "HRSAParse";
            this.Text = "HRSA Transfer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button hrsaDataBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button healRecordBtn;
        private System.Windows.Forms.TextBox hrsaDataBox;
        private System.Windows.Forms.TextBox healRecordBox;
        private System.Windows.Forms.Button processMembersBtn;
        private System.Windows.Forms.Button closeBtn;
    }
}