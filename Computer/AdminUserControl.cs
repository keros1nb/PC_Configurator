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
    public partial class AdminUserControl : UserControl
    {
        public AdminUserControl()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminUSERSControl AdminUSERS = new AdminUSERSControl();
            Controls.Clear();
            Controls.Add(AdminUSERS);
            AdminUSERS.Dock = DockStyle.None;
        }

        private void button4_Click(object sender, EventArgs e)
        {
          //  управление таблицей готовых комплектов

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // управление таблицей level1
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Level2UCEditor LVL2UCEditor = new Level2UCEditor();
            Controls.Clear();
            Controls.Add(LVL2UCEditor);
            LVL2UCEditor.Dock = DockStyle.None;
        }
    }
}
