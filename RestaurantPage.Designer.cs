namespace LOGIN_SDAM_ASSIGNMENT
{
    partial class RestaurantPage
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
            lblName = new Label();
            lblAddress = new Label();
            menu_items = new ListBox();
            gobck_btn = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(348, 46);
            lblName.Name = "lblName";
            lblName.Size = new Size(17, 20);
            lblName.TabIndex = 0;
            lblName.Text = "ll";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(348, 81);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(17, 20);
            lblAddress.TabIndex = 1;
            lblAddress.Text = "ll";
            // 
            // menu_items
            // 
            menu_items.FormattingEnabled = true;
            menu_items.Location = new Point(148, 134);
            menu_items.Name = "menu_items";
            menu_items.Size = new Size(450, 264);
            menu_items.TabIndex = 2;
            // 
            // gobck_btn
            // 
            gobck_btn.Location = new Point(652, 413);
            gobck_btn.Name = "gobck_btn";
            gobck_btn.Size = new Size(94, 29);
            gobck_btn.TabIndex = 3;
            gobck_btn.Text = "Back";
            gobck_btn.UseVisualStyleBackColor = true;
            gobck_btn.Click += gobck_btn_Click;
            // 
            // RestaurantPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 463);
            Controls.Add(gobck_btn);
            Controls.Add(menu_items);
            Controls.Add(lblAddress);
            Controls.Add(lblName);
            Name = "RestaurantPage";
            Text = "RestaurantPage";
            Load += RestaurantPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblAddress;
        private ListBox menu_items;
        private Button gobck_btn;
    }
}