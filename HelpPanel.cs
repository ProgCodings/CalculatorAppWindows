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
    public partial class HelpPanel : UserControl
    {
        public HelpPanel()
        {
            InitializeComponent();
        }

        private void HelpPanel_Load(object sender, EventArgs e)
        {
            
            this.AdjustFormScrollbars(true);
            this.BackColor = Properties.Settings.Default.PanelColor;
        }




        private void HelpPanel_Scroll(object sender, ScrollEventArgs e)
        {
       
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
