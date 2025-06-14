namespace LOGIN_SDAM_ASSIGNMENT
{
    partial class Restaurantinterface
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
            profile_btn = new Button();
            listBox1 = new ListBox();
            pending_orders = new Label();
            edit_menu_btn = new Button();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // profile_btn
            // 
            profile_btn.BackColor = Color.Black;
            profile_btn.FlatStyle = FlatStyle.Popup;
            profile_btn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            profile_btn.ForeColor = SystemColors.Control;
            profile_btn.Location = new Point(185, 396);
            profile_btn.Name = "profile_btn";
            profile_btn.Size = new Size(87, 34);
            profile_btn.TabIndex = 0;
            profile_btn.Text = "Profile";
            profile_btn.UseVisualStyleBackColor = false;
            profile_btn.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.LightSteelBlue;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(149, 104);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(533, 284);
            listBox1.TabIndex = 2;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // pending_orders
            // 
            pending_orders.AutoSize = true;
            pending_orders.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pending_orders.Location = new Point(364, 75);
            pending_orders.Name = "pending_orders";
            pending_orders.Size = new Size(134, 23);
            pending_orders.TabIndex = 5;
            pending_orders.Text = "Pending Orders";
            pending_orders.Click += label2_Click;
            // 
            // edit_menu_btn
            // 
            edit_menu_btn.BackColor = Color.Black;
            edit_menu_btn.FlatStyle = FlatStyle.Popup;
            edit_menu_btn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            edit_menu_btn.ForeColor = SystemColors.Control;
            edit_menu_btn.Location = new Point(532, 396);
            edit_menu_btn.Name = "edit_menu_btn";
            edit_menu_btn.Size = new Size(122, 34);
            edit_menu_btn.TabIndex = 6;
            edit_menu_btn.Text = "Sign Out";
            edit_menu_btn.UseVisualStyleBackColor = false;
            edit_menu_btn.Click += edit_menu_btn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Stencil", 28.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(296, 9);
            label4.Name = "label4";
            label4.Size = new Size(257, 56);
            label4.TabIndex = 9;
            label4.Text = "Handiyen";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.PowderBlue;
            pictureBox1.Image = Properties.Resources.d;
            pictureBox1.Location = new Point(689, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(99, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // Restaurantinterface
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(edit_menu_btn);
            Controls.Add(pending_orders);
            Controls.Add(listBox1);
            Controls.Add(profile_btn);
            Name = "Restaurantinterface";
            Text = "Restaurantinterface";
            Load += Restaurantinterface_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button profile_btn;
        private ListBox listBox1;
        private Label handiyen;
        private Label pending_orders;
        private Button edit_menu_btn;
        private Label label4;
        private PictureBox pictureBox1;
    }
}