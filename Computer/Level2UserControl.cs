using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer
{
    public partial class Level2UserControl : UserControl
    {
        public Level2UserControl(string Id_Level1)
        {
            InitializeComponent();
            List<string> lvl2 = SQLClass.Select("SELECT ID, Id_name,  Id_Level1, Name, Image, Features, Quantity, Price FROM level2 WHERE Id_Level1 = '" + Id_Level1 + "'");




            try
            {
                Text = lvl2[3];
                label1.Text = lvl2[3];
                pictureBox1.Load("../../Pictures/" + lvl2[4]);
            }
            catch (Exception) { };
        }

        private void Level2UserControl_Load(object sender, EventArgs e)
        {

        }

    }
}
