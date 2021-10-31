namespace YourTable
{
    partial class Task_Information
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
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_priority = new System.Windows.Forms.Label();
            this.lbl_completionDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbx_workDates = new System.Windows.Forms.ListBox();
            this.btn_goToDate = new System.Windows.Forms.Button();
            this.lbl_count = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.img_sticker = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.img_sticker)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_title.Font = new System.Drawing.Font("MV Boli", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(309, -16);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(407, 105);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Task Logs";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(107, 113);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(355, 46);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Name: placeholder";
            // 
            // lbl_priority
            // 
            this.lbl_priority.AutoSize = true;
            this.lbl_priority.BackColor = System.Drawing.Color.Transparent;
            this.lbl_priority.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_priority.Location = new System.Drawing.Point(107, 182);
            this.lbl_priority.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_priority.Name = "lbl_priority";
            this.lbl_priority.Size = new System.Drawing.Size(374, 46);
            this.lbl_priority.TabIndex = 2;
            this.lbl_priority.Text = "Priority: placeholder";
            // 
            // lbl_completionDate
            // 
            this.lbl_completionDate.AutoSize = true;
            this.lbl_completionDate.BackColor = System.Drawing.Color.Transparent;
            this.lbl_completionDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_completionDate.Location = new System.Drawing.Point(107, 252);
            this.lbl_completionDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_completionDate.Name = "lbl_completionDate";
            this.lbl_completionDate.Size = new System.Drawing.Size(547, 46);
            this.lbl_completionDate.TabIndex = 3;
            this.lbl_completionDate.Text = "Completion Date: placeholder";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 394);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "Work Dates:";
            // 
            // lbx_workDates
            // 
            this.lbx_workDates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbx_workDates.Font = new System.Drawing.Font("Minecraft", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbx_workDates.FormattingEnabled = true;
            this.lbx_workDates.ItemHeight = 24;
            this.lbx_workDates.Location = new System.Drawing.Point(355, 382);
            this.lbx_workDates.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbx_workDates.Name = "lbx_workDates";
            this.lbx_workDates.Size = new System.Drawing.Size(288, 148);
            this.lbx_workDates.TabIndex = 5;
            this.lbx_workDates.SelectedIndexChanged += new System.EventHandler(this.SelectedItem);
            // 
            // btn_goToDate
            // 
            this.btn_goToDate.BackColor = System.Drawing.Color.Transparent;
            this.btn_goToDate.CausesValidation = false;
            this.btn_goToDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_goToDate.Font = new System.Drawing.Font("Minecraft", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_goToDate.Location = new System.Drawing.Point(804, 372);
            this.btn_goToDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_goToDate.Name = "btn_goToDate";
            this.btn_goToDate.Size = new System.Drawing.Size(248, 89);
            this.btn_goToDate.TabIndex = 6;
            this.btn_goToDate.Text = "Go to date";
            this.btn_goToDate.UseVisualStyleBackColor = false;
            this.btn_goToDate.Visible = false;
            this.btn_goToDate.Click += new System.EventHandler(this.btn_goToDate_Click);
            // 
            // lbl_count
            // 
            this.lbl_count.AutoSize = true;
            this.lbl_count.BackColor = System.Drawing.Color.Transparent;
            this.lbl_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_count.Location = new System.Drawing.Point(107, 322);
            this.lbl_count.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_count.Name = "lbl_count";
            this.lbl_count.Size = new System.Drawing.Size(471, 46);
            this.lbl_count.TabIndex = 7;
            this.lbl_count.Text = "Dates Count: placeholder";
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancel.CausesValidation = false;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Minecraft", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(879, 486);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(173, 54);
            this.btn_cancel.TabIndex = 8;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // img_sticker
            // 
            this.img_sticker.BackColor = System.Drawing.Color.Transparent;
            this.img_sticker.Location = new System.Drawing.Point(755, 12);
            this.img_sticker.Name = "img_sticker";
            this.img_sticker.Size = new System.Drawing.Size(300, 212);
            this.img_sticker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_sticker.TabIndex = 9;
            this.img_sticker.TabStop = false;
            // 
            // Task_Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::YourTable.Properties.Resources.pink_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.img_sticker);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.lbl_count);
            this.Controls.Add(this.btn_goToDate);
            this.Controls.Add(this.lbx_workDates);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_completionDate);
            this.Controls.Add(this.lbl_priority);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Task_Information";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task_Information";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.From_Closing);
            this.Load += new System.EventHandler(this.Task_Information_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_sticker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_priority;
        private System.Windows.Forms.Label lbl_completionDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbx_workDates;
        private System.Windows.Forms.Button btn_goToDate;
        private System.Windows.Forms.Label lbl_count;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.PictureBox img_sticker;
    }
}