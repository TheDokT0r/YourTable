namespace YourTable
{
    partial class Calender
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
            this.lbl_month = new System.Windows.Forms.Label();
            this.lbl_day1 = new System.Windows.Forms.Label();
            this.lbl_day2 = new System.Windows.Forms.Label();
            this.lbl_day3 = new System.Windows.Forms.Label();
            this.lbl_day4 = new System.Windows.Forms.Label();
            this.sqliteCommand1 = new Microsoft.Data.Sqlite.SqliteCommand();
            this.lbl_day5 = new System.Windows.Forms.Label();
            this.lbl_day6 = new System.Windows.Forms.Label();
            this.lbl_day7 = new System.Windows.Forms.Label();
            this.lbl_day8 = new System.Windows.Forms.Label();
            this.lbl_day9 = new System.Windows.Forms.Label();
            this.lbl_day10 = new System.Windows.Forms.Label();
            this.lbl_day11 = new System.Windows.Forms.Label();
            this.lbl_day12 = new System.Windows.Forms.Label();
            this.lbl_day13 = new System.Windows.Forms.Label();
            this.lbl_day14 = new System.Windows.Forms.Label();
            this.lbl_day15 = new System.Windows.Forms.Label();
            this.lbl_day16 = new System.Windows.Forms.Label();
            this.lbl_day17 = new System.Windows.Forms.Label();
            this.lbl_day18 = new System.Windows.Forms.Label();
            this.lbl_day19 = new System.Windows.Forms.Label();
            this.lbl_day20 = new System.Windows.Forms.Label();
            this.lbl_day21 = new System.Windows.Forms.Label();
            this.lbl_day22 = new System.Windows.Forms.Label();
            this.lbl_day23 = new System.Windows.Forms.Label();
            this.lbl_day24 = new System.Windows.Forms.Label();
            this.lbl_day25 = new System.Windows.Forms.Label();
            this.lbl_day26 = new System.Windows.Forms.Label();
            this.lbl_day27 = new System.Windows.Forms.Label();
            this.lbl_day28 = new System.Windows.Forms.Label();
            this.lbl_day29 = new System.Windows.Forms.Label();
            this.lbl_day30 = new System.Windows.Forms.Label();
            this.lbl_day31 = new System.Windows.Forms.Label();
            this.lbl_placeholder = new System.Windows.Forms.Label();
            this.img_Next = new System.Windows.Forms.PictureBox();
            this.img_back = new System.Windows.Forms.PictureBox();
            this.lbl_year = new System.Windows.Forms.Label();
            this.btn_goToToday = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.img_Next)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_back)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_month
            // 
            this.lbl_month.AutoSize = true;
            this.lbl_month.BackColor = System.Drawing.Color.Transparent;
            this.lbl_month.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_month.Font = new System.Drawing.Font("MV Boli", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_month.ForeColor = System.Drawing.Color.Black;
            this.lbl_month.Location = new System.Drawing.Point(349, 107);
            this.lbl_month.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_month.Name = "lbl_month";
            this.lbl_month.Size = new System.Drawing.Size(291, 105);
            this.lbl_month.TabIndex = 0;
            this.lbl_month.Text = "Month";
            this.lbl_month.Click += new System.EventHandler(this.lbl_month_Click);
            // 
            // lbl_day1
            // 
            this.lbl_day1.AutoSize = true;
            this.lbl_day1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_day1.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_day1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_day1.Location = new System.Drawing.Point(221, 252);
            this.lbl_day1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_day1.Name = "lbl_day1";
            this.lbl_day1.Size = new System.Drawing.Size(24, 31);
            this.lbl_day1.TabIndex = 1;
            this.lbl_day1.Text = "1";
            this.lbl_day1.Click += new System.EventHandler(this.days_Click_Handler);
            // 
            // lbl_day2
            // 
            this.lbl_day2.AutoSize = true;
            this.lbl_day2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_day2.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_day2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_day2.Location = new System.Drawing.Point(272, 252);
            this.lbl_day2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_day2.Name = "lbl_day2";
            this.lbl_day2.Size = new System.Drawing.Size(30, 31);
            this.lbl_day2.TabIndex = 2;
            this.lbl_day2.Text = "2";
            this.lbl_day2.Click += new System.EventHandler(this.days_Click_Handler);
            // 
            // lbl_day3
            // 
            this.lbl_day3.AutoSize = true;
            this.lbl_day3.BackColor = System.Drawing.Color.Transparent;
            this.lbl_day3.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_day3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_day3.Location = new System.Drawing.Point(336, 252);
            this.lbl_day3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_day3.Name = "lbl_day3";
            this.lbl_day3.Size = new System.Drawing.Size(30, 31);
            this.lbl_day3.TabIndex = 3;
            this.lbl_day3.Text = "3";
            this.lbl_day3.Click += new System.EventHandler(this.days_Click_Handler);
            // 
            // lbl_day4
            // 
            this.lbl_day4.AutoSize = true;
            this.lbl_day4.BackColor = System.Drawing.Color.Transparent;
            this.lbl_day4.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_day4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_day4.Location = new System.Drawing.Point(391, 252);
            this.lbl_day4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_day4.Name = "lbl_day4";
            this.lbl_day4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_day4.Size = new System.Drawing.Size(30, 31);
            this.lbl_day4.TabIndex = 4;
            this.lbl_day4.Text = "4";
            this.lbl_day4.Click += new System.EventHandler(this.days_Click_Handler);
            // 
            // sqliteCommand1
            // 
            this.sqliteCommand1.CommandTimeout = 30;
            this.sqliteCommand1.Connection = null;
            this.sqliteCommand1.Transaction = null;
            this.sqliteCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // lbl_day5
            // 
            this.lbl_day5.AutoSize = true;
            this.lbl_day5.BackColor = System.Drawing.Color.Transparent;
            this.lbl_day5.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_day5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_day5.Location = new System.Drawing.Point(451, 252);
            this.lbl_day5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_day5.Name = "lbl_day5";
            this.lbl_day5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_day5.Size = new System.Drawing.Size(30, 31);
            this.lbl_day5.TabIndex = 5;
            this.lbl_day5.Text = "5";
            this.lbl_day5.Click += new System.EventHandler(this.days_Click_Handler);
            // 
            // lbl_day6
            // 
            this.lbl_day6.AutoSize = true;
            this.lbl_day6.BackColor = System.Drawing.Color.Transparent;
            this.lbl_day6.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_day6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_day6.Location = new System.Drawing.Point(508, 252);
            this.lbl_day6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_day6.Name = "lbl_day6";
            this.lbl_day6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_day6.Size = new System.Drawing.Size(30, 31);
            this.lbl_day6.TabIndex = 6;
            this.lbl_day6.Text = "6";
            this.lbl_day6.Click += new System.EventHandler(this.days_Click_Handler);
            // 
            // lbl_day7
            // 
            this.lbl_day7.AutoSize = true;
            this.lbl_day7.BackColor = System.Drawing.Color.Transparent;
            this.lbl_day7.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_day7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_day7.Location = new System.Drawing.Point(568, 252);
            this.lbl_day7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_day7.Name = "lbl_day7";
            this.lbl_day7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_day7.Size = new System.Drawing.Size(28, 31);
            this.lbl_day7.TabIndex = 7;
            this.lbl_day7.Text = "7";
            this.lbl_day7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_day7.Click += new System.EventHandler(this.days_Click_Handler);
            // 
            // lbl_day8
            // 
            this.lbl_day8.AutoSize = true;
            this.lbl_day8.BackColor = System.Drawing.Color.Transparent;
            this.lbl_day8.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_day8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_day8.Location = new System.Drawing.Point(629, 252);
            this.lbl_day8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_day8.Name = "lbl_day8";
            this.lbl_day8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_day8.Size = new System.Drawing.Size(30, 31);
            this.lbl_day8.TabIndex = 8;
            this.lbl_day8.Text = "8";
            this.lbl_day8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_day8.Click += new System.EventHandler(this.days_Click_Handler);
            // 
            // lbl_day9
            // 
            this.lbl_day9.AutoSize = true;
            this.lbl_day9.BackColor = System.Drawing.Color.Transparent;
            this.lbl_day9.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_day9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_day9.Location = new System.Drawing.Point(696, 252);
            this.lbl_day9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_day9.Name = "lbl_day9";
            this.lbl_day9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_day9.Size = new System.Drawing.Size(30, 31);
            this.lbl_day9.TabIndex = 9;
            this.lbl_day9.Text = "9";
            this.lbl_day9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_day9.Click += new System.EventHandler(this.days_Click_Handler);
            // 
            // lbl_day10
            // 
            this.lbl_day10.AutoSize = true;
            this.lbl_day10.BackColor = System.Drawing.Color.Transparent;
            this.lbl_day10.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_day10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_day10.Location = new System.Drawing.Point(752, 252);
            this.lbl_day10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_day10.Name = "lbl_day10";
            this.lbl_day10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_day10.Size = new System.Drawing.Size(41, 31);
            this.lbl_day10.TabIndex = 10;
            this.lbl_day10.Text = "10";
            this.lbl_day10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_day10.Click += new System.EventHandler(this.days_Click_Handler);
            // 
            // lbl_day11
            // 
            this.lbl_day11.AutoSize = true;
            this.lbl_day11.BackColor = System.Drawing.Color.Transparent;
            this.lbl_day11.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_day11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_day11.Location = new System.Drawing.Point(204, 320);
            this.lbl_day11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_day11.Name = "lbl_day11";
            this.lbl_day11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_day11.Size = new System.Drawing.Size(34, 31);
            this.lbl_day11.TabIndex = 11;
            this.lbl_day11.Text = "11";
            this.lbl_day11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_day11.Click += new System.EventHandler(this.days_Click_Handler);
            // 
            // lbl_day12
            // 
            this.lbl_day12.AutoSize = true;
            this.lbl_day12.BackColor = System.Drawing.Color.Transparent;
            this.lbl_day12.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_day12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_day12.Location = new System.Drawing.Point(261, 320);
            this.lbl_day12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_day12.Name = "lbl_day12";
            this.lbl_day12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_day12.Size = new System.Drawing.Size(40, 31);
            this.lbl_day12.TabIndex = 12;
            this.lbl_day12.Text = "12";
            this.lbl_day12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_day12.Click += new System.EventHandler(this.days_Click_Handler);
            // 
            // lbl_day13
            // 
            this.lbl_day13.AutoSize = true;
            this.lbl_day13.BackColor = System.Drawing.Color.Transparent;
            this.lbl_day13.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_day13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_day13.Location = new System.Drawing.Point(325, 320);
            this.lbl_day13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_day13.Name = "lbl_day13";
            this.lbl_day13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_day13.Size = new System.Drawing.Size(40, 31);
            this.lbl_day13.TabIndex = 13;
            this.lbl_day13.Text = "12";
            this.lbl_day13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_day13.Click += new System.EventHandler(this.days_Click_Handler);
            // 
            // lbl_day14
            // 
            this.lbl_day14.AutoSize = true;
            this.lbl_day14.BackColor = System.Drawing.Color.Transparent;
            this.lbl_day14.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_day14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_day14.Location = new System.Drawing.Point(380, 320);
            this.lbl_day14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_day14.Name = "lbl_day14";
            this.lbl_day14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_day14.Size = new System.Drawing.Size(40, 31);
            this.lbl_day14.TabIndex = 14;
            this.lbl_day14.Text = "12";
            this.lbl_day14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_day14.Click += new System.EventHandler(this.days_Click_Handler);
            // 
            // lbl_day15
            // 
            this.lbl_day15.AutoSize = true;
            this.lbl_day15.BackColor = System.Drawing.Color.Transparent;
            this.lbl_day15.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_day15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_day15.Location = new System.Drawing.Point(440, 320);
            this.lbl_day15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_day15.Name = "lbl_day15";
            this.lbl_day15.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_day15.Size = new System.Drawing.Size(40, 31);
            this.lbl_day15.TabIndex = 15;
            this.lbl_day15.Text = "12";
            this.lbl_day15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_day15.Click += new System.EventHandler(this.days_Click_Handler);
            // 
            // lbl_day16
            // 
            this.lbl_day16.AutoSize = true;
            this.lbl_day16.BackColor = System.Drawing.Color.Transparent;
            this.lbl_day16.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_day16.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_day16.Location = new System.Drawing.Point(497, 320);
            this.lbl_day16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_day16.Name = "lbl_day16";
            this.lbl_day16.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_day16.Size = new System.Drawing.Size(40, 31);
            this.lbl_day16.TabIndex = 16;
            this.lbl_day16.Text = "12";
            this.lbl_day16.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_day16.Click += new System.EventHandler(this.days_Click_Handler);
            // 
            // lbl_day17
            // 
            this.lbl_day17.AutoSize = true;
            this.lbl_day17.BackColor = System.Drawing.Color.Transparent;
            this.lbl_day17.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_day17.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_day17.Location = new System.Drawing.Point(555, 320);
            this.lbl_day17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_day17.Name = "lbl_day17";
            this.lbl_day17.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_day17.Size = new System.Drawing.Size(40, 31);
            this.lbl_day17.TabIndex = 17;
            this.lbl_day17.Text = "12";
            this.lbl_day17.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_day17.Click += new System.EventHandler(this.days_Click_Handler);
            // 
            // lbl_day18
            // 
            this.lbl_day18.AutoSize = true;
            this.lbl_day18.BackColor = System.Drawing.Color.Transparent;
            this.lbl_day18.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_day18.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_day18.Location = new System.Drawing.Point(617, 320);
            this.lbl_day18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_day18.Name = "lbl_day18";
            this.lbl_day18.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_day18.Size = new System.Drawing.Size(40, 31);
            this.lbl_day18.TabIndex = 18;
            this.lbl_day18.Text = "12";
            this.lbl_day18.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_day18.Click += new System.EventHandler(this.days_Click_Handler);
            // 
            // lbl_day19
            // 
            this.lbl_day19.AutoSize = true;
            this.lbl_day19.BackColor = System.Drawing.Color.Transparent;
            this.lbl_day19.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_day19.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_day19.Location = new System.Drawing.Point(685, 320);
            this.lbl_day19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_day19.Name = "lbl_day19";
            this.lbl_day19.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_day19.Size = new System.Drawing.Size(40, 31);
            this.lbl_day19.TabIndex = 19;
            this.lbl_day19.Text = "12";
            this.lbl_day19.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_day19.Click += new System.EventHandler(this.days_Click_Handler);
            // 
            // lbl_day20
            // 
            this.lbl_day20.AutoSize = true;
            this.lbl_day20.BackColor = System.Drawing.Color.Transparent;
            this.lbl_day20.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_day20.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_day20.Location = new System.Drawing.Point(752, 320);
            this.lbl_day20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_day20.Name = "lbl_day20";
            this.lbl_day20.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_day20.Size = new System.Drawing.Size(40, 31);
            this.lbl_day20.TabIndex = 20;
            this.lbl_day20.Text = "12";
            this.lbl_day20.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_day20.Click += new System.EventHandler(this.days_Click_Handler);
            // 
            // lbl_day21
            // 
            this.lbl_day21.AutoSize = true;
            this.lbl_day21.BackColor = System.Drawing.Color.Transparent;
            this.lbl_day21.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_day21.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_day21.Location = new System.Drawing.Point(204, 393);
            this.lbl_day21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_day21.Name = "lbl_day21";
            this.lbl_day21.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_day21.Size = new System.Drawing.Size(40, 31);
            this.lbl_day21.TabIndex = 21;
            this.lbl_day21.Text = "12";
            this.lbl_day21.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_day21.Click += new System.EventHandler(this.days_Click_Handler);
            // 
            // lbl_day22
            // 
            this.lbl_day22.AutoSize = true;
            this.lbl_day22.BackColor = System.Drawing.Color.Transparent;
            this.lbl_day22.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_day22.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_day22.Location = new System.Drawing.Point(256, 393);
            this.lbl_day22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_day22.Name = "lbl_day22";
            this.lbl_day22.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_day22.Size = new System.Drawing.Size(40, 31);
            this.lbl_day22.TabIndex = 22;
            this.lbl_day22.Text = "12";
            this.lbl_day22.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_day22.Click += new System.EventHandler(this.days_Click_Handler);
            // 
            // lbl_day23
            // 
            this.lbl_day23.AutoSize = true;
            this.lbl_day23.BackColor = System.Drawing.Color.Transparent;
            this.lbl_day23.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_day23.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_day23.Location = new System.Drawing.Point(325, 393);
            this.lbl_day23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_day23.Name = "lbl_day23";
            this.lbl_day23.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_day23.Size = new System.Drawing.Size(40, 31);
            this.lbl_day23.TabIndex = 23;
            this.lbl_day23.Text = "12";
            this.lbl_day23.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_day23.Click += new System.EventHandler(this.days_Click_Handler);
            // 
            // lbl_day24
            // 
            this.lbl_day24.AutoSize = true;
            this.lbl_day24.BackColor = System.Drawing.Color.Transparent;
            this.lbl_day24.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_day24.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_day24.Location = new System.Drawing.Point(377, 393);
            this.lbl_day24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_day24.Name = "lbl_day24";
            this.lbl_day24.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_day24.Size = new System.Drawing.Size(40, 31);
            this.lbl_day24.TabIndex = 24;
            this.lbl_day24.Text = "12";
            this.lbl_day24.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_day24.Click += new System.EventHandler(this.days_Click_Handler);
            // 
            // lbl_day25
            // 
            this.lbl_day25.AutoSize = true;
            this.lbl_day25.BackColor = System.Drawing.Color.Transparent;
            this.lbl_day25.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_day25.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_day25.Location = new System.Drawing.Point(429, 393);
            this.lbl_day25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_day25.Name = "lbl_day25";
            this.lbl_day25.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_day25.Size = new System.Drawing.Size(40, 31);
            this.lbl_day25.TabIndex = 25;
            this.lbl_day25.Text = "12";
            this.lbl_day25.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_day25.Click += new System.EventHandler(this.days_Click_Handler);
            // 
            // lbl_day26
            // 
            this.lbl_day26.AutoSize = true;
            this.lbl_day26.BackColor = System.Drawing.Color.Transparent;
            this.lbl_day26.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_day26.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_day26.Location = new System.Drawing.Point(497, 393);
            this.lbl_day26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_day26.Name = "lbl_day26";
            this.lbl_day26.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_day26.Size = new System.Drawing.Size(40, 31);
            this.lbl_day26.TabIndex = 26;
            this.lbl_day26.Text = "12";
            this.lbl_day26.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_day26.Click += new System.EventHandler(this.days_Click_Handler);
            // 
            // lbl_day27
            // 
            this.lbl_day27.AutoSize = true;
            this.lbl_day27.BackColor = System.Drawing.Color.Transparent;
            this.lbl_day27.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_day27.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_day27.Location = new System.Drawing.Point(555, 393);
            this.lbl_day27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_day27.Name = "lbl_day27";
            this.lbl_day27.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_day27.Size = new System.Drawing.Size(40, 31);
            this.lbl_day27.TabIndex = 27;
            this.lbl_day27.Text = "12";
            this.lbl_day27.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_day27.Click += new System.EventHandler(this.days_Click_Handler);
            // 
            // lbl_day28
            // 
            this.lbl_day28.AutoSize = true;
            this.lbl_day28.BackColor = System.Drawing.Color.Transparent;
            this.lbl_day28.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_day28.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_day28.Location = new System.Drawing.Point(607, 393);
            this.lbl_day28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_day28.Name = "lbl_day28";
            this.lbl_day28.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_day28.Size = new System.Drawing.Size(40, 31);
            this.lbl_day28.TabIndex = 28;
            this.lbl_day28.Text = "12";
            this.lbl_day28.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_day28.Click += new System.EventHandler(this.days_Click_Handler);
            // 
            // lbl_day29
            // 
            this.lbl_day29.AutoSize = true;
            this.lbl_day29.BackColor = System.Drawing.Color.Transparent;
            this.lbl_day29.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_day29.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_day29.Location = new System.Drawing.Point(685, 393);
            this.lbl_day29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_day29.Name = "lbl_day29";
            this.lbl_day29.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_day29.Size = new System.Drawing.Size(40, 31);
            this.lbl_day29.TabIndex = 29;
            this.lbl_day29.Text = "12";
            this.lbl_day29.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_day29.Click += new System.EventHandler(this.days_Click_Handler);
            // 
            // lbl_day30
            // 
            this.lbl_day30.AutoSize = true;
            this.lbl_day30.BackColor = System.Drawing.Color.Transparent;
            this.lbl_day30.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_day30.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_day30.Location = new System.Drawing.Point(752, 393);
            this.lbl_day30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_day30.Name = "lbl_day30";
            this.lbl_day30.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_day30.Size = new System.Drawing.Size(40, 31);
            this.lbl_day30.TabIndex = 30;
            this.lbl_day30.Text = "12";
            this.lbl_day30.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_day30.Click += new System.EventHandler(this.days_Click_Handler);
            // 
            // lbl_day31
            // 
            this.lbl_day31.AutoSize = true;
            this.lbl_day31.BackColor = System.Drawing.Color.Transparent;
            this.lbl_day31.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_day31.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_day31.Location = new System.Drawing.Point(480, 443);
            this.lbl_day31.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_day31.Name = "lbl_day31";
            this.lbl_day31.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_day31.Size = new System.Drawing.Size(40, 31);
            this.lbl_day31.TabIndex = 31;
            this.lbl_day31.Text = "12";
            this.lbl_day31.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_day31.Click += new System.EventHandler(this.days_Click_Handler);
            // 
            // lbl_placeholder
            // 
            this.lbl_placeholder.AutoSize = true;
            this.lbl_placeholder.BackColor = System.Drawing.Color.Transparent;
            this.lbl_placeholder.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_placeholder.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_placeholder.Location = new System.Drawing.Point(629, 443);
            this.lbl_placeholder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_placeholder.Name = "lbl_placeholder";
            this.lbl_placeholder.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_placeholder.Size = new System.Drawing.Size(135, 31);
            this.lbl_placeholder.TabIndex = 32;
            this.lbl_placeholder.Text = "placeholder";
            this.lbl_placeholder.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_placeholder.Visible = false;
            // 
            // img_Next
            // 
            this.img_Next.BackColor = System.Drawing.Color.Transparent;
            this.img_Next.Image = global::YourTable.Properties.Resources.Next_btn;
            this.img_Next.Location = new System.Drawing.Point(649, 478);
            this.img_Next.Margin = new System.Windows.Forms.Padding(4);
            this.img_Next.Name = "img_Next";
            this.img_Next.Size = new System.Drawing.Size(80, 62);
            this.img_Next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_Next.TabIndex = 34;
            this.img_Next.TabStop = false;
            this.img_Next.Click += new System.EventHandler(this.img_Next_Click);
            // 
            // img_back
            // 
            this.img_back.BackColor = System.Drawing.Color.Transparent;
            this.img_back.Image = global::YourTable.Properties.Resources.back_btn;
            this.img_back.Location = new System.Drawing.Point(279, 478);
            this.img_back.Margin = new System.Windows.Forms.Padding(4);
            this.img_back.Name = "img_back";
            this.img_back.Size = new System.Drawing.Size(80, 62);
            this.img_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_back.TabIndex = 35;
            this.img_back.TabStop = false;
            this.img_back.Click += new System.EventHandler(this.img_back_Click);
            // 
            // lbl_year
            // 
            this.lbl_year.AutoSize = true;
            this.lbl_year.BackColor = System.Drawing.Color.Transparent;
            this.lbl_year.Font = new System.Drawing.Font("MV Boli", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_year.Location = new System.Drawing.Point(447, 196);
            this.lbl_year.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_year.Name = "lbl_year";
            this.lbl_year.Size = new System.Drawing.Size(110, 58);
            this.lbl_year.TabIndex = 36;
            this.lbl_year.Text = "year";
            // 
            // btn_goToToday
            // 
            this.btn_goToToday.BackColor = System.Drawing.Color.Transparent;
            this.btn_goToToday.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_goToToday.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_goToToday.Location = new System.Drawing.Point(415, 494);
            this.btn_goToToday.Name = "btn_goToToday";
            this.btn_goToToday.Size = new System.Drawing.Size(160, 46);
            this.btn_goToToday.TabIndex = 38;
            this.btn_goToToday.Text = "Go to today";
            this.btn_goToToday.UseVisualStyleBackColor = false;
            this.btn_goToToday.Click += new System.EventHandler(this.btn_goToToday_Click);
            // 
            // Calender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::YourTable.Properties.Resources.Your_calender_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btn_goToToday);
            this.Controls.Add(this.lbl_year);
            this.Controls.Add(this.img_back);
            this.Controls.Add(this.img_Next);
            this.Controls.Add(this.lbl_placeholder);
            this.Controls.Add(this.lbl_day31);
            this.Controls.Add(this.lbl_day30);
            this.Controls.Add(this.lbl_day29);
            this.Controls.Add(this.lbl_day28);
            this.Controls.Add(this.lbl_day27);
            this.Controls.Add(this.lbl_day26);
            this.Controls.Add(this.lbl_day25);
            this.Controls.Add(this.lbl_day24);
            this.Controls.Add(this.lbl_day23);
            this.Controls.Add(this.lbl_day22);
            this.Controls.Add(this.lbl_day21);
            this.Controls.Add(this.lbl_day20);
            this.Controls.Add(this.lbl_day19);
            this.Controls.Add(this.lbl_day18);
            this.Controls.Add(this.lbl_day17);
            this.Controls.Add(this.lbl_day16);
            this.Controls.Add(this.lbl_day15);
            this.Controls.Add(this.lbl_day14);
            this.Controls.Add(this.lbl_day13);
            this.Controls.Add(this.lbl_day12);
            this.Controls.Add(this.lbl_day11);
            this.Controls.Add(this.lbl_day10);
            this.Controls.Add(this.lbl_day9);
            this.Controls.Add(this.lbl_day8);
            this.Controls.Add(this.lbl_day7);
            this.Controls.Add(this.lbl_day6);
            this.Controls.Add(this.lbl_day5);
            this.Controls.Add(this.lbl_day4);
            this.Controls.Add(this.lbl_day3);
            this.Controls.Add(this.lbl_day2);
            this.Controls.Add(this.lbl_day1);
            this.Controls.Add(this.lbl_month);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Calender";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YourTable";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Calender_Close);
            this.Load += new System.EventHandler(this.Calender_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_Next)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_month;
        private System.Windows.Forms.Label lbl_day1;
        private System.Windows.Forms.Label lbl_day2;
        private System.Windows.Forms.Label lbl_day3;
        private System.Windows.Forms.Label lbl_day4;
        private Microsoft.Data.Sqlite.SqliteCommand sqliteCommand1;
        private System.Windows.Forms.Label lbl_day5;
        private System.Windows.Forms.Label lbl_day6;
        private System.Windows.Forms.Label lbl_day7;
        private System.Windows.Forms.Label lbl_day8;
        private System.Windows.Forms.Label lbl_day9;
        private System.Windows.Forms.Label lbl_day10;
        private System.Windows.Forms.Label lbl_day11;
        private System.Windows.Forms.Label lbl_day12;
        private System.Windows.Forms.Label lbl_day13;
        private System.Windows.Forms.Label lbl_day14;
        private System.Windows.Forms.Label lbl_day15;
        private System.Windows.Forms.Label lbl_day16;
        private System.Windows.Forms.Label lbl_day17;
        private System.Windows.Forms.Label lbl_day18;
        private System.Windows.Forms.Label lbl_day19;
        private System.Windows.Forms.Label lbl_day20;
        private System.Windows.Forms.Label lbl_day21;
        private System.Windows.Forms.Label lbl_day22;
        private System.Windows.Forms.Label lbl_day23;
        private System.Windows.Forms.Label lbl_day24;
        private System.Windows.Forms.Label lbl_day25;
        private System.Windows.Forms.Label lbl_day26;
        private System.Windows.Forms.Label lbl_day27;
        private System.Windows.Forms.Label lbl_day28;
        private System.Windows.Forms.Label lbl_day29;
        private System.Windows.Forms.Label lbl_day30;
        private System.Windows.Forms.Label lbl_day31;
        private System.Windows.Forms.Label lbl_placeholder;
        private System.Windows.Forms.PictureBox img_Next;
        private System.Windows.Forms.PictureBox img_back;
        private System.Windows.Forms.Label lbl_year;
        private System.Windows.Forms.Button btn_goToToday;
    }
}