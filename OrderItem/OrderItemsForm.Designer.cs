namespace RMS.OrderItem
{
    partial class OrderItemsForm
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
            dgvItems = new DataGridView();
            btnAdd = new Button();
            btnDelete = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtOrderId = new TextBox();
            txtFoodId = new TextBox();
            txtQuantity = new TextBox();
            BackToMain = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            SuspendLayout();
            // 
            // dgvItems
            // 
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Location = new Point(516, 225);
            dgvItems.Name = "dgvItems";
            dgvItems.RowHeadersWidth = 62;
            dgvItems.Size = new Size(422, 308);
            dgvItems.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(161, 544);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(329, 544);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 214);
            label1.Name = "label1";
            label1.Size = new Size(74, 25);
            label1.TabIndex = 5;
            label1.Text = "OrderId";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 307);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 6;
            label2.Text = "Food";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 396);
            label3.Name = "label3";
            label3.Size = new Size(80, 25);
            label3.TabIndex = 7;
            label3.Text = "Quantity";
            // 
            // txtOrderId
            // 
            txtOrderId.Location = new Point(180, 208);
            txtOrderId.Name = "txtOrderId";
            txtOrderId.Size = new Size(150, 31);
            txtOrderId.TabIndex = 10;
            // 
            // txtFoodId
            // 
            txtFoodId.Location = new Point(180, 304);
            txtFoodId.Name = "txtFoodId";
            txtFoodId.Size = new Size(150, 31);
            txtFoodId.TabIndex = 11;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(180, 396);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(150, 31);
            txtQuantity.TabIndex = 12;
            // 
            // BackToMain
            // 
            BackToMain.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BackToMain.Location = new Point(813, 543);
            BackToMain.Name = "BackToMain";
            BackToMain.Size = new Size(112, 34);
            BackToMain.TabIndex = 16;
            BackToMain.Text = "Back";
            BackToMain.UseVisualStyleBackColor = true;
            BackToMain.Click += BackToMain_Click;
            // 
            // OrderItemsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 610);
            Controls.Add(BackToMain);
            Controls.Add(txtQuantity);
            Controls.Add(txtFoodId);
            Controls.Add(txtOrderId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dgvItems);
            Name = "OrderItemsForm";
            Text = "OrderItemsForm";
            Load += OrderItemsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvItems;
        private Button btnAdd;
        private Button btnDelete;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtOrderId;
        private TextBox txtFoodId;
        private TextBox txtQuantity;
        private Button BackToMain;
    }
}