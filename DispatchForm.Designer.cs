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
            lblOrderId.Location = new Point(191, 43);
            lblOrderId.Name = "lblOrderId";
            lblOrderId.Size = new Size(73, 20);
            lblOrderId.TabIndex = 0;
            lblOrderId.Text = "Order ID :";
            // 
            // lblOrderTime
            // 
            lblOrderTime.AutoSize = true;
            lblOrderTime.Location = new Point(191, 80);
            lblOrderTime.Name = "lblOrderTime";
            lblOrderTime.Size = new Size(91, 20);
            lblOrderTime.TabIndex = 1;
            lblOrderTime.Text = "Order Time :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(191, 266);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 3;
            label4.Text = "Select Driver : ";
            // 
            // txtOrderId
            // 
            txtOrderId.Location = new Point(384, 40);
            txtOrderId.Name = "txtOrderId";
            txtOrderId.ReadOnly = true;
            txtOrderId.Size = new Size(125, 27);
            txtOrderId.TabIndex = 5;
            // 
            // txtOrderTime
            // 
            txtOrderTime.Location = new Point(384, 73);
            txtOrderTime.Name = "txtOrderTime";
            txtOrderTime.ReadOnly = true;
            txtOrderTime.Size = new Size(125, 27);
            txtOrderTime.TabIndex = 6;
            // 
            // driverslb
            // 
            driverslb.FormattingEnabled = true;
            driverslb.Location = new Point(384, 266);
            driverslb.Name = "driverslb";
            driverslb.Size = new Size(157, 64);
            driverslb.TabIndex = 8;
            // 
            // btnDispatchOrder
            // 
            btnDispatchOrder.Location = new Point(308, 358);
            btnDispatchOrder.Name = "btnDispatchOrder";
            btnDispatchOrder.Size = new Size(94, 29);
            btnDispatchOrder.TabIndex = 10;
            btnDispatchOrder.Text = "Dispatch Order";
            btnDispatchOrder.UseVisualStyleBackColor = true;
            btnDispatchOrder.Click += btnDispatchOrder_Click;
            // 
            // txtPayment
            // 
            txtPayment.Location = new Point(384, 156);
            txtPayment.Name = "txtPayment";
            txtPayment.ReadOnly = true;
            txtPayment.Size = new Size(125, 27);
            txtPayment.TabIndex = 14;
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(384, 123);
            txtLocation.Name = "txtLocation";
            txtLocation.ReadOnly = true;
            txtLocation.Size = new Size(125, 27);
            txtLocation.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(191, 163);
            label1.Name = "label1";
            label1.Size = new Size(128, 20);
            label1.TabIndex = 12;
            label1.Text = "Payment Method :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(191, 136);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 11;
            label2.Text = "Location :";
            // 
            // DispatchForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
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