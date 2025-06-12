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
            label3 = new Label();
            menu_edit_lb = new ListBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(190, 325);
            button1.Name = "button1";
            button1.Size = new Size(116, 29);
            button1.TabIndex = 0;
            button1.Text = "Add item";
            button1.UseVisualStyleBackColor = true;
            // 
            // bck_btn
            // 
            bck_btn.Location = new Point(26, 31);
            bck_btn.Name = "bck_btn";
            bck_btn.Size = new Size(94, 29);
            bck_btn.TabIndex = 1;
            bck_btn.Text = "Back";
            bck_btn.UseVisualStyleBackColor = true;
            bck_btn.Click += bck_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 140);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(94, 20);
            label1.TabIndex = 2;
            label1.Text = "Item Name : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 216);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 3;
            label2.Text = "Price :";
            // 
            // Itm_name_input_txt
            // 
            Itm_name_input_txt.Location = new Point(190, 133);
            Itm_name_input_txt.Name = "Itm_name_input_txt";
            Itm_name_input_txt.Size = new Size(125, 27);
            Itm_name_input_txt.TabIndex = 4;
            Itm_name_input_txt.TextChanged += Itm_name_input_txt_TextChanged;
            // 
            // Itm_price_input_txt
            // 
            Itm_price_input_txt.Location = new Point(190, 213);
            Itm_price_input_txt.Name = "Itm_price_input_txt";
            Itm_price_input_txt.Size = new Size(125, 27);
            Itm_price_input_txt.TabIndex = 5;
            // 
            // menu_delete_btn
            // 
            menu_delete_btn.Location = new Point(26, 325);
            menu_delete_btn.Name = "menu_delete_btn";
            menu_delete_btn.Size = new Size(116, 29);
            menu_delete_btn.TabIndex = 6;
            menu_delete_btn.Text = "delete menu";
            menu_delete_btn.UseVisualStyleBackColor = true;
            menu_delete_btn.Click += menu_delete_btn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(303, 31);
            label3.Name = "label3";
            label3.Size = new Size(157, 38);
            label3.TabIndex = 7;
            label3.Text = "Handiyen";
            // 
            // menu_edit_lb
            // 
            menu_edit_lb.FormattingEnabled = true;
            menu_edit_lb.Location = new Point(428, 101);
            menu_edit_lb.Name = "menu_edit_lb";
            menu_edit_lb.Size = new Size(326, 344);
            menu_edit_lb.TabIndex = 8;
            menu_edit_lb.SelectedIndexChanged += menu_edit_lb_SelectedIndexChanged;
            // 
            // menueditpage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 561);
            Controls.Add(menu_edit_lb);
            Controls.Add(label3);
            Controls.Add(menu_delete_btn);
            Controls.Add(Itm_price_input_txt);
            Controls.Add(Itm_name_input_txt);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(bck_btn);
            Controls.Add(button1);
            Name = "menueditpage";
            Text = "menueditpage";
            Load += menueditpage_Load;
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
        private Label label3;
        private ListBox menu_edit_lb;
    }
}