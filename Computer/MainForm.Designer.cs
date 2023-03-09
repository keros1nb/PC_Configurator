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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Комплектующие");
            this.AuthPanel = new System.Windows.Forms.Panel();
            this.DesignButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.AccountButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.AdminButton = new System.Windows.Forms.Button();
            this.ViewPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.уникальныйДизайнКнопкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.уникальныйДизайнНадписиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AuthPanel.SuspendLayout();
            this.ViewPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // AuthPanel
            // 
            this.AuthPanel.Controls.Add(this.DesignButton);
            this.AuthPanel.Controls.Add(this.label5);
            this.AuthPanel.Controls.Add(this.AccountButton);
            this.AuthPanel.Controls.Add(this.button1);
            this.AuthPanel.Controls.Add(this.AdminButton);
            this.AuthPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AuthPanel.Location = new System.Drawing.Point(0, 0);
            this.AuthPanel.Name = "AuthPanel";
            this.AuthPanel.Size = new System.Drawing.Size(1464, 45);
            this.AuthPanel.TabIndex = 0;
            // 
            // DesignButton
            // 
            this.DesignButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DesignButton.Location = new System.Drawing.Point(779, 5);
            this.DesignButton.Margin = new System.Windows.Forms.Padding(2);
            this.DesignButton.Name = "DesignButton";
            this.DesignButton.Size = new System.Drawing.Size(134, 32);
            this.DesignButton.TabIndex = 18;
            this.DesignButton.Text = "Дизайн";
            this.DesignButton.UseVisualStyleBackColor = true;
            this.DesignButton.Visible = false;
            this.DesignButton.Click += new System.EventHandler(this.DesignButton_Click);
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
            this.AccountButton.Location = new System.Drawing.Point(933, 5);
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
            this.AdminButton.Location = new System.Drawing.Point(1110, 8);
            this.AdminButton.Margin = new System.Windows.Forms.Padding(2);
            this.AdminButton.Name = "AdminButton";
            this.AdminButton.Size = new System.Drawing.Size(105, 27);
            this.AdminButton.TabIndex = 14;
            this.AdminButton.Text = "Админка";
            this.AdminButton.UseVisualStyleBackColor = true;
            this.AdminButton.Visible = false;
            this.AdminButton.Click += new System.EventHandler(this.AdminButton_Click);
            // 
            // ViewPanel
            // 
            this.ViewPanel.Controls.Add(this.label2);
            this.ViewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewPanel.Location = new System.Drawing.Point(315, 3);
            this.ViewPanel.Name = "ViewPanel";
            this.ViewPanel.Size = new System.Drawing.Size(1146, 534);
            this.ViewPanel.TabIndex = 1;
            this.ViewPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ViewPanel_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(361, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Конфигуратор ПК";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.32505F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.67495F));
            this.tableLayoutPanel1.Controls.Add(this.ViewPanel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.treeView1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 45);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1464, 540);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            treeNode2.BackColor = System.Drawing.Color.White;
            treeNode2.Name = "Узел0";
            treeNode2.Text = "Комплектующие";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.treeView1.Size = new System.Drawing.Size(306, 534);
            this.treeView1.TabIndex = 2;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.уникальныйДизайнКнопкиToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(228, 48);
            // 
            // уникальныйДизайнКнопкиToolStripMenuItem
            // 
            this.уникальныйДизайнКнопкиToolStripMenuItem.Name = "уникальныйДизайнКнопкиToolStripMenuItem";
            this.уникальныйДизайнКнопкиToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.уникальныйДизайнКнопкиToolStripMenuItem.Text = "Уникальный дизайн кнопки";
            this.уникальныйДизайнКнопкиToolStripMenuItem.Click += new System.EventHandler(this.уникальныйДизайнКнопкиToolStripMenuItem_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.уникальныйДизайнНадписиToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(234, 26);
            // 
            // уникальныйДизайнНадписиToolStripMenuItem
            // 
            this.уникальныйДизайнНадписиToolStripMenuItem.Name = "уникальныйДизайнНадписиToolStripMenuItem";
            this.уникальныйДизайнНадписиToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.уникальныйДизайнНадписиToolStripMenuItem.Text = "Уникальный дизайн надписи";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 585);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.AuthPanel);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.AuthPanel.ResumeLayout(false);
            this.AuthPanel.PerformLayout();
            this.ViewPanel.ResumeLayout(false);
            this.ViewPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AuthPanel;
        private System.Windows.Forms.Panel ViewPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AccountButton;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button AdminButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button DesignButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem уникальныйДизайнКнопкиToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem уникальныйДизайнНадписиToolStripMenuItem;
    }
}

