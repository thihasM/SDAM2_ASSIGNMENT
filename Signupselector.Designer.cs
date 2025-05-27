namespace LOGIN_SDAM_ASSIGNMENT
{
    partial class Signupselector
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
            sign_res_btn = new Button();
            sign_con_btn = new Button();
            signup_bck_btn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // sign_res_btn
            // 
            sign_res_btn.BackColor = SystemColors.ActiveCaptionText;
            sign_res_btn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sign_res_btn.ForeColor = SystemColors.ButtonFace;
            sign_res_btn.Location = new Point(234, 246);
            sign_res_btn.Name = "sign_res_btn";
            sign_res_btn.Size = new Size(119, 45);
            sign_res_btn.TabIndex = 0;
            sign_res_btn.Text = "Resturant";
            sign_res_btn.UseVisualStyleBackColor = false;
            sign_res_btn.Click += sign_res_btn_Click;
            // 
            // sign_con_btn
            // 
            sign_con_btn.BackColor = SystemColors.ActiveCaptionText;
            sign_con_btn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sign_con_btn.ForeColor = SystemColors.ButtonFace;
            sign_con_btn.Location = new Point(439, 246);
            sign_con_btn.Name = "sign_con_btn";
            sign_con_btn.Size = new Size(119, 45);
            sign_con_btn.TabIndex = 1;
            sign_con_btn.Text = "Customer";
            sign_con_btn.UseVisualStyleBackColor = false;
            sign_con_btn.Click += sign_con_btn_Click;
            // 
            // signup_bck_btn
            // 
            signup_bck_btn.BackColor = SystemColors.ActiveCaptionText;
            signup_bck_btn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signup_bck_btn.ForeColor = SystemColors.ButtonFace;
            signup_bck_btn.Location = new Point(334, 326);
            signup_bck_btn.Name = "signup_bck_btn";
            signup_bck_btn.Size = new Size(122, 45);
            signup_bck_btn.TabIndex = 2;
            signup_bck_btn.Text = "Go Back";
            signup_bck_btn.UseVisualStyleBackColor = false;
            signup_bck_btn.Click += signup_bck_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(334, 72);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(273, 143);
            label2.Name = "label2";
            label2.Size = new Size(285, 35);
            label2.TabIndex = 5;
            label2.Text = "Choose accout type : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(322, 58);
            label3.Name = "label3";
            label3.Size = new Size(157, 38);
            label3.TabIndex = 6;
            label3.Text = "Handiyen";
            // 
            // Signupselector
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(signup_bck_btn);
            Controls.Add(sign_con_btn);
            Controls.Add(sign_res_btn);
            Name = "Signupselector";
            Text = "Signupselector";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button sign_res_btn;
        private Button sign_con_btn;
        private Button signup_bck_btn;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}