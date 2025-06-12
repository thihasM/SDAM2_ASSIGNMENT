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
            label1 = new Label();
            SuspendLayout();
            // 
            // profile_btn
            // 
            profile_btn.Location = new Point(185, 404);
            profile_btn.Name = "profile_btn";
            profile_btn.Size = new Size(73, 34);
            profile_btn.TabIndex = 0;
            profile_btn.Text = "Profile";
            profile_btn.UseVisualStyleBackColor = true;
            profile_btn.Click += button1_Click;
            // 
            // listBox1
            // 
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
            pending_orders.Location = new Point(336, 73);
            pending_orders.Name = "pending_orders";
            pending_orders.Size = new Size(110, 20);
            pending_orders.TabIndex = 5;
            pending_orders.Text = "Pending Orders";
            pending_orders.Click += label2_Click;
            // 
            // edit_menu_btn
            // 
            edit_menu_btn.Location = new Point(566, 404);
            edit_menu_btn.Name = "edit_menu_btn";
            edit_menu_btn.Size = new Size(92, 34);
            edit_menu_btn.TabIndex = 6;
            edit_menu_btn.Text = "Edit Menu";
            edit_menu_btn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(319, 6);
            label1.Name = "label1";
            label1.Size = new Size(157, 38);
            label1.TabIndex = 7;
            label1.Text = "Handiyen";
            // 
            // Restaurantinterface
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(edit_menu_btn);
            Controls.Add(pending_orders);
            Controls.Add(listBox1);
            Controls.Add(profile_btn);
            Name = "Restaurantinterface";
            Text = "Restaurantinterface";
            Load += Restaurantinterface_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button profile_btn;
        private ListBox listBox1;
        private Label handiyen;
        private Label pending_orders;
        private Button edit_menu_btn;
        private Label label1;
    }
}