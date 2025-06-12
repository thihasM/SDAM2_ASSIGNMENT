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
            plc_odr_btn = new Button();
            cus_profile_btn = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(348, 46);
            lblName.Name = "lblName";
            lblName.Size = new Size(17, 20);
            lblName.TabIndex = 0;
            lblName.Text = "ll";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(348, 81);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(17, 20);
            lblAddress.TabIndex = 1;
            lblAddress.Text = "ll";
            // 
            // menu_items
            // 
            menu_items.FormattingEnabled = true;
            menu_items.Location = new Point(174, 178);
            menu_items.Name = "menu_items";
            menu_items.Size = new Size(380, 204);
            menu_items.TabIndex = 2;
            menu_items.SelectedIndexChanged += menu_items_SelectedIndexChanged;
            // 
            // gobck_btn
            // 
            gobck_btn.Location = new Point(12, 12);
            gobck_btn.Name = "gobck_btn";
            gobck_btn.Size = new Size(94, 29);
            gobck_btn.TabIndex = 3;
            gobck_btn.Text = "Back";
            gobck_btn.UseVisualStyleBackColor = true;
            gobck_btn.Click += gobck_btn_Click;
            // 
            // plc_odr_btn
            // 
            plc_odr_btn.Location = new Point(154, 404);
            plc_odr_btn.Name = "plc_odr_btn";
            plc_odr_btn.Size = new Size(94, 29);
            plc_odr_btn.TabIndex = 4;
            plc_odr_btn.Text = "Place Order";
            plc_odr_btn.UseVisualStyleBackColor = true;
            plc_odr_btn.Click += plc_odr_btn_Click;
            // 
            // cus_profile_btn
            // 
            cus_profile_btn.Location = new Point(472, 404);
            cus_profile_btn.Name = "cus_profile_btn";
            cus_profile_btn.Size = new Size(94, 29);
            cus_profile_btn.TabIndex = 5;
            cus_profile_btn.Text = "Profile";
            cus_profile_btn.UseVisualStyleBackColor = true;
            cus_profile_btn.Click += cus_profile_btn_Click;
            // 
            // RestaurantPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 463);
            Controls.Add(cus_profile_btn);
            Controls.Add(plc_odr_btn);
            Controls.Add(gobck_btn);
            Controls.Add(menu_items);
            Controls.Add(lblAddress);
            Controls.Add(lblName);
            Name = "RestaurantPage";
            Text = "RestaurantPage";
            Load += RestaurantPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblAddress;
        private ListBox menu_items;
        private Button gobck_btn;
        private Button plc_odr_btn;
        private Button cus_profile_btn;
    }
}