using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMS.OrderItem
{
    public partial class OrderItemsForm : Form
    {
        ItemService service = new ItemService();
        public OrderItemsForm()
        {
            InitializeComponent();
            LoadItems();
        }
        private void LoadItems()
        {
            dgvItems.DataSource = service.GetAllItems();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ItemModel item = new ItemModel(
                int.Parse(txtOrderId.Text),
                int.Parse(txtFoodId.Text),
                float.Parse(txtQuantity.Text)
            );

            service.AddItem(item);
            LoadItems();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            service.DeleteItem(int.Parse(txtOrderId.Text));
            LoadItems();
        }
        private void OrderItemsForm_Load(object sender, EventArgs e)
        {

        }

        private void BackToMain_Click(object sender, EventArgs e)
        {
            FormHelper.PopulateScreen(new MainMenu());
        }
    }
}
