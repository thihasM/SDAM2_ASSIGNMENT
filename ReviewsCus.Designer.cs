namespace LOGIN_SDAM_ASSIGNMENT
{
    partial class ReviewsCus
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
            panel1 = new Panel();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            label1 = new Label();
            cus_rev_lb = new ListBox();
            label2 = new Label();
            textBox1 = new TextBox();
            add_rev_btn = new Button();
            user_back_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(8, 121);
            panel1.Name = "panel1";
            panel1.Size = new Size(750, 3);
            panel1.TabIndex = 47;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(308, 92);
            label7.Name = "label7";
            label7.Size = new Size(119, 23);
            label7.TabIndex = 46;
            label7.Text = "Reviews page";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.PowderBlue;
            pictureBox1.Image = Properties.Resources.d;
            pictureBox1.Location = new Point(689, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(99, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 45;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.PowderBlue;
            label6.Font = new Font("Stencil", 28.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(251, 26);
            label6.Name = "label6";
            label6.Size = new Size(257, 56);
            label6.TabIndex = 44;
            label6.Text = "Handiyen";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 144);
            label1.Name = "label1";
            label1.Size = new Size(89, 23);
            label1.TabIndex = 48;
            label1.Text = "Reviews : ";
            // 
            // cus_rev_lb
            // 
            cus_rev_lb.BackColor = Color.LightSteelBlue;
            cus_rev_lb.FormattingEnabled = true;
            cus_rev_lb.Location = new Point(159, 144);
            cus_rev_lb.Name = "cus_rev_lb";
            cus_rev_lb.Size = new Size(495, 184);
            cus_rev_lb.TabIndex = 49;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 362);
            label2.Name = "label2";
            label2.Size = new Size(135, 23);
            label2.TabIndex = 50;
            label2.Text = "Add a Review : ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(159, 358);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Enter Your Review";
            textBox1.Size = new Size(495, 27);
            textBox1.TabIndex = 51;
            // 
            // add_rev_btn
            // 
            add_rev_btn.BackColor = Color.Black;
            add_rev_btn.FlatStyle = FlatStyle.Popup;
            add_rev_btn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add_rev_btn.ForeColor = SystemColors.Control;
            add_rev_btn.Location = new Point(543, 406);
            add_rev_btn.Name = "add_rev_btn";
            add_rev_btn.Size = new Size(108, 29);
            add_rev_btn.TabIndex = 53;
            add_rev_btn.Text = "Add";
            add_rev_btn.UseVisualStyleBackColor = false;
            // 
            // user_back_btn
            // 
            user_back_btn.BackColor = Color.Black;
            user_back_btn.FlatStyle = FlatStyle.Popup;
            user_back_btn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            user_back_btn.ForeColor = SystemColors.Control;
            user_back_btn.Location = new Point(420, 406);
            user_back_btn.Name = "user_back_btn";
            user_back_btn.Size = new Size(108, 29);
            user_back_btn.TabIndex = 52;
            user_back_btn.Text = "Go Back";
            user_back_btn.UseVisualStyleBackColor = false;
            user_back_btn.Click += user_back_btn_Click;
            // 
            // ReviewsCus
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(add_rev_btn);
            Controls.Add(user_back_btn);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(cus_rev_lb);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(label7);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Name = "ReviewsCus";
            Text = "ReviewsCus";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label7;
        private PictureBox pictureBox1;
        private Label label6;
        private Label label1;
        private ListBox cus_rev_lb;
        private Label label2;
        private TextBox textBox1;
        private Button add_rev_btn;
        private Button user_back_btn;
    }
}