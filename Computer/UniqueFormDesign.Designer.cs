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
            this.SuspendLayout();
            // 
            // ButtonColorButton
            // 
            this.ButtonColorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonColorButton.Location = new System.Drawing.Point(66, 173);
            this.ButtonColorButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonColorButton.Name = "ButtonColorButton";
            this.ButtonColorButton.Size = new System.Drawing.Size(165, 44);
            this.ButtonColorButton.TabIndex = 8;
            this.ButtonColorButton.Text = "Цвет";
            this.ButtonColorButton.UseVisualStyleBackColor = true;
            // 
            // ButtonFontButton
            // 
            this.ButtonFontButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonFontButton.Location = new System.Drawing.Point(66, 108);
            this.ButtonFontButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonFontButton.Name = "ButtonFontButton";
            this.ButtonFontButton.Size = new System.Drawing.Size(165, 44);
            this.ButtonFontButton.TabIndex = 7;
            this.ButtonFontButton.Text = "Шрифт";
            this.ButtonFontButton.UseVisualStyleBackColor = true;
            // 
            // buttonObrazec
            // 
            this.buttonObrazec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonObrazec.Location = new System.Drawing.Point(66, 25);
            this.buttonObrazec.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonObrazec.Name = "buttonObrazec";
            this.buttonObrazec.Size = new System.Drawing.Size(165, 44);
            this.buttonObrazec.TabIndex = 6;
            this.buttonObrazec.Text = "Образец";
            this.buttonObrazec.UseVisualStyleBackColor = true;
            // 
            // UniqueFormDesign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 248);
            this.Controls.Add(this.ButtonColorButton);
            this.Controls.Add(this.ButtonFontButton);
            this.Controls.Add(this.buttonObrazec);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UniqueFormDesign";
            this.Text = "UniqueFormDesign";
            this.Load += new System.EventHandler(this.UniqueFormDesign_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonColorButton;
        private System.Windows.Forms.Button ButtonFontButton;
        private System.Windows.Forms.Button buttonObrazec;
    }
}