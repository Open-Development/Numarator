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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSiraNumarasi = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            this.listWaiting.Location = new System.Drawing.Point(12, 38);
            this.listWaiting.Name = "listWaiting";
            this.listWaiting.Size = new System.Drawing.Size(120, 407);
            this.listWaiting.TabIndex = 1;
            // 
            // listInProgress
            // 
            this.listInProgress.FormattingEnabled = true;
            this.listInProgress.Location = new System.Drawing.Point(272, 38);
            this.listInProgress.Name = "listInProgress";
            this.listInProgress.Size = new System.Drawing.Size(120, 407);
            this.listInProgress.TabIndex = 2;
            // 
            // lblLastNumber
            // 
            this.lblLastNumber.AutoSize = true;
            this.lblLastNumber.Location = new System.Drawing.Point(205, 58);
            this.lblLastNumber.Name = "lblLastNumber";
            this.lblLastNumber.Size = new System.Drawing.Size(35, 13);
            this.lblLastNumber.TabIndex = 3;
            this.lblLastNumber.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bekleyen Sira Numaralari";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Masa : Sira Numarasi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Son Numara:";
            // 
            // lblSiraNumarasi
            // 
            this.lblSiraNumarasi.AutoSize = true;
            this.lblSiraNumarasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSiraNumarasi.Location = new System.Drawing.Point(168, 124);
            this.lblSiraNumarasi.Name = "lblSiraNumarasi";
            this.lblSiraNumarasi.Size = new System.Drawing.Size(72, 63);
            this.lblSiraNumarasi.TabIndex = 7;
            this.lblSiraNumarasi.Text = "9.";
            this.lblSiraNumarasi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(148, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Siradasiniz";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblSiraNumarasi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSiraNumarasi;
        private System.Windows.Forms.Label label5;
    }
}

