namespace LOGIN_SDAM_ASSIGNMENT
{
    partial class Payment
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
            radioCash = new RadioButton();
            card_radio_btn = new RadioButton();
            card_name_txt = new Label();
            card_number_txt = new Label();
            expdate_txt = new Label();
            cvc_txt = new Label();
            placeorder_btn = new Button();
            back_home_btn = new Button();
            cardname_tb = new TextBox();
            cardnum_tb = new TextBox();
            expdate_tb = new TextBox();
            cvc_tb = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            order_st_txt = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // radioCash
            // 
            radioCash.AutoSize = true;
            radioCash.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            radioCash.Location = new Point(75, 136);
            radioCash.Margin = new Padding(4, 3, 4, 3);
            radioCash.Name = "radioCash";
            radioCash.Size = new Size(73, 27);
            radioCash.TabIndex = 0;
            radioCash.TabStop = true;
            radioCash.Text = "Cash";
            radioCash.UseVisualStyleBackColor = true;
            radioCash.CheckedChanged += cash_radio_btn_CheckedChanged;
            // 
            // card_radio_btn
            // 
            card_radio_btn.AutoSize = true;
            card_radio_btn.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            card_radio_btn.Location = new Point(602, 136);
            card_radio_btn.Margin = new Padding(4, 3, 4, 3);
            card_radio_btn.Name = "card_radio_btn";
            card_radio_btn.Size = new Size(73, 27);
            card_radio_btn.TabIndex = 1;
            card_radio_btn.TabStop = true;
            card_radio_btn.Text = "Card";
            card_radio_btn.UseVisualStyleBackColor = true;
            // 
            // card_name_txt
            // 
            card_name_txt.AutoSize = true;
            card_name_txt.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            card_name_txt.Location = new Point(13, 172);
            card_name_txt.Margin = new Padding(4, 0, 4, 0);
            card_name_txt.Name = "card_name_txt";
            card_name_txt.Size = new Size(159, 23);
            card_name_txt.TabIndex = 2;
            card_name_txt.Text = "Cardholder Name";
            // 
            // card_number_txt
            // 
            card_number_txt.AutoSize = true;
            card_number_txt.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            card_number_txt.Location = new Point(13, 245);
            card_number_txt.Margin = new Padding(4, 0, 4, 0);
            card_number_txt.Name = "card_number_txt";
            card_number_txt.Size = new Size(124, 23);
            card_number_txt.TabIndex = 3;
            card_number_txt.Text = "Card Number";
            // 
            // expdate_txt
            // 
            expdate_txt.AutoSize = true;
            expdate_txt.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            expdate_txt.Location = new Point(93, 327);
            expdate_txt.Margin = new Padding(4, 0, 4, 0);
            expdate_txt.Name = "expdate_txt";
            expdate_txt.Size = new Size(112, 23);
            expdate_txt.TabIndex = 4;
            expdate_txt.Text = "Expiry Date";
            expdate_txt.Click += label3_Click;
            // 
            // cvc_txt
            // 
            cvc_txt.AutoSize = true;
            cvc_txt.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            cvc_txt.Location = new Point(593, 327);
            cvc_txt.Margin = new Padding(4, 0, 4, 0);
            cvc_txt.Name = "cvc_txt";
            cvc_txt.Size = new Size(52, 23);
            cvc_txt.TabIndex = 5;
            cvc_txt.Text = "CVC";
            // 
            // placeorder_btn
            // 
            placeorder_btn.BackColor = Color.Black;
            placeorder_btn.FlatStyle = FlatStyle.Popup;
            placeorder_btn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            placeorder_btn.ForeColor = SystemColors.Control;
            placeorder_btn.Location = new Point(301, 399);
            placeorder_btn.Margin = new Padding(4, 3, 4, 3);
            placeorder_btn.Name = "placeorder_btn";
            placeorder_btn.Size = new Size(186, 39);
            placeorder_btn.TabIndex = 6;
            placeorder_btn.Text = "Place Order";
            placeorder_btn.UseVisualStyleBackColor = false;
            placeorder_btn.Click += placeorder_btn_Click;
            // 
            // back_home_btn
            // 
            back_home_btn.BackColor = Color.Black;
            back_home_btn.FlatStyle = FlatStyle.Popup;
            back_home_btn.ForeColor = SystemColors.Control;
            back_home_btn.Location = new Point(13, 30);
            back_home_btn.Margin = new Padding(4, 3, 4, 3);
            back_home_btn.Name = "back_home_btn";
            back_home_btn.Size = new Size(101, 33);
            back_home_btn.TabIndex = 7;
            back_home_btn.Text = "Go Back";
            back_home_btn.UseVisualStyleBackColor = false;
            back_home_btn.Click += back_home_btn_Click;
            // 
            // cardname_tb
            // 
            cardname_tb.Location = new Point(13, 203);
            cardname_tb.Margin = new Padding(4, 3, 4, 3);
            cardname_tb.Name = "cardname_tb";
            cardname_tb.Size = new Size(781, 30);
            cardname_tb.TabIndex = 8;
            // 
            // cardnum_tb
            // 
            cardnum_tb.Location = new Point(13, 276);
            cardnum_tb.Margin = new Padding(4, 3, 4, 3);
            cardnum_tb.Name = "cardnum_tb";
            cardnum_tb.Size = new Size(781, 30);
            cardnum_tb.TabIndex = 9;
            // 
            // expdate_tb
            // 
            expdate_tb.Location = new Point(75, 355);
            expdate_tb.Margin = new Padding(4, 3, 4, 3);
            expdate_tb.Name = "expdate_tb";
            expdate_tb.Size = new Size(150, 30);
            expdate_tb.TabIndex = 10;
            // 
            // cvc_tb
            // 
            cvc_tb.Location = new Point(567, 355);
            cvc_tb.Margin = new Padding(4, 3, 4, 3);
            cvc_tb.Name = "cvc_tb";
            cvc_tb.Size = new Size(108, 30);
            cvc_tb.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.PowderBlue;
            label1.Font = new Font("Stencil", 28.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(262, 10);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(257, 56);
            label1.TabIndex = 12;
            label1.Text = "Handiyen";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.PowderBlue;
            pictureBox1.Image = Properties.Resources.d;
            pictureBox1.Location = new Point(689, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(99, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(25, 116);
            panel1.Name = "panel1";
            panel1.Size = new Size(750, 3);
            panel1.TabIndex = 40;
            // 
            // order_st_txt
            // 
            order_st_txt.AutoSize = true;
            order_st_txt.BackColor = Color.Transparent;
            order_st_txt.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            order_st_txt.Location = new Point(341, 90);
            order_st_txt.Name = "order_st_txt";
            order_st_txt.Size = new Size(124, 23);
            order_st_txt.TabIndex = 41;
            order_st_txt.Text = "Payment Page";
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(order_st_txt);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(cvc_tb);
            Controls.Add(expdate_tb);
            Controls.Add(cardnum_tb);
            Controls.Add(cardname_tb);
            Controls.Add(back_home_btn);
            Controls.Add(placeorder_btn);
            Controls.Add(cvc_txt);
            Controls.Add(expdate_txt);
            Controls.Add(card_number_txt);
            Controls.Add(card_name_txt);
            Controls.Add(card_radio_btn);
            Controls.Add(radioCash);
            Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Payment";
            Text = "Payment";
            Load += Payment_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioCash;
        private RadioButton card_radio_btn;
        private Label card_name_txt;
        private Label card_number_txt;
        private Label expdate_txt;
        private Label cvc_txt;
        private Button placeorder_btn;
        private Button back_home_btn;
        private TextBox cardname_tb;
        private TextBox cardnum_tb;
        private TextBox expdate_tb;
        private TextBox cvc_tb;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label order_st_txt;
    }
}