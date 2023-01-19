using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            List<string> Components = SQLClass.Select("SELECT ID, Name, Image FROM main");
            CompsPanel.Controls.Clear();
            CompsPanel.Controls.Add(label2);

            int x = 40;
            for (int i = 0; i < Components.Count; i += 3)
            {

                PictureBox pb = new PictureBox();
                pb = new PictureBox();
                try
                {
                    pb.Load("../../Pictures/" + Components[i + 2]);
                }
                catch (Exception) { }
                pb.Location = new Point(x, 50);
                pb.Size = new Size(200, 180);
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.Tag = Components[i];
                pb.Click += new EventHandler(pictureBox_Click);
                CompsPanel.Controls.Add(pb);


                Label lbl = new Label();
                lbl.Location = new Point(x, 240);
                lbl.Size = new Size(200, 30);
                lbl.Font = new Font("Microsoft Sans Serif", 12);
                lbl.Text = Components[i + 1];
                lbl.Tag = Components[i];
                lbl.Click += new EventHandler(label_Click);
                CompsPanel.Controls.Add(lbl);



                x += 220;
            }


        }

        private void MainForm_Load(object sender, EventArgs e)
        {

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
            Level1 lvl1 = new Level1(pb.Tag.ToString());
            lvl1.ShowDialog();
        }

        
        private void label_Click(object sender, EventArgs e)
        {
            Label pb = (Label)sender;
            Level1 lvl1 = new Level1(pb.Tag.ToString());
            lvl1.ShowDialog();
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

