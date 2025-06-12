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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            order_st_lb = new ListBox();
            SuspendLayout();
            // 
            // livetrack_btn
            // 
            livetrack_btn.Location = new Point(338, 515);
            livetrack_btn.Name = "livetrack_btn";
            livetrack_btn.Size = new Size(167, 29);
            livetrack_btn.TabIndex = 0;
            livetrack_btn.Text = "Live track Your Order";
            livetrack_btn.UseVisualStyleBackColor = true;
            // 
            // Back_btn
            // 
            Back_btn.Location = new Point(322, 570);
            Back_btn.Name = "Back_btn";
            Back_btn.Size = new Size(192, 29);
            Back_btn.TabIndex = 1;
            Back_btn.Text = "Go Back to Homepage";
            Back_btn.UseVisualStyleBackColor = true;
            // 
            // order_dt_lb
            // 
            order_dt_lb.FormattingEnabled = true;
            order_dt_lb.Location = new Point(322, 182);
            order_dt_lb.Name = "order_dt_lb";
            order_dt_lb.Size = new Size(197, 124);
            order_dt_lb.TabIndex = 2;
            // 
            // ship_dt_lb
            // 
            ship_dt_lb.FormattingEnabled = true;
            ship_dt_lb.Location = new Point(322, 372);
            ship_dt_lb.Name = "ship_dt_lb";
            ship_dt_lb.Size = new Size(197, 104);
            ship_dt_lb.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Location = new Point(372, 45);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 4;
            label1.Text = "Order Status";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(369, 147);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 5;
            label2.Text = "Order Details";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(358, 334);
            label3.Name = "label3";
            label3.Size = new Size(125, 20);
            label3.TabIndex = 6;
            label3.Text = "Shipping Address";
            label3.Click += label3_Click;
            // 
            // order_st_lb
            // 
            order_st_lb.FormattingEnabled = true;
            order_st_lb.Location = new Point(303, 90);
            order_st_lb.Name = "order_st_lb";
            order_st_lb.Size = new Size(239, 24);
            order_st_lb.TabIndex = 7;
            // 
            // trackoder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 628);
            Controls.Add(order_st_lb);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ship_dt_lb);
            Controls.Add(order_dt_lb);
            Controls.Add(Back_btn);
            Controls.Add(livetrack_btn);
            Name = "trackoder";
            Text = "trackoder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button livetrack_btn;
        private Button Back_btn;
        private ListBox order_dt_lb;
        private ListBox ship_dt_lb;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox order_st_lb;
    }
}