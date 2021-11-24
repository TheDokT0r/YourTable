namespace YourTable
{
    partial class YourTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YourTable));
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_desc = new System.Windows.Forms.Label();
            this.btn_goBack = new System.Windows.Forms.Button();
            this.img_gitHub = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.img_gitHub)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(459, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(147, 51);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "About:";
            // 
            // lbl_desc
            // 
            this.lbl_desc.AutoSize = true;
            this.lbl_desc.BackColor = System.Drawing.Color.Transparent;
            this.lbl_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_desc.Location = new System.Drawing.Point(142, 60);
            this.lbl_desc.Name = "lbl_desc";
            this.lbl_desc.Size = new System.Drawing.Size(837, 348);
            this.lbl_desc.TabIndex = 1;
            this.lbl_desc.Text = resources.GetString("lbl_desc.Text");
            this.lbl_desc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_goBack
            // 
            this.btn_goBack.BackColor = System.Drawing.Color.Transparent;
            this.btn_goBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_goBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_goBack.Location = new System.Drawing.Point(439, 499);
            this.btn_goBack.Name = "btn_goBack";
            this.btn_goBack.Size = new System.Drawing.Size(167, 56);
            this.btn_goBack.TabIndex = 3;
            this.btn_goBack.Text = "Go Back";
            this.btn_goBack.UseVisualStyleBackColor = false;
            this.btn_goBack.Click += new System.EventHandler(this.btn_goBack_Click);
            // 
            // img_gitHub
            // 
            this.img_gitHub.BackColor = System.Drawing.Color.Transparent;
            this.img_gitHub.BackgroundImage = global::YourTable.Properties.Resources.btn_github;
            this.img_gitHub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.img_gitHub.Image = global::YourTable.Properties.Resources.btn_github;
            this.img_gitHub.Location = new System.Drawing.Point(479, 415);
            this.img_gitHub.Name = "img_gitHub";
            this.img_gitHub.Size = new System.Drawing.Size(84, 78);
            this.img_gitHub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_gitHub.TabIndex = 4;
            this.img_gitHub.TabStop = false;
            this.img_gitHub.Click += new System.EventHandler(this.img_gitHub_Click);
            // 
            // YourTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::YourTable.Properties.Resources.pink_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.img_gitHub);
            this.Controls.Add(this.btn_goBack);
            this.Controls.Add(this.lbl_desc);
            this.Controls.Add(this.lbl_title);
            this.Name = "YourTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AboutPage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AboutPage_FormClosing);
            this.Load += new System.EventHandler(this.AboutPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_gitHub)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_desc;
        private System.Windows.Forms.Button btn_goBack;
        private System.Windows.Forms.PictureBox img_gitHub;
    }
}