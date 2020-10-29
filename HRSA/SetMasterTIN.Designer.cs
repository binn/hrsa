namespace HRSA
{
    partial class SetMasterTIN
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
            this.masterTinInput = new System.Windows.Forms.TextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.setBtn = new System.Windows.Forms.Button();
            this.masterTinLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // masterTinInput
            // 
            this.masterTinInput.Location = new System.Drawing.Point(12, 29);
            this.masterTinInput.Name = "masterTinInput";
            this.masterTinInput.Size = new System.Drawing.Size(157, 20);
            this.masterTinInput.TabIndex = 0;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(94, 55);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // setBtn
            // 
            this.setBtn.Location = new System.Drawing.Point(13, 55);
            this.setBtn.Name = "setBtn";
            this.setBtn.Size = new System.Drawing.Size(75, 23);
            this.setBtn.TabIndex = 2;
            this.setBtn.Text = "OK";
            this.setBtn.UseVisualStyleBackColor = true;
            this.setBtn.Click += new System.EventHandler(this.setBtn_Click);
            // 
            // masterTinLabel
            // 
            this.masterTinLabel.AutoSize = true;
            this.masterTinLabel.Location = new System.Drawing.Point(13, 10);
            this.masterTinLabel.Name = "masterTinLabel";
            this.masterTinLabel.Size = new System.Drawing.Size(114, 13);
            this.masterTinLabel.TabIndex = 3;
            this.masterTinLabel.Text = "Enter new Master TIN:";
            // 
            // SetMasterTIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(181, 90);
            this.Controls.Add(this.masterTinLabel);
            this.Controls.Add(this.setBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.masterTinInput);
            this.Name = "SetMasterTIN";
            this.Text = "Set Master TIN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox masterTinInput;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button setBtn;
        private System.Windows.Forms.Label masterTinLabel;
    }
}