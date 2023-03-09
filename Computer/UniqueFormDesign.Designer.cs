namespace Computer
{
    partial class UniqueFormDesign
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
            this.ButtonColorButton = new System.Windows.Forms.Button();
            this.ButtonFontButton = new System.Windows.Forms.Button();
            this.buttonObrazec = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.Button_Coordinates = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Button_Size = new System.Windows.Forms.TextBox();
            this.SaveCoordsAndSizeButton = new System.Windows.Forms.Button();
            this.ButtonCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ButtonColorButton
            // 
            this.ButtonColorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonColorButton.Location = new System.Drawing.Point(66, 149);
            this.ButtonColorButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonColorButton.Name = "ButtonColorButton";
            this.ButtonColorButton.Size = new System.Drawing.Size(165, 44);
            this.ButtonColorButton.TabIndex = 8;
            this.ButtonColorButton.Text = "Цвет";
            this.ButtonColorButton.UseVisualStyleBackColor = true;
            this.ButtonColorButton.Click += new System.EventHandler(this.ButtonColorButton_Click);
            // 
            // ButtonFontButton
            // 
            this.ButtonFontButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonFontButton.Location = new System.Drawing.Point(66, 85);
            this.ButtonFontButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonFontButton.Name = "ButtonFontButton";
            this.ButtonFontButton.Size = new System.Drawing.Size(165, 44);
            this.ButtonFontButton.TabIndex = 7;
            this.ButtonFontButton.Text = "Шрифт";
            this.ButtonFontButton.UseVisualStyleBackColor = true;
            this.ButtonFontButton.Click += new System.EventHandler(this.ButtonFontButton_Click);
            // 
            // buttonObrazec
            // 
            this.buttonObrazec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonObrazec.Location = new System.Drawing.Point(66, 14);
            this.buttonObrazec.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonObrazec.Name = "buttonObrazec";
            this.buttonObrazec.Size = new System.Drawing.Size(165, 44);
            this.buttonObrazec.TabIndex = 6;
            this.buttonObrazec.Text = "Образец";
            this.buttonObrazec.UseVisualStyleBackColor = true;
            // 
            // Button_Coordinates
            // 
            this.Button_Coordinates.Location = new System.Drawing.Point(131, 212);
            this.Button_Coordinates.Name = "Button_Coordinates";
            this.Button_Coordinates.Size = new System.Drawing.Size(140, 26);
            this.Button_Coordinates.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Коордианты";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Размер";
            // 
            // Button_Size
            // 
            this.Button_Size.Location = new System.Drawing.Point(131, 255);
            this.Button_Size.Name = "Button_Size";
            this.Button_Size.Size = new System.Drawing.Size(140, 26);
            this.Button_Size.TabIndex = 11;
            // 
            // SaveCoordsAndSizeButton
            // 
            this.SaveCoordsAndSizeButton.Location = new System.Drawing.Point(16, 325);
            this.SaveCoordsAndSizeButton.Name = "SaveCoordsAndSizeButton";
            this.SaveCoordsAndSizeButton.Size = new System.Drawing.Size(255, 34);
            this.SaveCoordsAndSizeButton.TabIndex = 13;
            this.SaveCoordsAndSizeButton.Text = "Сохранить";
            this.SaveCoordsAndSizeButton.UseVisualStyleBackColor = true;
            this.SaveCoordsAndSizeButton.Click += new System.EventHandler(this.SaveCoordsAndSizeButton_Click);
            // 
            // ButtonCheckBox
            // 
            this.ButtonCheckBox.AutoSize = true;
            this.ButtonCheckBox.Location = new System.Drawing.Point(16, 295);
            this.ButtonCheckBox.Name = "ButtonCheckBox";
            this.ButtonCheckBox.Size = new System.Drawing.Size(178, 24);
            this.ButtonCheckBox.TabIndex = 14;
            this.ButtonCheckBox.Text = "Только для админа";
            this.ButtonCheckBox.UseVisualStyleBackColor = true;
            this.ButtonCheckBox.CheckedChanged += new System.EventHandler(this.ButtonCheckBox_CheckedChanged);
            // 
            // UniqueFormDesign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 370);
            this.Controls.Add(this.ButtonCheckBox);
            this.Controls.Add(this.SaveCoordsAndSizeButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Button_Size);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button_Coordinates);
            this.Controls.Add(this.ButtonColorButton);
            this.Controls.Add(this.ButtonFontButton);
            this.Controls.Add(this.buttonObrazec);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UniqueFormDesign";
            this.Text = "UniqueFormDesign";
            this.Load += new System.EventHandler(this.UniqueFormDesign_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonColorButton;
        private System.Windows.Forms.Button ButtonFontButton;
        private System.Windows.Forms.Button buttonObrazec;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox Button_Coordinates;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Button_Size;
        private System.Windows.Forms.Button SaveCoordsAndSizeButton;
        private System.Windows.Forms.CheckBox ButtonCheckBox;
    }
}