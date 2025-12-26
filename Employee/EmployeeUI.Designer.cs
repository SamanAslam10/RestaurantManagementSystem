namespace RMS.Employee
{
    partial class EmployeeUI
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
            Title = new TextBox();
            FirstName = new Label();
            LastName = new Label();
            Phone = new Label();
            CNIC = new Label();
            AddProduct = new Button();
            nameTextBox = new TextBox();
            phoneTextBox = new TextBox();
            lnameTextBox = new TextBox();
            cnicTextBox = new TextBox();
            BackToMain = new Button();
            DeleteProduct = new Button();
            UpdateProduct = new Button();
            EmployeeDataGrid = new DataGridView();
            Column5 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            Column12 = new DataGridViewTextBoxColumn();
            EmployeeId = new Label();
            IDtext = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            textBox11 = new TextBox();
            textBox12 = new TextBox();
            Salary = new Label();
            RoleID = new Label();
            HireDate = new Label();
            Address = new Label();
            Email = new Label();
            Role = new Label();
            Status = new Label();
            ((System.ComponentModel.ISupportInitialize)EmployeeDataGrid).BeginInit();
            SuspendLayout();
            // 
            // Title
            // 
            Title.BackColor = Color.LightPink;
            Title.Font = new Font("Rage Italic", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Title.ForeColor = Color.PaleVioletRed;
            Title.Location = new Point(565, 31);
            Title.Name = "Title";
            Title.Size = new Size(576, 128);
            Title.TabIndex = 0;
            Title.Text = "Employee Menu";
            Title.TextChanged += Title_TextChanged;
            // 
            // FirstName
            // 
            FirstName.AutoSize = true;
            FirstName.BackColor = Color.PaleVioletRed;
            FirstName.Font = new Font("Georgia", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            FirstName.ForeColor = Color.MistyRose;
            FirstName.Location = new Point(12, 56);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(149, 32);
            FirstName.TabIndex = 1;
            FirstName.Text = "FirstName";
            // 
            // LastName
            // 
            LastName.AutoSize = true;
            LastName.BackColor = Color.PaleVioletRed;
            LastName.Font = new Font("Georgia", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            LastName.ForeColor = Color.MistyRose;
            LastName.Location = new Point(10, 108);
            LastName.Name = "LastName";
            LastName.Size = new Size(144, 32);
            LastName.TabIndex = 2;
            LastName.Text = "LastName";
            // 
            // Phone
            // 
            Phone.AutoSize = true;
            Phone.BackColor = Color.PaleVioletRed;
            Phone.Font = new Font("Georgia", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Phone.ForeColor = Color.MistyRose;
            Phone.Location = new Point(12, 163);
            Phone.Name = "Phone";
            Phone.Size = new Size(107, 32);
            Phone.TabIndex = 3;
            Phone.Text = "Phone  ";
            // 
            // CNIC
            // 
            CNIC.AutoSize = true;
            CNIC.BackColor = Color.PaleVioletRed;
            CNIC.Font = new Font("Georgia", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            CNIC.ForeColor = Color.MistyRose;
            CNIC.Location = new Point(10, 219);
            CNIC.Name = "CNIC";
            CNIC.Size = new Size(82, 32);
            CNIC.TabIndex = 4;
            CNIC.Text = "CNIC";
            // 
            // AddProduct
            // 
            AddProduct.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddProduct.Location = new Point(100, 638);
            AddProduct.Name = "AddProduct";
            AddProduct.Size = new Size(112, 34);
            AddProduct.TabIndex = 6;
            AddProduct.Text = "Add";
            AddProduct.UseVisualStyleBackColor = true;
            AddProduct.Click += AddProduct_Click;
            // 
            // nameTextBox
            // 
            nameTextBox.AccessibleName = "NameTextBox";
            nameTextBox.BackColor = Color.MistyRose;
            nameTextBox.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameTextBox.ForeColor = Color.PaleVioletRed;
            nameTextBox.Location = new Point(183, 56);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(162, 35);
            nameTextBox.TabIndex = 11;
            nameTextBox.TextChanged += nameTextBox_TextChanged;
            nameTextBox.KeyUp += nameTextBox_KeyUp;
            // 
            // phoneTextBox
            // 
            phoneTextBox.AccessibleName = "SalePriceTextBox";
            phoneTextBox.BackColor = Color.MistyRose;
            phoneTextBox.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneTextBox.ForeColor = Color.PaleVioletRed;
            phoneTextBox.Location = new Point(183, 160);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(162, 35);
            phoneTextBox.TabIndex = 12;
            phoneTextBox.TextChanged += SalePriceTextBox_TextChanged;
            phoneTextBox.KeyUp += SalePriceTextBox_KeyUp;
            // 
            // lnameTextBox
            // 
            lnameTextBox.AccessibleName = "PurchasePriceTextBox";
            lnameTextBox.BackColor = Color.MistyRose;
            lnameTextBox.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lnameTextBox.ForeColor = Color.PaleVioletRed;
            lnameTextBox.Location = new Point(183, 105);
            lnameTextBox.Name = "lnameTextBox";
            lnameTextBox.Size = new Size(162, 35);
            lnameTextBox.TabIndex = 13;
            lnameTextBox.TextChanged += PurchasePriceTextBox_TextChanged;
            lnameTextBox.KeyUp += PurchasePriceTextBox_KeyUp;
            // 
            // cnicTextBox
            // 
            cnicTextBox.AccessibleName = "DiscountTextBox";
            cnicTextBox.BackColor = Color.MistyRose;
            cnicTextBox.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cnicTextBox.ForeColor = Color.PaleVioletRed;
            cnicTextBox.Location = new Point(183, 216);
            cnicTextBox.Name = "cnicTextBox";
            cnicTextBox.Size = new Size(162, 35);
            cnicTextBox.TabIndex = 14;
            cnicTextBox.TextChanged += DiscountTextBox_TextChanged;
            cnicTextBox.KeyUp += DiscountTextBox_KeyUp;
            // 
            // BackToMain
            // 
            BackToMain.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BackToMain.Location = new Point(1148, 638);
            BackToMain.Name = "BackToMain";
            BackToMain.Size = new Size(112, 34);
            BackToMain.TabIndex = 15;
            BackToMain.Text = "Back";
            BackToMain.UseVisualStyleBackColor = true;
            BackToMain.Click += BackToMain_Click;
            // 
            // DeleteProduct
            // 
            DeleteProduct.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DeleteProduct.Location = new Point(413, 638);
            DeleteProduct.Name = "DeleteProduct";
            DeleteProduct.Size = new Size(112, 34);
            DeleteProduct.TabIndex = 17;
            DeleteProduct.Text = "Delete";
            DeleteProduct.UseVisualStyleBackColor = true;
            DeleteProduct.Click += DeleteProduct_Click;
            // 
            // UpdateProduct
            // 
            UpdateProduct.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UpdateProduct.Location = new Point(254, 638);
            UpdateProduct.Name = "UpdateProduct";
            UpdateProduct.Size = new Size(112, 34);
            UpdateProduct.TabIndex = 18;
            UpdateProduct.Text = "Update";
            UpdateProduct.UseVisualStyleBackColor = true;
            UpdateProduct.Click += UpdateProduct_Click;
            // 
            // EmployeeDataGrid
            // 
            EmployeeDataGrid.AllowUserToAddRows = false;
            EmployeeDataGrid.AllowUserToOrderColumns = true;
            EmployeeDataGrid.BackgroundColor = Color.PaleVioletRed;
            EmployeeDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EmployeeDataGrid.Columns.AddRange(new DataGridViewColumn[] { Column5, Column1, Column2, Column3, Column4, Column6, Column7, Column8, Column9, Column10, Column11, Column12 });
            EmployeeDataGrid.GridColor = Color.MistyRose;
            EmployeeDataGrid.Location = new Point(365, 249);
            EmployeeDataGrid.MultiSelect = false;
            EmployeeDataGrid.Name = "EmployeeDataGrid";
            EmployeeDataGrid.ReadOnly = true;
            EmployeeDataGrid.RowHeadersVisible = false;
            EmployeeDataGrid.RowHeadersWidth = 62;
            EmployeeDataGrid.Size = new Size(983, 360);
            EmployeeDataGrid.TabIndex = 19;
            EmployeeDataGrid.CellContentClick += ProductDataGrid_CellContentClick;
            // 
            // Column5
            // 
            Column5.HeaderText = "EmployeeId";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 150;
            // 
            // Column1
            // 
            Column1.HeaderText = "FirstName";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.HeaderText = "LastName";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.HeaderText = "CNIC";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.HeaderText = "Phone";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 150;
            // 
            // Column6
            // 
            Column6.HeaderText = "Email";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 150;
            // 
            // Column7
            // 
            Column7.HeaderText = "Address";
            Column7.MinimumWidth = 8;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 150;
            // 
            // Column8
            // 
            Column8.HeaderText = "HireDate";
            Column8.MinimumWidth = 8;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Width = 150;
            // 
            // Column9
            // 
            Column9.HeaderText = "RoleId";
            Column9.MinimumWidth = 8;
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            Column9.Width = 150;
            // 
            // Column10
            // 
            Column10.HeaderText = "Salary";
            Column10.MinimumWidth = 8;
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            Column10.Width = 150;
            // 
            // Column11
            // 
            Column11.HeaderText = "Status";
            Column11.MinimumWidth = 8;
            Column11.Name = "Column11";
            Column11.ReadOnly = true;
            Column11.Width = 150;
            // 
            // Column12
            // 
            Column12.HeaderText = "Role";
            Column12.MinimumWidth = 8;
            Column12.Name = "Column12";
            Column12.ReadOnly = true;
            Column12.Width = 150;
            // 
            // EmployeeId
            // 
            EmployeeId.AutoSize = true;
            EmployeeId.BackColor = Color.PaleVioletRed;
            EmployeeId.Font = new Font("Georgia", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            EmployeeId.ForeColor = Color.MistyRose;
            EmployeeId.Location = new Point(12, 9);
            EmployeeId.Name = "EmployeeId";
            EmployeeId.Size = new Size(165, 32);
            EmployeeId.TabIndex = 20;
            EmployeeId.Text = "EmployeeId";
            // 
            // IDtext
            // 
            IDtext.AccessibleName = "NameTextBox";
            IDtext.BackColor = Color.MistyRose;
            IDtext.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IDtext.ForeColor = Color.PaleVioletRed;
            IDtext.Location = new Point(183, 6);
            IDtext.Name = "IDtext";
            IDtext.Size = new Size(162, 35);
            IDtext.TabIndex = 21;
            IDtext.TextChanged += IDtext_TextChanged;
            IDtext.KeyUp += IDtext_KeyUp;
            // 
            // textBox6
            // 
            textBox6.AccessibleName = "DiscountTextBox";
            textBox6.BackColor = Color.MistyRose;
            textBox6.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox6.ForeColor = Color.PaleVioletRed;
            textBox6.Location = new Point(183, 574);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(162, 35);
            textBox6.TabIndex = 27;
            // 
            // textBox7
            // 
            textBox7.AccessibleName = "DiscountTextBox";
            textBox7.BackColor = Color.MistyRose;
            textBox7.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox7.ForeColor = Color.PaleVioletRed;
            textBox7.Location = new Point(183, 523);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(162, 35);
            textBox7.TabIndex = 28;
            // 
            // textBox8
            // 
            textBox8.AccessibleName = "DiscountTextBox";
            textBox8.BackColor = Color.MistyRose;
            textBox8.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox8.ForeColor = Color.PaleVioletRed;
            textBox8.Location = new Point(183, 471);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(162, 35);
            textBox8.TabIndex = 29;
            // 
            // textBox9
            // 
            textBox9.AccessibleName = "DiscountTextBox";
            textBox9.BackColor = Color.MistyRose;
            textBox9.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox9.ForeColor = Color.PaleVioletRed;
            textBox9.Location = new Point(183, 421);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(162, 35);
            textBox9.TabIndex = 30;
            // 
            // textBox10
            // 
            textBox10.AccessibleName = "DiscountTextBox";
            textBox10.BackColor = Color.MistyRose;
            textBox10.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox10.ForeColor = Color.PaleVioletRed;
            textBox10.Location = new Point(183, 368);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(162, 35);
            textBox10.TabIndex = 31;
            // 
            // textBox11
            // 
            textBox11.AccessibleName = "DiscountTextBox";
            textBox11.BackColor = Color.MistyRose;
            textBox11.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox11.ForeColor = Color.PaleVioletRed;
            textBox11.Location = new Point(183, 318);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(162, 35);
            textBox11.TabIndex = 32;
            // 
            // textBox12
            // 
            textBox12.AccessibleName = "DiscountTextBox";
            textBox12.BackColor = Color.MistyRose;
            textBox12.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox12.ForeColor = Color.PaleVioletRed;
            textBox12.Location = new Point(183, 265);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(162, 35);
            textBox12.TabIndex = 33;
            // 
            // Salary
            // 
            Salary.AutoSize = true;
            Salary.BackColor = Color.PaleVioletRed;
            Salary.Font = new Font("Georgia", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Salary.ForeColor = Color.MistyRose;
            Salary.Location = new Point(10, 577);
            Salary.Name = "Salary";
            Salary.Size = new Size(99, 32);
            Salary.TabIndex = 34;
            Salary.Text = "Salary";
            // 
            // RoleID
            // 
            RoleID.AutoSize = true;
            RoleID.BackColor = Color.PaleVioletRed;
            RoleID.Font = new Font("Georgia", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            RoleID.ForeColor = Color.MistyRose;
            RoleID.Location = new Point(12, 424);
            RoleID.Name = "RoleID";
            RoleID.Size = new Size(102, 32);
            RoleID.TabIndex = 35;
            RoleID.Text = "RoleID";
            // 
            // HireDate
            // 
            HireDate.AutoSize = true;
            HireDate.BackColor = Color.PaleVioletRed;
            HireDate.Font = new Font("Georgia", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            HireDate.ForeColor = Color.MistyRose;
            HireDate.Location = new Point(12, 371);
            HireDate.Name = "HireDate";
            HireDate.Size = new Size(138, 32);
            HireDate.TabIndex = 36;
            HireDate.Text = "HireDate ";
            // 
            // Address
            // 
            Address.AutoSize = true;
            Address.BackColor = Color.PaleVioletRed;
            Address.Font = new Font("Georgia", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Address.ForeColor = Color.MistyRose;
            Address.Location = new Point(12, 321);
            Address.Name = "Address";
            Address.Size = new Size(115, 32);
            Address.TabIndex = 37;
            Address.Text = "Address";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.BackColor = Color.PaleVioletRed;
            Email.Font = new Font("Georgia", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Email.ForeColor = Color.MistyRose;
            Email.Location = new Point(10, 268);
            Email.Name = "Email";
            Email.Size = new Size(89, 32);
            Email.TabIndex = 38;
            Email.Text = "Email";
            // 
            // Role
            // 
            Role.AutoSize = true;
            Role.BackColor = Color.PaleVioletRed;
            Role.Font = new Font("Georgia", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Role.ForeColor = Color.MistyRose;
            Role.Location = new Point(10, 474);
            Role.Name = "Role";
            Role.Size = new Size(70, 32);
            Role.TabIndex = 40;
            Role.Text = "Role";
            // 
            // Status
            // 
            Status.AutoSize = true;
            Status.BackColor = Color.PaleVioletRed;
            Status.Font = new Font("Georgia", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Status.ForeColor = Color.MistyRose;
            Status.Location = new Point(10, 526);
            Status.Name = "Status";
            Status.Size = new Size(94, 32);
            Status.TabIndex = 41;
            Status.Text = "Status";
            // 
            // EmployeeUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(1360, 738);
            Controls.Add(Status);
            Controls.Add(Role);
            Controls.Add(Email);
            Controls.Add(Address);
            Controls.Add(HireDate);
            Controls.Add(RoleID);
            Controls.Add(Salary);
            Controls.Add(textBox12);
            Controls.Add(textBox11);
            Controls.Add(textBox10);
            Controls.Add(textBox9);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(IDtext);
            Controls.Add(EmployeeId);
            Controls.Add(EmployeeDataGrid);
            Controls.Add(UpdateProduct);
            Controls.Add(DeleteProduct);
            Controls.Add(BackToMain);
            Controls.Add(cnicTextBox);
            Controls.Add(lnameTextBox);
            Controls.Add(phoneTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(AddProduct);
            Controls.Add(CNIC);
            Controls.Add(Phone);
            Controls.Add(LastName);
            Controls.Add(FirstName);
            Controls.Add(Title);
            ForeColor = Color.PaleVioletRed;
            Name = "EmployeeUI";
            Load += ProductMenu_Load;
            ((System.ComponentModel.ISupportInitialize)EmployeeDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Title;
        private new Label FirstName;
        private Label LastName;
        private Label Phone;
        private Label CNIC;
        private Button AddProduct;
        private TextBox nameTextBox;
        private TextBox phoneTextBox;
        private TextBox lnameTextBox;
        private TextBox cnicTextBox;
        private Button BackToMain;
        private Button DeleteProduct;
        private Button UpdateProduct;
        private DataGridView EmployeeDataGrid;
        private Label EmployeeId;
        private TextBox IDtext;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox11;
        private TextBox textBox12;
        private Label Salary;
        private Label RoleID;
        private Label HireDate;
        private Label Address;
        private Label Email;
        private Label Role;
        private Label Status;
    }
}