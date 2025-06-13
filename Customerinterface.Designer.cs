namespace LOGIN_SDAM_ASSIGNMENT
{
    partial class Customerinterface
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
            customer_intf_lb = new ListBox();
            label2 = new Label();
            label1 = new Label();
            order_btn = new Button();
            profile_btn = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // customer_intf_lb
            // 
            customer_intf_lb.BackColor = Color.LightSteelBlue;
            customer_intf_lb.FormattingEnabled = true;
            customer_intf_lb.Location = new Point(151, 117);
            customer_intf_lb.Name = "customer_intf_lb";
            customer_intf_lb.Size = new Size(523, 244);
            customer_intf_lb.TabIndex = 0;
            customer_intf_lb.SelectedIndexChanged += customer_intf_lb_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 28.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(268, 9);
            label2.Name = "label2";
            label2.Size = new Size(257, 56);
            label2.TabIndex = 31;
            label2.Text = "Handiyen";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(306, 91);
            label1.Name = "label1";
            label1.Size = new Size(187, 23);
            label1.TabIndex = 32;
            label1.Text = "Available Restaurants:";
            label1.Click += label1_Click;
            // 
            // order_btn
            // 
            order_btn.BackColor = Color.Black;
            order_btn.FlatStyle = FlatStyle.Popup;
            order_btn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            order_btn.ForeColor = Color.White;
            order_btn.Location = new Point(171, 377);
            order_btn.Name = "order_btn";
            order_btn.Size = new Size(124, 42);
            order_btn.TabIndex = 33;
            order_btn.Text = "View Order";
            order_btn.UseVisualStyleBackColor = false;
            order_btn.Click += order_btn_Click;
            // 
            // profile_btn
            // 
            profile_btn.BackColor = Color.Black;
            profile_btn.FlatStyle = FlatStyle.Popup;
            profile_btn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            profile_btn.ForeColor = Color.White;
            profile_btn.Location = new Point(525, 377);
            profile_btn.Name = "profile_btn";
            profile_btn.Size = new Size(124, 42);
            profile_btn.TabIndex = 34;
            profile_btn.Text = "Profile";
            profile_btn.UseVisualStyleBackColor = false;
            profile_btn.Click += profile_btn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.d;
            pictureBox1.Location = new Point(689, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(99, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 35;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Customerinterface
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(profile_btn);
            Controls.Add(order_btn);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(customer_intf_lb);
            Name = "Customerinterface";
            Text = "Customerinterface";
            Load += Customerinterface_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox customer_intf_lb;
        private Label label2;
        private Label label1;
        private Button order_btn;
        private Button profile_btn;
        private PictureBox pictureBox1;
    }
}