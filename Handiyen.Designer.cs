namespace LOGIN_SDAM_ASSIGNMENT
{
    partial class Handiyen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Log_in_btn = new Button();
            Sign_up_btn = new Button();
            label1 = new Label();
            testConnectionBtn = new Button();
            SuspendLayout();
            // 
            // Log_in_btn
            // 
            Log_in_btn.BackColor = SystemColors.ActiveCaptionText;
            Log_in_btn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Log_in_btn.ForeColor = SystemColors.ButtonFace;
            Log_in_btn.Location = new Point(229, 217);
            Log_in_btn.Name = "Log_in_btn";
            Log_in_btn.Size = new Size(112, 54);
            Log_in_btn.TabIndex = 2;
            Log_in_btn.Text = "Log In";
            Log_in_btn.UseVisualStyleBackColor = false;
            Log_in_btn.Click += Log_in_btn_Click;
            // 
            // Sign_up_btn
            // 
            Sign_up_btn.BackColor = SystemColors.ActiveCaptionText;
            Sign_up_btn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Sign_up_btn.ForeColor = SystemColors.ButtonFace;
            Sign_up_btn.Location = new Point(229, 288);
            Sign_up_btn.Name = "Sign_up_btn";
            Sign_up_btn.Size = new Size(112, 52);
            Sign_up_btn.TabIndex = 3;
            Sign_up_btn.Text = "Sign Up";
            Sign_up_btn.UseVisualStyleBackColor = false;
            Sign_up_btn.Click += Sign_up_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(215, 63);
            label1.Name = "label1";
            label1.Size = new Size(157, 38);
            label1.TabIndex = 4;
            label1.Text = "Handiyen";
            // 
            // testConnectionBtn
            // 
            testConnectionBtn.Location = new Point(476, 374);
            testConnectionBtn.Name = "testConnectionBtn";
            testConnectionBtn.Size = new Size(94, 29);
            testConnectionBtn.TabIndex = 5;
            testConnectionBtn.Text = "test con";
            testConnectionBtn.UseVisualStyleBackColor = true;
            testConnectionBtn.Click += testConnectionBtn_Click;
            // 
            // Handiyen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(609, 435);
            Controls.Add(testConnectionBtn);
            Controls.Add(label1);
            Controls.Add(Sign_up_btn);
            Controls.Add(Log_in_btn);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Handiyen";
            Text = "Handiyen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Log_in_btn;
        private Button Sign_up_btn;
        private Label label1;
        private Button testConnectionBtn;
    }
}
