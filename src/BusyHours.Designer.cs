namespace YourTable
{
    partial class BusyHours
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_hours = new System.Windows.Forms.Label();
            this.txt_hour1 = new System.Windows.Forms.TextBox();
            this.lbl_00 = new System.Windows.Forms.Label();
            this.txt_hour2 = new System.Windows.Forms.TextBox();
            this.lbl_001 = new System.Windows.Forms.Label();
            this.lbl_occurrence = new System.Windows.Forms.Label();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.dt_date = new System.Windows.Forms.DateTimePicker();
            this.lbl_firstOccurrence = new System.Windows.Forms.Label();
            this.lbx_occurrence = new System.Windows.Forms.ListBox();
            this.lbl_loading = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MV Boli", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(387, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Busy Hours";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(102, 119);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(206, 32);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Name of event:";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(317, 113);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(256, 38);
            this.txt_name.TabIndex = 2;
            // 
            // lbl_hours
            // 
            this.lbl_hours.AutoSize = true;
            this.lbl_hours.BackColor = System.Drawing.Color.Transparent;
            this.lbl_hours.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hours.Location = new System.Drawing.Point(105, 207);
            this.lbl_hours.Name = "lbl_hours";
            this.lbl_hours.Size = new System.Drawing.Size(206, 32);
            this.lbl_hours.TabIndex = 3;
            this.lbl_hours.Text = "Hours of event:";
            // 
            // txt_hour1
            // 
            this.txt_hour1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hour1.Location = new System.Drawing.Point(317, 201);
            this.txt_hour1.Name = "txt_hour1";
            this.txt_hour1.Size = new System.Drawing.Size(77, 38);
            this.txt_hour1.TabIndex = 4;
            // 
            // lbl_00
            // 
            this.lbl_00.AutoSize = true;
            this.lbl_00.BackColor = System.Drawing.Color.Transparent;
            this.lbl_00.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_00.Location = new System.Drawing.Point(400, 207);
            this.lbl_00.Name = "lbl_00";
            this.lbl_00.Size = new System.Drawing.Size(78, 32);
            this.lbl_00.TabIndex = 5;
            this.lbl_00.Text = ":00  -";
            // 
            // txt_hour2
            // 
            this.txt_hour2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hour2.Location = new System.Drawing.Point(477, 201);
            this.txt_hour2.Name = "txt_hour2";
            this.txt_hour2.Size = new System.Drawing.Size(77, 38);
            this.txt_hour2.TabIndex = 6;
            // 
            // lbl_001
            // 
            this.lbl_001.AutoSize = true;
            this.lbl_001.BackColor = System.Drawing.Color.Transparent;
            this.lbl_001.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_001.Location = new System.Drawing.Point(560, 207);
            this.lbl_001.Name = "lbl_001";
            this.lbl_001.Size = new System.Drawing.Size(55, 32);
            this.lbl_001.TabIndex = 7;
            this.lbl_001.Text = ":00";
            // 
            // lbl_occurrence
            // 
            this.lbl_occurrence.AutoSize = true;
            this.lbl_occurrence.BackColor = System.Drawing.Color.Transparent;
            this.lbl_occurrence.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_occurrence.Location = new System.Drawing.Point(105, 365);
            this.lbl_occurrence.Name = "lbl_occurrence";
            this.lbl_occurrence.Size = new System.Drawing.Size(169, 32);
            this.lbl_occurrence.TabIndex = 8;
            this.lbl_occurrence.Text = "Occurrence:";
            // 
            // btn_confirm
            // 
            this.btn_confirm.BackColor = System.Drawing.Color.Transparent;
            this.btn_confirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_confirm.Font = new System.Drawing.Font("MV Boli", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirm.Location = new System.Drawing.Point(772, 176);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(251, 109);
            this.btn_confirm.TabIndex = 10;
            this.btn_confirm.Text = "Confirm";
            this.btn_confirm.UseVisualStyleBackColor = false;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // dt_date
            // 
            this.dt_date.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_date.Location = new System.Drawing.Point(333, 289);
            this.dt_date.Name = "dt_date";
            this.dt_date.Size = new System.Drawing.Size(200, 22);
            this.dt_date.TabIndex = 11;
            // 
            // lbl_firstOccurrence
            // 
            this.lbl_firstOccurrence.AutoSize = true;
            this.lbl_firstOccurrence.BackColor = System.Drawing.Color.Transparent;
            this.lbl_firstOccurrence.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_firstOccurrence.Location = new System.Drawing.Point(102, 281);
            this.lbl_firstOccurrence.Name = "lbl_firstOccurrence";
            this.lbl_firstOccurrence.Size = new System.Drawing.Size(225, 32);
            this.lbl_firstOccurrence.TabIndex = 12;
            this.lbl_firstOccurrence.Text = "First occurrence:";
            // 
            // lbx_occurrence
            // 
            this.lbx_occurrence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbx_occurrence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbx_occurrence.FormattingEnabled = true;
            this.lbx_occurrence.ItemHeight = 25;
            this.lbx_occurrence.Items.AddRange(new object[] {
            "Only once",
            "Daily",
            "Weekely",
            "Monthly"});
            this.lbx_occurrence.Location = new System.Drawing.Point(300, 365);
            this.lbx_occurrence.Name = "lbx_occurrence";
            this.lbx_occurrence.Size = new System.Drawing.Size(189, 129);
            this.lbx_occurrence.TabIndex = 13;
            // 
            // lbl_loading
            // 
            this.lbl_loading.AutoSize = true;
            this.lbl_loading.BackColor = System.Drawing.Color.Transparent;
            this.lbl_loading.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loading.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_loading.Location = new System.Drawing.Point(259, 516);
            this.lbl_loading.Name = "lbl_loading";
            this.lbl_loading.Size = new System.Drawing.Size(356, 29);
            this.lbl_loading.TabIndex = 14;
            this.lbl_loading.Text = "Loading your data, please wait...\r\n";
            this.lbl_loading.Visible = false;
            // 
            // BusyHours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::YourTable.Properties.Resources.pink_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lbl_loading);
            this.Controls.Add(this.lbx_occurrence);
            this.Controls.Add(this.lbl_firstOccurrence);
            this.Controls.Add(this.dt_date);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.lbl_occurrence);
            this.Controls.Add(this.lbl_001);
            this.Controls.Add(this.txt_hour2);
            this.Controls.Add(this.lbl_00);
            this.Controls.Add(this.txt_hour1);
            this.Controls.Add(this.lbl_hours);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BusyHours";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BusyHours";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BusyHours_FormClosing);
            this.Load += new System.EventHandler(this.BusyHours_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_hours;
        private System.Windows.Forms.TextBox txt_hour1;
        private System.Windows.Forms.Label lbl_00;
        private System.Windows.Forms.TextBox txt_hour2;
        private System.Windows.Forms.Label lbl_001;
        private System.Windows.Forms.Label lbl_occurrence;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.DateTimePicker dt_date;
        private System.Windows.Forms.Label lbl_firstOccurrence;
        private System.Windows.Forms.ListBox lbx_occurrence;
        private System.Windows.Forms.Label lbl_loading;
    }
}