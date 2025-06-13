namespace LOGIN_SDAM_ASSIGNMENT
{
    partial class menueditpage
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
            button1 = new Button();
            bck_btn = new Button();
            label1 = new Label();
            label2 = new Label();
            Itm_name_input_txt = new TextBox();
            Itm_price_input_txt = new TextBox();
            menu_delete_btn = new Button();
            menu_edit_lb = new ListBox();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(266, 317);
            button1.Name = "button1";
            button1.Size = new Size(134, 30);
            button1.TabIndex = 0;
            button1.Text = "Add Item";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // bck_btn
            // 
            bck_btn.BackColor = Color.Black;
            bck_btn.FlatStyle = FlatStyle.Popup;
            bck_btn.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            bck_btn.ForeColor = Color.White;
            bck_btn.Location = new Point(12, 12);
            bck_btn.Name = "bck_btn";
            bck_btn.Size = new Size(94, 29);
            bck_btn.TabIndex = 1;
            bck_btn.Text = "Back";
            bck_btn.UseVisualStyleBackColor = false;
            bck_btn.Click += bck_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F);
            label1.Location = new Point(147, 181);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(100, 22);
            label1.TabIndex = 2;
            label1.Text = "Item Name ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F);
            label2.Location = new Point(195, 250);
            label2.Name = "label2";
            label2.Size = new Size(52, 22);
            label2.TabIndex = 3;
            label2.Text = "Price";
            // 
            // Itm_name_input_txt
            // 
            Itm_name_input_txt.Location = new Point(256, 179);
            Itm_name_input_txt.Name = "Itm_name_input_txt";
            Itm_name_input_txt.Size = new Size(144, 27);
            Itm_name_input_txt.TabIndex = 4;
            Itm_name_input_txt.TextChanged += Itm_name_input_txt_TextChanged;
            // 
            // Itm_price_input_txt
            // 
            Itm_price_input_txt.Location = new Point(256, 250);
            Itm_price_input_txt.Name = "Itm_price_input_txt";
            Itm_price_input_txt.Size = new Size(144, 27);
            Itm_price_input_txt.TabIndex = 5;
            // 
            // menu_delete_btn
            // 
            menu_delete_btn.BackColor = Color.Black;
            menu_delete_btn.FlatStyle = FlatStyle.Popup;
            menu_delete_btn.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            menu_delete_btn.ForeColor = Color.White;
            menu_delete_btn.Location = new Point(266, 359);
            menu_delete_btn.Name = "menu_delete_btn";
            menu_delete_btn.Size = new Size(134, 30);
            menu_delete_btn.TabIndex = 6;
            menu_delete_btn.Text = "Delete Menu";
            menu_delete_btn.UseVisualStyleBackColor = false;
            menu_delete_btn.Click += menu_delete_btn_Click;
            // 
            // menu_edit_lb
            // 
            menu_edit_lb.BackColor = Color.LightSteelBlue;
            menu_edit_lb.FormattingEnabled = true;
            menu_edit_lb.Location = new Point(417, 103);
            menu_edit_lb.Name = "menu_edit_lb";
            menu_edit_lb.Size = new Size(326, 344);
            menu_edit_lb.TabIndex = 8;
            menu_edit_lb.SelectedIndexChanged += menu_edit_lb_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Stencil", 28.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(255, 12);
            label4.Name = "label4";
            label4.Size = new Size(257, 56);
            label4.TabIndex = 9;
            label4.Text = "Handiyen";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.PowderBlue;
            pictureBox1.Image = Properties.Resources.d;
            pictureBox1.Location = new Point(689, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(99, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // menueditpage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(menu_edit_lb);
            Controls.Add(menu_delete_btn);
            Controls.Add(Itm_price_input_txt);
            Controls.Add(Itm_name_input_txt);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(bck_btn);
            Controls.Add(button1);
            Name = "menueditpage";
            Text = "Menu edit page ";
            Load += menueditpage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button bck_btn;
        private Label label1;
        private Label label2;
        private TextBox Itm_name_input_txt;
        private TextBox Itm_price_input_txt;
        private Button menu_delete_btn;
        private ListBox menu_edit_lb;
        private Label label4;
        private PictureBox pictureBox1;
    }
}