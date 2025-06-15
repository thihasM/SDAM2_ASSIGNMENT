namespace LOGIN_SDAM_ASSIGNMENT
{
    partial class ReviewRes
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
            panel1 = new Panel();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            res_rev_lb = new ListBox();
            label1 = new Label();
            user_back_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(15, 115);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(750, 4);
            panel1.TabIndex = 51;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(315, 86);
            label7.Name = "label7";
            label7.Size = new Size(119, 23);
            label7.TabIndex = 50;
            label7.Text = "Reviews page";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.PowderBlue;
            pictureBox1.Image = Properties.Resources.d;
            pictureBox1.Location = new Point(689, 13);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(99, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 49;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.PowderBlue;
            label6.Font = new Font("Stencil", 28.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(258, 20);
            label6.Name = "label6";
            label6.Size = new Size(257, 56);
            label6.TabIndex = 48;
            label6.Text = "Handiyen";
            // 
            // res_rev_lb
            // 
            res_rev_lb.BackColor = Color.LightSteelBlue;
            res_rev_lb.FormattingEnabled = true;
            res_rev_lb.Location = new Point(141, 156);
            res_rev_lb.Margin = new Padding(3, 4, 3, 4);
            res_rev_lb.Name = "res_rev_lb";
            res_rev_lb.Size = new Size(495, 184);
            res_rev_lb.TabIndex = 53;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 156);
            label1.Name = "label1";
            label1.Size = new Size(89, 23);
            label1.TabIndex = 52;
            label1.Text = "Reviews : ";
            // 
            // user_back_btn
            // 
            user_back_btn.BackColor = Color.Black;
            user_back_btn.FlatStyle = FlatStyle.Popup;
            user_back_btn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            user_back_btn.ForeColor = SystemColors.Control;
            user_back_btn.Location = new Point(528, 369);
            user_back_btn.Margin = new Padding(3, 4, 3, 4);
            user_back_btn.Name = "user_back_btn";
            user_back_btn.Size = new Size(108, 29);
            user_back_btn.TabIndex = 54;
            user_back_btn.Text = "Go Back";
            user_back_btn.UseVisualStyleBackColor = false;
            // 
            // ReviewRes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(800, 449);
            Controls.Add(user_back_btn);
            Controls.Add(res_rev_lb);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(label7);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ReviewRes";
            Text = "ReviewRes";
            Load += ReviewRes_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label7;
        private PictureBox pictureBox1;
        private Label label6;
        private ListBox res_rev_lb;
        private Label label1;
        private Button user_back_btn;
    }
}