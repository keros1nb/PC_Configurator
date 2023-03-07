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
        Button btn;
        public UniqueFormDesign(Button _btn)
        {
            InitializeComponent();

            btn = _btn;

            buttonObrazec.Text = btn.Text;
            buttonObrazec.Font = btn.Font;
            buttonObrazec.BackColor = btn.BackColor;
            buttonObrazec.ForeColor = btn.ForeColor;
            buttonObrazec.Size = btn.Size;


            Button_Coordinates.Text = btn.Location.X.ToString() + ", " + btn.Location.Y.ToString();
            Button_Size.Text = btn.Size.Width.ToString() + ", " + btn.Size.Height.ToString();

        }

        private void UniqueFormDesign_Load(object sender, EventArgs e)
        {

        }

        //шрифт и цвет шрифта кнопки
        private void ButtonFontButton_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = buttonObrazec.Font;
            fontDialog1.Color = buttonObrazec.ForeColor;

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                buttonObrazec.Font = fontDialog1.Font;
                buttonObrazec.ForeColor = fontDialog1.Color;

                UniqueFormDesign_Load(null, null);


                SQLClass.Update("DELETE FROM uniqueform WHERE Type = '" + buttonObrazec.GetType() + "' AND Name =  '" + btn.Name + "' AND Form = '" + btn.FindForm().Name + "' AND Parameter = 'Font'");
                SQLClass.Update("DELETE FROM uniqueform WHERE Type = '" + buttonObrazec.GetType() + "' AND Name =  '" + btn.Name + "' AND Form = '" + btn.FindForm().Name + "' AND Parameter = 'Font_Color'");

                SQLClass.Update("INSERT INTO uniqueform (Type, Name, Form, Parameter, Value) VALUES ('" + buttonObrazec.GetType() + "', '" + btn.Name + "', '" + btn.FindForm().Name + "', 'Font', '" + buttonObrazec.Font.Name + ";" + buttonObrazec.Font.Size.ToString() + "')");
                SQLClass.Update("INSERT INTO uniqueform (Type, Name, Form, Parameter, Value) VALUES ('" + buttonObrazec.GetType() + "', '" + btn.Name + "', '" + btn.FindForm().Name + "', 'Font_Color', '" + buttonObrazec.ForeColor.ToArgb() + "')");
            }
        }

        //цвет кнопки
        private void ButtonColorButton_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = buttonObrazec.BackColor;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {

                buttonObrazec.BackColor = colorDialog1.Color;

                UniqueFormDesign_Load(null, null);

                SQLClass.Update("DELETE FROM uniqueform WHERE Type = '" + buttonObrazec.GetType() + "' AND Name =  '" + btn.Name + "' AND Form = '" + btn.FindForm().Name + "' AND Parameter = 'COLOR'");
                SQLClass.Update("INSERT INTO uniqueform (Type, Name, Form, Parameter, Value) VALUES ('" + buttonObrazec.GetType() + "', '" + btn.Name + "', '" + btn.FindForm().Name + "', 'COLOR', '" + buttonObrazec.BackColor.ToArgb() + "')");

            }


        }

        private void SaveCoordsAndSizeButton_Click(object sender, EventArgs e)
        {
            SQLClass.Update("DELETE FROM uniqueform WHERE Type  = '" + buttonObrazec.GetType() + "' AND Name =  '" + btn.Name + "' AND Form = '" + btn.FindForm().Name + "' AND Parameter = 'LOCATION'");
            SQLClass.Update("DELETE FROM uniqueform WHERE Type  = '" + buttonObrazec.GetType() + "' AND Name =  '" + btn.Name + "' AND Form = '" + btn.FindForm().Name + "' AND Parameter = 'SIZE'");

            SQLClass.Update("INSERT INTO uniqueform (Type, Name, Form, Parameter, Value) VALUES ('" + buttonObrazec.GetType() + "', '" + btn.Name + "', '" + btn.FindForm().Name + "', 'LOCATION', '" + Button_Coordinates.Text + "')");
            SQLClass.Update("INSERT INTO uniqueform (Type, Name, Form, Parameter, Value) VALUES ('" + buttonObrazec.GetType() + "', '" + btn.Name + "', '" + btn.FindForm().Name + "',   'SIZE',   '" + Button_Size.Text + "')");
        }
    }
}
