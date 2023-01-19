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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLClass.Update("INSERT INTO users (Name, Surname, City, Age, Login, Password, Email)" +
                             "VALUES('" + NameTextBox.Text + "', '" + SurnameTextBox.Text + "', '" + CityComboBox.Text + "', '" + AgeTextBox.Text + "', '" + LoginTextBox.Text + "', '" + PasswordTextBox.Text + "', '" + EmailTextBox.Text + "')");

            MessageBox.Show("Сохранено");
            Close();
        }
    }
}
