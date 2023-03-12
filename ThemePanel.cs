using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class ThemePanel : UserControl
    {
       
        public static ThemePanel instance;
        public ThemePanel()
        {
            InitializeComponent();
            instance = this;
        }

        private void ThemePanel_Load(object sender, EventArgs e)
        {
            ThemeCombo.SelectedItem = Properties.Settings.Default.ComboItem;
            LcdCombo.SelectedItem = Properties.Settings.Default.LCDcomboitem;
            label5.Text = Properties.Settings.Default.fontsizeMem.ToString();
            CalcLCDTest.Font = new Font(Properties.Settings.Default.fontnames, Properties.Settings.Default.fontsizeMem);
            
            if (label5.Text == 42.ToString())
            {
                guna2Button1.Enabled = false;
            }
            if (label5.Text == 2.ToString())
            {
                DecreaseFontBtn.Enabled = false;
            }
            else
            {
                guna2Button1.Enabled = true;
                DecreaseFontBtn.Enabled = true;
            }


        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
                  
        {
            Properties.Settings.Default.FillClr = Settings.instance.BackColor;
            // CalcuForm calcuForm = new CalcuForm();
            switch (ThemeCombo.SelectedItem)
            {

                case "Red":
                    this.BackColor = Color.FromArgb(158, 0, 0);
                    Properties.Settings.Default.ComboItem = ThemeCombo.SelectedItem.ToString();
                    Properties.Settings.Default.BackClr = this.BackColor;
                    Properties.Settings.Default.PanelColor = Properties.Settings.Default.BackClr;
                    CalcuForm.instance.BackColor = this.BackColor;
                    Settings.instance.BackColor = Color.DarkRed;
                    Properties.Settings.Default.FillClr = Settings.instance.BackColor;
                    Properties.Settings.Default.Save();
                    break;

                case "Blue":
                    this.BackColor = Color.FromArgb(0, 30, 99);
                    Properties.Settings.Default.ComboItem = ThemeCombo.SelectedItem.ToString();
                    Properties.Settings.Default.BackClr = this.BackColor;
                    Properties.Settings.Default.PanelColor = Properties.Settings.Default.BackClr;
                    CalcuForm.instance.BackColor = this.BackColor;
                    Settings.instance.BackColor = Color.DarkBlue;
                    Properties.Settings.Default.FillClr = Settings.instance.BackColor;
                    Properties.Settings.Default.Save();
                    break;

                case "Green":
                    this.BackColor = Color.FromArgb(0, 99, 5);
                    Properties.Settings.Default.ComboItem = ThemeCombo.SelectedItem.ToString();
                    Properties.Settings.Default.BackClr = this.BackColor;
                    Properties.Settings.Default.PanelColor = Properties.Settings.Default.BackClr;
                    CalcuForm.instance.BackColor = this.BackColor;
                    Settings.instance.BackColor = Color.FromArgb(3, 128, 23);
                    Properties.Settings.Default.FillClr = Settings.instance.BackColor;
                    Properties.Settings.Default.Save();
                    break;
                case "Orange":
                    this.BackColor = Color.FromArgb(171, 112, 3);
                    Properties.Settings.Default.ComboItem = ThemeCombo.SelectedItem.ToString();
                    Properties.Settings.Default.BackClr = this.BackColor;
                    Properties.Settings.Default.PanelColor = Properties.Settings.Default.BackClr;
                    CalcuForm.instance.BackColor = this.BackColor;
                    Settings.instance.BackColor = Color.DarkOrange;
                    Properties.Settings.Default.FillClr = Settings.instance.BackColor;
                    Properties.Settings.Default.Save();
                    break;
                case "Pink":
                    this.BackColor = Color.FromArgb(168, 49, 121);
                    Properties.Settings.Default.ComboItem = ThemeCombo.SelectedItem.ToString();
                    Properties.Settings.Default.BackClr = this.BackColor;
                    Properties.Settings.Default.PanelColor = Properties.Settings.Default.BackClr;
                    CalcuForm.instance.BackColor = this.BackColor;
                    Settings.instance.BackColor = Color.FromArgb(191, 44, 152);
                    Properties.Settings.Default.FillClr = Settings.instance.BackColor;
                    Properties.Settings.Default.Save();
                    break;
                case "White":
                    this.BackColor = Color.FromArgb(184, 184, 184);
                    Properties.Settings.Default.ComboItem = ThemeCombo.SelectedItem.ToString();
                    Properties.Settings.Default.BackClr = this.BackColor;
                    Properties.Settings.Default.PanelColor = Properties.Settings.Default.BackClr;
                    CalcuForm.instance.BackColor = this.BackColor;
                    Settings.instance.BackColor = Color.FromArgb(163, 163, 163);
                    Properties.Settings.Default.FillClr = Settings.instance.BackColor;
                    Properties.Settings.Default.Save();
                    break;
                case "Black":
                    this.BackColor = Color.FromArgb(28, 28, 28);
                    Properties.Settings.Default.ComboItem = ThemeCombo.SelectedItem.ToString();
                    Properties.Settings.Default.BackClr = this.BackColor;
                    Properties.Settings.Default.PanelColor = Properties.Settings.Default.BackClr;
                    CalcuForm.instance.BackColor = this.BackColor;
                    Settings.instance.BackColor = Color.FromArgb(43, 43, 43);
                    Properties.Settings.Default.FillClr = Settings.instance.BackColor;
                    Properties.Settings.Default.Save();
                    break;
                case "Set default":
                    this.BackColor = Color.FromArgb(60, 60, 60);
                    Properties.Settings.Default.ComboItem = ThemeCombo.SelectedItem.ToString();
                    Properties.Settings.Default.BackClr = Color.FromArgb(64, 64, 64);
                    Properties.Settings.Default.PanelColor = Properties.Settings.Default.BackClr;
                    CalcuForm.instance.BackColor = Color.FromArgb(64,64,64);
                    Settings.instance.BackColor = Color.FromArgb(64, 64, 64);
                    Properties.Settings.Default.FillClr = Settings.instance.BackColor;
                    Properties.Settings.Default.Save();
                    break;


            }




        }

        private void LcdCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (LcdCombo.SelectedItem)
            {
                case "Red":
                    Properties.Settings.Default.LCDcomboitem = LcdCombo.SelectedItem.ToString();
                    CalcuForm.instance.ChangeLCDcolor(Color.Red);
                    Properties.Settings.Default.Save();
                    CalcLCDTest.ForeColor = Properties.Settings.Default.LCDcolor;
                    break;

                case "Blue":
                    Properties.Settings.Default.LCDcomboitem = LcdCombo.SelectedItem.ToString();
                    CalcuForm.instance.ChangeLCDcolor(Color.FromArgb(0, 179, 255));
                    Properties.Settings.Default.Save();
                    CalcLCDTest.ForeColor = Properties.Settings.Default.LCDcolor;
                    break;

                case "Green":
                    Properties.Settings.Default.LCDcomboitem = LcdCombo.SelectedItem.ToString();
                    CalcuForm.instance.ChangeLCDcolor(Color.FromArgb(9, 255, 0));
                    Properties.Settings.Default.Save();
                    CalcLCDTest.ForeColor = Properties.Settings.Default.LCDcolor;
                    break;
                case "Orange":
                    Properties.Settings.Default.LCDcomboitem = LcdCombo.SelectedItem.ToString();
                    CalcuForm.instance.ChangeLCDcolor(Color.FromArgb(255, 174, 0));
                    Properties.Settings.Default.Save();
                    CalcLCDTest.ForeColor = Properties.Settings.Default.LCDcolor;
                    break;
                case "Pink":
                    Properties.Settings.Default.LCDcomboitem = LcdCombo.SelectedItem.ToString();
                    CalcuForm.instance.ChangeLCDcolor(Color.FromArgb(250, 52, 240));
                    Properties.Settings.Default.Save();
                    CalcLCDTest.ForeColor = Properties.Settings.Default.LCDcolor;
                    break;
                case "Set default":
                    Properties.Settings.Default.LCDcomboitem = LcdCombo.SelectedItem.ToString();
                    CalcuForm.instance.ChangeLCDcolor(Color.FromArgb(255, 255, 255));
                    Properties.Settings.Default.Save();
                    CalcLCDTest.ForeColor = Properties.Settings.Default.LCDcolor;
                    break;
            }
          


        }

        private void CalcLCDTest_TextChanged(object sender, EventArgs e)
        {

        }

        public void guna2Button1_Click(object sender, EventArgs e)
        {
            float fontsize = 2;
            CalcLCDTest.Font = new Font(CalcLCDTest.Font.Name,CalcLCDTest.Font.Size+fontsize); // 38 + 2

            
            CalcuForm.instance.ChangeLCDfontSize(2); // + 2

            float counter = CalcLCDTest.Font.Size;
            label5.Text = CalcLCDTest.Font.Size.ToString();


            Properties.Settings.Default.fontsizeMem = CalcLCDTest.Font.Size;
            Properties.Settings.Default.Save();

            if (counter == 42)
            {
     
          
                guna2Button1.Enabled = false ; // 38 + 2
            }
            else if (counter != 2)
            {
                DecreaseFontBtn.Enabled = true;
            }
           

        }

        public void DecreaseFontBtn_Click(object sender, EventArgs e)
        {
            float fontsize = 2;
            CalcLCDTest.Font = new Font(CalcLCDTest.Font.Name, CalcLCDTest.Font.Size - fontsize); // 38 + 2


            CalcuForm.instance.ChangeLCDfontSize(-2); // + 2

            float counter = CalcLCDTest.Font.Size;
            label5.Text = CalcLCDTest.Font.Size.ToString();

            Properties.Settings.Default.fontsizeMem = CalcLCDTest.Font.Size;
            Properties.Settings.Default.Save();
    
            if (counter == 2)
            {
                
                
                DecreaseFontBtn.Enabled = false; // 38 + 2
            }
            else if (counter != 42)
            {
                guna2Button1.Enabled = true;
            }



        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void SetDefaultFont_Click(object sender, EventArgs e)
        {
            CalcuForm.instance.ChangeLCDfontName("DS-Digital");

            Properties.Settings.Default.fontnames = "DS-Digital";
            CalcLCDTest.Font = new Font("DS-Digital", 38);
            Properties.Settings.Default.fontsizeMem = 38;
            Properties.Settings.Default.Save();
            label5.Text = Properties.Settings.Default.fontsizeMem.ToString();
            guna2Button1.Enabled = true;
            DecreaseFontBtn.Enabled = true;
            CalcuForm.instance.MemoryMainLCDFont(38);

        }
    }
}
