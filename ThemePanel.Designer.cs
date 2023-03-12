namespace Calc
{
    partial class ThemePanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ThemeCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LcdCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CalcLCDTest = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SetDefaultFont = new Guna.UI2.WinForms.Guna2Button();
            this.DecreaseFontBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // ThemeCombo
            // 
            this.ThemeCombo.BackColor = System.Drawing.Color.Transparent;
            this.ThemeCombo.BorderColor = System.Drawing.Color.DimGray;
            this.ThemeCombo.BorderRadius = 5;
            this.ThemeCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ThemeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ThemeCombo.FillColor = System.Drawing.Color.Gray;
            this.ThemeCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ThemeCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ThemeCombo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ThemeCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ThemeCombo.ItemHeight = 30;
            this.ThemeCombo.Items.AddRange(new object[] {
            "Red",
            "Blue",
            "Green",
            "Orange",
            "Pink",
            "White",
            "Black",
            "Set default"});
            this.ThemeCombo.ItemsAppearance.ForeColor = System.Drawing.Color.White;
            this.ThemeCombo.Location = new System.Drawing.Point(131, 36);
            this.ThemeCombo.Name = "ThemeCombo";
            this.ThemeCombo.Size = new System.Drawing.Size(210, 36);
            this.ThemeCombo.TabIndex = 0;
            this.ThemeCombo.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Theme Color";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LcdCombo
            // 
            this.LcdCombo.BackColor = System.Drawing.Color.Transparent;
            this.LcdCombo.BorderColor = System.Drawing.Color.DimGray;
            this.LcdCombo.BorderRadius = 5;
            this.LcdCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.LcdCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LcdCombo.FillColor = System.Drawing.Color.Gray;
            this.LcdCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LcdCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LcdCombo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.LcdCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LcdCombo.ItemHeight = 30;
            this.LcdCombo.Items.AddRange(new object[] {
            "Red",
            "Blue",
            "Green",
            "Orange",
            "Pink",
            "Set default"});
            this.LcdCombo.ItemsAppearance.ForeColor = System.Drawing.Color.White;
            this.LcdCombo.Location = new System.Drawing.Point(131, 106);
            this.LcdCombo.Name = "LcdCombo";
            this.LcdCombo.Size = new System.Drawing.Size(210, 36);
            this.LcdCombo.TabIndex = 0;
            this.LcdCombo.SelectedIndexChanged += new System.EventHandler(this.LcdCombo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "LCD Color";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CalcLCDTest
            // 
            this.CalcLCDTest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CalcLCDTest.BackColor = System.Drawing.Color.Transparent;
            this.CalcLCDTest.BorderRadius = 3;
            this.CalcLCDTest.BorderThickness = 0;
            this.CalcLCDTest.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CalcLCDTest.DefaultText = "2+2";
            this.CalcLCDTest.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CalcLCDTest.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CalcLCDTest.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CalcLCDTest.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CalcLCDTest.FillColor = System.Drawing.Color.Black;
            this.CalcLCDTest.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CalcLCDTest.Font = new System.Drawing.Font("DS-Digital", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcLCDTest.ForeColor = System.Drawing.Color.White;
            this.CalcLCDTest.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CalcLCDTest.Location = new System.Drawing.Point(21, 283);
            this.CalcLCDTest.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.CalcLCDTest.Name = "CalcLCDTest";
            this.CalcLCDTest.PasswordChar = '\0';
            this.CalcLCDTest.PlaceholderText = "";
            this.CalcLCDTest.SelectedText = "";
            this.CalcLCDTest.Size = new System.Drawing.Size(320, 47);
            this.CalcLCDTest.TabIndex = 2;
            this.CalcLCDTest.TextChanged += new System.EventHandler(this.CalcLCDTest_TextChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Cairo", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(146, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Example";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator1.FillColor = System.Drawing.Color.DarkGray;
            this.guna2Separator1.Location = new System.Drawing.Point(21, 329);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(320, 19);
            this.guna2Separator1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(16, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 33);
            this.label4.TabIndex = 1;
            this.label4.Text = "Font";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Cairo", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(116, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 27);
            this.label5.TabIndex = 5;
            this.label5.Text = "Font";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // SetDefaultFont
            // 
            this.SetDefaultFont.BackColor = System.Drawing.Color.Transparent;
            this.SetDefaultFont.BorderRadius = 3;
            this.SetDefaultFont.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SetDefaultFont.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SetDefaultFont.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SetDefaultFont.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SetDefaultFont.FillColor = System.Drawing.Color.Gray;
            this.SetDefaultFont.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SetDefaultFont.ForeColor = System.Drawing.Color.White;
            this.SetDefaultFont.ImageSize = new System.Drawing.Size(15, 15);
            this.SetDefaultFont.Location = new System.Drawing.Point(228, 175);
            this.SetDefaultFont.Name = "SetDefaultFont";
            this.SetDefaultFont.Size = new System.Drawing.Size(113, 23);
            this.SetDefaultFont.TabIndex = 4;
            this.SetDefaultFont.Text = "Set Default";
            this.SetDefaultFont.Click += new System.EventHandler(this.SetDefaultFont_Click);
            // 
            // DecreaseFontBtn
            // 
            this.DecreaseFontBtn.BackColor = System.Drawing.Color.Transparent;
            this.DecreaseFontBtn.BorderRadius = 3;
            this.DecreaseFontBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DecreaseFontBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DecreaseFontBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DecreaseFontBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DecreaseFontBtn.FillColor = System.Drawing.Color.Gray;
            this.DecreaseFontBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DecreaseFontBtn.ForeColor = System.Drawing.Color.White;
            this.DecreaseFontBtn.Image = global::Calc.Properties.Resources.icons8_subtract_60;
            this.DecreaseFontBtn.ImageSize = new System.Drawing.Size(15, 15);
            this.DecreaseFontBtn.Location = new System.Drawing.Point(199, 175);
            this.DecreaseFontBtn.Name = "DecreaseFontBtn";
            this.DecreaseFontBtn.Size = new System.Drawing.Size(23, 23);
            this.DecreaseFontBtn.TabIndex = 4;
            this.DecreaseFontBtn.Click += new System.EventHandler(this.DecreaseFontBtn_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 3;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.Black;
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Gray;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = global::Calc.Properties.Resources.icons8_plus_math_50__1_;
            this.guna2Button1.Location = new System.Drawing.Point(170, 175);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(23, 23);
            this.guna2Button1.TabIndex = 4;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // ThemePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SetDefaultFont);
            this.Controls.Add(this.DecreaseFontBtn);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.CalcLCDTest);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LcdCombo);
            this.Controls.Add(this.ThemeCombo);
            this.Name = "ThemePanel";
            this.Size = new System.Drawing.Size(361, 398);
            this.Load += new System.EventHandler(this.ThemePanel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox ThemeCombo;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox LcdCombo;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox CalcLCDTest;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button DecreaseFontBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button SetDefaultFont;
    }
}
