using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Computer
{
    public partial class Level0UserControl : UserControl
    {
        public Level0UserControl()
        {
            InitializeComponent();
            DesignerUserControl.ApplyChanges(this);
            DesignerUserControl.ApplyMenu(this);

        }
        string address = "";
        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                address = openFileDialog1.FileName;
                pictureBox1.Load(address);
                System.IO.File.Copy(address, "../../Pictures/" + System.IO.Path.GetFileName(address));
                address = System.IO.Path.GetFileName(address);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {


            SQLClass.Update("INSERT INTO level1  Name, Image)" +
                             "VALUES('" + NameTextBox.Text + "', '" + address + "', '" + "')");
            MessageBox.Show("Сохранено");
            Level1UCEditor_Load(sender, e);
            return;

        }

        private void Level1UCEditor_Load(object sender, EventArgs e)
        {
            List<string> list = SQLClass.Select("SELECT ID, Id_Name, Name FROM level1");

            panel1.Controls.Clear();
            int y = 30;
            for (int i = 0; i < list.Count; i += 3)
            {
                Label lbl0 = new Label();
                lbl0.Location = new Point(50, y);
                lbl0.Size = new Size(50, 30);
                lbl0.Font = new Font("Microsoft Sans Serif", 12);
                lbl0.Text = list[i];
                panel1.Controls.Add(lbl0);

                Label lbl1 = new Label();
                lbl1.Location = new Point(225, y);
                lbl1.Size = new Size(200, 30);
                lbl1.Font = new Font("Microsoft Sans Serif", 12);
                lbl1.Text = list[i + 1];
                panel1.Controls.Add(lbl1); ;



                y += 35;
            }
        }

        private void Level0UserControl_Load(object sender, EventArgs e)
        {
            DesignerUserControl.ApplyChanges(this);
            DesignerUserControl.ApplyMenu(this);
        }
    }


}




