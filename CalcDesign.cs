using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;


namespace Calc
{
    
    public partial class CalcuForm : Form
    {

        public static CalcuForm instance;
        public CalcuForm()
        {
            
            InitializeComponent();
            instance = this;
        }
        public static double Evaluate(string expression)
        {
            System.Data.DataTable table = new System.Data.DataTable();
            table.Columns.Add("expression", string.Empty.GetType(), expression);
            System.Data.DataRow row = table.NewRow();
            table.Rows.Add(row);
            return double.Parse((string)row["expression"]);
        }
        public void CalcuForm_Load(object sender, EventArgs e)
        {

            CalcLCD.Font = new Font(Properties.Settings.Default.fontnames, Properties.Settings.Default.fontsizeMem);
            CalcLCD.ForeColor = Properties.Settings.Default.LCDcolor;
            this.BackColor = Properties.Settings.Default.BackClr;
        }
 
        public void ChangeLCDcolor(Color VarColor)
        {
            Properties.Settings.Default.LCDcolor = VarColor; //red
            CalcLCD.ForeColor = Properties.Settings.Default.LCDcolor;
    
            
        }
        public void ChangeLCDfontSize(float Num) 
        {

            CalcLCD.Font = new Font(CalcLCD.Font.Name,CalcLCD.Font.Size + Num);

           // basicSize = CalcLCD.Font.Size; // 38

        }

        public void MemoryMainLCDFont(float Num)
        {

            CalcLCD.Font = new Font(CalcLCD.Font.Name,Num);

            // basicSize = CalcLCD.Font.Size; // 38




        }
        public void ChangeLCDfontName(string fontName)
        {

            CalcLCD.Font = new Font(fontName, CalcLCD.Font.Size);

            // basicSize = CalcLCD.Font.Size; // 38




        }



        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void WindStatBtn_Click(object sender, EventArgs e)
            
        {
            try
            {
                switch (WindStatBtn.Checked)
                {
                    case true:
                        this.WindowState = FormWindowState.Maximized;
                        Settings.instance.BringToFront();
                        break;

                    case false:
                        this.WindowState = FormWindowState.Normal;
                        Settings.instance.BringToFront();
                        break;
                }
            }
            catch
            {

            }

            
        }

        private void MiniBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void EqlBtn_Click(object sender, EventArgs e)
        {
           // HistoryPanel.instance.transferData(label1.Text, CalcLCD.Text);
            
            try
            {

                
                string LCD = CalcLCD.Text;
                var evaler = Convert.ToString(Evaluate(LCD));
                CalcLCD.Text = evaler.ToString();
                var formater = double.Parse(CalcLCD.Text) ;
              
               // CalcLCD.Text = formater.ToString("#,###,###");
                var khalas = (formater.ToString());
                CalcLCD.Text = khalas.ToString();
                Properties.Settings.Default.CalcResultsMem = CalcLCD.Text;
                Properties.Settings.Default.Save();

             
                





                //  var path = "words.txt";
                // StreamWriter sw = File.AppendText(path);

                // sw.WriteLine("------------");
                //sw.WriteLine(CalcLCD.Text);

            }
            catch 
            {
                Exception er = new Exception();
                CalcLCD.Text = "Error";
                Thread.Sleep(100);

               

            //    StreamWriter sw = File.AppendText("calc.txt");

              //  sw.WriteLine("------------");
               // sw.WriteLine("Error");


 

            }

        }

        public void CalcLCD_TextChanged(object sender, EventArgs e)
        {
            label1.Text = CalcLCD.Text;
            Properties.Settings.Default.CalcboxMem = label1.Text;
            Properties.Settings.Default.Save();
            if (CalcLCD.Text == "Error")
            {
                
                CalcLCD.Text = "";
            }

            var convert = (CalcLCD.Text);

            var calc = (CalcLCD.Text);

            label1.Text = CalcLCD.Text;

        }

        private void BtnOne_Click(object sender, EventArgs e)
        {
            CalcLCD.Text = CalcLCD.Text + "1" ;
        }

        private void BtnTwo_Click(object sender, EventArgs e)
        {
            CalcLCD.Text = CalcLCD.Text + "2";
        }

        private void BtnThree_Click(object sender, EventArgs e)
        {
            CalcLCD.Text = CalcLCD.Text + "3";
        }

        private void BtnFour_Click(object sender, EventArgs e)
        {
            CalcLCD.Text = CalcLCD.Text + "4";
        }

        private void Btnfive_Click(object sender, EventArgs e)
        {
            CalcLCD.Text = CalcLCD.Text + "5";
        }

        private void BtnSix_Click(object sender, EventArgs e)
        {
            CalcLCD.Text = CalcLCD.Text + "6";
        }

        private void BtnSeven_Click(object sender, EventArgs e)
        {
            CalcLCD.Text = CalcLCD.Text + "7";
        }

        private void BtnEight_Click(object sender, EventArgs e)
        {
            CalcLCD.Text = CalcLCD.Text + "8";
        }

        private void BtnNine_Click(object sender, EventArgs e)
        {
            CalcLCD.Text = CalcLCD.Text + "9";
        }
        private void ZeroBtn_Click(object sender, EventArgs e)
        {
            CalcLCD.Text = CalcLCD.Text + "0";
        }
        private void PointBtn_Click(object sender, EventArgs e)
        {
            CalcLCD.Text = CalcLCD.Text + ".";
        }
        //******************************************
        private void DivideBtn_Click(object sender, EventArgs e)
        {
            CalcLCD.Text = CalcLCD.Text + "/";
        }
        private void MultBtn_Click(object sender, EventArgs e)
        {
            CalcLCD.Text = CalcLCD.Text + "*";
        }
        private void PlusBtn_Click(object sender, EventArgs e)
        {
            CalcLCD.Text = CalcLCD.Text + "+";

        }

        private void MinusBtn_Click(object sender, EventArgs e)
        {
            CalcLCD.Text = CalcLCD.Text + "-";
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            CalcLCD.Text = "";
           
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {

            try
            {
                var text = CalcLCD.Text;
                CalcLCD.Text = text.Remove(text.Length - 1);
            }
            catch
            {
               
                
            }



        }


        private void CalcuForm_KeyDown(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.NumPad0 || e.KeyCode == Keys.D0)
            {
                ZeroBtn.PerformClick();
            }

            if (e.KeyCode == Keys.NumPad1 || e.KeyCode == Keys.D1)
            {
                BtnOne.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.D2)
            {
                BtnTwo.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad3 || e.KeyCode == Keys.D3)
            {
                BtnThree.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad4 || e.KeyCode == Keys.D4)
            {
                BtnFour.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad5 || e.KeyCode == Keys.D5)
            {
                Btnfive.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad6 || e.KeyCode == Keys.D6)
            {
                BtnSix.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad7 || e.KeyCode == Keys.D7)
            {
                BtnSeven.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad8 || e.KeyCode == Keys.D8)
            {
                BtnEight.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad9 || e.KeyCode == Keys.D9)
            {
                BtnNine.PerformClick();
            }
            //////////////////////////////
            if (e.KeyCode == Keys.Add)
            {
                PlusBtn.PerformClick();
            }
            if (e.KeyCode == Keys.Subtract)
            {
                MinusBtn.PerformClick();
            }
            if (e.KeyCode == Keys.Multiply)
            {
                MultBtn.PerformClick();
            }
            if (e.KeyCode == Keys.Divide)
            {
                DivideBtn.PerformClick();
            }
            ////////////////
            if (e.KeyCode == Keys.Delete) 
            {
                ClearBtn.PerformClick();
            }
            if (e.KeyCode == Keys.Back)
            {
                DeleteBtn.PerformClick();
            }    



        }

        private void CalcuForm_KeyPress(object sender, KeyPressEventArgs e)
        {

            EqlBtn.Focus(); 
            switch (e.KeyChar.ToString())
            {

                case " ":
                EqlBtn.PerformClick();
                break;

                case "\r":
                    EqlBtn.PerformClick();
                    break;
            }
            switch (e.KeyChar.ToString())
            {
                case ".":
                    PointBtn.PerformClick();
                    break;
            }
        }

        private void guna2Button18_Click(object sender, EventArgs e)
        {
            try
            {
                int Conv = int.Parse(CalcLCD.Text); // 2 

                var texts = Conv * Conv;

                CalcLCD.Text = texts.ToString();
            }
            catch
            {

            }


            
        }

        private void guna2Button17_Click(object sender, EventArgs e)
        {

        }

        private void AbsBtn_Click(object sender, EventArgs e)
        {
            try
            {

                var Abs = CalcLCD.Text;

                int conv = int.Parse(Abs);
                var Last = Math.Abs(conv);
                CalcLCD.Text = Last.ToString();

            }
            catch
            {
                
            }

        }

        private void Sqrt_Click(object sender, EventArgs e)
        {
            try
            {
                var text = CalcLCD.Text;

                double conv = double.Parse(text);

                var all = Math.Pow(conv, 0.5); //////////////Math.Sqrt(conv);
                                               //9 - 9 + 2
                CalcLCD.Text = all.ToString();
            }
            catch
            { 
            }

        }

        private void Cbrt_Click(object sender, EventArgs e)
        {
            try
            {
                var text = CalcLCD.Text;

                double conv = double.Parse(text);



                var all = Math.Pow(conv, (double)1 / 3);

                CalcLCD.Text = all.ToString();

            }
            catch
            {

            }

        }

        public void MemoryShowOrClear_Click(object sender, EventArgs e)
        {
           
                double save = Properties.Settings.Default.Memorys;
                CalcLCD.Text = Properties.Settings.Default.Memorys.ToString();
                Properties.Settings.Default.Save();


       
        }

        public void memoryAdd_Click(object sender, EventArgs e)
        {
            try
            {
                double memAdd = double.Parse(CalcLCD.Text); //9

                double DataAdd = Properties.Settings.Default.Memorys;
                //9         //  8
                double addtomem = (DataAdd + memAdd);

                double full = (addtomem);
                Properties.Settings.Default.Memorys = full;
            }
            catch
            {

            }

            

        }

        public void Memoryminus_Click(object sender, EventArgs e)
        {
            try
            {
                double memMin = double.Parse(CalcLCD.Text); //9

                double DataMin = Properties.Settings.Default.Memorys;
                //9         //  8
                double SubFrommem = (DataMin - memMin);

                double full = (SubFrommem);
                Properties.Settings.Default.Memorys = full;
            }
            catch
            {

            }

        }

        private void PieBtn(object sender, EventArgs e)
        {
            try
            {
                var pie = CalcLCD.Text;

                double convert = double.Parse(pie);

                double calc = convert * 22 / 7;

                CalcLCD.Text = calc.ToString();
            }
            catch
            {

            }

        }

        private void MemoryShowOrClear_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Properties.Settings.Default.Memorys = 0;
        }

        private void SettingBtn_Click(object sender, EventArgs e)
        {
            Settings SettingsForm = new Settings();
            SettingsForm.Show();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ModulusBtn_Click(object sender, EventArgs e)
        {
            var LCD = CalcLCD.Text;
            var evaler = Convert.ToString(Evaluate(LCD));
            double finish = double.Parse(evaler) / 100;
            CalcLCD.Text = finish.ToString();
        }
    }
}
