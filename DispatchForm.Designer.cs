namespace LOGIN_SDAM_ASSIGNMENT
{
    partial class DispatchForm
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
            lblOrderId = new Label();
            lblOrderTime = new Label();
            label4 = new Label();
            txtOrderId = new TextBox();
            txtOrderTime = new TextBox();
            driverslb = new ListBox();
            btnDispatchOrder = new Button();
            txtPayment = new TextBox();
            txtLocation = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // lblOrderId
            // 
            lblOrderId.AutoSize = true;
            lblOrderId.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOrderId.Location = new Point(218, 43);
            lblOrderId.Name = "lblOrderId";
            lblOrderId.Size = new Size(93, 22);
            lblOrderId.TabIndex = 0;
            lblOrderId.Text = "Order ID :";
            // 
            // lblOrderTime
            // 
            lblOrderTime.AutoSize = true;
            lblOrderTime.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOrderTime.Location = new Point(218, 80);
            lblOrderTime.Name = "lblOrderTime";
            lblOrderTime.Size = new Size(113, 22);
            lblOrderTime.TabIndex = 1;
            lblOrderTime.Text = "Order Time :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(218, 266);
            label4.Name = "label4";
            label4.Size = new Size(133, 22);
            label4.TabIndex = 3;
            label4.Text = "Select Driver : ";
            // 
            // txtOrderId
            // 
            txtOrderId.Location = new Point(411, 40);
            txtOrderId.Name = "txtOrderId";
            txtOrderId.ReadOnly = true;
            txtOrderId.Size = new Size(125, 27);
            txtOrderId.TabIndex = 5;
            // 
            // txtOrderTime
            // 
            txtOrderTime.Location = new Point(411, 73);
            txtOrderTime.Name = "txtOrderTime";
            txtOrderTime.ReadOnly = true;
            txtOrderTime.Size = new Size(125, 27);
            txtOrderTime.TabIndex = 6;
            // 
            // driverslb
            // 
            driverslb.FormattingEnabled = true;
            driverslb.Location = new Point(411, 266);
            driverslb.Name = "driverslb";
            driverslb.Size = new Size(157, 64);
            driverslb.TabIndex = 8;
            // 
            // btnDispatchOrder
            // 
            btnDispatchOrder.BackColor = Color.Black;
            btnDispatchOrder.FlatStyle = FlatStyle.Popup;
            btnDispatchOrder.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDispatchOrder.ForeColor = Color.White;
            btnDispatchOrder.Location = new Point(335, 358);
            btnDispatchOrder.Name = "btnDispatchOrder";
            btnDispatchOrder.Size = new Size(94, 29);
            btnDispatchOrder.TabIndex = 10;
            btnDispatchOrder.Text = "Dispatch Order";
            btnDispatchOrder.UseVisualStyleBackColor = false;
            btnDispatchOrder.Click += btnDispatchOrder_Click;
            // 
            // txtPayment
            // 
            txtPayment.Location = new Point(411, 156);
            txtPayment.Name = "txtPayment";
            txtPayment.ReadOnly = true;
            txtPayment.Size = new Size(125, 27);
            txtPayment.TabIndex = 14;
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(411, 123);
            txtLocation.Name = "txtLocation";
            txtLocation.ReadOnly = true;
            txtLocation.Size = new Size(125, 27);
            txtLocation.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(218, 163);
            label1.Name = "label1";
            label1.Size = new Size(152, 22);
            label1.TabIndex = 12;
            label1.Text = "Payment Method :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(218, 136);
            label2.Name = "label2";
            label2.Size = new Size(90, 22);
            label2.TabIndex = 11;
            label2.Text = "Location :";
            // 
            // DispatchForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPayment);
            Controls.Add(txtLocation);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(btnDispatchOrder);
            Controls.Add(driverslb);
            Controls.Add(txtOrderTime);
            Controls.Add(txtOrderId);
            Controls.Add(label4);
            Controls.Add(lblOrderTime);
            Controls.Add(lblOrderId);
            Name = "DispatchForm";
            Text = "DispatchForm";
            Load += DispatchForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOrderId;
        private Label lblOrderTime;
        private Label label4;
        private TextBox txtOrderId;
        private TextBox txtOrderTime;
        private ListBox driverslb;
        private Button btnDispatchOrder;
        private TextBox txtPayment;
        private TextBox txtLocation;
        private Label label1;
        private Label label2;
    }
}