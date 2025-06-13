namespace LOGIN_SDAM_ASSIGNMENT
{
    partial class ResturantProfile
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
            res_edit_btn = new Button();
            res_review_comments_btn = new Button();
            res_log_out_btn = new Button();
            res_delete_account_btn = new Button();
            res_edit_food_menu_btn = new Button();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            res_back_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // res_edit_btn
            // 
            res_edit_btn.BackColor = Color.Black;
            res_edit_btn.FlatStyle = FlatStyle.Popup;
            res_edit_btn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            res_edit_btn.ForeColor = SystemColors.Control;
            res_edit_btn.Location = new Point(297, 113);
            res_edit_btn.Name = "res_edit_btn";
            res_edit_btn.Size = new Size(203, 55);
            res_edit_btn.TabIndex = 0;
            res_edit_btn.Text = "Edit Profile";
            res_edit_btn.UseVisualStyleBackColor = false;
            // 
            // res_review_comments_btn
            // 
            res_review_comments_btn.BackColor = Color.Black;
            res_review_comments_btn.FlatStyle = FlatStyle.Popup;
            res_review_comments_btn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            res_review_comments_btn.ForeColor = SystemColors.Control;
            res_review_comments_btn.Location = new Point(297, 174);
            res_review_comments_btn.Name = "res_review_comments_btn";
            res_review_comments_btn.Size = new Size(203, 55);
            res_review_comments_btn.TabIndex = 1;
            res_review_comments_btn.Text = "Review Comments";
            res_review_comments_btn.UseVisualStyleBackColor = false;
            res_review_comments_btn.Click += button2_Click;
            // 
            // res_log_out_btn
            // 
            res_log_out_btn.BackColor = Color.Black;
            res_log_out_btn.FlatStyle = FlatStyle.Popup;
            res_log_out_btn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            res_log_out_btn.ForeColor = SystemColors.Control;
            res_log_out_btn.Location = new Point(297, 295);
            res_log_out_btn.Name = "res_log_out_btn";
            res_log_out_btn.Size = new Size(203, 55);
            res_log_out_btn.TabIndex = 2;
            res_log_out_btn.Text = "Log Out";
            res_log_out_btn.UseVisualStyleBackColor = false;
            // 
            // res_delete_account_btn
            // 
            res_delete_account_btn.BackColor = Color.Black;
            res_delete_account_btn.FlatStyle = FlatStyle.Popup;
            res_delete_account_btn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            res_delete_account_btn.ForeColor = SystemColors.Control;
            res_delete_account_btn.Location = new Point(297, 356);
            res_delete_account_btn.Name = "res_delete_account_btn";
            res_delete_account_btn.Size = new Size(203, 55);
            res_delete_account_btn.TabIndex = 3;
            res_delete_account_btn.Text = "Delete Account";
            res_delete_account_btn.UseVisualStyleBackColor = false;
            // 
            // res_edit_food_menu_btn
            // 
            res_edit_food_menu_btn.BackColor = Color.Black;
            res_edit_food_menu_btn.FlatStyle = FlatStyle.Popup;
            res_edit_food_menu_btn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            res_edit_food_menu_btn.ForeColor = SystemColors.Control;
            res_edit_food_menu_btn.Location = new Point(297, 235);
            res_edit_food_menu_btn.Name = "res_edit_food_menu_btn";
            res_edit_food_menu_btn.Size = new Size(203, 55);
            res_edit_food_menu_btn.TabIndex = 4;
            res_edit_food_menu_btn.Text = "Edit Food Menu";
            res_edit_food_menu_btn.UseVisualStyleBackColor = false;
            res_edit_food_menu_btn.Click += res_edit_food_menu_btn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Stencil", 28.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(271, 26);
            label4.Name = "label4";
            label4.Size = new Size(257, 56);
            label4.TabIndex = 9;
            label4.Text = "Handiyen";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.PowderBlue;
            pictureBox1.Image = Properties.Resources.d;
            pictureBox1.Location = new Point(689, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(99, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // res_back_btn
            // 
            res_back_btn.BackColor = Color.Black;
            res_back_btn.FlatStyle = FlatStyle.Popup;
            res_back_btn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            res_back_btn.ForeColor = SystemColors.Control;
            res_back_btn.Location = new Point(12, 12);
            res_back_btn.Name = "res_back_btn";
            res_back_btn.Size = new Size(93, 33);
            res_back_btn.TabIndex = 11;
            res_back_btn.Text = "Go Back";
            res_back_btn.UseVisualStyleBackColor = false;
            // 
            // ResturantProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(res_back_btn);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(res_edit_food_menu_btn);
            Controls.Add(res_delete_account_btn);
            Controls.Add(res_log_out_btn);
            Controls.Add(res_review_comments_btn);
            Controls.Add(res_edit_btn);
            Name = "ResturantProfile";
            Text = "ResturantProfile";
            Load += ResturantProfile_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button res_edit_btn;
        private Button res_review_comments_btn;
        private Button res_log_out_btn;
        private Button res_delete_account_btn;
        private Button res_edit_food_menu_btn;
        private Label label4;
        private PictureBox pictureBox1;
        private Button res_back_btn;
    }
}