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
    public partial class AdminUSERSControl : UserControl
    {
        public AdminUSERSControl()
        {
            InitializeComponent();
            UsersFoundButton_Click_1(null, null);
            List<string> cities = SQLClass.Select("SELECT Name FROM cities ORDER BY Name");
            CityComboBox.Items.Clear();
            CityComboBox.Items.Add("");
            foreach (string city in cities)
                CityComboBox.Items.Add(city);

            DesignerUserControl.ApplyChanges(this);
            DesignerUserControl.ApplyMenu(this);
        }




        private void UsersFoundButton_Click_1(object sender, EventArgs e)
        {
            string command = "SELECT Name, Surname, City, Age FROM users WHERE 1";
            if (CityComboBox.Text != "")
                command += " AND City = '" + CityComboBox.Text + "'";
            if (UsersAgeTextBox.Text != "")
                command += " AND Age >= '" + UsersAgeTextBox.Text + "'";

            List<string> user_data = SQLClass.Select(command);

            UsersPanel.Controls.Clear();
            int y = 30;
            for (int i = 0; i < user_data.Count; i += 4)
            {
                Label lbl0 = new Label();
                lbl0.Location = new Point(50, y);
                lbl0.Size = new Size(170, 30);
                lbl0.Font = new Font("Microsoft Sans Serif", 12);
                lbl0.Text = user_data[i];
                UsersPanel.Controls.Add(lbl0);

                Label lbl1 = new Label();
                lbl1.Location = new Point(230, y);
                lbl1.Size = new Size(150, 30);
                lbl1.Font = new Font("Microsoft Sans Serif", 12);
                lbl1.Text = user_data[i + 1];
                UsersPanel.Controls.Add(lbl1); ;

                Label lbl2 = new Label();
                lbl2.Location = new Point(400, y);
                lbl2.Size = new Size(200, 30);
                lbl2.Font = new Font("Microsoft Sans Serif", 12);
                lbl2.Text = user_data[i + 2];
                UsersPanel.Controls.Add(lbl2); ;

                Label lbl3 = new Label();
                lbl3.Location = new Point(610, y);
                lbl3.Size = new Size(200, 30);
                lbl3.Font = new Font("Microsoft Sans Serif", 12);
                lbl3.Text = user_data[i + 3];
                UsersPanel.Controls.Add(lbl3); ;



                y += 35;
            }
        }

        private void AdminUSERSControl_Load(object sender, EventArgs e)
        {
            DesignerUserControl.ApplyChanges(this);
            DesignerUserControl.ApplyMenu(this);
        }
    }
}
        

       
    

