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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Log_in_btn
            // 
            Log_in_btn.BackColor = SystemColors.ActiveCaptionText;
            Log_in_btn.FlatStyle = FlatStyle.Popup;
            Log_in_btn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Log_in_btn.ForeColor = SystemColors.ButtonFace;
            Log_in_btn.Location = new Point(310, 291);
            Log_in_btn.Name = "Log_in_btn";
            Log_in_btn.Size = new Size(172, 65);
            Log_in_btn.TabIndex = 2;
            Log_in_btn.Text = "Log In";
            Log_in_btn.UseVisualStyleBackColor = false;
            Log_in_btn.Click += Log_in_btn_Click;
            // 
            // Sign_up_btn
            // 
            Sign_up_btn.BackColor = SystemColors.ActiveCaptionText;
            Sign_up_btn.FlatStyle = FlatStyle.Popup;
            Sign_up_btn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Sign_up_btn.ForeColor = SystemColors.ButtonFace;
            Sign_up_btn.Location = new Point(311, 362);
            Sign_up_btn.Name = "Sign_up_btn";
            Sign_up_btn.Size = new Size(172, 66);
            Sign_up_btn.TabIndex = 3;
            Sign_up_btn.Text = "Sign Up";
            Sign_up_btn.UseVisualStyleBackColor = false;
            Sign_up_btn.Click += Sign_up_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.PowderBlue;
            label1.Font = new Font("Stencil", 28.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(263, 33);
            label1.Name = "label1";
            label1.Size = new Size(257, 56);
            label1.TabIndex = 4;
            label1.Text = "Handiyen";
            label1.Click += label1_Click;
            // 
            // testConnectionBtn
            // 
            testConnectionBtn.Location = new Point(694, 405);
            testConnectionBtn.Name = "testConnectionBtn";
            testConnectionBtn.Size = new Size(94, 29);
            testConnectionBtn.TabIndex = 5;
            testConnectionBtn.Text = "test con";
            testConnectionBtn.UseVisualStyleBackColor = true;
            testConnectionBtn.Click += testConnectionBtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(21, 100);
            panel1.Name = "panel1";
            panel1.Size = new Size(750, 3);
            panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.PowderBlue;
            pictureBox1.Image = Properties.Resources.d;
            pictureBox1.Location = new Point(310, 127);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(172, 148);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(8, 502);
            panel3.Name = "panel3";
            panel3.Size = new Size(420, 3);
            panel3.TabIndex = 8;
            // 
            // Handiyen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(testConnectionBtn);
            Controls.Add(label1);
            Controls.Add(Sign_up_btn);
            Controls.Add(Log_in_btn);
            ForeColor = Color.Cyan;
            Name = "Handiyen";
            Text = "Handiyen";
            Load += Handiyen_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Log_in_btn;
        private Button Sign_up_btn;
        private Label label1;
        private Button testConnectionBtn;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel3;
    }
}
