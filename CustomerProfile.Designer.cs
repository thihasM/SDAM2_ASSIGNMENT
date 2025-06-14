namespace LOGIN_SDAM_ASSIGNMENT
{
    partial class CustomerProfile
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
            cus_edit_btn = new Button();
            cus_delete_account_btn = new Button();
            cus_log_out_btn = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            cus_pro_go_back_btn = new Button();
            Trck_ord_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cus_edit_btn
            // 
            cus_edit_btn.BackColor = Color.Black;
            cus_edit_btn.FlatStyle = FlatStyle.Popup;
            cus_edit_btn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cus_edit_btn.ForeColor = Color.White;
            cus_edit_btn.Location = new Point(343, 130);
            cus_edit_btn.Name = "cus_edit_btn";
            cus_edit_btn.Size = new Size(119, 57);
            cus_edit_btn.TabIndex = 0;
            cus_edit_btn.Text = "Edit Profile";
            cus_edit_btn.UseVisualStyleBackColor = false;
            cus_edit_btn.Click += button1_Click;
            // 
            // cus_delete_account_btn
            // 
            cus_delete_account_btn.BackColor = Color.Black;
            cus_delete_account_btn.Cursor = Cursors.No;
            cus_delete_account_btn.FlatStyle = FlatStyle.Popup;
            cus_delete_account_btn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cus_delete_account_btn.ForeColor = Color.White;
            cus_delete_account_btn.Location = new Point(343, 358);
            cus_delete_account_btn.Name = "cus_delete_account_btn";
            cus_delete_account_btn.Size = new Size(119, 57);
            cus_delete_account_btn.TabIndex = 1;
            cus_delete_account_btn.Text = "Delete Account";
            cus_delete_account_btn.UseVisualStyleBackColor = false;
            // 
            // cus_log_out_btn
            // 
            cus_log_out_btn.BackColor = Color.Black;
            cus_log_out_btn.FlatStyle = FlatStyle.Popup;
            cus_log_out_btn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cus_log_out_btn.ForeColor = Color.White;
            cus_log_out_btn.Location = new Point(343, 277);
            cus_log_out_btn.Name = "cus_log_out_btn";
            cus_log_out_btn.Size = new Size(119, 57);
            cus_log_out_btn.TabIndex = 2;
            cus_log_out_btn.Text = "Log Out";
            cus_log_out_btn.UseVisualStyleBackColor = false;
            cus_log_out_btn.Click += cus_log_out_btn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 28.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(278, 29);
            label2.Name = "label2";
            label2.Size = new Size(257, 56);
            label2.TabIndex = 31;
            label2.Text = "Handiyen";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.PowderBlue;
            pictureBox1.Image = Properties.Resources.d;
            pictureBox1.Location = new Point(689, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(99, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            // 
            // cus_pro_go_back_btn
            // 
            cus_pro_go_back_btn.BackColor = Color.Black;
            cus_pro_go_back_btn.FlatStyle = FlatStyle.Popup;
            cus_pro_go_back_btn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cus_pro_go_back_btn.ForeColor = Color.White;
            cus_pro_go_back_btn.Location = new Point(12, 12);
            cus_pro_go_back_btn.Name = "cus_pro_go_back_btn";
            cus_pro_go_back_btn.Size = new Size(93, 33);
            cus_pro_go_back_btn.TabIndex = 37;
            cus_pro_go_back_btn.Text = "Go Back";
            cus_pro_go_back_btn.UseVisualStyleBackColor = false;
            // 
            // Trck_ord_btn
            // 
            Trck_ord_btn.BackColor = Color.Black;
            Trck_ord_btn.FlatStyle = FlatStyle.Popup;
            Trck_ord_btn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Trck_ord_btn.ForeColor = Color.White;
            Trck_ord_btn.Location = new Point(343, 203);
            Trck_ord_btn.Name = "Trck_ord_btn";
            Trck_ord_btn.Size = new Size(119, 57);
            Trck_ord_btn.TabIndex = 38;
            Trck_ord_btn.Text = "Track Order";
            Trck_ord_btn.UseVisualStyleBackColor = false;
            Trck_ord_btn.Click += Trck_ord_btn_Click;
            // 
            // CustomerProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(Trck_ord_btn);
            Controls.Add(cus_pro_go_back_btn);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(cus_log_out_btn);
            Controls.Add(cus_delete_account_btn);
            Controls.Add(cus_edit_btn);
            Name = "CustomerProfile";
            Text = "CustomerProfile";
            Load += CustomerProfile_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cus_edit_btn;
        private Button cus_delete_account_btn;
        private Button cus_log_out_btn;
        private Label label2;
        private PictureBox pictureBox1;
        private Button cus_pro_go_back_btn;
        private Button Trck_ord_btn;
    }
}