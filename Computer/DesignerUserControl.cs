using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer
{
    public partial class DesignerUserControl : UserControl
    {
        public static ContextMenuStrip Button_ContextMenu;

        #region textbox
        public static Font Textbox_Font;
        public static Color Textbox_Font_Color;
        #endregion

        #region button
        public static Font Button_Font;
        public static Color Button_Font_Color;
        public static Color Button_Color;
        #endregion

        #region label
        public static Font Label_Font;
        public static Color Label_Font_Color;
        #endregion

        #region panel
        public static Color Panel_Color;
        #endregion

       
        public DesignerUserControl()
        {
            InitializeComponent();

        }

        private void DesignerUserControl_Load(object sender, EventArgs e)
        {
            textBox1.Font = Textbox_Font;
            textBox1.ForeColor = Textbox_Font_Color;
            buttonObrazec.Font = Button_Font;
            buttonObrazec.ForeColor = Button_Font_Color;
            buttonObrazec.BackColor = Button_Color;
            label3.Font = Label_Font;
            label3.ForeColor = Label_Font_Color;
            panel1.BackColor = Panel_Color;

        }

        public static void ReadDefaultDesign()
        {

            #region Buttons Reading
            ///чтение цвета кнопки
            try
            {
                string color = SQLClass.Select("SELECT Value FROM defaultdesign WHERE Type = 'System.Windows.Forms.Button' AND Parameter = 'COLOR'")[0];
                Button_Color = Color.FromArgb(Convert.ToInt32(color));
            }
            catch (Exception) { }

            /// чтение типа и цвета шрифта кнопки
            try
            {
                string color = SQLClass.Select("SELECT Value FROM defaultdesign WHERE Type = 'System.Windows.Forms.Button' AND Parameter = 'Font_Color'")[0];
                Button_Font_Color = Color.FromArgb(Convert.ToInt32(color));

                string font = SQLClass.Select("SELECT Value FROM defaultdesign WHERE Type = 'System.Windows.Forms.Button' AND Parameter = 'Font'")[0];
                string[] parts = font.Split(new char[] { ';' });
                Button_Font = new Font(new FontFamily(parts[0]), (float)Convert.ToDouble(parts[1]));

            }
            catch (Exception) { }

            #endregion

            #region Panel Reading
            ///чтение цвета панели
            try
            {
                string color = SQLClass.Select("SELECT Value FROM defaultdesign WHERE Type = 'System.Windows.Forms.Panel' AND Parameter = 'COLOR'")[0];
                Panel_Color = Color.FromArgb(Convert.ToInt32(color));
            }
            catch (Exception) { }
            #endregion

            #region Label Reading

            ///чтение цвета лейбла
            try
            {
                string color = SQLClass.Select("SELECT Value FROM defaultdesign WHERE Type = 'System.Windows.Forms.Label' AND Parameter = 'COLOR'")[0];
                Label_Font_Color = Color.FromArgb(Convert.ToInt32(color));
            }
            catch (Exception) { }

            /// чтение тип шрифта лейбла
            try
            {
                string font = SQLClass.Select("SELECT Value FROM defaultdesign WHERE Type = 'System.Windows.Forms.Label' AND Parameter = 'Font'")[0];
                string[] parts = font.Split(new char[] { ';' });
                Label_Font = new Font(new FontFamily(parts[0]), (float)Convert.ToDouble(parts[1]));
            }
            catch (Exception) { }

            #endregion

            #region TextBox Reading
            ///чтение цвета шрифта текстбокса
            try
            {
                string color = SQLClass.Select("SELECT Value FROM defaultdesign WHERE Type = 'System.Windows.Forms.TextBox' AND Parameter = 'COLOR'")[0];
                Textbox_Font_Color = Color.FromArgb(Convert.ToInt32(color));
            }
            catch (Exception) { }
            ///чтение типа шрифта текстбокса
            try
            {
                string font = SQLClass.Select("SELECT Value FROM defaultdesign WHERE Type = 'System.Windows.Forms.TextBox' AND Parameter = 'Font'")[0];
                string[] parts = font.Split(new char[] { ';' });
                Textbox_Font = new Font(new FontFamily(parts[0]), (float)Convert.ToDouble(parts[1]));
            }
            catch (Exception) { }
            #endregion
        }

        public static void ReadUniqueDesignButton(Button btn)
        {
            #region Buttons Reading
           //чтение цвета кнопки
            try
            {
                string color = SQLClass.Select("SELECT Value FROM uniqueform WHERE Type = 'System.Windows.Forms.Button' AND Name = '" + btn.Name + "' AND Form = '" + btn.FindForm().Name + "' AND Parameter = 'COLOR'")[0];
                btn.BackColor = Color.FromArgb(Convert.ToInt32(color));
            }
            catch (Exception) { }

          //чтение цвета шрифта и шрифта кнопки
            try
            {
                string color = SQLClass.Select("SELECT Value FROM uniqueform WHERE Type = 'System.Windows.Forms.Button' AND Name = '" + btn.Name + "' AND Form = '" + btn.FindForm().Name + "' AND Parameter = 'Font_Color'")[0];
                btn.ForeColor = Color.FromArgb(Convert.ToInt32(color));

                string font = SQLClass.Select("SELECT Value FROM uniqueform WHERE Type = 'System.Windows.Forms.Button' AND Name = '" + btn.Name + "' AND Form = '" + btn.FindForm().Name +  "' AND Parameter = 'Font'")[0];
                string[] parts = font.Split(new char[] { ';' });
                btn.Font = new Font(new FontFamily(parts[0]), (float)Convert.ToDouble(parts[1]));

            }   
            catch (Exception) { }

            //Чтение координат кнопки
            try
            {
                string Location = SQLClass.Select("SELECT Value FROM uniqueform WHERE Type = 'System.Windows.Forms.Button' AND Name = '" + btn.Name + "' AND Form = '" + btn.FindForm().Name + "' AND Parameter = 'LOCATION'")[0];
                string[] parts = Location.Split(new char[] { ',' });
                btn.Location = new Point(Convert.ToInt32(parts[0]), Convert.ToInt32(parts[1]));
            }
            catch (Exception) { }

            //чтение размера кнопки
            try
            {
                string Size = SQLClass.Select("SELECT Value FROM uniqueform WHERE Type = 'System.Windows.Forms.Button' AND Name = '" + btn.Name + "' AND Form = '" + btn.FindForm().Name + "' AND Parameter = 'SIZE'")[0];
                string[] parts = Size.Split(new char[] { ',' });
                btn.Size = new Size(Convert.ToInt32(parts[0]), Convert.ToInt32(parts[1]));
            }
            catch (Exception) { }


            #endregion
        }



        public static void ApplyChanges(Control Form)
        {
            foreach (Control ctrl in Form.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Font = Textbox_Font;
                    ctrl.ForeColor = Textbox_Font_Color;
                }
                else
                {
                    ApplyChanges(ctrl);
                }

                if (ctrl is Button)
                {
                    ctrl.Font = Button_Font;
                    ctrl.ForeColor = Button_Font_Color;
                    ctrl.BackColor = Button_Color;
                    ReadUniqueDesignButton(ctrl as Button);
                }
                else
                {
                    ApplyChanges(ctrl);
                }

                if (ctrl is Label)
                {
                    ctrl.Font = Label_Font;
                    ctrl.ForeColor = Label_Font_Color;
                }
                else
                {
                    ApplyChanges(ctrl);
                }

                if (ctrl is Panel)
                {
                    ctrl.BackColor = Panel_Color;
                }
                else
                {
                    ApplyChanges(ctrl);
                }
            }
        }

        public static void ApplyMenu(Control Form)
        {
            foreach (Control ctrl in Form.Controls)
            {
                
                if (ctrl is Button && MainForm.isAdmin)
                {
                    ctrl.ContextMenuStrip  = Button_ContextMenu;
                   
                }
                else
                {
                    ApplyMenu(ctrl);
                }

            }
        }


        //шрифт текст бокса и его цвет
        private void ButtonTextBoxFont_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = Textbox_Font;
            fontDialog1.Color = Textbox_Font_Color;

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                Textbox_Font = fontDialog1.Font;
                Textbox_Font_Color = fontDialog1.Color;

                DesignerUserControl_Load(null, null);

                SQLClass.Update("DELETE FROM defaultdesign WHERE Type = '" + textBox1.GetType() + "' AND Parameter = 'Font'");
                SQLClass.Update("DELETE FROM defaultdesign WHERE Type = '" + textBox1.GetType() + "' AND Parameter = 'Font_Color'");

                SQLClass.Update("INSERT INTO defaultdesign (Type, Parameter, Value) VALUES ('" + textBox1.GetType() + "', 'Font', '" + Textbox_Font.Name + ";" + Textbox_Font.Size.ToString() + "')");
                SQLClass.Update("INSERT INTO defaultdesign (Type, Parameter, Value) VALUES ('" + textBox1.GetType() + "', 'Font_Color', '" + Textbox_Font_Color.ToArgb() + "')");
            }
        }

        //шрифт и цвет шрифта кнопки
        private void ButtonFontButton_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = Button_Font;
            fontDialog1.Color = Button_Font_Color;

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                Button_Font = fontDialog1.Font;
                Button_Font_Color = fontDialog1.Color;

                DesignerUserControl_Load(null, null);


                SQLClass.Update("DELETE FROM defaultdesign WHERE Type = '" + buttonObrazec.GetType() + "' AND Parameter = 'Font'");
                SQLClass.Update("DELETE FROM defaultdesign WHERE Type = '" + buttonObrazec.GetType() + "' AND Parameter = 'Font_Color'");

                SQLClass.Update("INSERT INTO defaultdesign (Type, Parameter, Value) VALUES ('" + buttonObrazec.GetType() + "', 'Font', '" + Button_Font.Name + ";" + Button_Font.Size.ToString() + "')");
                SQLClass.Update("INSERT INTO defaultdesign (Type, Parameter, Value) VALUES ('" + buttonObrazec.GetType() + "', 'Font_Color', '" + Button_Font_Color.ToArgb() + "')");
            }
        }

        //цвет кнопки
        private void ButtonColorButton_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = Button_Color;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {

                Button_Color = colorDialog1.Color;

                DesignerUserControl_Load(null, null);

                SQLClass.Update("DELETE FROM defaultdesign WHERE Type = '" + buttonObrazec.GetType() + "' AND Parameter = 'COLOR'");

                SQLClass.Update("INSERT INTO defaultdesign (Type, Parameter, Value) VALUES ('" + buttonObrazec.GetType() + "', 'COLOR', '" + Button_Color.ToArgb() + "')");
            }
        }

        //шрифт и цвета лейбла
        private void LabelFontButton_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = Label_Font;
            fontDialog1.Color = Label_Font_Color;

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                Label_Font = fontDialog1.Font;
                Label_Font_Color = fontDialog1.Color;

                DesignerUserControl_Load(null, null);

                SQLClass.Update("DELETE FROM defaultdesign WHERE Type = '" + label3.GetType() + "' AND Parameter = 'COLOR'");
                SQLClass.Update("INSERT INTO defaultdesign (Type, Parameter, Value) VALUES ('" + label3.GetType() + "', 'COLOR', '" + Label_Font_Color.ToArgb() + "')");

                SQLClass.Update("DELETE FROM defaultdesign WHERE Type = '" + label3.GetType() + "' AND Parameter = 'Font'");
                SQLClass.Update("INSERT INTO defaultdesign (Type, Parameter, Value) VALUES ('" + label3.GetType() + "', 'Font', '" + Label_Font.Name + ";" + Label_Font.Size.ToString() + "')");



            }
        }

        //цвет панели
        private void ButtonPanelColor_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = Panel_Color;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Panel_Color = colorDialog1.Color;

                DesignerUserControl_Load(null, null);


                SQLClass.Update("DELETE FROM defaultdesign WHERE Type = '" + panel1.GetType() + "' AND Parameter = 'COLOR'");

                SQLClass.Update("INSERT INTO defaultdesign (Type, Parameter, Value) VALUES ('" + panel1.GetType() + "', 'COLOR', '" + Panel_Color.ToArgb() + "')");

            }

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void buttonObrazec_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }
    }
}

