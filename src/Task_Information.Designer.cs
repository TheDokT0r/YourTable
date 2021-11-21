﻿namespace YourTable
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
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.img_sticker)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_title.Font = new System.Drawing.Font("MV Boli", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(232, -13);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(326, 85);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Task Logs";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(12, 95);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(286, 37);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Name: placeholder";
            // 
            // lbl_priority
            // 
            this.lbl_priority.AutoSize = true;
            this.lbl_priority.BackColor = System.Drawing.Color.Transparent;
            this.lbl_priority.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_priority.Location = new System.Drawing.Point(12, 151);
            this.lbl_priority.Name = "lbl_priority";
            this.lbl_priority.Size = new System.Drawing.Size(299, 37);
            this.lbl_priority.TabIndex = 2;
            this.lbl_priority.Text = "Priority: placeholder";
            // 
            // lbl_completionDate
            // 
            this.lbl_completionDate.AutoSize = true;
            this.lbl_completionDate.BackColor = System.Drawing.Color.Transparent;
            this.lbl_completionDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_completionDate.Location = new System.Drawing.Point(12, 208);
            this.lbl_completionDate.Name = "lbl_completionDate";
            this.lbl_completionDate.Size = new System.Drawing.Size(438, 37);
            this.lbl_completionDate.TabIndex = 3;
            this.lbl_completionDate.Text = "Completion Date: placeholder";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Work Dates:";
            // 
            // lbx_workDates
            // 
            this.lbx_workDates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbx_workDates.Font = new System.Drawing.Font("Minecraft", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbx_workDates.FormattingEnabled = true;
            this.lbx_workDates.ItemHeight = 19;
            this.lbx_workDates.Location = new System.Drawing.Point(198, 313);
            this.lbx_workDates.Name = "lbx_workDates";
            this.lbx_workDates.Size = new System.Drawing.Size(217, 118);
            this.lbx_workDates.TabIndex = 5;
            this.lbx_workDates.SelectedIndexChanged += new System.EventHandler(this.SelectedItem);
            // 
            // btn_goToDate
            // 
            this.btn_goToDate.BackColor = System.Drawing.Color.Transparent;
            this.btn_goToDate.CausesValidation = false;
            this.btn_goToDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_goToDate.Font = new System.Drawing.Font("Minecraft", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_goToDate.Location = new System.Drawing.Point(603, 305);
            this.btn_goToDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_goToDate.Name = "btn_goToDate";
            this.btn_goToDate.Size = new System.Drawing.Size(186, 72);
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
            this.lbl_count.Location = new System.Drawing.Point(12, 265);
            this.lbl_count.Name = "lbl_count";
            this.lbl_count.Size = new System.Drawing.Size(378, 37);
            this.lbl_count.TabIndex = 7;
            this.lbl_count.Text = "Dates Count: placeholder";
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancel.CausesValidation = false;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Minecraft", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(659, 387);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(130, 44);
            this.btn_cancel.TabIndex = 8;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // img_sticker
            // 
            this.img_sticker.BackColor = System.Drawing.Color.Transparent;
            this.img_sticker.Location = new System.Drawing.Point(564, 16);
            this.img_sticker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.img_sticker.Name = "img_sticker";
            this.img_sticker.Size = new System.Drawing.Size(225, 172);
            this.img_sticker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_sticker.TabIndex = 9;
            this.img_sticker.TabStop = false;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Transparent;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Minecraft", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(420, 313);
            this.btn_add.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(86, 31);
            this.btn_add.TabIndex = 10;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.BackColor = System.Drawing.Color.Transparent;
            this.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove.Font = new System.Drawing.Font("Minecraft", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove.Location = new System.Drawing.Point(420, 356);
            this.btn_remove.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(86, 31);
            this.btn_remove.TabIndex = 11;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = false;
            this.btn_remove.Visible = false;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // Task_Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::YourTable.Properties.Resources.pink_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_add);
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
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_remove;
    }
}