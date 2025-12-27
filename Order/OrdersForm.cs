using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMS.Order
{
    public partial class OrdersForm : Form
    {
        OrderService service = new OrderService();
        public OrdersForm()
        {
            InitializeComponent();
        }
        private void LoadOrders()
        {
            dgvOrders.DataSource = service.GetAllOrders();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OrderModel order = new OrderModel(
                int.Parse(txtOrderId.Text),
                int.Parse(txtCustomerId.Text),
                int.Parse(txtEmployeeId.Text),
                float.Parse(txtBill.Text),
                txtPaidType.Text
            );

            service.AddOrder(order);
            LoadOrders();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            service.DeleteOrder(int.Parse(txtOrderId.Text));
            LoadOrders();
        }
        private void OrdersForm_Load(object sender, EventArgs e)
        {

        }
    }
}
