namespace LOGIN_SDAM_ASSIGNMENT
{
    partial class trackoder
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
            livetrack_btn = new Button();
            Back_btn = new Button();
            order_dt_lb = new ListBox();
            ship_dt_lb = new ListBox();
            order_st_txt = new Label();
            order_dt_txt = new Label();
            ship_txt = new Label();
            order_st_lb = new ListBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // livetrack_btn
            // 
            livetrack_btn.BackColor = Color.Black;
            livetrack_btn.FlatStyle = FlatStyle.Popup;
            livetrack_btn.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            livetrack_btn.ForeColor = SystemColors.Control;
            livetrack_btn.Location = new Point(674, 409);
            livetrack_btn.Name = "livetrack_btn";
            livetrack_btn.Size = new Size(114, 29);
            livetrack_btn.TabIndex = 0;
            livetrack_btn.Text = "Live Track";
            livetrack_btn.UseVisualStyleBackColor = false;
            // 
            // Back_btn
            // 
            Back_btn.BackColor = Color.Black;
            Back_btn.FlatStyle = FlatStyle.Popup;
            Back_btn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Back_btn.ForeColor = SystemColors.Control;
            Back_btn.Location = new Point(12, 12);
            Back_btn.Name = "Back_btn";
            Back_btn.Size = new Size(93, 33);
            Back_btn.TabIndex = 1;
            Back_btn.Text = "Go Back";
            Back_btn.UseVisualStyleBackColor = false;
            // 
            // order_dt_lb
            // 
            order_dt_lb.BackColor = Color.LightSteelBlue;
            order_dt_lb.FormattingEnabled = true;
            order_dt_lb.Location = new Point(304, 198);
            order_dt_lb.Name = "order_dt_lb";
            order_dt_lb.Size = new Size(197, 124);
            order_dt_lb.TabIndex = 2;
            // 
            // ship_dt_lb
            // 
            ship_dt_lb.BackColor = Color.LightSteelBlue;
            ship_dt_lb.FormattingEnabled = true;
            ship_dt_lb.Location = new Point(304, 358);
            ship_dt_lb.Name = "ship_dt_lb";
            ship_dt_lb.Size = new Size(197, 104);
            ship_dt_lb.TabIndex = 3;
            // 
            // order_st_txt
            // 
            order_st_txt.AutoSize = true;
            order_st_txt.BackColor = Color.Transparent;
            order_st_txt.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            order_st_txt.Location = new Point(348, 88);
            order_st_txt.Name = "order_st_txt";
            order_st_txt.Size = new Size(112, 23);
            order_st_txt.TabIndex = 4;
            order_st_txt.Text = "Order Status";
            // 
            // order_dt_txt
            // 
            order_dt_txt.AutoSize = true;
            order_dt_txt.Font = new Font("Times New Roman", 12F);
            order_dt_txt.Location = new Point(342, 174);
            order_dt_txt.Name = "order_dt_txt";
            order_dt_txt.Size = new Size(119, 22);
            order_dt_txt.TabIndex = 5;
            order_dt_txt.Text = "Order Details";
            // 
            // ship_txt
            // 
            ship_txt.AutoSize = true;
            ship_txt.Font = new Font("Times New Roman", 12F);
            ship_txt.Location = new Point(327, 330);
            ship_txt.Name = "ship_txt";
            ship_txt.Size = new Size(150, 22);
            ship_txt.TabIndex = 6;
            ship_txt.Text = "Shipping Address";
            ship_txt.Click += label3_Click;
            // 
            // order_st_lb
            // 
            order_st_lb.BackColor = Color.LightSteelBlue;
            order_st_lb.FormattingEnabled = true;
            order_st_lb.Location = new Point(288, 138);
            order_st_lb.Name = "order_st_lb";
            order_st_lb.Size = new Size(239, 24);
            order_st_lb.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.PowderBlue;
            pictureBox1.Image = Properties.Resources.d;
            pictureBox1.Location = new Point(689, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(99, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 37;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 28.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(270, 28);
            label2.Name = "label2";
            label2.Size = new Size(257, 56);
            label2.TabIndex = 38;
            label2.Text = "Handiyen";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(12, 113);
            panel1.Name = "panel1";
            panel1.Size = new Size(750, 3);
            panel1.TabIndex = 39;
            // 
            // trackoder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(order_st_lb);
            Controls.Add(ship_txt);
            Controls.Add(order_dt_txt);
            Controls.Add(order_st_txt);
            Controls.Add(ship_dt_lb);
            Controls.Add(order_dt_lb);
            Controls.Add(Back_btn);
            Controls.Add(livetrack_btn);
            Name = "trackoder";
            Text = "trackoder";
            Load += trackoder_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button livetrack_btn;
        private Button Back_btn;
        private ListBox order_dt_lb;
        private ListBox ship_dt_lb;
        private Label order_st_txt;
        private Label order_dt_txt;
        private Label ship_txt;
        private ListBox order_st_lb;
        private PictureBox pictureBox1;
        private Label label2;
        private Panel panel1;
    }
}