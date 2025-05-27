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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            log_usen_txtb = new TextBox();
            log_pass_txtb = new TextBox();
            SuspendLayout();
            // 
            // login_btn
            // 
            login_btn.Location = new Point(457, 298);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(94, 29);
            login_btn.TabIndex = 1;
            login_btn.Text = "Log In";
            login_btn.UseVisualStyleBackColor = true;
            // 
            // login_bck_btn
            // 
            login_bck_btn.Location = new Point(272, 298);
            login_bck_btn.Name = "login_bck_btn";
            login_bck_btn.Size = new Size(94, 29);
            login_bck_btn.TabIndex = 2;
            login_bck_btn.Text = "Go Back";
            login_bck_btn.UseVisualStyleBackColor = true;
            login_bck_btn.Click += login_bck_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(367, 75);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 3;
            label1.Text = "Handiyen";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(272, 157);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 4;
            label2.Text = "User Name : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(272, 222);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 5;
            label3.Text = "Password : ";
            // 
            // log_usen_txtb
            // 
            log_usen_txtb.Location = new Point(406, 157);
            log_usen_txtb.Name = "log_usen_txtb";
            log_usen_txtb.Size = new Size(125, 27);
            log_usen_txtb.TabIndex = 6;
            // 
            // log_pass_txtb
            // 
            log_pass_txtb.Location = new Point(406, 219);
            log_pass_txtb.Name = "log_pass_txtb";
            log_pass_txtb.Size = new Size(125, 27);
            log_pass_txtb.TabIndex = 7;
            // 
            // Loginform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(log_pass_txtb);
            Controls.Add(log_usen_txtb);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(login_bck_btn);
            Controls.Add(login_btn);
            Name = "Loginform";
            Text = "Loginform";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button login_btn;
        private Button login_bck_btn;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox log_usen_txtb;
        private TextBox log_pass_txtb;
    }
}