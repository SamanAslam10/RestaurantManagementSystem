using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMS.Employee
{
    public partial class EmployeeUI : Form
    {
        EmployeeService _service = new EmployeeService();
        public EmployeeUI()
        {
            InitializeComponent();
            LoadEmployee();
        }

        private void ProductMenu_Load(object sender, EventArgs e)
        {
        }

        private void Title_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProductDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadEmployee()
        {
            List<EmployeeModel> employee = _service.GetAllData();
            foreach (EmployeeModel e in employee )
            {
                EmployeeDataGrid.Rows.Add(e.Id , e.First_Name , e.Last_Name , e.CNIC , e.phone , e.email , e.address , e.HireDate , e.RoleId , e.Salary , e.status , e.Role );
            }
        }
        private void AddProduct_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == null || lnameTextBox.Text == null || phoneTextBox.Text == null || cnicTextBox.Text == null)
            {
                return;
            }
            else
            {
                int id = int.Parse(IDtext.Text);
                string fname = nameTextBox.Text;
                string lname = lnameTextBox.Text;
                string cnic = cnicTextBox.Text;
                string phone = phoneTextBox.Text;
                string email = textBox12.Text;
                string address = textBox11.Text;
                string hireDate = textBox10.Text;
                int roleId = int.Parse(textBox9.Text);
                float salary = float.Parse(textBox7.Text);
                string status = textBox6.Text;
                string role = textBox8.Text;

                EmployeeModel employee = new EmployeeModel(id, fname,lname , cnic , phone , email , address , hireDate , roleId , role , status , salary);
                _service.AddEmployee(employee);

                LoadEmployee();
            }
        }

        private void UpdateProduct_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == null) return;
            else
            {
                int id = int.Parse(IDtext.Text);
                string name = nameTextBox.Text;
                float purchasePrice = float.Parse(lnameTextBox.Text);
                float salePrice = float.Parse(phoneTextBox.Text);
                int discount = int.Parse(cnicTextBox.Text);

                EmployeeModel employee = new EmployeeModel();
                _service.UpdateEmployee(employee);

                LoadEmployee();
            }
        }

        private void DeleteProduct_Click(object sender, EventArgs e)
        {
            int id = int.Parse(IDtext.Text);
            _service.DeleteEmployee(id);

            LoadEmployee();
        }

        private void ViewAllProducts_Click(object sender, EventArgs e)
        {
            LoadEmployee();
        }

        private void BackToMain_Click(object sender, EventArgs e)
        {
            FormHelper.PopulateScreen(new MainMenu());
        }

        private void IDtext_TextChanged(object sender, EventArgs e)
        {
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void PurchasePriceTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void SalePriceTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void DiscountTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void IDtext_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                nameTextBox.Focus();
            }
        }

        private void nameTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lnameTextBox.Focus();
            }
        }

        private void PurchasePriceTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                phoneTextBox.Focus();
            }
        }

        private void SalePriceTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cnicTextBox.Focus();
            }
        }

        private void DiscountTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) 
            {
                AddProduct.Focus();
            }
        }
    }
}