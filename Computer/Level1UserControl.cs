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
    public partial class Level1UserControl : UserControl
    {
        public Level1UserControl(string Id_Name)
        {
            InitializeComponent();
            List<string> lvl1 = SQLClass.Select("SELECT ID, Id_Name, Name, Image, Features, Quantity, Price FROM level1 WHERE Id_Name = '" + Id_Name + "'");


            Text = lvl1[2];
            label1.Text = lvl1[2];
            try
            {
                pictureBox1.Load("../../Pictures/" + lvl1[3]);
            }
            catch (Exception) { };

            Level1Panel.Controls.Clear();


            int x = 40;
            for (int i = 0; i < lvl1.Count; i += 7)
            {

                PictureBox pb = new PictureBox();
                pb = new PictureBox();
                try
                {
                    pb.Load("../../Pictures/" + lvl1[i + 3]);
                }
                catch (Exception) { }
                pb.Location = new Point(x, 30);
                pb.Size = new Size(100, 100);
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.Tag = lvl1[i];
                pb.Click += new EventHandler(pictureBox1_Click);
                Level1Panel.Controls.Add(pb);


                Label lbl = new Label();
                lbl.Location = new Point(x, 140);
                lbl.Size = new Size(200, 30);
                lbl.Font = new Font("Microsoft Sans Serif", 12);
                lbl.Text = lvl1[i + 2];
                lbl.Tag = lvl1[i];
                lbl.Click += new EventHandler(label2_Click);
                Level1Panel.Controls.Add(lbl);



                x += 210;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            Level2UserControl lvl2UC = new Level2UserControl(pb.Tag.ToString());
            lvl2UC.Dock = DockStyle.None;
            Controls.Clear();
            Controls.Add(lvl2UC);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            Level2UserControl lvl2UC = new Level2UserControl(lbl.Tag.ToString());
            lvl2UC.Dock = DockStyle.None;
            Controls.Clear();
            Controls.Add(lvl2UC);
        }

       
    }
}
