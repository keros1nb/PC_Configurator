namespace Computer
{
    partial class DesignerUserControl
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonTextBoxFont = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ButtonColorButton = new System.Windows.Forms.Button();
            this.ButtonFontButton = new System.Windows.Forms.Button();
            this.buttonObrazec = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonPanelColor = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.LabelFontButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(966, 618);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.ButtonTextBoxFont);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(958, 585);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Дизайн TextBox ";
            this.tabPage1.UseVisualStyleBackColor = true;

            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(366, 185);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 26);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Образец";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(397, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Образец";
            // 
            // ButtonTextBoxFont
            // 
            this.ButtonTextBoxFont.Location = new System.Drawing.Point(379, 236);
            this.ButtonTextBoxFont.Name = "ButtonTextBoxFont";
            this.ButtonTextBoxFont.Size = new System.Drawing.Size(113, 49);
            this.ButtonTextBoxFont.TabIndex = 3;
            this.ButtonTextBoxFont.Text = "Шрифт";
            this.ButtonTextBoxFont.UseVisualStyleBackColor = true;
            this.ButtonTextBoxFont.Click += new System.EventHandler(this.ButtonTextBoxFont_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ButtonColorButton);
            this.tabPage2.Controls.Add(this.ButtonFontButton);
            this.tabPage2.Controls.Add(this.buttonObrazec);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(958, 585);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Дизайн Button";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ButtonColorButton
            // 
            this.ButtonColorButton.Location = new System.Drawing.Point(167, 285);
            this.ButtonColorButton.Name = "ButtonColorButton";
            this.ButtonColorButton.Size = new System.Drawing.Size(200, 57);
            this.ButtonColorButton.TabIndex = 5;
            this.ButtonColorButton.Text = "Цвет";
            this.ButtonColorButton.UseVisualStyleBackColor = true;
            this.ButtonColorButton.Click += new System.EventHandler(this.ButtonColorButton_Click);
            // 
            // ButtonFontButton
            // 
            this.ButtonFontButton.Location = new System.Drawing.Point(167, 190);
            this.ButtonFontButton.Name = "ButtonFontButton";
            this.ButtonFontButton.Size = new System.Drawing.Size(200, 57);
            this.ButtonFontButton.TabIndex = 4;
            this.ButtonFontButton.Text = "Шрифт";
            this.ButtonFontButton.UseVisualStyleBackColor = true;
            this.ButtonFontButton.Click += new System.EventHandler(this.ButtonFontButton_Click);
            // 
            // buttonObrazec
            // 
            this.buttonObrazec.Location = new System.Drawing.Point(468, 234);
            this.buttonObrazec.Name = "buttonObrazec";
            this.buttonObrazec.Size = new System.Drawing.Size(200, 57);
            this.buttonObrazec.TabIndex = 3;
            this.buttonObrazec.Text = "Образец";
            this.buttonObrazec.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Controls.Add(this.ButtonPanelColor);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(958, 585);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = " Дизайн Panel";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(501, 157);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 270);
            this.panel1.TabIndex = 3;
            // 
            // ButtonPanelColor
            // 
            this.ButtonPanelColor.Location = new System.Drawing.Point(180, 207);
            this.ButtonPanelColor.Name = "ButtonPanelColor";
            this.ButtonPanelColor.Size = new System.Drawing.Size(152, 81);
            this.ButtonPanelColor.TabIndex = 2;
            this.ButtonPanelColor.Text = "Цвет";
            this.ButtonPanelColor.UseVisualStyleBackColor = true;
            this.ButtonPanelColor.Click += new System.EventHandler(this.ButtonPanelColor_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.LabelFontButton);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(958, 585);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Дизайн Label";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // LabelFontButton
            // 
            this.LabelFontButton.Location = new System.Drawing.Point(386, 172);
            this.LabelFontButton.Name = "LabelFontButton";
            this.LabelFontButton.Size = new System.Drawing.Size(106, 34);
            this.LabelFontButton.TabIndex = 3;
            this.LabelFontButton.Text = "Шрифт";
            this.LabelFontButton.UseVisualStyleBackColor = true;
            this.LabelFontButton.Click += new System.EventHandler(this.LabelFontButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(411, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // fontDialog1
            // 
            this.fontDialog1.ShowColor = true;
            // 
            // DesignerUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DesignerUserControl";
            this.Size = new System.Drawing.Size(966, 618);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonTextBoxFont;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button ButtonColorButton;
        private System.Windows.Forms.Button ButtonFontButton;
        private System.Windows.Forms.Button buttonObrazec;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ButtonPanelColor;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button LabelFontButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}
