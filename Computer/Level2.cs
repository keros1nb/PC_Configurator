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
    public partial class Level2 : Form
    {
        public Level2(string Id_Level1)
        {
            InitializeComponent();

            if (Id_Level1 == "1")
            {
                List<string> lvl2 = SQLClass.Select("SELECT ID, Id_Level1, Name, Image, Features, Quantity, Price FROM level2 WHERE Id_Level1 = '" + Id_Level1 + "'");





                Text = lvl2[2];
                label1.Text = lvl2[2];
                try
                {
                    pictureBox1.Load("../../Pictures/" + lvl2[3]);
                }
                catch (Exception) { };


            }
        }
            private void Level2_Load(object sender, EventArgs e)
            {

            }
        }
    }

