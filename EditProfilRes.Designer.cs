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
            label2 = new Label();
            label3 = new Label();
            res_phone_number_edit_textbox = new TextBox();
            label4 = new Label();
            res_email = new TextBox();
            label5 = new Label();
            res_address = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(283, 89);
            label2.Name = "label2";
            label2.Size = new Size(249, 23);
            label2.TabIndex = 6;
            label2.Text = "Edit Restuarant Owner Profile";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F);
            label3.Location = new Point(167, 162);
            label3.Name = "label3";
            label3.Size = new Size(126, 22);
            label3.TabIndex = 8;
            label3.Text = "Phone Number";
            label3.Click += label3_Click;
            // 
            // res_phone_number_edit_textbox
            // 
            res_phone_number_edit_textbox.Location = new Point(167, 185);
            res_phone_number_edit_textbox.Name = "res_phone_number_edit_textbox";
            res_phone_number_edit_textbox.PlaceholderText = "Enter Your Phone Number";
            res_phone_number_edit_textbox.Size = new Size(476, 27);
            res_phone_number_edit_textbox.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F);
            label4.Location = new Point(167, 230);
            label4.Name = "label4";
            label4.Size = new Size(57, 22);
            label4.TabIndex = 10;
            label4.Text = "Email";
            // 
            // res_email
            // 
            res_email.Location = new Point(167, 253);
            res_email.Name = "res_email";
            res_email.PlaceholderText = "Enter Your Email Address";
            res_email.Size = new Size(476, 27);
            res_email.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F);
            label5.Location = new Point(167, 294);
            label5.Name = "label5";
            label5.Size = new Size(76, 22);
            label5.TabIndex = 12;
            label5.Text = "Address";
            // 
            // res_address
            // 
            res_address.Location = new Point(167, 317);
            res_address.Name = "res_address";
            res_address.PlaceholderText = "Enter Your Address";
            res_address.Size = new Size(476, 27);
            res_address.TabIndex = 11;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(549, 395);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 17;
            button1.Text = "Confirm Edit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(438, 395);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 18;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Stencil", 28.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(275, 9);
            label6.Name = "label6";
            label6.Size = new Size(257, 56);
            label6.TabIndex = 19;
            label6.Text = "Handiyen";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.PowderBlue;
            pictureBox1.Image = Properties.Resources.d;
            pictureBox1.Location = new Point(689, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(99, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(22, 115);
            panel1.Name = "panel1";
            panel1.Size = new Size(750, 3);
            panel1.TabIndex = 38;
            // 
            // EditProfilRes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(res_address);
            Controls.Add(label4);
            Controls.Add(res_email);
            Controls.Add(label3);
            Controls.Add(res_phone_number_edit_textbox);
            Controls.Add(label2);
            Name = "EditProfilRes";
            Text = "EditProfilRes";
            Load += EditProfilRes_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private TextBox res_phone_number_edit_textbox;
        private Label label4;
        private TextBox res_email;
        private Label label5;
        private TextBox res_address;
        private Button button1;
        private Button button2;
        private Label label6;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}