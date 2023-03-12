namespace Calc
{
    partial class Settings
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.LeftPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.AboutBtn = new Guna.UI2.WinForms.Guna2Button();
            this.HelpBtn = new Guna.UI2.WinForms.Guna2Button();
            this.HistoryBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ThemeBtn = new Guna.UI2.WinForms.Guna2Button();
            this.MainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.CloseBtnSet = new Guna.UI2.WinForms.Guna2CircleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.LeftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 9;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.Transparent;
            this.LeftPanel.BorderRadius = 9;
            this.LeftPanel.Controls.Add(this.AboutBtn);
            this.LeftPanel.Controls.Add(this.HelpBtn);
            this.LeftPanel.Controls.Add(this.HistoryBtn);
            this.LeftPanel.Controls.Add(this.ThemeBtn);
            this.LeftPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.LeftPanel.Location = new System.Drawing.Point(12, 40);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(141, 398);
            this.LeftPanel.TabIndex = 0;
            // 
            // AboutBtn
            // 
            this.AboutBtn.Animated = true;
            this.AboutBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.AboutBtn.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.AboutBtn.CustomBorderThickness = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.AboutBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AboutBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AboutBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AboutBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AboutBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.AboutBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.AboutBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutBtn.ForeColor = System.Drawing.Color.White;
            this.AboutBtn.Image = global::Calc.Properties.Resources.icons8_info_50;
            this.AboutBtn.ImageOffset = new System.Drawing.Point(-1, 0);
            this.AboutBtn.Location = new System.Drawing.Point(0, 300);
            this.AboutBtn.Name = "AboutBtn";
            this.AboutBtn.Size = new System.Drawing.Size(141, 100);
            this.AboutBtn.TabIndex = 3;
            this.AboutBtn.Text = "About";
            this.AboutBtn.Click += new System.EventHandler(this.AboutBtn_Click);
            this.AboutBtn.MouseHover += new System.EventHandler(this.ThemeBtn_MouseHover);
            // 
            // HelpBtn
            // 
            this.HelpBtn.Animated = true;
            this.HelpBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.HelpBtn.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.HelpBtn.CustomBorderThickness = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.HelpBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.HelpBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.HelpBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.HelpBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.HelpBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.HelpBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.HelpBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpBtn.ForeColor = System.Drawing.Color.White;
            this.HelpBtn.Image = global::Calc.Properties.Resources.icons8_help_50;
            this.HelpBtn.ImageOffset = new System.Drawing.Point(-1, 0);
            this.HelpBtn.Location = new System.Drawing.Point(0, 200);
            this.HelpBtn.Name = "HelpBtn";
            this.HelpBtn.Size = new System.Drawing.Size(141, 100);
            this.HelpBtn.TabIndex = 2;
            this.HelpBtn.Text = "Help";
            this.HelpBtn.Click += new System.EventHandler(this.HelpBtn_Click);
            this.HelpBtn.MouseHover += new System.EventHandler(this.ThemeBtn_MouseHover);
            // 
            // HistoryBtn
            // 
            this.HistoryBtn.Animated = true;
            this.HistoryBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.HistoryBtn.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.HistoryBtn.CustomBorderThickness = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.HistoryBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.HistoryBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.HistoryBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.HistoryBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.HistoryBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.HistoryBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.HistoryBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HistoryBtn.ForeColor = System.Drawing.Color.White;
            this.HistoryBtn.Image = global::Calc.Properties.Resources.icons8_time_machine_100__1_;
            this.HistoryBtn.ImageOffset = new System.Drawing.Point(-1, 0);
            this.HistoryBtn.Location = new System.Drawing.Point(0, 100);
            this.HistoryBtn.Name = "HistoryBtn";
            this.HistoryBtn.Size = new System.Drawing.Size(141, 100);
            this.HistoryBtn.TabIndex = 1;
            this.HistoryBtn.Text = "History";
            this.HistoryBtn.Click += new System.EventHandler(this.HistoryBtn_Click);
            this.HistoryBtn.MouseHover += new System.EventHandler(this.ThemeBtn_MouseHover);
            // 
            // ThemeBtn
            // 
            this.ThemeBtn.Animated = true;
            this.ThemeBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.ThemeBtn.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ThemeBtn.CustomBorderThickness = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.ThemeBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ThemeBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ThemeBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ThemeBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ThemeBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ThemeBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ThemeBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThemeBtn.ForeColor = System.Drawing.Color.White;
            this.ThemeBtn.Image = global::Calc.Properties.Resources.icons8_paint_brush_50;
            this.ThemeBtn.ImageOffset = new System.Drawing.Point(-1, 0);
            this.ThemeBtn.Location = new System.Drawing.Point(0, 0);
            this.ThemeBtn.Name = "ThemeBtn";
            this.ThemeBtn.Size = new System.Drawing.Size(141, 100);
            this.ThemeBtn.TabIndex = 0;
            this.ThemeBtn.Text = "Themes";
            this.ThemeBtn.Click += new System.EventHandler(this.guna2Button1_Click);
            this.ThemeBtn.MouseHover += new System.EventHandler(this.ThemeBtn_MouseHover);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Transparent;
            this.MainPanel.BorderRadius = 9;
            this.MainPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.MainPanel.Location = new System.Drawing.Point(159, 40);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(361, 398);
            this.MainPanel.TabIndex = 0;
            // 
            // CloseBtnSet
            // 
            this.CloseBtnSet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBtnSet.Animated = true;
            this.CloseBtnSet.BackColor = System.Drawing.Color.Transparent;
            this.CloseBtnSet.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CloseBtnSet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CloseBtnSet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CloseBtnSet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CloseBtnSet.FillColor = System.Drawing.Color.Red;
            this.CloseBtnSet.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CloseBtnSet.ForeColor = System.Drawing.Color.White;
            this.CloseBtnSet.HoverState.FillColor = System.Drawing.Color.Firebrick;
            this.CloseBtnSet.Location = new System.Drawing.Point(500, 11);
            this.CloseBtnSet.Name = "CloseBtnSet";
            this.CloseBtnSet.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.CloseBtnSet.Size = new System.Drawing.Size(19, 17);
            this.CloseBtnSet.TabIndex = 2;
            this.CloseBtnSet.Click += new System.EventHandler(this.CloseBtnSet_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(220, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Settings";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(532, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CloseBtnSet);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.LeftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(532, 450);
            this.MinimumSize = new System.Drawing.Size(532, 450);
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.LeftPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2Panel LeftPanel;
        private Guna.UI2.WinForms.Guna2Button ThemeBtn;
        private Guna.UI2.WinForms.Guna2Panel MainPanel;
        private Guna.UI2.WinForms.Guna2CircleButton CloseBtnSet;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button AboutBtn;
        private Guna.UI2.WinForms.Guna2Button HelpBtn;
        private Guna.UI2.WinForms.Guna2Button HistoryBtn;
    }
}