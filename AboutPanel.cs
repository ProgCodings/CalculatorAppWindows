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
    public partial class AboutPanel : UserControl
    {
        public AboutPanel()
        {
            InitializeComponent();
        }


        private void AboutPanel_Load(object sender, EventArgs e)
        {
            this.BackColor = Properties.Settings.Default.PanelColor;
         
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Leave(object sender, EventArgs e)
        {
            
            
                axWindowsMediaPlayer1.URL = ("");
            

        }

        private void AboutPanel_Click(object sender, EventArgs e)
        {
            try
            {
                axWindowsMediaPlayer1.URL = ("M:\\C# learn\\Pro\\ProgCalc\\Calc\\Resources\\KitabAllah.mp3");
            }
            catch
            {

            }

      
        }

        private void AboutPanel_Leave(object sender, EventArgs e)
        {
            try
            {
                axWindowsMediaPlayer1.URL = ("");
            }
            catch
            {

            }
        
        }
    }
}
