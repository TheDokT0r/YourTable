namespace YourTable
{
    partial class AddTask
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
            this.lbl_Task = new System.Windows.Forms.Label();
            this.lbl_taskName = new System.Windows.Forms.Label();
            this.lbl_ = new System.Windows.Forms.Label();
            this.lbl_priority = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_hours = new System.Windows.Forms.TextBox();
            this.cmb_priority = new System.Windows.Forms.ComboBox();
            this.dt_complition = new System.Windows.Forms.DateTimePicker();
            this.btn_done = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.img_sticker = new System.Windows.Forms.PictureBox();
            this.lbl_hour = new System.Windows.Forms.Label();
            this.txb_hour = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.img_sticker)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Task
            // 
            this.lbl_Task.AutoEllipsis = true;
            this.lbl_Task.AutoSize = true;
            this.lbl_Task.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Task.Font = new System.Drawing.Font("MV Boli", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Task.Location = new System.Drawing.Point(291, 11);
            this.lbl_Task.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Task.Name = "lbl_Task";
            this.lbl_Task.Size = new System.Drawing.Size(408, 105);
            this.lbl_Task.TabIndex = 0;
            this.lbl_Task.Text = "New Task";
            // 
            // lbl_taskName
            // 
            this.lbl_taskName.AutoSize = true;
            this.lbl_taskName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_taskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_taskName.Location = new System.Drawing.Point(101, 183);
            this.lbl_taskName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_taskName.Name = "lbl_taskName";
            this.lbl_taskName.Size = new System.Drawing.Size(157, 36);
            this.lbl_taskName.TabIndex = 1;
            this.lbl_taskName.Text = "task name:";
            // 
            // lbl_
            // 
            this.lbl_.AutoSize = true;
            this.lbl_.BackColor = System.Drawing.Color.Transparent;
            this.lbl_.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_.Location = new System.Drawing.Point(101, 266);
            this.lbl_.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_.Name = "lbl_";
            this.lbl_.Size = new System.Drawing.Size(444, 72);
            this.lbl_.TabIndex = 2;
            this.lbl_.Text = "how much time it would take you\r\nto complete the task (hours):\r\n";
            // 
            // lbl_priority
            // 
            this.lbl_priority.AutoSize = true;
            this.lbl_priority.BackColor = System.Drawing.Color.Transparent;
            this.lbl_priority.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_priority.Location = new System.Drawing.Point(101, 388);
            this.lbl_priority.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_priority.Name = "lbl_priority";
            this.lbl_priority.Size = new System.Drawing.Size(114, 36);
            this.lbl_priority.TabIndex = 3;
            this.lbl_priority.Text = "priority:";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.BackColor = System.Drawing.Color.Transparent;
            this.lbl_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.Location = new System.Drawing.Point(101, 498);
            this.lbl_date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(265, 36);
            this.lbl_date.TabIndex = 4;
            this.lbl_date.Text = "date of completion:";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(280, 185);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(195, 30);
            this.txt_name.TabIndex = 5;
            // 
            // txt_hours
            // 
            this.txt_hours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hours.Location = new System.Drawing.Point(569, 308);
            this.txt_hours.Margin = new System.Windows.Forms.Padding(4);
            this.txt_hours.Name = "txt_hours";
            this.txt_hours.Size = new System.Drawing.Size(113, 30);
            this.txt_hours.TabIndex = 6;
            // 
            // cmb_priority
            // 
            this.cmb_priority.FormattingEnabled = true;
            this.cmb_priority.Items.AddRange(new object[] {
            "low",
            "normal",
            "high",
            "very high",
            "D E A T H"});
            this.cmb_priority.Location = new System.Drawing.Point(232, 398);
            this.cmb_priority.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_priority.Name = "cmb_priority";
            this.cmb_priority.Size = new System.Drawing.Size(160, 24);
            this.cmb_priority.TabIndex = 7;
            // 
            // dt_complition
            // 
            this.dt_complition.Location = new System.Drawing.Point(374, 509);
            this.dt_complition.Margin = new System.Windows.Forms.Padding(4);
            this.dt_complition.Name = "dt_complition";
            this.dt_complition.Size = new System.Drawing.Size(265, 22);
            this.dt_complition.TabIndex = 8;
            // 
            // btn_done
            // 
            this.btn_done.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_done.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_done.Location = new System.Drawing.Point(865, 260);
            this.btn_done.Margin = new System.Windows.Forms.Padding(4);
            this.btn_done.Name = "btn_done";
            this.btn_done.Size = new System.Drawing.Size(185, 78);
            this.btn_done.TabIndex = 9;
            this.btn_done.Text = "Done";
            this.btn_done.UseVisualStyleBackColor = false;
            this.btn_done.Click += new System.EventHandler(this.btn_done_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(865, 361);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(185, 78);
            this.btn_back.TabIndex = 11;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // img_sticker
            // 
            this.img_sticker.BackColor = System.Drawing.Color.Transparent;
            this.img_sticker.Location = new System.Drawing.Point(719, 11);
            this.img_sticker.Margin = new System.Windows.Forms.Padding(4);
            this.img_sticker.Name = "img_sticker";
            this.img_sticker.Size = new System.Drawing.Size(351, 224);
            this.img_sticker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_sticker.TabIndex = 14;
            this.img_sticker.TabStop = false;
            this.img_sticker.Click += new System.EventHandler(this.img_sticker_Click);
            // 
            // lbl_hour
            // 
            this.lbl_hour.AutoSize = true;
            this.lbl_hour.BackColor = System.Drawing.Color.Transparent;
            this.lbl_hour.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hour.Location = new System.Drawing.Point(663, 498);
            this.lbl_hour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_hour.Name = "lbl_hour";
            this.lbl_hour.Size = new System.Drawing.Size(84, 36);
            this.lbl_hour.TabIndex = 15;
            this.lbl_hour.Text = "hour:";
            // 
            // txb_hour
            // 
            this.txb_hour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_hour.Location = new System.Drawing.Point(755, 501);
            this.txb_hour.Margin = new System.Windows.Forms.Padding(4);
            this.txb_hour.Name = "txb_hour";
            this.txb_hour.Size = new System.Drawing.Size(113, 30);
            this.txb_hour.TabIndex = 16;
            // 
            // AddTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::YourTable.Properties.Resources.pink_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.txb_hour);
            this.Controls.Add(this.lbl_hour);
            this.Controls.Add(this.img_sticker);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_done);
            this.Controls.Add(this.dt_complition);
            this.Controls.Add(this.cmb_priority);
            this.Controls.Add(this.txt_hours);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_priority);
            this.Controls.Add(this.lbl_);
            this.Controls.Add(this.lbl_taskName);
            this.Controls.Add(this.lbl_Task);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YourTable";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddTask_Close);
            this.Load += new System.EventHandler(this.AddTask_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_sticker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Task;
        private System.Windows.Forms.Label lbl_taskName;
        private System.Windows.Forms.Label lbl_;
        private System.Windows.Forms.Label lbl_priority;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_hours;
        private System.Windows.Forms.ComboBox cmb_priority;
        private System.Windows.Forms.DateTimePicker dt_complition;
        private System.Windows.Forms.Button btn_done;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.PictureBox img_sticker;
        private System.Windows.Forms.Label lbl_hour;
        private System.Windows.Forms.TextBox txb_hour;
    }
}