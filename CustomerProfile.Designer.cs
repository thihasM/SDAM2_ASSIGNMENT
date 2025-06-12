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
            SuspendLayout();
            // 
            // cus_edit_btn
            // 
            cus_edit_btn.Location = new Point(353, 128);
            cus_edit_btn.Name = "cus_edit_btn";
            cus_edit_btn.Size = new Size(119, 44);
            cus_edit_btn.TabIndex = 0;
            cus_edit_btn.Text = "Edit Profile";
            cus_edit_btn.UseVisualStyleBackColor = true;
            cus_edit_btn.Click += button1_Click;
            // 
            // cus_delete_account_btn
            // 
            cus_delete_account_btn.Location = new Point(353, 295);
            cus_delete_account_btn.Name = "cus_delete_account_btn";
            cus_delete_account_btn.Size = new Size(119, 45);
            cus_delete_account_btn.TabIndex = 1;
            cus_delete_account_btn.Text = "Delete Account";
            cus_delete_account_btn.UseVisualStyleBackColor = true;
            // 
            // cus_log_out_btn
            // 
            cus_log_out_btn.Location = new Point(353, 214);
            cus_log_out_btn.Name = "cus_log_out_btn";
            cus_log_out_btn.Size = new Size(119, 42);
            cus_log_out_btn.TabIndex = 2;
            cus_log_out_btn.Text = "Log Out";
            cus_log_out_btn.UseVisualStyleBackColor = true;
            // 
            // CustomerProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cus_log_out_btn);
            Controls.Add(cus_delete_account_btn);
            Controls.Add(cus_edit_btn);
            Name = "CustomerProfile";
            Text = "CustomerProfile";
            ResumeLayout(false);
        }

        #endregion

        private Button cus_edit_btn;
        private Button cus_delete_account_btn;
        private Button cus_log_out_btn;
    }
}