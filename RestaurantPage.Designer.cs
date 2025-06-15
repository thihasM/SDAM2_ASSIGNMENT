namespace LOGIN_SDAM_ASSIGNMENT
{
    partial class RestaurantPage
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
            lblName = new Label();
            lblAddress = new Label();
            menu_items = new ListBox();
            gobck_btn = new Button();
            cart_btn = new Button();
            cus_profile_btn = new Button();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            lblWelcome = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(348, 100);
            lblName.Name = "lblName";
            lblName.Size = new Size(20, 23);
            lblName.TabIndex = 0;
            lblName.Text = "ll";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddress.Location = new Point(348, 135);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(22, 22);
            lblAddress.TabIndex = 1;
            lblAddress.Text = "ll";
            // 
            // menu_items
            // 
            menu_items.BackColor = Color.LightSteelBlue;
            menu_items.FormattingEnabled = true;
            menu_items.Location = new Point(174, 178);
            menu_items.Name = "menu_items";
            menu_items.Size = new Size(380, 204);
            menu_items.TabIndex = 2;
            menu_items.SelectedIndexChanged += menu_items_SelectedIndexChanged;
            // 
            // gobck_btn
            // 
            gobck_btn.BackColor = Color.Black;
            gobck_btn.FlatStyle = FlatStyle.Popup;
            gobck_btn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gobck_btn.ForeColor = SystemColors.Control;
            gobck_btn.Location = new Point(12, 34);
            gobck_btn.Name = "gobck_btn";
            gobck_btn.Size = new Size(94, 29);
            gobck_btn.TabIndex = 3;
            gobck_btn.Text = "Go Back";
            gobck_btn.UseVisualStyleBackColor = false;
            gobck_btn.Click += gobck_btn_Click;
            // 
            // cart_btn
            // 
            cart_btn.BackColor = Color.Black;
            cart_btn.FlatStyle = FlatStyle.Popup;
            cart_btn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cart_btn.ForeColor = SystemColors.Control;
            cart_btn.Location = new Point(174, 394);
            cart_btn.Name = "cart_btn";
            cart_btn.Size = new Size(141, 29);
            cart_btn.TabIndex = 4;
            cart_btn.Text = "Cart";
            cart_btn.UseVisualStyleBackColor = false;
            cart_btn.Click += plc_odr_btn_Click;
            // 
            // cus_profile_btn
            // 
            cus_profile_btn.BackColor = Color.Black;
            cus_profile_btn.FlatStyle = FlatStyle.Popup;
            cus_profile_btn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cus_profile_btn.ForeColor = SystemColors.Control;
            cus_profile_btn.Location = new Point(413, 394);
            cus_profile_btn.Name = "cus_profile_btn";
            cus_profile_btn.Size = new Size(141, 29);
            cus_profile_btn.TabIndex = 5;
            cus_profile_btn.Text = "Review";
            cus_profile_btn.UseVisualStyleBackColor = false;
            cus_profile_btn.Click += cus_profile_btn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.PowderBlue;
            pictureBox1.Image = Properties.Resources.d;
            pictureBox1.Location = new Point(689, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(99, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Stencil", 28.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(241, 12);
            label4.Name = "label4";
            label4.Size = new Size(257, 56);
            label4.TabIndex = 11;
            label4.Text = "Handiyen";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(738, 434);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(50, 20);
            lblWelcome.TabIndex = 12;
            lblWelcome.Text = "label1";
            // 
            // RestaurantPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(800, 463);
            Controls.Add(lblWelcome);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(cus_profile_btn);
            Controls.Add(cart_btn);
            Controls.Add(gobck_btn);
            Controls.Add(menu_items);
            Controls.Add(lblAddress);
            Controls.Add(lblName);
            Name = "RestaurantPage";
            Text = "RestaurantPage";
            Load += RestaurantPage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblAddress;
        private ListBox menu_items;
        private Button gobck_btn;
        private Button cart_btn;
        private Button cus_profile_btn;
        private PictureBox pictureBox1;
        private Label label4;
        private Label lblWelcome;
    }
}