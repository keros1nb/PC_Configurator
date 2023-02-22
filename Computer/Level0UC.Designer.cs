namespace Computer
{
    partial class Level0UC
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
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
            this.Level0Panel.Size = new System.Drawing.Size(966, 167);
            this.Level0Panel.TabIndex = 3;
            this.Level0Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Level0Panel_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(56, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(15, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Level1Panel
            // 
            this.Level1Panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Level1Panel.Location = new System.Drawing.Point(0, 167);
            this.Level1Panel.Name = "Level1Panel";
            this.Level1Panel.Size = new System.Drawing.Size(966, 451);
            this.Level1Panel.TabIndex = 4;
            // 
            // Level0UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Level0Panel);
            this.Controls.Add(this.Level1Panel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Level0UC";
            this.Size = new System.Drawing.Size(966, 618);
            this.Level0Panel.ResumeLayout(false);
            this.Level0Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Level0Panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel Level1Panel;
    }
}
