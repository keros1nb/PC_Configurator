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
        public Level2(string model)
        {
            InitializeComponent();

            if (model == "Razer DeathAdder") ;
            {
                Text = "Razer DeathAdder";
                label1.Text = "Razer DeathAdder";
            }
        }

        private void Level2_Load(object sender, EventArgs e)
        {

        }
    }
}
