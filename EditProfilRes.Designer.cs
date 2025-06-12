namespace LOGIN_SDAM_ASSIGNMENT
{
    partial class EditProfilRes
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
            res_name_edit_textbox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            res_phone_number_edit_textbox = new TextBox();
            label4 = new Label();
            res_email = new TextBox();
            label5 = new Label();
            res_address = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // res_name_edit_textbox
            // 
            res_name_edit_textbox.Location = new Point(167, 73);
            res_name_edit_textbox.Name = "res_name_edit_textbox";
            res_name_edit_textbox.Size = new Size(476, 27);
            res_name_edit_textbox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(167, 50);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 5;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(306, 9);
            label2.Name = "label2";
            label2.Size = new Size(203, 20);
            label2.TabIndex = 6;
            label2.Text = "Edit Restuarant Owner Profile";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(167, 120);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 8;
            label3.Text = "Phone Number";
            label3.Click += label3_Click;
            // 
            // res_phone_number_edit_textbox
            // 
            res_phone_number_edit_textbox.Location = new Point(167, 143);
            res_phone_number_edit_textbox.Name = "res_phone_number_edit_textbox";
            res_phone_number_edit_textbox.Size = new Size(476, 27);
            res_phone_number_edit_textbox.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(167, 188);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 10;
            label4.Text = "Email";
            // 
            // res_email
            // 
            res_email.Location = new Point(167, 211);
            res_email.Name = "res_email";
            res_email.Size = new Size(476, 27);
            res_email.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(167, 283);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 12;
            label5.Text = "Address";
            // 
            // res_address
            // 
            res_address.Location = new Point(167, 306);
            res_address.Name = "res_address";
            res_address.Size = new Size(476, 27);
            res_address.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(549, 366);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 17;
            button1.Text = "Confirm Edit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(438, 366);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 18;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            // 
            // EditProfilRes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(res_address);
            Controls.Add(label4);
            Controls.Add(res_email);
            Controls.Add(label3);
            Controls.Add(res_phone_number_edit_textbox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(res_name_edit_textbox);
            Name = "EditProfilRes";
            Text = "EditProfilRes";
            Load += EditProfilRes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox res_name_edit_textbox;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox res_phone_number_edit_textbox;
        private Label label4;
        private TextBox res_email;
        private Label label5;
        private TextBox res_address;
        private Button button1;
        private Button button2;
    }
}