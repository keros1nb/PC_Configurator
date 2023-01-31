namespace Computer
{
    partial class AdminUSERSControl
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
            this.FliterPanel = new System.Windows.Forms.Panel();
            this.UsersFoundButton = new System.Windows.Forms.Button();
            this.UsersAgeTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CityComboBox = new System.Windows.Forms.ComboBox();
            this.UsersPanel = new System.Windows.Forms.Panel();
            this.FliterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FliterPanel
            // 
            this.FliterPanel.Controls.Add(this.UsersFoundButton);
            this.FliterPanel.Controls.Add(this.UsersAgeTextBox);
            this.FliterPanel.Controls.Add(this.label6);
            this.FliterPanel.Controls.Add(this.label2);
            this.FliterPanel.Controls.Add(this.label1);
            this.FliterPanel.Controls.Add(this.CityComboBox);
            this.FliterPanel.Location = new System.Drawing.Point(17, 29);
            this.FliterPanel.Margin = new System.Windows.Forms.Padding(2);
            this.FliterPanel.Name = "FliterPanel";
            this.FliterPanel.Size = new System.Drawing.Size(854, 217);
            this.FliterPanel.TabIndex = 2;
            // 
            // UsersFoundButton
            // 
            this.UsersFoundButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsersFoundButton.Location = new System.Drawing.Point(540, 73);
            this.UsersFoundButton.Margin = new System.Windows.Forms.Padding(2);
            this.UsersFoundButton.Name = "UsersFoundButton";
            this.UsersFoundButton.Size = new System.Drawing.Size(198, 36);
            this.UsersFoundButton.TabIndex = 26;
            this.UsersFoundButton.Text = "Поиск";
            this.UsersFoundButton.UseVisualStyleBackColor = true;
            this.UsersFoundButton.Click += new System.EventHandler(this.UsersFoundButton_Click_1);
            // 
            // UsersAgeTextBox
            // 
            this.UsersAgeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsersAgeTextBox.Location = new System.Drawing.Point(306, 80);
            this.UsersAgeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.UsersAgeTextBox.Name = "UsersAgeTextBox";
            this.UsersAgeTextBox.Size = new System.Drawing.Size(183, 24);
            this.UsersAgeTextBox.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(344, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Фильтр пользователей";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(302, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Выберите возраст";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Выберите город";
            // 
            // CityComboBox
            // 
            this.CityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CityComboBox.FormattingEnabled = true;
            this.CityComboBox.Location = new System.Drawing.Point(25, 83);
            this.CityComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.CityComboBox.Name = "CityComboBox";
            this.CityComboBox.Size = new System.Drawing.Size(207, 21);
            this.CityComboBox.TabIndex = 4;
            // 
            // UsersPanel
            // 
            this.UsersPanel.AutoScroll = true;
            this.UsersPanel.Location = new System.Drawing.Point(17, 251);
            this.UsersPanel.Margin = new System.Windows.Forms.Padding(2);
            this.UsersPanel.Name = "UsersPanel";
            this.UsersPanel.Size = new System.Drawing.Size(854, 245);
            this.UsersPanel.TabIndex = 3;
            // 
            // AdminUSERSControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FliterPanel);
            this.Controls.Add(this.UsersPanel);
            this.Name = "AdminUSERSControl";
            this.Size = new System.Drawing.Size(888, 525);
            this.FliterPanel.ResumeLayout(false);
            this.FliterPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FliterPanel;
        private System.Windows.Forms.Button UsersFoundButton;
        private System.Windows.Forms.TextBox UsersAgeTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CityComboBox;
        private System.Windows.Forms.Panel UsersPanel;
    }
}
