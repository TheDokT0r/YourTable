namespace YourTable
{
    partial class Questions
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
            this.img_title = new System.Windows.Forms.PictureBox();
            this.lbl_question = new System.Windows.Forms.Label();
            this.txt_answer = new System.Windows.Forms.TextBox();
            this.btn_next = new System.Windows.Forms.Button();
            this.cmb_options = new System.Windows.Forms.ComboBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.img_sticker = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.img_title)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_sticker)).BeginInit();
            this.SuspendLayout();
            // 
            // img_title
            // 
            this.img_title.BackColor = System.Drawing.Color.Transparent;
            this.img_title.Image = global::YourTable.Properties.Resources.Some_questions_before_we_begin;
            this.img_title.Location = new System.Drawing.Point(229, -70);
            this.img_title.Margin = new System.Windows.Forms.Padding(4);
            this.img_title.Name = "img_title";
            this.img_title.Size = new System.Drawing.Size(643, 300);
            this.img_title.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_title.TabIndex = 0;
            this.img_title.TabStop = false;
            // 
            // lbl_question
            // 
            this.lbl_question.AutoSize = true;
            this.lbl_question.BackColor = System.Drawing.Color.Transparent;
            this.lbl_question.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_question.Location = new System.Drawing.Point(377, 163);
            this.lbl_question.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_question.Name = "lbl_question";
            this.lbl_question.Size = new System.Drawing.Size(302, 40);
            this.lbl_question.TabIndex = 1;
            this.lbl_question.Text = "question placeholder";
            this.lbl_question.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_question.Click += new System.EventHandler(this.lbl_question_Click);
            // 
            // txt_answer
            // 
            this.txt_answer.Location = new System.Drawing.Point(407, 281);
            this.txt_answer.Margin = new System.Windows.Forms.Padding(4);
            this.txt_answer.Name = "txt_answer";
            this.txt_answer.Size = new System.Drawing.Size(220, 22);
            this.txt_answer.TabIndex = 2;
            this.txt_answer.TextChanged += new System.EventHandler(this.txt_answer_TextChanged);
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.Color.Transparent;
            this.btn_next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_next.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next.Location = new System.Drawing.Point(423, 363);
            this.btn_next.Margin = new System.Windows.Forms.Padding(4);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(183, 68);
            this.btn_next.TabIndex = 3;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // cmb_options
            // 
            this.cmb_options.FormattingEnabled = true;
            this.cmb_options.Items.AddRange(new object[] {
            "\"None\""});
            this.cmb_options.Location = new System.Drawing.Point(407, 279);
            this.cmb_options.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_options.Name = "cmb_options";
            this.cmb_options.Size = new System.Drawing.Size(220, 24);
            this.cmb_options.TabIndex = 5;
            this.cmb_options.SelectedIndexChanged += new System.EventHandler(this.cmb_options_SelectedIndexChanged);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancel.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(423, 462);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(183, 68);
            this.btn_cancel.TabIndex = 6;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // img_sticker
            // 
            this.img_sticker.BackColor = System.Drawing.Color.Transparent;
            this.img_sticker.Location = new System.Drawing.Point(786, 336);
            this.img_sticker.Name = "img_sticker";
            this.img_sticker.Size = new System.Drawing.Size(269, 206);
            this.img_sticker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_sticker.TabIndex = 7;
            this.img_sticker.TabStop = false;
            // 
            // Questions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.BackgroundImage = global::YourTable.Properties.Resources.pink_background;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.img_sticker);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.cmb_options);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.txt_answer);
            this.Controls.Add(this.lbl_question);
            this.Controls.Add(this.img_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Questions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YourTable";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Questios_Close);
            this.Load += new System.EventHandler(this.Questions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_title)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_sticker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox img_title;
        private System.Windows.Forms.Label lbl_question;
        private System.Windows.Forms.TextBox txt_answer;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.ComboBox cmb_options;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.PictureBox img_sticker;
    }
}