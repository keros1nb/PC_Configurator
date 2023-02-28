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
    public partial class AccountForm : Form
    {
        public AccountForm()
        {
            InitializeComponent();
            List<string> user_data = SQLClass.Select("SELECT Name, Surname, City, Age, Login, Password, Email FROM users WHERE Login = '" +
                                                        MainForm.Login + "'");
            List<string> cities = SQLClass.Select("SELECT Name FROM cities ");
            ;
            NameTextBox.Text = user_data[0];
            SurnameTextBox.Text = user_data[1];
            for (int i = 0; i < cities.Count; i++)
            {
                CityComboBox.Items.Add(cities[i]);
                if (user_data[2] == cities[i])
                    CityComboBox.Text = cities[i];


            }
            AgeTextBox.Text = user_data[3];
            LoginTextBox.Text = user_data[4];
            PasswordTextBox.Text = user_data[5];
            EmailTextBox.Text = user_data[6];

            DesignerUserControl.ApplyChanges(this);
            DesignerUserControl.ApplyMenu(this);
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLClass.Update("UPDATE users SET Name = '" + NameTextBox.Text + "', Surname = '" + SurnameTextBox.Text + "', " +
                             "Login  = '" + LoginTextBox.Text + "', " +
                             "Password = '" + PasswordTextBox.Text + "', " +
                             "Email = '" + EmailTextBox.Text + "', " +
                             "Age = '" + AgeTextBox.Text + "'" +
                             "WHERE Login = '" + MainForm.Login + "'");

            MainForm.Login = LoginTextBox.Text;


            MessageBox.Show("Успешно сохранено");
            Close();
        }

        private void CityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            DesignerUserControl.ApplyChanges(this);
            DesignerUserControl.ApplyMenu(this);

        }
    }
}
