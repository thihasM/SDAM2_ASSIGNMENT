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
            // order_st_txt
            // 
            order_st_txt.AutoSize = true;
            order_st_txt.BackColor = SystemColors.Control;
            order_st_txt.Location = new Point(372, 45);
            order_st_txt.Name = "order_st_txt";
            order_st_txt.Size = new Size(91, 20);
            order_st_txt.TabIndex = 4;
            order_st_txt.Text = "Order Status";
            // 
            // order_dt_txt
            // 
            order_dt_txt.AutoSize = true;
            order_dt_txt.Location = new Point(369, 147);
            order_dt_txt.Name = "order_dt_txt";
            order_dt_txt.Size = new Size(97, 20);
            order_dt_txt.TabIndex = 5;
            order_dt_txt.Text = "Order Details";
            // 
            // ship_txt
            // 
            ship_txt.AutoSize = true;
            ship_txt.Location = new Point(358, 334);
            ship_txt.Name = "ship_txt";
            ship_txt.Size = new Size(125, 20);
            ship_txt.TabIndex = 6;
            ship_txt.Text = "Shipping Address";
            ship_txt.Click += label3_Click;
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
            Controls.Add(ship_txt);
            Controls.Add(order_dt_txt);
            Controls.Add(order_st_txt);
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
        private Label order_st_txt;
        private Label order_dt_txt;
        private Label ship_txt;
        private ListBox order_st_lb;
    }
}