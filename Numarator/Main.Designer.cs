namespace Numarator
{
    partial class Main
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
            this.btnGetNumber = new System.Windows.Forms.Button();
            this.listWaiting = new System.Windows.Forms.ListBox();
            this.listInProgress = new System.Windows.Forms.ListBox();
            this.lblLastNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGetNumber
            // 
            this.btnGetNumber.Location = new System.Drawing.Point(138, 12);
            this.btnGetNumber.Name = "btnGetNumber";
            this.btnGetNumber.Size = new System.Drawing.Size(128, 23);
            this.btnGetNumber.TabIndex = 0;
            this.btnGetNumber.Text = "button1";
            this.btnGetNumber.UseVisualStyleBackColor = true;
            this.btnGetNumber.Click += new System.EventHandler(this.BtnGetNumber_Click);
            // 
            // listWaiting
            // 
            this.listWaiting.FormattingEnabled = true;
            this.listWaiting.Location = new System.Drawing.Point(12, 12);
            this.listWaiting.Name = "listWaiting";
            this.listWaiting.Size = new System.Drawing.Size(120, 433);
            this.listWaiting.TabIndex = 1;
            // 
            // listInProgress
            // 
            this.listInProgress.FormattingEnabled = true;
            this.listInProgress.Location = new System.Drawing.Point(272, 12);
            this.listInProgress.Name = "listInProgress";
            this.listInProgress.Size = new System.Drawing.Size(120, 433);
            this.listInProgress.TabIndex = 2;
            // 
            // lblLastNumber
            // 
            this.lblLastNumber.AutoSize = true;
            this.lblLastNumber.Location = new System.Drawing.Point(138, 58);
            this.lblLastNumber.Name = "lblLastNumber";
            this.lblLastNumber.Size = new System.Drawing.Size(35, 13);
            this.lblLastNumber.TabIndex = 3;
            this.lblLastNumber.Text = "label1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 450);
            this.Controls.Add(this.lblLastNumber);
            this.Controls.Add(this.listInProgress);
            this.Controls.Add(this.listWaiting);
            this.Controls.Add(this.btnGetNumber);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetNumber;
        private System.Windows.Forms.ListBox listWaiting;
        private System.Windows.Forms.ListBox listInProgress;
        private System.Windows.Forms.Label lblLastNumber;
    }
}

