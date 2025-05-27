namespace LOGIN_SDAM_ASSIGNMENT
{
    partial class Signupresform
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
            label6 = new Label();
            label7 = new Label();
            sign_res_name_txtb = new TextBox();
            sign_res_pass_txtb = new TextBox();
            sign_res_pnum_txtb = new TextBox();
            sign_res_email_txtb = new TextBox();
            sign_res_add_txtb = new TextBox();
            sign_res_conpass_txtb = new TextBox();
            signup_res_btn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(249, 110);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(369, 28);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 1;
            label2.Text = "Handiyen";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(249, 152);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 2;
            label3.Text = "Enter address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(249, 190);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 3;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(249, 232);
            label5.Name = "label5";
            label5.Size = new Size(108, 20);
            label5.TabIndex = 4;
            label5.Text = "Phone Number";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(249, 272);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 5;
            label6.Text = "Password";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(249, 312);
            label7.Name = "label7";
            label7.Size = new Size(127, 20);
            label7.TabIndex = 6;
            label7.Text = "Confirm Password";
            // 
            // sign_res_name_txtb
            // 
            sign_res_name_txtb.Location = new Point(462, 107);
            sign_res_name_txtb.Name = "sign_res_name_txtb";
            sign_res_name_txtb.PlaceholderText = "Enter Resturant Name";
            sign_res_name_txtb.Size = new Size(160, 27);
            sign_res_name_txtb.TabIndex = 7;
            // 
            // sign_res_pass_txtb
            // 
            sign_res_pass_txtb.Location = new Point(462, 272);
            sign_res_pass_txtb.Name = "sign_res_pass_txtb";
            sign_res_pass_txtb.PlaceholderText = "Password";
            sign_res_pass_txtb.Size = new Size(160, 27);
            sign_res_pass_txtb.TabIndex = 8;
            // 
            // sign_res_pnum_txtb
            // 
            sign_res_pnum_txtb.Location = new Point(462, 232);
            sign_res_pnum_txtb.Name = "sign_res_pnum_txtb";
            sign_res_pnum_txtb.PlaceholderText = "+94 XXXXXXXXX";
            sign_res_pnum_txtb.Size = new Size(160, 27);
            sign_res_pnum_txtb.TabIndex = 9;
            // 
            // sign_res_email_txtb
            // 
            sign_res_email_txtb.Location = new Point(462, 190);
            sign_res_email_txtb.Name = "sign_res_email_txtb";
            sign_res_email_txtb.PlaceholderText = "Enter Your Email";
            sign_res_email_txtb.Size = new Size(160, 27);
            sign_res_email_txtb.TabIndex = 10;
            // 
            // sign_res_add_txtb
            // 
            sign_res_add_txtb.Location = new Point(462, 152);
            sign_res_add_txtb.Name = "sign_res_add_txtb";
            sign_res_add_txtb.PlaceholderText = "Enter Your Address";
            sign_res_add_txtb.Size = new Size(160, 27);
            sign_res_add_txtb.TabIndex = 11;
            // 
            // sign_res_conpass_txtb
            // 
            sign_res_conpass_txtb.Location = new Point(462, 312);
            sign_res_conpass_txtb.Name = "sign_res_conpass_txtb";
            sign_res_conpass_txtb.PlaceholderText = "Confirm Password";
            sign_res_conpass_txtb.Size = new Size(160, 27);
            sign_res_conpass_txtb.TabIndex = 12;
            // 
            // signup_res_btn
            // 
            signup_res_btn.Location = new Point(486, 374);
            signup_res_btn.Name = "signup_res_btn";
            signup_res_btn.Size = new Size(94, 29);
            signup_res_btn.TabIndex = 13;
            signup_res_btn.Text = "Sign UP";
            signup_res_btn.UseVisualStyleBackColor = true;
            // 
            // Signupresform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(signup_res_btn);
            Controls.Add(sign_res_conpass_txtb);
            Controls.Add(sign_res_add_txtb);
            Controls.Add(sign_res_email_txtb);
            Controls.Add(sign_res_pnum_txtb);
            Controls.Add(sign_res_pass_txtb);
            Controls.Add(sign_res_name_txtb);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Signupresform";
            Text = "Signupresform";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox sign_res_name_txtb;
        private TextBox sign_res_pass_txtb;
        private TextBox sign_res_pnum_txtb;
        private TextBox sign_res_email_txtb;
        private TextBox sign_res_add_txtb;
        private TextBox sign_res_conpass_txtb;
        private Button signup_res_btn;
    }
}