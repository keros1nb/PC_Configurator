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
        public Level1UserControl(string Id_Level1)
        {
            InitializeComponent();
            List<string> lvl1 = SQLClass.Select("SELECT ID, Name, Image FROM level1 WHERE ID = '" + Id_Level1 + "'");
            List<string> lvl2 = SQLClass.Select("SELECT ID, Name, Features, Image, Quantity, Price FROM level2 WHERE Id_Level1 = '" + Id_Level1 + "'");

            Text = lvl1[1];
            label1.Text = lvl1[1];
            try
            {
                
                pictureBox1.Load("../../Pictures/" + lvl1 [2]);
            }
            catch (Exception) { };

            Level1Panel.Controls.Clear();


            int x = 40;
            for (int i = 0; i < lvl2.Count; i += 6  )
            {

                PictureBox pb = new PictureBox();
                pb = new PictureBox();
                try
                {
                    pb.Load("../../Pictures/" + lvl2[i + 4]);
                }
                catch (Exception) { }
                pb.Location = new Point(x, 30);
                pb.Size = new Size(100, 100);
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.Tag = lvl2[i];
                pb.Click += new EventHandler(pictureBox1_Click);
                Level1Panel.Controls.Add(pb);


                Label lbl = new Label();
                lbl.Location = new Point(x, 140);
                lbl.Size = new Size(200, 30);
                lbl.Font = new Font("Microsoft Sans Serif", 12);
                lbl.Text = lvl2[i + 1];
                lbl.Tag = lvl2[i];
                lbl.Click += new EventHandler(label2_Click);
                Level1Panel.Controls.Add(lbl);



                x += 210;
            }
            DesignerUserControl.ApplyChanges(this);
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

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void Level1Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Level0Panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
