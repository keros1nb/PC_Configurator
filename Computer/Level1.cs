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
    public partial class Level1 : Form
    {
       public static string model;
        public Level1(string NameComponent)
        {
            InitializeComponent();

            if (NameComponent == "Computer")
            {
                Text = "Системные блоки";
                label1.Text = "Системные блоки";
                pictureBox1.Load("../../Pictures/Computer.png");
            }

            if (NameComponent == "Monitor")
            {
                Text = "Мониторы";
                label1.Text = "Мониторы";
                pictureBox1.Load("../../Pictures/Monitor.png");
            }

            if (NameComponent == "Keyboard")
            {
                Text = "Клавиатуры";
                label1.Text = "Клавиатуры";
                pictureBox1.Load("../../Pictures/Keyboard.png");
            }

            if (NameComponent == "Mouse")
            {
                Text = "Мыши";
                label1.Text = "Мыши";
                pictureBox1.Load("../../Pictures/Mouse.png");
            }
        }

        private void Level1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            model = "Razer DeathAdder";
            Level2 lvl2 = new Level2("model");
            lvl2.ShowDialog();
        }
    }
}
