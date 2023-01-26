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

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string id_main;
            string id_level1;

            List<string> parts = SQLClass.Select("SELECT ID, Name FROM main");
            for(int i=0; i < parts.Count; i+=2)
            {
                id_main = parts[i];
                TreeNode Node0 = new TreeNode(parts[i+1]);
                treeView1.Nodes[0].Nodes.Add(Node0);

                List<string> level1 = SQLClass.Select("SELECT ID, Name FROM level1 WHERE Id_Name = '" + id_main + "'");
                for (int j = 0; j < level1.Count; j += 2)
                {
                    id_level1 = level1[j];
                    TreeNode Node1 = new TreeNode(level1[j + 1]);
                    Node0.Nodes.Add(Node1);

                    List<string> level2 = SQLClass.Select("SELECT ID, Name FROM level2 WHERE Id_Level1 = '" + id_level1 + "'");
                    for(int g=0; g<level2.Count; g+=2)
                    {
                        TreeNode Node2 = new TreeNode(level2[g+1]);
                        Node1.Nodes.Add(Node2);
                    }
                }
            }
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
                AuthPanel.Controls.Clear();
                button1.Text = "Войти";
                AuthPanel.Controls.Add(button1);
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
                }

                AdminButton.Visible = isAdmin;
                label5.Text = NameSurname;
                AuthPanel.Controls.Add(label5);
                AuthPanel.Controls.Add(AccountButton);
                AuthPanel.Controls.Add(AdminButton);
            }
        }

        private void AccountButton_Click(object sender, EventArgs e)
        {
            AccountForm AcF = new AccountForm();
            AcF.ShowDialog();
        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            AdminForm AF = new AdminForm();
            AF.ShowDialog();
        }
    }
    }

