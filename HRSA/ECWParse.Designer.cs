namespace HRSA
{
    partial class ECWParse
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
            this.ecwRecordBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ecwRecordsOpenFileBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ecwPatientDataOpenFileBtn = new System.Windows.Forms.Button();
            this.ecwDataBox = new System.Windows.Forms.TextBox();
            this.generateBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.dosBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ecwRecordBox
            // 
            this.ecwRecordBox.Location = new System.Drawing.Point(126, 29);
            this.ecwRecordBox.Name = "ecwRecordBox";
            this.ecwRecordBox.Size = new System.Drawing.Size(236, 20);
            this.ecwRecordBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select ECW Records:";
            // 
            // ecwRecordsOpenFileBtn
            // 
            this.ecwRecordsOpenFileBtn.Location = new System.Drawing.Point(12, 27);
            this.ecwRecordsOpenFileBtn.Name = "ecwRecordsOpenFileBtn";
            this.ecwRecordsOpenFileBtn.Size = new System.Drawing.Size(108, 23);
            this.ecwRecordsOpenFileBtn.TabIndex = 2;
            this.ecwRecordsOpenFileBtn.Text = "Open File";
            this.ecwRecordsOpenFileBtn.UseVisualStyleBackColor = true;
            this.ecwRecordsOpenFileBtn.Click += new System.EventHandler(this.ecwRecordsOpenFileBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select ECW Patient Data:";
            // 
            // ecwPatientDataOpenFileBtn
            // 
            this.ecwPatientDataOpenFileBtn.Location = new System.Drawing.Point(12, 78);
            this.ecwPatientDataOpenFileBtn.Name = "ecwPatientDataOpenFileBtn";
            this.ecwPatientDataOpenFileBtn.Size = new System.Drawing.Size(108, 23);
            this.ecwPatientDataOpenFileBtn.TabIndex = 5;
            this.ecwPatientDataOpenFileBtn.Text = "Open File";
            this.ecwPatientDataOpenFileBtn.UseVisualStyleBackColor = true;
            this.ecwPatientDataOpenFileBtn.Click += new System.EventHandler(this.ecwPatientDataOpenFileBtn_Click);
            // 
            // ecwDataBox
            // 
            this.ecwDataBox.Location = new System.Drawing.Point(126, 80);
            this.ecwDataBox.Name = "ecwDataBox";
            this.ecwDataBox.Size = new System.Drawing.Size(236, 20);
            this.ecwDataBox.TabIndex = 4;
            // 
            // generateBtn
            // 
            this.generateBtn.Location = new System.Drawing.Point(186, 106);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(125, 23);
            this.generateBtn.TabIndex = 6;
            this.generateBtn.Text = "Generate";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(317, 106);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(45, 23);
            this.closeBtn.TabIndex = 7;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // dosBox
            // 
            this.dosBox.Location = new System.Drawing.Point(51, 109);
            this.dosBox.Name = "dosBox";
            this.dosBox.Size = new System.Drawing.Size(69, 20);
            this.dosBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "DOS:";
            // 
            // ECWParse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 139);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dosBox);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.ecwPatientDataOpenFileBtn);
            this.Controls.Add(this.ecwDataBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ecwRecordsOpenFileBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ecwRecordBox);
            this.Name = "ECWParse";
            this.Text = "ECW Record Parse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ecwRecordBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ecwRecordsOpenFileBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ecwPatientDataOpenFileBtn;
        private System.Windows.Forms.TextBox ecwDataBox;
        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.TextBox dosBox;
        private System.Windows.Forms.Label label3;
    }
}