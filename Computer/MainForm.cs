using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer
{
    public partial class MainForm : Form
    {
        public static string NameComponent;

        public static string Login = "";
        public static string NameSurname = "";
        public static bool isAdmin = false;

        

        public MainForm()
        {
            InitializeComponent();

            MainUserControl MainUC = new MainUserControl();
            MainUC.Dock = DockStyle.Fill;
            ViewPanel.Controls.Clear();
            ViewPanel.Controls.Add(MainUC);

            DesignerUserControl.ApplyChanges(this);
            DesignerUserControl.ApplyMenu(this);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string id_main;
            string id_level1;

            DesignerUserControl.Button_ContextMenu = contextMenuStrip1;

            List<string> parts = SQLClass.Select("SELECT ID, Name FROM main");
            for (int i = 0; i < parts.Count; i += 2)
            {
                id_main = parts[i];
                TreeNode Node0 = new TreeNode(parts[i + 1]);
                Node0.Tag = parts[i];
                treeView1.Nodes[0].Nodes.Add(Node0);

                List<string> level1 = SQLClass.Select("SELECT ID, Name FROM level1 WHERE Id_Name = '" + id_main + "'");
                for (int j = 0; j < level1.Count; j += 2)
                {
                    id_level1 = level1[j];
                    TreeNode Node1 = new TreeNode(level1[j + 1]);
                    Node1.Tag = parts[j];
                    Node0.Nodes.Add(Node1);

                    List<string> level2 = SQLClass.Select("SELECT ID, Name FROM level2 WHERE Id_Level1 = '" + id_level1 + "'");
                    for (int g = 0; g < level2.Count; g += 2)
                    {
                        TreeNode Node2 = new TreeNode(level2[g + 1]);
                        Node1.Nodes.Add(Node2);
                    }
                }
            }
            DesignerUserControl.ApplyChanges(this);
            DesignerUserControl.ApplyMenu(this);
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

            PictureBox pb = (PictureBox)sender;
            Level1UserControl lvl1UC = new Level1UserControl(pb.Tag.ToString());
            lvl1UC.Dock = DockStyle.None;
            Controls.Clear();
            Controls.Add(lvl1UC);
        }


        private void label_Click(object sender, EventArgs e)
        {

            Label lbl = (Label)sender;
            Level1UserControl lvl1UC = new Level1UserControl(lbl.Tag.ToString());
            lvl1UC.Dock = DockStyle.None;
            Controls.Clear();
            Controls.Add(lvl1UC);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Выйти")
            {
                Login = "";
                button1.Text = "Войти";
                isAdmin = false;
                AdminButton.Visible = false;
                DesignButton.Visible = false;
                DesignerUserControl.ApplyMenu(this);
                DesignerUserControl.ApplyChanges(this);



                AuthPanel.Controls.Clear();
                AuthPanel.Controls.Add(button1);
                AuthPanel.Controls.Add(DesignButton);
            }
            else
            {
                AuthorizeForm AF = new AuthorizeForm();
                AF.ShowDialog();

                AuthPanel.Controls.Clear();
                button1.Text = "Выйти";
                AuthPanel.Controls.Add(button1);
                if (NameSurname != "")
                {
                    label5.Visible = true;
                    AccountButton.Visible = true;
                    DesignButton.Visible = true;
                    
                }



                AdminButton.Visible = isAdmin;
                label5.Text = "Приветствуем, " + NameSurname;
                AuthPanel.Controls.Add(label5);
                AuthPanel.Controls.Add(AccountButton);
                AuthPanel.Controls.Add(AdminButton);
                AuthPanel.Controls.Add(DesignButton);
                DesignerUserControl.ApplyMenu(this);
                DesignerUserControl.ApplyChanges(this);

            }
        }

        private void AccountButton_Click(object sender, EventArgs e)
        {
            AccountForm AcF = new AccountForm();
            AcF.ShowDialog();
        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            AdminUserControl AdminUC = new AdminUserControl();
            ViewPanel.Controls.Clear();
            ViewPanel.Controls.Add(AdminUC);
            AdminUC.Dock = DockStyle.None;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Level == 0 && e.Node.Text == "Комплектующие")
            {
                MainUserControl MainUC = new MainUserControl();
                MainUC.Dock = DockStyle.Fill;
                ViewPanel.Controls.Clear();
                ViewPanel.Controls.Add(MainUC);
            }

            else if (e.Node.Level == 1 && e.Node.Parent.Text == "Комплектующие")
            {
                Level1UserControl lvl1UC = new Level1UserControl(e.Node.Tag.ToString());
                lvl1UC.Dock = DockStyle.None;
                ViewPanel.Controls.Clear();
                ViewPanel.Controls.Add(lvl1UC);
            }


            else if (e.Node.Level == 2 && e.Node.Parent.Parent.Text == "Комплектующие")
            {
                Level2UserControl lvl2UC = new Level2UserControl(e.Node.Tag.ToString());
                lvl2UC.Dock = DockStyle.None;
                ViewPanel.Controls.Clear();
                ViewPanel.Controls.Add(lvl2UC);

            }

            else if (e.Node.Level == 0 && e.Node.Text == "Вход админа")
            {
                AdminUserControl adminUserControl = new AdminUserControl();
                adminUserControl.Dock = DockStyle.None;
                ViewPanel.Controls.Clear();
                ViewPanel.Controls.Add(adminUserControl);

            }

            else if (e.Node.Level == 1 && e.Node.Parent.Text == "Вход админа" && e.Node.Text == "Управление пользователями")
            {

                AdminUSERSControl adminUSERSControl = new AdminUSERSControl();
                ViewPanel.Controls.Clear();
                ViewPanel.Controls.Add(adminUSERSControl);
                adminUSERSControl.Dock = DockStyle.None;
            }

            else if (e.Node.Level == 1 && e.Node.Parent.Text == "Вход админа" && e.Node.Text == "Редактирование компонентов")
            {

                Level2UCEditor level2UCEditor = new Level2UCEditor();
                ViewPanel.Controls.Clear();
                ViewPanel.Controls.Add(level2UCEditor);
                level2UCEditor.Dock = DockStyle.None;
            }

            else if (e.Node.Level == 1 && e.Node.Parent.Text == "Вход админа" && e.Node.Text == "Редактирование подкатегорий")
            {

                Level1UCEditor level1UCEditor = new Level1UCEditor();
                ViewPanel.Controls.Clear();
                ViewPanel.Controls.Add(level1UCEditor);
                level1UCEditor.Dock = DockStyle.None;
            }

            else if (e.Node.Level == 1 && e.Node.Parent.Text == "Вход админа" && e.Node.Text == "Редактирование комплектов")
            {

                Level0UserControl LVL0 = new Level0UserControl();
                ViewPanel.Controls.Clear();
                ViewPanel.Controls.Add(LVL0);
                LVL0.Dock = DockStyle.None;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isAdmin && treeView1.Nodes.Count == 1)
            {
                TreeNode node = new TreeNode("Вход админа");
                treeView1.Nodes.Add(node);

                TreeNode node1 = new TreeNode("Управление пользователями"); 
                node.Nodes.Add(node1);

                TreeNode node2 = new TreeNode("Редактирование компонентов");
                node.Nodes.Add(node2);

                TreeNode node3 = new TreeNode("Редактирование подкатегорий");
                node.Nodes.Add(node3);

                TreeNode node4 = new TreeNode("Редактирование комплектов");
                node.Nodes.Add(node4);
            }
            else if (!isAdmin && treeView1.Nodes.Count > 1)
            {
                treeView1.Nodes.RemoveAt(1);
            }

        }

        private void ViewPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DesignButton_Click(object sender, EventArgs e)
        {
            DesignerUserControl DUC = new DesignerUserControl();
            ViewPanel.Controls.Clear();
            ViewPanel.Controls.Add(DUC);
            DUC.Dock = DockStyle.None;

            DesignerUserControl.ApplyChanges(this);
        }

       

      

        private void уникальныйДизайнКнопкиToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                ToolStripMenuItem item = (ToolStripMenuItem)sender;
                ContextMenuStrip CMS = (ContextMenuStrip)(item.GetCurrentParent());
                Button button = (Button)(CMS.SourceControl);
                UniqueFormDesign UFD = new UniqueFormDesign(button);
                UFD.ShowDialog();
            }
            catch (Exception ex) { }
        }
    }
}

