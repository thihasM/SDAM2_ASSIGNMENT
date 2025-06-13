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
            cash_radio_btn = new RadioButton();
            card_radio_btn = new RadioButton();
            card_name_txt = new Label();
            card_number_txt = new Label();
            expdate_txt = new Label();
            cvc_txt = new Label();
            placeorder_txt = new Button();
            back_home_btn = new Button();
            cardname_tb = new TextBox();
            cardnum_tb = new TextBox();
            expdate_tb = new TextBox();
            cvc_tb = new TextBox();
            SuspendLayout();
            // 
            // cash_radio_btn
            // 
            cash_radio_btn.AutoSize = true;
            cash_radio_btn.Location = new Point(159, 99);
            cash_radio_btn.Name = "cash_radio_btn";
            cash_radio_btn.Size = new Size(61, 24);
            cash_radio_btn.TabIndex = 0;
            cash_radio_btn.TabStop = true;
            cash_radio_btn.Text = "Cash";
            cash_radio_btn.UseVisualStyleBackColor = true;
            // 
            // card_radio_btn
            // 
            card_radio_btn.AutoSize = true;
            card_radio_btn.Location = new Point(539, 99);
            card_radio_btn.Name = "card_radio_btn";
            card_radio_btn.Size = new Size(61, 24);
            card_radio_btn.TabIndex = 1;
            card_radio_btn.TabStop = true;
            card_radio_btn.Text = "Card";
            card_radio_btn.UseVisualStyleBackColor = true;
            // 
            // card_name_txt
            // 
            card_name_txt.AutoSize = true;
            card_name_txt.Location = new Point(108, 168);
            card_name_txt.Name = "card_name_txt";
            card_name_txt.Size = new Size(127, 20);
            card_name_txt.TabIndex = 2;
            card_name_txt.Text = "Cardholder Name";
            // 
            // card_number_txt
            // 
            card_number_txt.AutoSize = true;
            card_number_txt.Location = new Point(108, 252);
            card_number_txt.Name = "card_number_txt";
            card_number_txt.Size = new Size(98, 20);
            card_number_txt.TabIndex = 3;
            card_number_txt.Text = "Card Number";
            // 
            // expdate_txt
            // 
            expdate_txt.AutoSize = true;
            expdate_txt.Location = new Point(239, 373);
            expdate_txt.Name = "expdate_txt";
            expdate_txt.Size = new Size(85, 20);
            expdate_txt.TabIndex = 4;
            expdate_txt.Text = "Expiry Date";
            expdate_txt.Click += label3_Click;
            // 
            // cvc_txt
            // 
            cvc_txt.AutoSize = true;
            cvc_txt.Location = new Point(509, 373);
            cvc_txt.Name = "cvc_txt";
            cvc_txt.Size = new Size(36, 20);
            cvc_txt.TabIndex = 5;
            cvc_txt.Text = "CVC";
            // 
            // placeorder_txt
            // 
            placeorder_txt.Location = new Point(353, 459);
            placeorder_txt.Name = "placeorder_txt";
            placeorder_txt.Size = new Size(124, 34);
            placeorder_txt.TabIndex = 6;
            placeorder_txt.Text = "Place Order";
            placeorder_txt.UseVisualStyleBackColor = true;
            // 
            // back_home_btn
            // 
            back_home_btn.Location = new Point(340, 511);
            back_home_btn.Name = "back_home_btn";
            back_home_btn.Size = new Size(153, 29);
            back_home_btn.TabIndex = 7;
            back_home_btn.Text = "Back to Homepage";
            back_home_btn.UseVisualStyleBackColor = true;
            // 
            // cardname_tb
            // 
            cardname_tb.Location = new Point(108, 202);
            cardname_tb.Name = "cardname_tb";
            cardname_tb.Size = new Size(578, 27);
            cardname_tb.TabIndex = 8;
            // 
            // cardnum_tb
            // 
            cardnum_tb.Location = new Point(108, 289);
            cardnum_tb.Name = "cardnum_tb";
            cardnum_tb.Size = new Size(578, 27);
            cardnum_tb.TabIndex = 9;
            // 
            // expdate_tb
            // 
            expdate_tb.Location = new Point(232, 404);
            expdate_tb.Name = "expdate_tb";
            expdate_tb.Size = new Size(101, 27);
            expdate_tb.TabIndex = 10;
            // 
            // cvc_tb
            // 
            cvc_tb.Location = new Point(492, 404);
            cvc_tb.Name = "cvc_tb";
            cvc_tb.Size = new Size(73, 27);
            cvc_tb.TabIndex = 11;
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cvc_tb);
            Controls.Add(expdate_tb);
            Controls.Add(cardnum_tb);
            Controls.Add(cardname_tb);
            Controls.Add(back_home_btn);
            Controls.Add(placeorder_txt);
            Controls.Add(cvc_txt);
            Controls.Add(expdate_txt);
            Controls.Add(card_number_txt);
            Controls.Add(card_name_txt);
            Controls.Add(card_radio_btn);
            Controls.Add(cash_radio_btn);
            Name = "Payment";
            Text = "Payment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton cash_radio_btn;
        private RadioButton card_radio_btn;
        private Label card_name_txt;
        private Label card_number_txt;
        private Label expdate_txt;
        private Label cvc_txt;
        private Button placeorder_txt;
        private Button back_home_btn;
        private TextBox cardname_tb;
        private TextBox cardnum_tb;
        private TextBox expdate_tb;
        private TextBox cvc_tb;
    }
}