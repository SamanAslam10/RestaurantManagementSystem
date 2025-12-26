using System.Net;
using RMS.Customer;

namespace RMS
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void Product_Click(object sender, EventArgs e)
        {
            FormHelper.PopulateScreen(new Product.ProductUI());
        }

        private void Customer_Click(object sender, EventArgs e)
        {
            FormHelper.PopulateScreen(new Customer.CustomerUI());
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Order_Click(object sender, EventArgs e)
        {
            FormHelper.PopulateScreen(new Order.OrderUI());
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            FormHelper.MasterPanel = this.Mainpanel;
        }

        private void MainMenuTitle_Click(object sender, EventArgs e)
        {

        }

        private void AdvanceProduct_Click(object sender, EventArgs e)
        {
            FormHelper.PopulateScreen(new Product.ProductAdvanceUI());
        }

        

        private void Mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OrderHistory_Click(object sender, EventArgs e)
        {
            FormHelper.PopulateScreen(new Order.OrderHistory());
        }
    }
}