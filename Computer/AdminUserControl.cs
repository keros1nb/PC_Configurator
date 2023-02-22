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
            DesignerUserControl.ApplyChanges(this);
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
            Level0UserControl LVL0 = new Level0UserControl();
            Controls.Clear();
            Controls.Add(LVL0);
            LVL0.Dock = DockStyle.None;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Level1UCEditor LVL1UCEditor = new Level1UCEditor();
            Controls.Clear();
            Controls.Add(LVL1UCEditor);
            LVL1UCEditor.Dock = DockStyle.None;
        }

            private void button2_Click(object sender, EventArgs e)
        {
            Level2UCEditor LVL2UCEditor = new Level2UCEditor();
            Controls.Clear();
            Controls.Add(LVL2UCEditor);
            LVL2UCEditor.Dock = DockStyle.None;
        }

        private void AdminUserControl_Load(object sender, EventArgs e)
        {
            DesignerUserControl.ApplyChanges(this);
        }
    }
}
