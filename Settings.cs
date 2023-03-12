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
    public partial class Settings : Form
    {
        public static Settings instance;
        public Settings()
        {
            InitializeComponent();
            instance = this;
            
           
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            ThemeBtn.PerformClick();
            MainPanel.FillColor = Properties.Settings.Default.PanelColor; 
            ThemeBtn.FillColor = Properties.Settings.Default.PanelColor;
            AboutBtn.FillColor = Properties.Settings.Default.PanelColor;
            HelpBtn.FillColor = Properties.Settings.Default.PanelColor;
            HistoryBtn.FillColor = Properties.Settings.Default.PanelColor;
            ThemeBtn.CustomBorderColor = Properties.Settings.Default.FillClr;
            HelpBtn.CustomBorderColor = Properties.Settings.Default.FillClr;
            AboutBtn.CustomBorderColor = Properties.Settings.Default.FillClr;
            HistoryBtn.CustomBorderColor = Properties.Settings.Default.FillClr;
        }
        public void panelSwitch(Control e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(e);
        }
        private void CloseBtnSet_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // MainPanel.Controls.Clear();
            //   MainPanel.Controls.Add(new ThemePanel());
            panelSwitch(new ThemePanel());


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void HelpBtn_Click(object sender, EventArgs e)
        {
            panelSwitch(new HelpPanel());
        }

        private void AboutBtn_Click(object sender, EventArgs e)
        {
            panelSwitch(new AboutPanel());
        }

        private void ThemeBtn_MouseHover(object sender, EventArgs e)
        {
            ThemeBtn.FillColor = Properties.Settings.Default.PanelColor;
            HelpBtn.FillColor = Properties.Settings.Default.PanelColor;
            AboutBtn.FillColor = Properties.Settings.Default.PanelColor;
            HistoryBtn.FillColor = Properties.Settings.Default.PanelColor;

            ThemeBtn.CustomBorderColor = Properties.Settings.Default.FillClr;
            HelpBtn.CustomBorderColor = Properties.Settings.Default.FillClr;
            AboutBtn.CustomBorderColor = Properties.Settings.Default.FillClr;
            HistoryBtn.CustomBorderColor = Properties.Settings.Default.FillClr;
        }

        private void HistoryBtn_Click(object sender, EventArgs e)
        {
            panelSwitch(new HistoryPanel());
        }
    }
}
