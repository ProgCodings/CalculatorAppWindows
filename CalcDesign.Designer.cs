namespace Calc
{
    partial class CalcuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalcuForm));
            this.CalcLCD = new Guna.UI2.WinForms.Guna2TextBox();
            this.CloseBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.WindStatBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.MiniBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.memoryAdd = new Guna.UI2.WinForms.Guna2Button();
            this.Memoryminus = new Guna.UI2.WinForms.Guna2Button();
            this.MemoryShowOrClear = new Guna.UI2.WinForms.Guna2Button();
            this.ClearBtn = new Guna.UI2.WinForms.Guna2Button();
            this.DeleteBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button16 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button17 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button18 = new Guna.UI2.WinForms.Guna2Button();
            this.DivideBtn = new Guna.UI2.WinForms.Guna2Button();
            this.Sqrt = new Guna.UI2.WinForms.Guna2Button();
            this.Cbrt = new Guna.UI2.WinForms.Guna2Button();
            this.BtnEight = new Guna.UI2.WinForms.Guna2Button();
            this.BtnNine = new Guna.UI2.WinForms.Guna2Button();
            this.BtnSeven = new Guna.UI2.WinForms.Guna2Button();
            this.MultBtn = new Guna.UI2.WinForms.Guna2Button();
            this.BtnSix = new Guna.UI2.WinForms.Guna2Button();
            this.BtnFour = new Guna.UI2.WinForms.Guna2Button();
            this.Btnfive = new Guna.UI2.WinForms.Guna2Button();
            this.MinusBtn = new Guna.UI2.WinForms.Guna2Button();
            this.PlusBtn = new Guna.UI2.WinForms.Guna2Button();
            this.BtnThree = new Guna.UI2.WinForms.Guna2Button();
            this.BtnTwo = new Guna.UI2.WinForms.Guna2Button();
            this.BtnOne = new Guna.UI2.WinForms.Guna2Button();
            this.EqlBtn = new Guna.UI2.WinForms.Guna2Button();
            this.PointBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ModulusBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ZeroBtn = new Guna.UI2.WinForms.Guna2Button();
            this.AbsBtn = new Guna.UI2.WinForms.Guna2Button();
            this.Animator = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.BorderForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SettingBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CalcLCD
            // 
            this.CalcLCD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CalcLCD.BackColor = System.Drawing.Color.Transparent;
            this.CalcLCD.BorderRadius = 6;
            this.CalcLCD.BorderThickness = 0;
            this.CalcLCD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CalcLCD.DefaultText = "";
            this.CalcLCD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CalcLCD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CalcLCD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CalcLCD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CalcLCD.FillColor = System.Drawing.Color.Black;
            this.CalcLCD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CalcLCD.Font = new System.Drawing.Font("DS-Digital", 38.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcLCD.ForeColor = System.Drawing.Color.White;
            this.CalcLCD.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CalcLCD.Location = new System.Drawing.Point(12, 48);
            this.CalcLCD.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.CalcLCD.Name = "CalcLCD";
            this.CalcLCD.PasswordChar = '\0';
            this.CalcLCD.PlaceholderText = "";
            this.CalcLCD.ReadOnly = true;
            this.CalcLCD.SelectedText = "";
            this.CalcLCD.Size = new System.Drawing.Size(382, 52);
            this.CalcLCD.TabIndex = 0;
            this.CalcLCD.TextChanged += new System.EventHandler(this.CalcLCD_TextChanged);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBtn.Animated = true;
            this.CloseBtn.BackColor = System.Drawing.Color.Transparent;
            this.CloseBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CloseBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CloseBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CloseBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CloseBtn.FillColor = System.Drawing.Color.Red;
            this.CloseBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CloseBtn.ForeColor = System.Drawing.Color.White;
            this.CloseBtn.HoverState.FillColor = System.Drawing.Color.Firebrick;
            this.CloseBtn.Location = new System.Drawing.Point(373, 14);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.CloseBtn.Size = new System.Drawing.Size(19, 17);
            this.CloseBtn.TabIndex = 1;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // WindStatBtn
            // 
            this.WindStatBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WindStatBtn.Animated = true;
            this.WindStatBtn.BackColor = System.Drawing.Color.Transparent;
            this.WindStatBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.WindStatBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(180)))), ((int)(((byte)(73)))));
            this.WindStatBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.WindStatBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.WindStatBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.WindStatBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.WindStatBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(180)))), ((int)(((byte)(73)))));
            this.WindStatBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.WindStatBtn.ForeColor = System.Drawing.Color.White;
            this.WindStatBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(123)))), ((int)(((byte)(51)))));
            this.WindStatBtn.Location = new System.Drawing.Point(345, 14);
            this.WindStatBtn.Name = "WindStatBtn";
            this.WindStatBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.WindStatBtn.Size = new System.Drawing.Size(19, 17);
            this.WindStatBtn.TabIndex = 1;
            this.WindStatBtn.Click += new System.EventHandler(this.WindStatBtn_Click);
            // 
            // MiniBtn
            // 
            this.MiniBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MiniBtn.Animated = true;
            this.MiniBtn.BackColor = System.Drawing.Color.Transparent;
            this.MiniBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.MiniBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.MiniBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.MiniBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.MiniBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(195)))), ((int)(((byte)(78)))));
            this.MiniBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MiniBtn.ForeColor = System.Drawing.Color.White;
            this.MiniBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(140)))), ((int)(((byte)(56)))));
            this.MiniBtn.Location = new System.Drawing.Point(317, 14);
            this.MiniBtn.Name = "MiniBtn";
            this.MiniBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.MiniBtn.Size = new System.Drawing.Size(19, 17);
            this.MiniBtn.TabIndex = 1;
            this.MiniBtn.Click += new System.EventHandler(this.MiniBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.memoryAdd, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Memoryminus, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.MemoryShowOrClear, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.ClearBtn, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.DeleteBtn, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.guna2Button16, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.guna2Button17, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.guna2Button18, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.DivideBtn, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.Sqrt, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Cbrt, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.BtnEight, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.BtnNine, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.BtnSeven, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.MultBtn, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.BtnSix, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.BtnFour, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.Btnfive, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.MinusBtn, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.PlusBtn, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.BtnThree, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.BtnTwo, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.BtnOne, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.EqlBtn, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.PointBtn, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.ModulusBtn, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.ZeroBtn, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.AbsBtn, 2, 2);
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 107);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(384, 409);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // memoryAdd
            // 
            this.memoryAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.memoryAdd.Animated = true;
            this.memoryAdd.BackColor = System.Drawing.Color.Transparent;
            this.memoryAdd.BorderRadius = 5;
            this.memoryAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.memoryAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.memoryAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.memoryAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.memoryAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.memoryAdd.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoryAdd.ForeColor = System.Drawing.Color.Black;
            this.memoryAdd.HoverState.FillColor = System.Drawing.Color.Teal;
            this.memoryAdd.Location = new System.Drawing.Point(3, 6);
            this.memoryAdd.Name = "memoryAdd";
            this.memoryAdd.Size = new System.Drawing.Size(90, 49);
            this.memoryAdd.TabIndex = 3;
            this.memoryAdd.Text = "M+";
            this.memoryAdd.TextOffset = new System.Drawing.Point(2, 0);
            this.memoryAdd.Click += new System.EventHandler(this.memoryAdd_Click);
            // 
            // Memoryminus
            // 
            this.Memoryminus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Memoryminus.Animated = true;
            this.Memoryminus.BackColor = System.Drawing.Color.Transparent;
            this.Memoryminus.BorderRadius = 5;
            this.Memoryminus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Memoryminus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Memoryminus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Memoryminus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Memoryminus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Memoryminus.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Memoryminus.ForeColor = System.Drawing.Color.Black;
            this.Memoryminus.HoverState.FillColor = System.Drawing.Color.Teal;
            this.Memoryminus.Location = new System.Drawing.Point(99, 6);
            this.Memoryminus.Name = "Memoryminus";
            this.Memoryminus.Size = new System.Drawing.Size(90, 49);
            this.Memoryminus.TabIndex = 4;
            this.Memoryminus.Text = "M-";
            this.Memoryminus.TextOffset = new System.Drawing.Point(2, 0);
            this.Memoryminus.Click += new System.EventHandler(this.Memoryminus_Click);
            // 
            // MemoryShowOrClear
            // 
            this.MemoryShowOrClear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MemoryShowOrClear.Animated = true;
            this.MemoryShowOrClear.BackColor = System.Drawing.Color.Transparent;
            this.MemoryShowOrClear.BorderRadius = 5;
            this.MemoryShowOrClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.MemoryShowOrClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.MemoryShowOrClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.MemoryShowOrClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.MemoryShowOrClear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MemoryShowOrClear.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemoryShowOrClear.ForeColor = System.Drawing.Color.Black;
            this.MemoryShowOrClear.HoverState.FillColor = System.Drawing.Color.Teal;
            this.MemoryShowOrClear.Location = new System.Drawing.Point(195, 6);
            this.MemoryShowOrClear.Name = "MemoryShowOrClear";
            this.MemoryShowOrClear.Size = new System.Drawing.Size(90, 49);
            this.MemoryShowOrClear.TabIndex = 5;
            this.MemoryShowOrClear.Text = "MRC";
            this.MemoryShowOrClear.Click += new System.EventHandler(this.MemoryShowOrClear_Click);
            this.MemoryShowOrClear.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MemoryShowOrClear_MouseDoubleClick);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearBtn.Animated = true;
            this.ClearBtn.BackColor = System.Drawing.Color.Transparent;
            this.ClearBtn.BorderRadius = 5;
            this.ClearBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ClearBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ClearBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ClearBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ClearBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClearBtn.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.ForeColor = System.Drawing.Color.Black;
            this.ClearBtn.HoverState.FillColor = System.Drawing.Color.Brown;
            this.ClearBtn.Location = new System.Drawing.Point(291, 6);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(90, 49);
            this.ClearBtn.TabIndex = 6;
            this.ClearBtn.Text = "C";
            this.ClearBtn.TextOffset = new System.Drawing.Point(0, -5);
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteBtn.Animated = true;
            this.DeleteBtn.BackColor = System.Drawing.Color.Transparent;
            this.DeleteBtn.BorderRadius = 5;
            this.DeleteBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DeleteBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DeleteBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeleteBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DeleteBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DeleteBtn.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.Black;
            this.DeleteBtn.HoverState.FillColor = System.Drawing.Color.Brown;
            this.DeleteBtn.Image = global::Calc.Properties.Resources.icons8_clear_symbol_50;
            this.DeleteBtn.ImageOffset = new System.Drawing.Point(-1, 0);
            this.DeleteBtn.ImageSize = new System.Drawing.Size(35, 35);
            this.DeleteBtn.Location = new System.Drawing.Point(291, 64);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(90, 49);
            this.DeleteBtn.TabIndex = 10;
            this.DeleteBtn.TextOffset = new System.Drawing.Point(0, -5);
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // guna2Button16
            // 
            this.guna2Button16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button16.Animated = true;
            this.guna2Button16.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button16.BorderRadius = 5;
            this.guna2Button16.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button16.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button16.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button16.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button16.FillColor = System.Drawing.Color.Gold;
            this.guna2Button16.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button16.ForeColor = System.Drawing.Color.Black;
            this.guna2Button16.HoverState.FillColor = System.Drawing.Color.Olive;
            this.guna2Button16.Image = global::Calc.Properties.Resources.icons8_pi_100;
            this.guna2Button16.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button16.Location = new System.Drawing.Point(195, 64);
            this.guna2Button16.Name = "guna2Button16";
            this.guna2Button16.Size = new System.Drawing.Size(90, 49);
            this.guna2Button16.TabIndex = 9;
            this.guna2Button16.TextOffset = new System.Drawing.Point(2, -1);
            this.guna2Button16.Click += new System.EventHandler(this.PieBtn);
            // 
            // guna2Button17
            // 
            this.guna2Button17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button17.Animated = true;
            this.guna2Button17.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button17.BorderRadius = 5;
            this.guna2Button17.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button17.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button17.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button17.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button17.FillColor = System.Drawing.Color.Gold;
            this.guna2Button17.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button17.ForeColor = System.Drawing.Color.Black;
            this.guna2Button17.HoverState.FillColor = System.Drawing.Color.Olive;
            this.guna2Button17.Image = global::Calc.Properties.Resources._1280_x_variable_removebg_preview;
            this.guna2Button17.ImageSize = new System.Drawing.Size(90, 50);
            this.guna2Button17.Location = new System.Drawing.Point(99, 64);
            this.guna2Button17.Name = "guna2Button17";
            this.guna2Button17.Size = new System.Drawing.Size(90, 49);
            this.guna2Button17.TabIndex = 8;
            this.guna2Button17.TextOffset = new System.Drawing.Point(2, -1);
            this.guna2Button17.Click += new System.EventHandler(this.guna2Button17_Click);
            // 
            // guna2Button18
            // 
            this.guna2Button18.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button18.Animated = true;
            this.guna2Button18.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button18.BorderRadius = 5;
            this.guna2Button18.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button18.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button18.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button18.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button18.FillColor = System.Drawing.Color.Gold;
            this.guna2Button18.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button18.ForeColor = System.Drawing.Color.Black;
            this.guna2Button18.HoverState.FillColor = System.Drawing.Color.Olive;
            this.guna2Button18.Location = new System.Drawing.Point(3, 64);
            this.guna2Button18.Name = "guna2Button18";
            this.guna2Button18.Size = new System.Drawing.Size(90, 49);
            this.guna2Button18.TabIndex = 7;
            this.guna2Button18.Text = "pw";
            this.guna2Button18.TextOffset = new System.Drawing.Point(2, -1);
            this.guna2Button18.Click += new System.EventHandler(this.guna2Button18_Click);
            // 
            // DivideBtn
            // 
            this.DivideBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DivideBtn.Animated = true;
            this.DivideBtn.BackColor = System.Drawing.Color.Transparent;
            this.DivideBtn.BorderRadius = 5;
            this.DivideBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DivideBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DivideBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DivideBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DivideBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.DivideBtn.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivideBtn.ForeColor = System.Drawing.Color.Black;
            this.DivideBtn.HoverState.FillColor = System.Drawing.Color.Purple;
            this.DivideBtn.Location = new System.Drawing.Point(291, 122);
            this.DivideBtn.Name = "DivideBtn";
            this.DivideBtn.Size = new System.Drawing.Size(90, 49);
            this.DivideBtn.TabIndex = 14;
            this.DivideBtn.Text = "÷";
            this.DivideBtn.TextOffset = new System.Drawing.Point(1, -5);
            this.DivideBtn.Click += new System.EventHandler(this.DivideBtn_Click);
            // 
            // Sqrt
            // 
            this.Sqrt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Sqrt.Animated = true;
            this.Sqrt.BackColor = System.Drawing.Color.Transparent;
            this.Sqrt.BorderRadius = 5;
            this.Sqrt.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Sqrt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Sqrt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Sqrt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Sqrt.FillColor = System.Drawing.Color.Gold;
            this.Sqrt.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sqrt.ForeColor = System.Drawing.Color.Black;
            this.Sqrt.HoverState.FillColor = System.Drawing.Color.Olive;
            this.Sqrt.Image = global::Calc.Properties.Resources.icons8_square_root_60;
            this.Sqrt.ImageSize = new System.Drawing.Size(40, 40);
            this.Sqrt.Location = new System.Drawing.Point(99, 122);
            this.Sqrt.Name = "Sqrt";
            this.Sqrt.Size = new System.Drawing.Size(90, 49);
            this.Sqrt.TabIndex = 12;
            this.Sqrt.TextOffset = new System.Drawing.Point(2, -1);
            this.Sqrt.Click += new System.EventHandler(this.Sqrt_Click);
            // 
            // Cbrt
            // 
            this.Cbrt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cbrt.Animated = true;
            this.Cbrt.BackColor = System.Drawing.Color.Transparent;
            this.Cbrt.BorderRadius = 5;
            this.Cbrt.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Cbrt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Cbrt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Cbrt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Cbrt.FillColor = System.Drawing.Color.Gold;
            this.Cbrt.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbrt.ForeColor = System.Drawing.Color.Black;
            this.Cbrt.HoverState.FillColor = System.Drawing.Color.Olive;
            this.Cbrt.Image = global::Calc.Properties.Resources.icons8_square_root_60___Copy;
            this.Cbrt.ImageSize = new System.Drawing.Size(40, 40);
            this.Cbrt.Location = new System.Drawing.Point(3, 122);
            this.Cbrt.Name = "Cbrt";
            this.Cbrt.Size = new System.Drawing.Size(90, 49);
            this.Cbrt.TabIndex = 11;
            this.Cbrt.TextOffset = new System.Drawing.Point(2, -1);
            this.Cbrt.Click += new System.EventHandler(this.Cbrt_Click);
            // 
            // BtnEight
            // 
            this.BtnEight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEight.Animated = true;
            this.BtnEight.BackColor = System.Drawing.Color.Transparent;
            this.BtnEight.BorderRadius = 5;
            this.BtnEight.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnEight.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnEight.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnEight.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnEight.FillColor = System.Drawing.Color.SpringGreen;
            this.BtnEight.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEight.ForeColor = System.Drawing.Color.Black;
            this.BtnEight.HoverState.FillColor = System.Drawing.Color.Green;
            this.BtnEight.Location = new System.Drawing.Point(99, 180);
            this.BtnEight.Name = "BtnEight";
            this.BtnEight.Size = new System.Drawing.Size(90, 49);
            this.BtnEight.TabIndex = 16;
            this.BtnEight.Text = "8";
            this.BtnEight.TextOffset = new System.Drawing.Point(2, -1);
            this.BtnEight.Click += new System.EventHandler(this.BtnEight_Click);
            // 
            // BtnNine
            // 
            this.BtnNine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNine.Animated = true;
            this.BtnNine.BackColor = System.Drawing.Color.Transparent;
            this.BtnNine.BorderRadius = 5;
            this.BtnNine.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnNine.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnNine.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnNine.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnNine.FillColor = System.Drawing.Color.SpringGreen;
            this.BtnNine.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNine.ForeColor = System.Drawing.Color.Black;
            this.BtnNine.HoverState.FillColor = System.Drawing.Color.Green;
            this.BtnNine.Location = new System.Drawing.Point(195, 180);
            this.BtnNine.Name = "BtnNine";
            this.BtnNine.Size = new System.Drawing.Size(90, 49);
            this.BtnNine.TabIndex = 17;
            this.BtnNine.Text = "9";
            this.BtnNine.TextOffset = new System.Drawing.Point(2, -1);
            this.BtnNine.Click += new System.EventHandler(this.BtnNine_Click);
            // 
            // BtnSeven
            // 
            this.BtnSeven.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSeven.Animated = true;
            this.BtnSeven.BackColor = System.Drawing.Color.Transparent;
            this.BtnSeven.BorderRadius = 5;
            this.BtnSeven.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnSeven.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnSeven.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnSeven.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnSeven.FillColor = System.Drawing.Color.SpringGreen;
            this.BtnSeven.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSeven.ForeColor = System.Drawing.Color.Black;
            this.BtnSeven.HoverState.FillColor = System.Drawing.Color.Green;
            this.BtnSeven.Location = new System.Drawing.Point(3, 180);
            this.BtnSeven.Name = "BtnSeven";
            this.BtnSeven.Size = new System.Drawing.Size(90, 49);
            this.BtnSeven.TabIndex = 15;
            this.BtnSeven.Text = "7";
            this.BtnSeven.TextOffset = new System.Drawing.Point(2, -1);
            this.BtnSeven.Click += new System.EventHandler(this.BtnSeven_Click);
            // 
            // MultBtn
            // 
            this.MultBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MultBtn.Animated = true;
            this.MultBtn.BackColor = System.Drawing.Color.Transparent;
            this.MultBtn.BorderRadius = 5;
            this.MultBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.MultBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.MultBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.MultBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.MultBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.MultBtn.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultBtn.ForeColor = System.Drawing.Color.Black;
            this.MultBtn.HoverState.FillColor = System.Drawing.Color.Purple;
            this.MultBtn.Location = new System.Drawing.Point(291, 180);
            this.MultBtn.Name = "MultBtn";
            this.MultBtn.Size = new System.Drawing.Size(90, 49);
            this.MultBtn.TabIndex = 18;
            this.MultBtn.Text = "×";
            this.MultBtn.TextOffset = new System.Drawing.Point(1, -5);
            this.MultBtn.Click += new System.EventHandler(this.MultBtn_Click);
            // 
            // BtnSix
            // 
            this.BtnSix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSix.Animated = true;
            this.BtnSix.BackColor = System.Drawing.Color.Transparent;
            this.BtnSix.BorderRadius = 5;
            this.BtnSix.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnSix.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnSix.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnSix.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnSix.FillColor = System.Drawing.Color.SpringGreen;
            this.BtnSix.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSix.ForeColor = System.Drawing.Color.Black;
            this.BtnSix.HoverState.FillColor = System.Drawing.Color.Green;
            this.BtnSix.Location = new System.Drawing.Point(195, 238);
            this.BtnSix.Name = "BtnSix";
            this.BtnSix.Size = new System.Drawing.Size(90, 49);
            this.BtnSix.TabIndex = 21;
            this.BtnSix.Text = "6";
            this.BtnSix.TextOffset = new System.Drawing.Point(2, -1);
            this.BtnSix.Click += new System.EventHandler(this.BtnSix_Click);
            // 
            // BtnFour
            // 
            this.BtnFour.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnFour.Animated = true;
            this.BtnFour.BackColor = System.Drawing.Color.Transparent;
            this.BtnFour.BorderRadius = 5;
            this.BtnFour.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnFour.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnFour.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnFour.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnFour.FillColor = System.Drawing.Color.SpringGreen;
            this.BtnFour.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFour.ForeColor = System.Drawing.Color.Black;
            this.BtnFour.HoverState.FillColor = System.Drawing.Color.Green;
            this.BtnFour.Location = new System.Drawing.Point(3, 238);
            this.BtnFour.Name = "BtnFour";
            this.BtnFour.Size = new System.Drawing.Size(90, 49);
            this.BtnFour.TabIndex = 19;
            this.BtnFour.Text = "4";
            this.BtnFour.TextOffset = new System.Drawing.Point(2, -1);
            this.BtnFour.Click += new System.EventHandler(this.BtnFour_Click);
            // 
            // Btnfive
            // 
            this.Btnfive.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btnfive.Animated = true;
            this.Btnfive.BackColor = System.Drawing.Color.Transparent;
            this.Btnfive.BorderRadius = 5;
            this.Btnfive.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btnfive.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btnfive.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btnfive.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btnfive.FillColor = System.Drawing.Color.SpringGreen;
            this.Btnfive.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnfive.ForeColor = System.Drawing.Color.Black;
            this.Btnfive.HoverState.FillColor = System.Drawing.Color.Green;
            this.Btnfive.Location = new System.Drawing.Point(99, 238);
            this.Btnfive.Name = "Btnfive";
            this.Btnfive.Size = new System.Drawing.Size(90, 49);
            this.Btnfive.TabIndex = 20;
            this.Btnfive.Text = "5";
            this.Btnfive.TextOffset = new System.Drawing.Point(2, -1);
            this.Btnfive.Click += new System.EventHandler(this.Btnfive_Click);
            // 
            // MinusBtn
            // 
            this.MinusBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MinusBtn.Animated = true;
            this.MinusBtn.BackColor = System.Drawing.Color.Transparent;
            this.MinusBtn.BorderRadius = 5;
            this.MinusBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.MinusBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.MinusBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.MinusBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.MinusBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.MinusBtn.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinusBtn.ForeColor = System.Drawing.Color.Black;
            this.MinusBtn.HoverState.FillColor = System.Drawing.Color.Purple;
            this.MinusBtn.Location = new System.Drawing.Point(291, 238);
            this.MinusBtn.Name = "MinusBtn";
            this.MinusBtn.Size = new System.Drawing.Size(90, 49);
            this.MinusBtn.TabIndex = 22;
            this.MinusBtn.Text = "–";
            this.MinusBtn.TextOffset = new System.Drawing.Point(1, -5);
            this.MinusBtn.Click += new System.EventHandler(this.MinusBtn_Click);
            // 
            // PlusBtn
            // 
            this.PlusBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlusBtn.Animated = true;
            this.PlusBtn.BackColor = System.Drawing.Color.Transparent;
            this.PlusBtn.BorderRadius = 5;
            this.PlusBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.PlusBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.PlusBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.PlusBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.PlusBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.PlusBtn.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlusBtn.ForeColor = System.Drawing.Color.Black;
            this.PlusBtn.HoverState.FillColor = System.Drawing.Color.Purple;
            this.PlusBtn.Location = new System.Drawing.Point(291, 296);
            this.PlusBtn.Name = "PlusBtn";
            this.PlusBtn.Size = new System.Drawing.Size(90, 49);
            this.PlusBtn.TabIndex = 26;
            this.PlusBtn.Text = "+";
            this.PlusBtn.TextOffset = new System.Drawing.Point(1, -5);
            this.PlusBtn.Click += new System.EventHandler(this.PlusBtn_Click);
            // 
            // BtnThree
            // 
            this.BtnThree.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnThree.Animated = true;
            this.BtnThree.BackColor = System.Drawing.Color.Transparent;
            this.BtnThree.BorderRadius = 5;
            this.BtnThree.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnThree.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnThree.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnThree.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnThree.FillColor = System.Drawing.Color.SpringGreen;
            this.BtnThree.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnThree.ForeColor = System.Drawing.Color.Black;
            this.BtnThree.HoverState.FillColor = System.Drawing.Color.Green;
            this.BtnThree.Location = new System.Drawing.Point(195, 296);
            this.BtnThree.Name = "BtnThree";
            this.BtnThree.Size = new System.Drawing.Size(90, 49);
            this.BtnThree.TabIndex = 25;
            this.BtnThree.Text = "3";
            this.BtnThree.TextOffset = new System.Drawing.Point(2, -1);
            this.BtnThree.Click += new System.EventHandler(this.BtnThree_Click);
            // 
            // BtnTwo
            // 
            this.BtnTwo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnTwo.Animated = true;
            this.BtnTwo.BackColor = System.Drawing.Color.Transparent;
            this.BtnTwo.BorderRadius = 5;
            this.BtnTwo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnTwo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnTwo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnTwo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnTwo.FillColor = System.Drawing.Color.SpringGreen;
            this.BtnTwo.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTwo.ForeColor = System.Drawing.Color.Black;
            this.BtnTwo.HoverState.FillColor = System.Drawing.Color.Green;
            this.BtnTwo.Location = new System.Drawing.Point(99, 296);
            this.BtnTwo.Name = "BtnTwo";
            this.BtnTwo.Size = new System.Drawing.Size(90, 49);
            this.BtnTwo.TabIndex = 24;
            this.BtnTwo.Text = "2";
            this.BtnTwo.TextOffset = new System.Drawing.Point(2, -1);
            this.BtnTwo.Click += new System.EventHandler(this.BtnTwo_Click);
            // 
            // BtnOne
            // 
            this.BtnOne.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnOne.Animated = true;
            this.BtnOne.BackColor = System.Drawing.Color.Transparent;
            this.BtnOne.BorderRadius = 5;
            this.BtnOne.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnOne.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnOne.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnOne.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnOne.FillColor = System.Drawing.Color.SpringGreen;
            this.BtnOne.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOne.ForeColor = System.Drawing.Color.Black;
            this.BtnOne.HoverState.FillColor = System.Drawing.Color.Green;
            this.BtnOne.Location = new System.Drawing.Point(3, 296);
            this.BtnOne.Name = "BtnOne";
            this.BtnOne.Size = new System.Drawing.Size(90, 49);
            this.BtnOne.TabIndex = 23;
            this.BtnOne.Text = "1";
            this.BtnOne.TextOffset = new System.Drawing.Point(2, -1);
            this.BtnOne.Click += new System.EventHandler(this.BtnOne_Click);
            // 
            // EqlBtn
            // 
            this.EqlBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.EqlBtn.Animated = true;
            this.EqlBtn.BackColor = System.Drawing.Color.Transparent;
            this.EqlBtn.BorderRadius = 5;
            this.EqlBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.EqlBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.EqlBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EqlBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.EqlBtn.FillColor = System.Drawing.SystemColors.MenuHighlight;
            this.EqlBtn.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EqlBtn.ForeColor = System.Drawing.Color.Black;
            this.EqlBtn.HoverState.FillColor = System.Drawing.Color.RoyalBlue;
            this.EqlBtn.Location = new System.Drawing.Point(291, 354);
            this.EqlBtn.Name = "EqlBtn";
            this.EqlBtn.Size = new System.Drawing.Size(90, 49);
            this.EqlBtn.TabIndex = 30;
            this.EqlBtn.Text = "=";
            this.EqlBtn.TextOffset = new System.Drawing.Point(1, -5);
            this.EqlBtn.Click += new System.EventHandler(this.EqlBtn_Click);
            // 
            // PointBtn
            // 
            this.PointBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PointBtn.Animated = true;
            this.PointBtn.BackColor = System.Drawing.Color.Transparent;
            this.PointBtn.BorderRadius = 5;
            this.PointBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.PointBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.PointBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.PointBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.PointBtn.FillColor = System.Drawing.Color.SpringGreen;
            this.PointBtn.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PointBtn.ForeColor = System.Drawing.Color.Black;
            this.PointBtn.HoverState.FillColor = System.Drawing.Color.Green;
            this.PointBtn.Location = new System.Drawing.Point(195, 354);
            this.PointBtn.Name = "PointBtn";
            this.PointBtn.Size = new System.Drawing.Size(90, 49);
            this.PointBtn.TabIndex = 29;
            this.PointBtn.Text = ".";
            this.PointBtn.TextOffset = new System.Drawing.Point(2, -1);
            this.PointBtn.Click += new System.EventHandler(this.PointBtn_Click);
            // 
            // ModulusBtn
            // 
            this.ModulusBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ModulusBtn.Animated = true;
            this.ModulusBtn.BackColor = System.Drawing.Color.Transparent;
            this.ModulusBtn.BorderRadius = 5;
            this.ModulusBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ModulusBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ModulusBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ModulusBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ModulusBtn.FillColor = System.Drawing.Color.SpringGreen;
            this.ModulusBtn.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModulusBtn.ForeColor = System.Drawing.Color.Black;
            this.ModulusBtn.HoverState.FillColor = System.Drawing.Color.Green;
            this.ModulusBtn.Location = new System.Drawing.Point(3, 354);
            this.ModulusBtn.Name = "ModulusBtn";
            this.ModulusBtn.Size = new System.Drawing.Size(90, 49);
            this.ModulusBtn.TabIndex = 27;
            this.ModulusBtn.Text = "%";
            this.ModulusBtn.TextOffset = new System.Drawing.Point(2, -1);
            this.ModulusBtn.Click += new System.EventHandler(this.ModulusBtn_Click);
            // 
            // ZeroBtn
            // 
            this.ZeroBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ZeroBtn.Animated = true;
            this.ZeroBtn.BackColor = System.Drawing.Color.Transparent;
            this.ZeroBtn.BorderRadius = 5;
            this.ZeroBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ZeroBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ZeroBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ZeroBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ZeroBtn.FillColor = System.Drawing.Color.SpringGreen;
            this.ZeroBtn.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZeroBtn.ForeColor = System.Drawing.Color.Black;
            this.ZeroBtn.HoverState.FillColor = System.Drawing.Color.Green;
            this.ZeroBtn.Location = new System.Drawing.Point(99, 354);
            this.ZeroBtn.Name = "ZeroBtn";
            this.ZeroBtn.Size = new System.Drawing.Size(90, 49);
            this.ZeroBtn.TabIndex = 28;
            this.ZeroBtn.Text = "0";
            this.ZeroBtn.TextOffset = new System.Drawing.Point(2, -1);
            this.ZeroBtn.Click += new System.EventHandler(this.ZeroBtn_Click);
            // 
            // AbsBtn
            // 
            this.AbsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AbsBtn.Animated = true;
            this.AbsBtn.BackColor = System.Drawing.Color.Transparent;
            this.AbsBtn.BorderRadius = 5;
            this.AbsBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AbsBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AbsBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AbsBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AbsBtn.FillColor = System.Drawing.Color.Gold;
            this.AbsBtn.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AbsBtn.ForeColor = System.Drawing.Color.Black;
            this.AbsBtn.HoverState.FillColor = System.Drawing.Color.Olive;
            this.AbsBtn.Image = global::Calc.Properties.Resources.abs1;
            this.AbsBtn.ImageSize = new System.Drawing.Size(40, 40);
            this.AbsBtn.Location = new System.Drawing.Point(195, 122);
            this.AbsBtn.Name = "AbsBtn";
            this.AbsBtn.Size = new System.Drawing.Size(90, 49);
            this.AbsBtn.TabIndex = 12;
            this.AbsBtn.TextOffset = new System.Drawing.Point(2, -1);
            this.AbsBtn.Click += new System.EventHandler(this.AbsBtn_Click);
            // 
            // Animator
            // 
            this.Animator.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
            this.Animator.Interval = 200;
            this.Animator.TargetForm = this;
            // 
            // BorderForm
            // 
            this.BorderForm.BorderRadius = 10;
            this.BorderForm.ContainerControl = this;
            this.BorderForm.DockIndicatorTransparencyValue = 0.6D;
            this.BorderForm.TransparentWhileDrag = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("DS-Digital", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(171, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 44);
            this.label1.TabIndex = 3;
            this.label1.Text = "la";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SettingBtn
            // 
            this.SettingBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingBtn.BackColor = System.Drawing.Color.Transparent;
            this.SettingBtn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.SettingBtn.HoverState.Image = global::Calc.Properties.Resources.outline_settings_white_48dp;
            this.SettingBtn.HoverState.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Vertical;
            this.SettingBtn.HoverState.ImageRotate = -9F;
            this.SettingBtn.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.SettingBtn.Image = global::Calc.Properties.Resources.outline_settings_white_48dp;
            this.SettingBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.SettingBtn.ImageRotate = 0F;
            this.SettingBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.SettingBtn.Location = new System.Drawing.Point(277, 6);
            this.SettingBtn.Name = "SettingBtn";
            this.SettingBtn.PressedState.Image = global::Calc.Properties.Resources.outline_settings_white_48dp;
            this.SettingBtn.PressedState.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Horizontal;
            this.SettingBtn.PressedState.ImageRotate = 9F;
            this.SettingBtn.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.SettingBtn.Size = new System.Drawing.Size(32, 35);
            this.SettingBtn.TabIndex = 4;
            this.SettingBtn.UseTransparentBackground = true;
            this.SettingBtn.Click += new System.EventHandler(this.SettingBtn_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(22, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "ProgCoding ©";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CalcuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(408, 530);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SettingBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.MiniBtn);
            this.Controls.Add(this.WindStatBtn);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.CalcLCD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(408, 530);
            this.Name = "CalcuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProgCoding Calculator";
            this.Load += new System.EventHandler(this.CalcuForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CalcuForm_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CalcuForm_KeyPress);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox CalcLCD;
        private Guna.UI2.WinForms.Guna2CircleButton CloseBtn;
        private Guna.UI2.WinForms.Guna2CircleButton WindStatBtn;
        private Guna.UI2.WinForms.Guna2CircleButton MiniBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button memoryAdd;
        private Guna.UI2.WinForms.Guna2Button Memoryminus;
        private Guna.UI2.WinForms.Guna2Button MemoryShowOrClear;
        private Guna.UI2.WinForms.Guna2Button ClearBtn;
        private Guna.UI2.WinForms.Guna2Button DeleteBtn;
        private Guna.UI2.WinForms.Guna2Button guna2Button16;
        private Guna.UI2.WinForms.Guna2Button guna2Button17;
        private Guna.UI2.WinForms.Guna2Button guna2Button18;
        private Guna.UI2.WinForms.Guna2Button DivideBtn;
        private Guna.UI2.WinForms.Guna2Button Sqrt;
        private Guna.UI2.WinForms.Guna2Button Cbrt;
        private Guna.UI2.WinForms.Guna2Button BtnEight;
        private Guna.UI2.WinForms.Guna2Button BtnNine;
        private Guna.UI2.WinForms.Guna2Button BtnSeven;
        private Guna.UI2.WinForms.Guna2Button MultBtn;
        private Guna.UI2.WinForms.Guna2Button BtnSix;
        private Guna.UI2.WinForms.Guna2Button BtnFour;
        private Guna.UI2.WinForms.Guna2Button Btnfive;
        private Guna.UI2.WinForms.Guna2Button MinusBtn;
        private Guna.UI2.WinForms.Guna2Button PlusBtn;
        private Guna.UI2.WinForms.Guna2Button BtnThree;
        private Guna.UI2.WinForms.Guna2Button BtnTwo;
        private Guna.UI2.WinForms.Guna2Button BtnOne;
        private Guna.UI2.WinForms.Guna2Button EqlBtn;
        private Guna.UI2.WinForms.Guna2Button PointBtn;
        private Guna.UI2.WinForms.Guna2Button ModulusBtn;
        private Guna.UI2.WinForms.Guna2Button ZeroBtn;
        private Guna.UI2.WinForms.Guna2AnimateWindow Animator;
        private Guna.UI2.WinForms.Guna2BorderlessForm BorderForm;
        private Guna.UI2.WinForms.Guna2Button AbsBtn;
        private Guna.UI2.WinForms.Guna2ImageButton SettingBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

