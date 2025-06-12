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
            SuspendLayout();
            // 
            // res_edit_btn
            // 
            res_edit_btn.Location = new Point(296, 86);
            res_edit_btn.Name = "res_edit_btn";
            res_edit_btn.Size = new Size(152, 55);
            res_edit_btn.TabIndex = 0;
            res_edit_btn.Text = "Edit Profile";
            res_edit_btn.UseVisualStyleBackColor = true;
            // 
            // res_review_comments_btn
            // 
            res_review_comments_btn.Location = new Point(296, 147);
            res_review_comments_btn.Name = "res_review_comments_btn";
            res_review_comments_btn.Size = new Size(152, 55);
            res_review_comments_btn.TabIndex = 1;
            res_review_comments_btn.Text = "Review Comments";
            res_review_comments_btn.UseVisualStyleBackColor = true;
            res_review_comments_btn.Click += button2_Click;
            // 
            // res_log_out_btn
            // 
            res_log_out_btn.Location = new Point(296, 208);
            res_log_out_btn.Name = "res_log_out_btn";
            res_log_out_btn.Size = new Size(152, 55);
            res_log_out_btn.TabIndex = 2;
            res_log_out_btn.Text = "Log Out";
            res_log_out_btn.UseVisualStyleBackColor = true;
            // 
            // res_delete_account_btn
            // 
            res_delete_account_btn.Location = new Point(296, 269);
            res_delete_account_btn.Name = "res_delete_account_btn";
            res_delete_account_btn.Size = new Size(152, 55);
            res_delete_account_btn.TabIndex = 3;
            res_delete_account_btn.Text = "Delete Account";
            res_delete_account_btn.UseVisualStyleBackColor = true;
            // 
            // ResturantProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(res_delete_account_btn);
            Controls.Add(res_log_out_btn);
            Controls.Add(res_review_comments_btn);
            Controls.Add(res_edit_btn);
            Name = "ResturantProfile";
            Text = "ResturantProfile";
            Load += ResturantProfile_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button res_edit_btn;
        private Button res_review_comments_btn;
        private Button res_log_out_btn;
        private Button res_delete_account_btn;
    }
}