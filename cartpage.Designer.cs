namespace LOGIN_SDAM_ASSIGNMENT
{
    partial class cartpage
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
            cart_lb = new ListBox();
            label2 = new Label();
            del_loc_tb = new TextBox();
            user_back_btn = new Button();
            payment_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(22, 120);
            panel1.Name = "panel1";
            panel1.Size = new Size(750, 3);
            panel1.TabIndex = 43;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(349, 94);
            label7.Name = "label7";
            label7.Size = new Size(88, 23);
            label7.TabIndex = 42;
            label7.Text = "Cart Page";
            label7.Click += label7_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.PowderBlue;
            pictureBox1.Image = Properties.Resources.d;
            pictureBox1.Location = new Point(689, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(99, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 41;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.PowderBlue;
            label6.Font = new Font("Stencil", 28.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(265, 25);
            label6.Name = "label6";
            label6.Size = new Size(257, 56);
            label6.TabIndex = 40;
            label6.Text = "Handiyen";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(38, 150);
            label1.Name = "label1";
            label1.Size = new Size(113, 23);
            label1.TabIndex = 44;
            label1.Text = "Your Order:";
            // 
            // cart_lb
            // 
            cart_lb.BackColor = Color.LightSteelBlue;
            cart_lb.FormattingEnabled = true;
            cart_lb.Location = new Point(184, 150);
            cart_lb.Name = "cart_lb";
            cart_lb.Size = new Size(423, 184);
            cart_lb.TabIndex = 45;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(38, 358);
            label2.Name = "label2";
            label2.Size = new Size(226, 23);
            label2.TabIndex = 46;
            label2.Text = "Enter Delivery Location :";
            // 
            // del_loc_tb
            // 
            del_loc_tb.Location = new Point(280, 358);
            del_loc_tb.Name = "del_loc_tb";
            del_loc_tb.PlaceholderText = "Enter Your Delivery Location";
            del_loc_tb.Size = new Size(384, 27);
            del_loc_tb.TabIndex = 47;
            // 
            // user_back_btn
            // 
            user_back_btn.BackColor = Color.Black;
            user_back_btn.FlatStyle = FlatStyle.Popup;
            user_back_btn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            user_back_btn.ForeColor = SystemColors.Control;
            user_back_btn.Location = new Point(426, 410);
            user_back_btn.Name = "user_back_btn";
            user_back_btn.Size = new Size(108, 29);
            user_back_btn.TabIndex = 48;
            user_back_btn.Text = "Go Back";
            user_back_btn.UseVisualStyleBackColor = false;
            user_back_btn.Click += user_back_btn_Click;
            // 
            // payment_btn
            // 
            payment_btn.BackColor = Color.Black;
            payment_btn.FlatStyle = FlatStyle.Popup;
            payment_btn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            payment_btn.ForeColor = SystemColors.Control;
            payment_btn.Location = new Point(551, 410);
            payment_btn.Name = "payment_btn";
            payment_btn.Size = new Size(108, 29);
            payment_btn.TabIndex = 49;
            payment_btn.Text = "Pay";
            payment_btn.UseVisualStyleBackColor = false;
            payment_btn.Click += payment_btn_Click;
            // 
            // cartpage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(payment_btn);
            Controls.Add(user_back_btn);
            Controls.Add(del_loc_tb);
            Controls.Add(label2);
            Controls.Add(cart_lb);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(label7);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Name = "cartpage";
            Text = "cartpage";
            Load += cartpage_Load;
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
        private ListBox cart_lb;
        private Label label2;
        private TextBox del_loc_tb;
        private Button user_back_btn;
        private Button payment_btn;
    }
}