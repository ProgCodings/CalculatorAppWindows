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
    public partial class HistoryPanel : UserControl
    {
        public static HistoryPanel instance;
        public HistoryPanel()
        {
            InitializeComponent();
            instance = this;
        }
        public string[] medo = { Properties.Settings.Default.CalcboxMem,Properties.Settings.Default.CalcResultsMem };
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void HistoryPanel_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            CalcuForm data = new CalcuForm();
           
            
        }
        public void transferData(string num1, string num2)
        {
            this.guna2DataGridView1.Rows.Add(num1,num2);
           // Properties.Settings.Default.DatagGrid = n(num1,num2); 

        }
    }
}
