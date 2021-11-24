namespace YourTable
{
    partial class TasksList
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
            this.lbx_tasks = new System.Windows.Forms.ListBox();
            this.btn_goToTask = new System.Windows.Forms.Button();
            this.btn_deleateTask = new System.Windows.Forms.Button();
            this.btn_goBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_title.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_title.Location = new System.Drawing.Point(380, 11);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(213, 52);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Tasks List";
            // 
            // lbx_tasks
            // 
            this.lbx_tasks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbx_tasks.Font = new System.Drawing.Font("Minecraft", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbx_tasks.FormattingEnabled = true;
            this.lbx_tasks.ItemHeight = 36;
            this.lbx_tasks.Location = new System.Drawing.Point(25, 110);
            this.lbx_tasks.Margin = new System.Windows.Forms.Padding(4);
            this.lbx_tasks.Name = "lbx_tasks";
            this.lbx_tasks.Size = new System.Drawing.Size(637, 292);
            this.lbx_tasks.TabIndex = 1;
            this.lbx_tasks.SelectedIndexChanged += new System.EventHandler(this.lbx_tasks_SelectedIndexChanged);
            // 
            // btn_goToTask
            // 
            this.btn_goToTask.BackColor = System.Drawing.Color.Transparent;
            this.btn_goToTask.Font = new System.Drawing.Font("Minecraft", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_goToTask.Location = new System.Drawing.Point(724, 110);
            this.btn_goToTask.Margin = new System.Windows.Forms.Padding(4);
            this.btn_goToTask.Name = "btn_goToTask";
            this.btn_goToTask.Size = new System.Drawing.Size(295, 143);
            this.btn_goToTask.TabIndex = 2;
            this.btn_goToTask.Text = "Go to task";
            this.btn_goToTask.UseVisualStyleBackColor = false;
            this.btn_goToTask.Visible = false;
            this.btn_goToTask.Click += new System.EventHandler(this.btn_goToTask_Click);
            // 
            // btn_deleateTask
            // 
            this.btn_deleateTask.BackColor = System.Drawing.Color.Transparent;
            this.btn_deleateTask.Font = new System.Drawing.Font("Minecraft", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleateTask.Location = new System.Drawing.Point(724, 279);
            this.btn_deleateTask.Margin = new System.Windows.Forms.Padding(4);
            this.btn_deleateTask.Name = "btn_deleateTask";
            this.btn_deleateTask.Size = new System.Drawing.Size(295, 143);
            this.btn_deleateTask.TabIndex = 3;
            this.btn_deleateTask.Text = "Delete task";
            this.btn_deleateTask.UseVisualStyleBackColor = false;
            this.btn_deleateTask.Visible = false;
            this.btn_deleateTask.Click += new System.EventHandler(this.btn_deleateTask_Click);
            // 
            // btn_goBack
            // 
            this.btn_goBack.BackColor = System.Drawing.Color.Transparent;
            this.btn_goBack.Font = new System.Drawing.Font("Minecraft", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_goBack.Location = new System.Drawing.Point(247, 459);
            this.btn_goBack.Margin = new System.Windows.Forms.Padding(4);
            this.btn_goBack.Name = "btn_goBack";
            this.btn_goBack.Size = new System.Drawing.Size(182, 82);
            this.btn_goBack.TabIndex = 4;
            this.btn_goBack.Text = "Go back";
            this.btn_goBack.UseVisualStyleBackColor = false;
            this.btn_goBack.Click += new System.EventHandler(this.btn_goBack_Click);
            // 
            // TasksList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::YourTable.Properties.Resources.pink_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1030, 548);
            this.Controls.Add(this.btn_goBack);
            this.Controls.Add(this.btn_deleateTask);
            this.Controls.Add(this.btn_goToTask);
            this.Controls.Add(this.lbx_tasks);
            this.Controls.Add(this.lbl_title);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TasksList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YourTable";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.End_Program);
            this.Load += new System.EventHandler(this.TasksList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.ListBox lbx_tasks;
        private System.Windows.Forms.Button btn_goToTask;
        private System.Windows.Forms.Button btn_deleateTask;
        private System.Windows.Forms.Button btn_goBack;
    }
}