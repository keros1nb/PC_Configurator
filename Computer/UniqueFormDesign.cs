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
    public partial class UniqueFormDesign : Form
    {
        public UniqueFormDesign(Button btn)
        {
            InitializeComponent();

            buttonObrazec.Text = btn.Text;
            buttonObrazec.Font = btn.Font;
            buttonObrazec.BackColor = btn.BackColor;
            buttonObrazec.ForeColor = btn.ForeColor;
        }

        private void UniqueFormDesign_Load(object sender, EventArgs e)
        {

        }
    }
}
