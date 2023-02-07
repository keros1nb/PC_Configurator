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
    public partial class Level2UCEditor : UserControl
    {
        public Level2UCEditor()
        {
            InitializeComponent();

            List<string> level1_list = SQLClass.Select("SELECT ID, Id_Name, Name FROM level1");

            comboBox1.Items.Clear();
            for (int i = 0; i < level1_list.Count; i += 3)
            {
                comboBox1.Items.Add(level1_list[i] + "," + level1_list[i + 1] + "," + level1_list[i + 2]);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

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
            string[] parts = comboBox1.Text.Split(new char[] { ',' });

            SQLClass.Update("INSERT INTO level2 (Id_name, Id_Level1, Name, Image, Quantity, Price)" +
                             "VALUES('" + parts[1] + "', '" + parts[0] + "', '" + NameTextBox.Text + "', '" + address + "', '" + QuantityTextBox + "', '" + PriceTextBox.Text + "')");
            MessageBox.Show("Сохранено");
            Level2UCEditor_Load(sender, e);
            return; 

        }

        private void DeleteRoomClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int y = btn.Location.Y;

            foreach (Control control in panel1.Controls)
            {
                if (control.Location == new Point(50, y))
                {
                    SQLClass.Update("DELETE FROM level2 WHERE ID = '" + control.Tag + "'");
                    Level2UCEditor_Load(sender, e);
                    return;
                }
            }
        }

        private void Level2UCEditor_Load(object sender, EventArgs e)
        {
            List<string> list = SQLClass.Select("SELECT ID, Id_name, Id_Level1, Name FROM level2");

            panel1.Controls.Clear();
            int y = 30;
            for (int i = 0; i < list.Count; i += 4)
            {
                Label lbl0 = new Label();
                lbl0.Location = new Point(50, y);
                lbl0.Size = new Size(170, 30);
                lbl0.Font = new Font("Microsoft Sans Serif", 12);
                lbl0.Text = list[i+1];
                lbl0.Tag = list[i];
                panel1.Controls.Add(lbl0);

                Label lbl1 = new Label();
                lbl1.Location = new Point(225, y);
                lbl1.Size = new Size(50, 30);
                lbl1.Font = new Font("Microsoft Sans Serif", 12);
                lbl1.Text = list[i + 2];
                panel1.Controls.Add(lbl1); ;

                Label lbl2 = new Label();
                lbl2.Location = new Point(280, y);
                lbl2.Size = new Size(200, 30);
                lbl2.Font = new Font("Microsoft Sans Serif", 12);
                lbl2.Text = list[i + 3];
                panel1.Controls.Add(lbl2); ;

                Button btn = new Button();
                btn.Location = new Point(540, y);
                btn.Size = new Size(100, 30);
                btn.Font = new Font("Microsoft Sans Serif", 12);
                btn.Click += new EventHandler(DeleteRoomClick);
                btn.Text = "Удалить";
                panel1.Controls.Add(btn);


                y += 35;
            }
        }
    }
}

