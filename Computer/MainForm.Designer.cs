namespace Computer
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.AuthPanel = new System.Windows.Forms.Panel();
            this.CompsPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AccountButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.AdminButton = new System.Windows.Forms.Button();
            this.AuthPanel.SuspendLayout();
            this.CompsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AuthPanel
            // 
            this.AuthPanel.Controls.Add(this.label5);
            this.AuthPanel.Controls.Add(this.AccountButton);
            this.AuthPanel.Controls.Add(this.button1);
            this.AuthPanel.Controls.Add(this.AdminButton);
            this.AuthPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AuthPanel.Location = new System.Drawing.Point(0, 0);
            this.AuthPanel.Name = "AuthPanel";
            this.AuthPanel.Size = new System.Drawing.Size(966, 45);
            this.AuthPanel.TabIndex = 0;
            // 
            // CompsPanel
            // 
            this.CompsPanel.Controls.Add(this.label2);
            this.CompsPanel.Location = new System.Drawing.Point(0, 80);
            this.CompsPanel.Name = "CompsPanel";
            this.CompsPanel.Size = new System.Drawing.Size(966, 402);
            this.CompsPanel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(397, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Конфигуратор ПК";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(103, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            // 
            // AccountButton
            // 
            this.AccountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AccountButton.Location = new System.Drawing.Point(649, 8);
            this.AccountButton.Margin = new System.Windows.Forms.Padding(2);
            this.AccountButton.Name = "AccountButton";
            this.AccountButton.Size = new System.Drawing.Size(161, 32);
            this.AccountButton.TabIndex = 16;
            this.AccountButton.Text = "Личный кабинет";
            this.AccountButton.UseVisualStyleBackColor = true;
            this.AccountButton.Visible = false;
            this.AccountButton.Click += new System.EventHandler(this.AccountButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(16, 8);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 27);
            this.button1.TabIndex = 15;
            this.button1.Text = "Войти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminButton
            // 
            this.AdminButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdminButton.Location = new System.Drawing.Point(835, 11);
            this.AdminButton.Margin = new System.Windows.Forms.Padding(2);
            this.AdminButton.Name = "AdminButton";
            this.AdminButton.Size = new System.Drawing.Size(105, 27);
            this.AdminButton.TabIndex = 14;
            this.AdminButton.Text = "Админка";
            this.AdminButton.UseVisualStyleBackColor = true;
            this.AdminButton.Visible = false;
            this.AdminButton.Click += new System.EventHandler(this.AdminButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 483);
            this.Controls.Add(this.CompsPanel);
            this.Controls.Add(this.AuthPanel);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.AuthPanel.ResumeLayout(false);
            this.AuthPanel.PerformLayout();
            this.CompsPanel.ResumeLayout(false);
            this.CompsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AuthPanel;
        private System.Windows.Forms.Panel CompsPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AccountButton;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button AdminButton;
    }
}

