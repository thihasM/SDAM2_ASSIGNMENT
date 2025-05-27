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
            SuspendLayout();
            // 
            // Log_in_btn
            // 
            Log_in_btn.Location = new Point(301, 245);
            Log_in_btn.Name = "Log_in_btn";
            Log_in_btn.Size = new Size(94, 29);
            Log_in_btn.TabIndex = 2;
            Log_in_btn.Text = "Log In";
            Log_in_btn.UseVisualStyleBackColor = true;
            Log_in_btn.Click += Log_in_btn_Click;
            // 
            // Sign_up_btn
            // 
            Sign_up_btn.Location = new Point(301, 293);
            Sign_up_btn.Name = "Sign_up_btn";
            Sign_up_btn.Size = new Size(94, 29);
            Sign_up_btn.TabIndex = 3;
            Sign_up_btn.Text = "Sign Up";
            Sign_up_btn.UseVisualStyleBackColor = true;
            Sign_up_btn.Click += Sign_up_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(310, 104);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 4;
            label1.Text = "Handiyen";
            // 
            // Handiyen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(690, 436);
            Controls.Add(label1);
            Controls.Add(Sign_up_btn);
            Controls.Add(Log_in_btn);
            Name = "Handiyen";
            Text = "Handiyen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Log_in_btn;
        private Button Sign_up_btn;
        private Label label1;
    }
}
