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
            SuspendLayout();
            // 
            // customer_intf_lb
            // 
            customer_intf_lb.FormattingEnabled = true;
            customer_intf_lb.Location = new Point(70, 138);
            customer_intf_lb.Name = "customer_intf_lb";
            customer_intf_lb.Size = new Size(661, 264);
            customer_intf_lb.TabIndex = 0;
            customer_intf_lb.SelectedIndexChanged += customer_intf_lb_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(317, 42);
            label2.Name = "label2";
            label2.Size = new Size(157, 38);
            label2.TabIndex = 31;
            label2.Text = "Handiyen";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 105);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 32;
            label1.Text = "Restaurants";
            // 
            // order_btn
            // 
            order_btn.Location = new Point(169, 415);
            order_btn.Name = "order_btn";
            order_btn.Size = new Size(94, 29);
            order_btn.TabIndex = 33;
            order_btn.Text = "View Order";
            order_btn.UseVisualStyleBackColor = true;
            // 
            // profile_btn
            // 
            profile_btn.Location = new Point(509, 415);
            profile_btn.Name = "profile_btn";
            profile_btn.Size = new Size(94, 29);
            profile_btn.TabIndex = 34;
            profile_btn.Text = "Profile";
            profile_btn.UseVisualStyleBackColor = true;
            // 
            // Customerinterface
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(profile_btn);
            Controls.Add(order_btn);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(customer_intf_lb);
            Name = "Customerinterface";
            Text = "Customerinterface";
            Load += Customerinterface_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox customer_intf_lb;
        private Label label2;
        private Label label1;
        private Button order_btn;
        private Button profile_btn;
    }
}