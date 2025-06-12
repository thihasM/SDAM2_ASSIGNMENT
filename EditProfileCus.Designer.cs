namespace LOGIN_SDAM_ASSIGNMENT
{
    partial class EditProfileCus
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            user_name_edit_textbox = new TextBox();
            user_phone__number_edit_textbox = new TextBox();
            user_email_edit_textbox = new TextBox();
            user_address_edit_textbox = new TextBox();
            user_confirm_edit_btn = new Button();
            user_back_btn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(342, 9);
            label1.Name = "label1";
            label1.Size = new Size(126, 20);
            label1.TabIndex = 0;
            label1.Text = "Edit User Account";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(159, 53);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(159, 121);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 2;
            label3.Text = "Phone Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(159, 194);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 3;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(159, 265);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 4;
            label5.Text = "Address";
            // 
            // user_name_edit_textbox
            // 
            user_name_edit_textbox.Location = new Point(159, 76);
            user_name_edit_textbox.Name = "user_name_edit_textbox";
            user_name_edit_textbox.Size = new Size(420, 27);
            user_name_edit_textbox.TabIndex = 6;
            // 
            // user_phone__number_edit_textbox
            // 
            user_phone__number_edit_textbox.Location = new Point(159, 144);
            user_phone__number_edit_textbox.Name = "user_phone__number_edit_textbox";
            user_phone__number_edit_textbox.Size = new Size(420, 27);
            user_phone__number_edit_textbox.TabIndex = 7;
            // 
            // user_email_edit_textbox
            // 
            user_email_edit_textbox.Location = new Point(159, 217);
            user_email_edit_textbox.Name = "user_email_edit_textbox";
            user_email_edit_textbox.Size = new Size(420, 27);
            user_email_edit_textbox.TabIndex = 8;
            // 
            // user_address_edit_textbox
            // 
            user_address_edit_textbox.Location = new Point(159, 288);
            user_address_edit_textbox.Name = "user_address_edit_textbox";
            user_address_edit_textbox.Size = new Size(420, 27);
            user_address_edit_textbox.TabIndex = 9;
            // 
            // user_confirm_edit_btn
            // 
            user_confirm_edit_btn.Location = new Point(485, 369);
            user_confirm_edit_btn.Name = "user_confirm_edit_btn";
            user_confirm_edit_btn.Size = new Size(94, 29);
            user_confirm_edit_btn.TabIndex = 11;
            user_confirm_edit_btn.Text = "Confirm";
            user_confirm_edit_btn.UseVisualStyleBackColor = true;
            // 
            // user_back_btn
            // 
            user_back_btn.Location = new Point(377, 369);
            user_back_btn.Name = "user_back_btn";
            user_back_btn.Size = new Size(94, 29);
            user_back_btn.TabIndex = 12;
            user_back_btn.Text = "Back";
            user_back_btn.UseVisualStyleBackColor = true;
            // 
            // EditProfileCus
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(user_back_btn);
            Controls.Add(user_confirm_edit_btn);
            Controls.Add(user_address_edit_textbox);
            Controls.Add(user_email_edit_textbox);
            Controls.Add(user_phone__number_edit_textbox);
            Controls.Add(user_name_edit_textbox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EditProfileCus";
            Text = "EditProfileCus";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox user_name_edit_textbox;
        private TextBox user_phone__number_edit_textbox;
        private TextBox user_email_edit_textbox;
        private TextBox user_address_edit_textbox;
        private Button user_confirm_edit_btn;
        private Button user_back_btn;
    }
}