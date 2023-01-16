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
        public MainForm()
        {
            InitializeComponent();
            List<string> Components = SQLClass.Select("SELECT Name, Image FROM main");
            CompsPanel.Controls.Clear();
            CompsPanel.Controls.Add(label1);

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
                pb.Location = new Point(x, 30);
                pb.Size = new Size(200, 180);
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.Tag = Components[i];
              //  pb.Click += new EventHandler(pictureBox1_Click);
                CompsPanel.Controls.Add(pb);


                Label lbl = new Label();
                lbl.Location = new Point(x, 210);
                lbl.Size = new Size(200, 30);
                lbl.Font = new Font("Microsoft Sans Serif", 12);
                lbl.Text = Components[i];
                lbl.Tag = Components[i + 1];
              // lbl.Click += new EventHandler(label4_Click);
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            NameComponent = "Computer";
            Level1 lvl1 = new Level1(NameComponent);
            lvl1.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            NameComponent = "Monitor";
            Level1 lvl1 = new Level1(NameComponent);
            lvl1.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            NameComponent = "Keyboard";
            Level1 lvl1 = new Level1(NameComponent);
            lvl1.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            NameComponent = "Mouse";
            Level1 lvl1 = new Level1(NameComponent);
            lvl1.ShowDialog();
        }
    }
}
