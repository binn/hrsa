namespace HRSA
{
    partial class Home
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
            this.ecwButton = new System.Windows.Forms.Button();
            this.hrsaTransferButton = new System.Windows.Forms.Button();
            this.hrsaBatchButton = new System.Windows.Forms.Button();
            this.masterTin = new System.Windows.Forms.Label();
            this.masterTinButton = new System.Windows.Forms.Button();
            this.ecwClaimBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ecwButton
            // 
            this.ecwButton.Font = new System.Drawing.Font("Segoe UI Semilight", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ecwButton.Location = new System.Drawing.Point(12, 37);
            this.ecwButton.Name = "ecwButton";
            this.ecwButton.Size = new System.Drawing.Size(452, 77);
            this.ecwButton.TabIndex = 0;
            this.ecwButton.Text = "Process ECW Records";
            this.ecwButton.UseVisualStyleBackColor = true;
            this.ecwButton.Click += new System.EventHandler(this.ecwButton_Click);
            // 
            // hrsaTransferButton
            // 
            this.hrsaTransferButton.Font = new System.Drawing.Font("Segoe UI Semilight", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hrsaTransferButton.Location = new System.Drawing.Point(12, 202);
            this.hrsaTransferButton.Name = "hrsaTransferButton";
            this.hrsaTransferButton.Size = new System.Drawing.Size(452, 76);
            this.hrsaTransferButton.TabIndex = 1;
            this.hrsaTransferButton.Text = "Transfer HRSA Records";
            this.hrsaTransferButton.UseVisualStyleBackColor = true;
            this.hrsaTransferButton.Click += new System.EventHandler(this.hrsaTransferButton_Click);
            // 
            // hrsaBatchButton
            // 
            this.hrsaBatchButton.Font = new System.Drawing.Font("Segoe UI Semilight", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hrsaBatchButton.Location = new System.Drawing.Point(12, 120);
            this.hrsaBatchButton.Name = "hrsaBatchButton";
            this.hrsaBatchButton.Size = new System.Drawing.Size(452, 76);
            this.hrsaBatchButton.TabIndex = 2;
            this.hrsaBatchButton.Text = "Create HRSA Batch";
            this.hrsaBatchButton.UseVisualStyleBackColor = true;
            this.hrsaBatchButton.Click += new System.EventHandler(this.hrsaBatchButton_Click);
            // 
            // masterTin
            // 
            this.masterTin.AutoSize = true;
            this.masterTin.Location = new System.Drawing.Point(13, 13);
            this.masterTin.Name = "masterTin";
            this.masterTin.Size = new System.Drawing.Size(63, 13);
            this.masterTin.TabIndex = 3;
            this.masterTin.Text = "Master TIN:";
            // 
            // masterTinButton
            // 
            this.masterTinButton.Location = new System.Drawing.Point(338, 8);
            this.masterTinButton.Name = "masterTinButton";
            this.masterTinButton.Size = new System.Drawing.Size(126, 23);
            this.masterTinButton.TabIndex = 4;
            this.masterTinButton.Text = "Set Master TIN";
            this.masterTinButton.UseVisualStyleBackColor = true;
            this.masterTinButton.Click += new System.EventHandler(this.masterTinButton_Click);
            // 
            // ecwClaimBtn
            // 
            this.ecwClaimBtn.Font = new System.Drawing.Font("Segoe UI Semilight", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ecwClaimBtn.Location = new System.Drawing.Point(12, 284);
            this.ecwClaimBtn.Name = "ecwClaimBtn";
            this.ecwClaimBtn.Size = new System.Drawing.Size(452, 76);
            this.ecwClaimBtn.TabIndex = 5;
            this.ecwClaimBtn.Text = "Process ECW Claims";
            this.ecwClaimBtn.UseVisualStyleBackColor = true;
            this.ecwClaimBtn.Click += new System.EventHandler(this.ecwClaimBtn_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 369);
            this.Controls.Add(this.ecwClaimBtn);
            this.Controls.Add(this.masterTinButton);
            this.Controls.Add(this.masterTin);
            this.Controls.Add(this.hrsaBatchButton);
            this.Controls.Add(this.hrsaTransferButton);
            this.Controls.Add(this.ecwButton);
            this.Name = "Home";
            this.Text = "HRSA Billing Hub";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ecwButton;
        private System.Windows.Forms.Button hrsaTransferButton;
        private System.Windows.Forms.Button hrsaBatchButton;
        private System.Windows.Forms.Label masterTin;
        private System.Windows.Forms.Button masterTinButton;
        private System.Windows.Forms.Button ecwClaimBtn;
    }
}

