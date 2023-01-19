namespace Computer
{
    partial class Level1
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
            this.Level0Panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Level1Panel = new System.Windows.Forms.Panel();
            this.Level0Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Level0Panel
            // 
            this.Level0Panel.Controls.Add(this.label1);
            this.Level0Panel.Controls.Add(this.pictureBox1);
            this.Level0Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Level0Panel.Location = new System.Drawing.Point(0, 0);
            this.Level0Panel.Name = "Level0Panel";
            this.Level0Panel.Size = new System.Drawing.Size(800, 222);
            this.Level0Panel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(74, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(22, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Level1Panel
            // 
            this.Level1Panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Level1Panel.Location = new System.Drawing.Point(0, 228);
            this.Level1Panel.Name = "Level1Panel";
            this.Level1Panel.Size = new System.Drawing.Size(800, 351);
            this.Level1Panel.TabIndex = 1;
            // 
            // Level1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 579);
            this.Controls.Add(this.Level1Panel);
            this.Controls.Add(this.Level0Panel);
            this.Name = "Level1";
            this.Text = "Level1";
            this.Load += new System.EventHandler(this.Level1_Load);
            this.Level0Panel.ResumeLayout(false);
            this.Level0Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Level0Panel;
        private System.Windows.Forms.Panel Level1Panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}