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
    public partial class MainUserControl : UserControl
    {
        public MainUserControl()
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
        private void CompsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}
