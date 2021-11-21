namespace YourTable
{
    partial class Menu
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
            this.lbl_welcomeBack = new System.Windows.Forms.Label();
            this.btn_changeInfo = new System.Windows.Forms.Button();
            this.btn_yourTimeTable = new System.Windows.Forms.Button();
            this.btn_addTask = new System.Windows.Forms.Button();
            this.btn_busyHours = new System.Windows.Forms.Button();
            this.btn_AllTasks = new System.Windows.Forms.Button();
            this.btn_About = new System.Windows.Forms.Button();
            this.lbl_nextTask = new System.Windows.Forms.Label();
            this.lbl_nextTaskName = new System.Windows.Forms.Label();
            this.lbl_nextTaskTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_welcomeBack
            // 
            this.lbl_welcomeBack.AutoSize = true;
            this.lbl_welcomeBack.BackColor = System.Drawing.Color.Transparent;
            this.lbl_welcomeBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcomeBack.Location = new System.Drawing.Point(252, -2);
            this.lbl_welcomeBack.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_welcomeBack.Name = "lbl_welcomeBack";
            this.lbl_welcomeBack.Size = new System.Drawing.Size(439, 69);
            this.lbl_welcomeBack.TabIndex = 2;
            this.lbl_welcomeBack.Text = "Welcome back!";
            // 
            // btn_changeInfo
            // 
            this.btn_changeInfo.BackColor = System.Drawing.Color.Transparent;
            this.btn_changeInfo.BackgroundImage = global::YourTable.Properties.Resources.info_btn;
            this.btn_changeInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_changeInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_changeInfo.Location = new System.Drawing.Point(724, 92);
            this.btn_changeInfo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_changeInfo.Name = "btn_changeInfo";
            this.btn_changeInfo.Size = new System.Drawing.Size(312, 162);
            this.btn_changeInfo.TabIndex = 3;
            this.btn_changeInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_changeInfo.UseVisualStyleBackColor = false;
            this.btn_changeInfo.Click += new System.EventHandler(this.btn_changeInfo_Click);
            // 
            // btn_yourTimeTable
            // 
            this.btn_yourTimeTable.BackColor = System.Drawing.Color.Transparent;
            this.btn_yourTimeTable.BackgroundImage = global::YourTable.Properties.Resources.timetable_btn;
            this.btn_yourTimeTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_yourTimeTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_yourTimeTable.Location = new System.Drawing.Point(13, 92);
            this.btn_yourTimeTable.Margin = new System.Windows.Forms.Padding(4);
            this.btn_yourTimeTable.Name = "btn_yourTimeTable";
            this.btn_yourTimeTable.Size = new System.Drawing.Size(312, 162);
            this.btn_yourTimeTable.TabIndex = 4;
            this.btn_yourTimeTable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_yourTimeTable.UseVisualStyleBackColor = false;
            this.btn_yourTimeTable.Click += new System.EventHandler(this.btn_yourTimeTable_Click);
            // 
            // btn_addTask
            // 
            this.btn_addTask.BackColor = System.Drawing.Color.Transparent;
            this.btn_addTask.BackgroundImage = global::YourTable.Properties.Resources.btn_new_tasks;
            this.btn_addTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_addTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addTask.Location = new System.Drawing.Point(724, 300);
            this.btn_addTask.Margin = new System.Windows.Forms.Padding(4);
            this.btn_addTask.Name = "btn_addTask";
            this.btn_addTask.Size = new System.Drawing.Size(312, 162);
            this.btn_addTask.TabIndex = 5;
            this.btn_addTask.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_addTask.UseVisualStyleBackColor = false;
            this.btn_addTask.Click += new System.EventHandler(this.btn_addTask_Click);
            // 
            // btn_busyHours
            // 
            this.btn_busyHours.BackColor = System.Drawing.Color.Transparent;
            this.btn_busyHours.BackgroundImage = global::YourTable.Properties.Resources.busy_hours_btn;
            this.btn_busyHours.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_busyHours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_busyHours.Location = new System.Drawing.Point(13, 300);
            this.btn_busyHours.Margin = new System.Windows.Forms.Padding(4);
            this.btn_busyHours.Name = "btn_busyHours";
            this.btn_busyHours.Size = new System.Drawing.Size(312, 162);
            this.btn_busyHours.TabIndex = 6;
            this.btn_busyHours.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_busyHours.UseVisualStyleBackColor = false;
            this.btn_busyHours.Click += new System.EventHandler(this.btn_busyHours_Click);
            // 
            // btn_AllTasks
            // 
            this.btn_AllTasks.BackColor = System.Drawing.Color.Transparent;
            this.btn_AllTasks.BackgroundImage = global::YourTable.Properties.Resources.All_tasks_btn;
            this.btn_AllTasks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_AllTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AllTasks.Location = new System.Drawing.Point(379, 174);
            this.btn_AllTasks.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AllTasks.Name = "btn_AllTasks";
            this.btn_AllTasks.Size = new System.Drawing.Size(312, 162);
            this.btn_AllTasks.TabIndex = 7;
            this.btn_AllTasks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_AllTasks.UseVisualStyleBackColor = false;
            this.btn_AllTasks.Click += new System.EventHandler(this.btn_AllTasks_Click);
            // 
            // btn_About
            // 
            this.btn_About.BackColor = System.Drawing.Color.Transparent;
            this.btn_About.BackgroundImage = global::YourTable.Properties.Resources.btn_about;
            this.btn_About.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_About.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_About.Location = new System.Drawing.Point(13, 474);
            this.btn_About.Name = "btn_About";
            this.btn_About.Size = new System.Drawing.Size(77, 68);
            this.btn_About.TabIndex = 8;
            this.btn_About.UseVisualStyleBackColor = false;
            this.btn_About.Click += new System.EventHandler(this.btn_About_Click);
            // 
            // lbl_nextTask
            // 
            this.lbl_nextTask.AutoSize = true;
            this.lbl_nextTask.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nextTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nextTask.Location = new System.Drawing.Point(359, 487);
            this.lbl_nextTask.Name = "lbl_nextTask";
            this.lbl_nextTask.Size = new System.Drawing.Size(149, 64);
            this.lbl_nextTask.TabIndex = 9;
            this.lbl_nextTask.Text = "Next Task:\r\nTime:";
            // 
            // lbl_nextTaskName
            // 
            this.lbl_nextTaskName.AutoSize = true;
            this.lbl_nextTaskName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nextTaskName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_nextTaskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nextTaskName.ForeColor = System.Drawing.Color.Blue;
            this.lbl_nextTaskName.Location = new System.Drawing.Point(503, 487);
            this.lbl_nextTaskName.Name = "lbl_nextTaskName";
            this.lbl_nextTaskName.Size = new System.Drawing.Size(83, 32);
            this.lbl_nextTaskName.TabIndex = 10;
            this.lbl_nextTaskName.Text = "None";
            this.lbl_nextTaskName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_nextTaskName.Click += new System.EventHandler(this.lbl_nextTaskName_Click);
            // 
            // lbl_nextTaskTime
            // 
            this.lbl_nextTaskTime.AutoSize = true;
            this.lbl_nextTaskTime.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nextTaskTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_nextTaskTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nextTaskTime.ForeColor = System.Drawing.Color.Blue;
            this.lbl_nextTaskTime.Location = new System.Drawing.Point(442, 519);
            this.lbl_nextTaskTime.Name = "lbl_nextTaskTime";
            this.lbl_nextTaskTime.Size = new System.Drawing.Size(83, 32);
            this.lbl_nextTaskTime.TabIndex = 11;
            this.lbl_nextTaskTime.Text = "None";
            this.lbl_nextTaskTime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_nextTaskTime.UseMnemonic = false;
            this.lbl_nextTaskTime.Click += new System.EventHandler(this.lbl_nextTaskTime_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::YourTable.Properties.Resources.pink_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lbl_nextTaskTime);
            this.Controls.Add(this.lbl_nextTaskName);
            this.Controls.Add(this.lbl_nextTask);
            this.Controls.Add(this.btn_About);
            this.Controls.Add(this.btn_AllTasks);
            this.Controls.Add(this.btn_busyHours);
            this.Controls.Add(this.btn_addTask);
            this.Controls.Add(this.btn_yourTimeTable);
            this.Controls.Add(this.btn_changeInfo);
            this.Controls.Add(this.lbl_welcomeBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YourTable";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_Close);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_welcomeBack;
        private System.Windows.Forms.Button btn_changeInfo;
        private System.Windows.Forms.Button btn_yourTimeTable;
        private System.Windows.Forms.Button btn_addTask;
        private System.Windows.Forms.Button btn_busyHours;
        private System.Windows.Forms.Button btn_AllTasks;
        private System.Windows.Forms.Button btn_About;
        private System.Windows.Forms.Label lbl_nextTask;
        private System.Windows.Forms.Label lbl_nextTaskName;
        private System.Windows.Forms.Label lbl_nextTaskTime;
    }
}