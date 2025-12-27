namespace RMS.Order
{
    partial class OrdersForm
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
            dgvOrders = new DataGridView();
            btnAdd = new Button();
            btnDelete = new Button();
            BackToMain = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtOrderId = new TextBox();
            txtCustomerId = new TextBox();
            txtEmployeeId = new TextBox();
            txtBill = new TextBox();
            txtPaidType = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            SuspendLayout();
            // 
            // dgvOrders
            // 
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Location = new Point(557, 223);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.RowHeadersWidth = 62;
            dgvOrders.Size = new Size(384, 295);
            dgvOrders.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(168, 550);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(371, 550);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // BackToMain
            // 
            BackToMain.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BackToMain.Location = new Point(829, 550);
            BackToMain.Name = "BackToMain";
            BackToMain.Size = new Size(112, 34);
            BackToMain.TabIndex = 17;
            BackToMain.Text = "Back";
            BackToMain.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 222);
            label1.Name = "label1";
            label1.Size = new Size(76, 25);
            label1.TabIndex = 18;
            label1.Text = "OrderID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 285);
            label2.Name = "label2";
            label2.Size = new Size(107, 25);
            label2.TabIndex = 19;
            label2.Text = "CustomerID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(80, 344);
            label3.Name = "label3";
            label3.Size = new Size(108, 25);
            label3.TabIndex = 20;
            label3.Text = "EmployeeID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(80, 401);
            label4.Name = "label4";
            label4.Size = new Size(34, 25);
            label4.TabIndex = 21;
            label4.Text = "Bill";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(80, 462);
            label5.Name = "label5";
            label5.Size = new Size(89, 25);
            label5.TabIndex = 22;
            label5.Text = "Payement";
            // 
            // txtOrderId
            // 
            txtOrderId.Location = new Point(221, 219);
            txtOrderId.Name = "txtOrderId";
            txtOrderId.Size = new Size(150, 31);
            txtOrderId.TabIndex = 23;
            // 
            // txtCustomerId
            // 
            txtCustomerId.Location = new Point(221, 282);
            txtCustomerId.Name = "txtCustomerId";
            txtCustomerId.Size = new Size(150, 31);
            txtCustomerId.TabIndex = 24;
            // 
            // txtEmployeeId
            // 
            txtEmployeeId.Location = new Point(221, 341);
            txtEmployeeId.Name = "txtEmployeeId";
            txtEmployeeId.Size = new Size(150, 31);
            txtEmployeeId.TabIndex = 25;
            // 
            // txtBill
            // 
            txtBill.Location = new Point(221, 395);
            txtBill.Name = "txtBill";
            txtBill.Size = new Size(150, 31);
            txtBill.TabIndex = 26;
            // 
            // txtPaidType
            // 
            txtPaidType.Location = new Point(221, 459);
            txtPaidType.Name = "txtPaidType";
            txtPaidType.Size = new Size(150, 31);
            txtPaidType.TabIndex = 27;
            // 
            // OrdersForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 605);
            Controls.Add(txtPaidType);
            Controls.Add(txtBill);
            Controls.Add(txtEmployeeId);
            Controls.Add(txtCustomerId);
            Controls.Add(txtOrderId);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BackToMain);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dgvOrders);
            Name = "OrdersForm";
            Text = "OrdersForm";
            Load += OrdersForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvOrders;
        private Button btnAdd;
        private Button btnDelete;
        private Button BackToMain;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtOrderId;
        private TextBox txtCustomerId;
        private TextBox txtEmployeeId;
        private TextBox txtBill;
        private TextBox txtPaidType;
    }
}