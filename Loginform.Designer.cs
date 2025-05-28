namespace LOGIN_SDAM_ASSIGNMENT
{
    partial class Loginform
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
            login_btn = new Button();
            login_bck_btn = new Button();
            label2 = new Label();
            label3 = new Label();
            log_usen_txtb = new TextBox();
            log_pass_txtb = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // login_btn
            // 
            login_btn.BackColor = SystemColors.ActiveCaptionText;
            login_btn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login_btn.ForeColor = SystemColors.ButtonHighlight;
            login_btn.Location = new Point(457, 298);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(103, 38);
            login_btn.TabIndex = 1;
            login_btn.Text = "Log In";
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += login_btn_Click;
            // 
            // login_bck_btn
            // 
            login_bck_btn.BackColor = SystemColors.ActiveCaptionText;
            login_bck_btn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login_bck_btn.ForeColor = SystemColors.Control;
            login_bck_btn.Location = new Point(299, 300);
            login_bck_btn.Name = "login_bck_btn";
            login_bck_btn.Size = new Size(107, 36);
            login_bck_btn.TabIndex = 2;
            login_bck_btn.Text = "Go Back";
            login_bck_btn.UseVisualStyleBackColor = false;
            login_bck_btn.Click += login_bck_btn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(272, 157);
            label2.Name = "label2";
            label2.Size = new Size(114, 22);
            label2.TabIndex = 4;
            label2.Text = "User Name : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(272, 222);
            label3.Name = "label3";
            label3.Size = new Size(104, 22);
            label3.TabIndex = 5;
            label3.Text = "Password : ";
            // 
            // log_usen_txtb
            // 
            log_usen_txtb.BackColor = SystemColors.ScrollBar;
            log_usen_txtb.BorderStyle = BorderStyle.FixedSingle;
            log_usen_txtb.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            log_usen_txtb.ForeColor = SystemColors.Desktop;
            log_usen_txtb.Location = new Point(406, 159);
            log_usen_txtb.Name = "log_usen_txtb";
            log_usen_txtb.PlaceholderText = "Enter your user name ";
            log_usen_txtb.Size = new Size(187, 27);
            log_usen_txtb.TabIndex = 6;
            // 
            // log_pass_txtb
            // 
            log_pass_txtb.BackColor = SystemColors.ScrollBar;
            log_pass_txtb.BorderStyle = BorderStyle.FixedSingle;
            log_pass_txtb.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            log_pass_txtb.Location = new Point(406, 219);
            log_pass_txtb.Name = "log_pass_txtb";
            log_pass_txtb.PlaceholderText = "Enter your user password";
            log_pass_txtb.Size = new Size(187, 27);
            log_pass_txtb.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(335, 63);
            label4.Name = "label4";
            label4.Size = new Size(157, 38);
            label4.TabIndex = 8;
            label4.Text = "Handiyen";
            // 
            // Loginform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(log_pass_txtb);
            Controls.Add(log_usen_txtb);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(login_bck_btn);
            Controls.Add(login_btn);
            Name = "Loginform";
            Text = "Loginform";
            Load += Loginform_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button login_btn;
        private Button login_bck_btn;
        private Label label2;
        private Label label3;
        private TextBox log_usen_txtb;
        private TextBox log_pass_txtb;
        private Label label4;
    }
}