namespace JocuriDistractive.Mockups
{
    partial class MockupSarpe
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
            this.btnStart = new System.Windows.Forms.Button();
            this.tablaSarpe = new System.Windows.Forms.PictureBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblPunctaj = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaSarpe)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(78, 768);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(153, 61);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start Joc";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // tablaSarpe
            // 
            this.tablaSarpe.BackColor = System.Drawing.Color.Black;
            this.tablaSarpe.Location = new System.Drawing.Point(69, 12);
            this.tablaSarpe.Name = "tablaSarpe";
            this.tablaSarpe.Size = new System.Drawing.Size(700, 700);
            this.tablaSarpe.TabIndex = 2;
            this.tablaSarpe.TabStop = false;
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(331, 754);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(153, 61);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop Joc";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // lblPunctaj
            // 
            this.lblPunctaj.AutoSize = true;
            this.lblPunctaj.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15F);
            this.lblPunctaj.Location = new System.Drawing.Point(646, 783);
            this.lblPunctaj.Name = "lblPunctaj";
            this.lblPunctaj.Size = new System.Drawing.Size(123, 32);
            this.lblPunctaj.TabIndex = 4;
            this.lblPunctaj.Text = "Punctaj: 0";
            // 
            // MockupSarpe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(937, 861);
            this.Controls.Add(this.lblPunctaj);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.tablaSarpe);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MockupSarpe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MockupSarpe";
            ((System.ComponentModel.ISupportInitialize)(this.tablaSarpe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox tablaSarpe;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblPunctaj;
    }
}