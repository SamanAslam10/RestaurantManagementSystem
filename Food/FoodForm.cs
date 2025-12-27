using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RMS.Food
{
    public partial class FoodForm : Form
    {
        FoodService service = new FoodService();
        public FoodForm()
        {
            InitializeComponent();
            LoadFood();
        }
        private void LoadFood()
        {
            dgvFood.DataSource = service.GetAllFood();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FoodModel food = new FoodModel(
                int.Parse(txtId.Text),
                txtName.Text,
                float.Parse(txtPrice.Text),
                txtType.Text
            );

            service.AddFood(food);
            LoadFood();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FoodModel food = new FoodModel(
                int.Parse(txtId.Text),
                txtName.Text,
                float.Parse(txtPrice.Text),
                txtType.Text
            );

            service.UpdateFood(food);
            LoadFood();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            service.DeleteFood(int.Parse(txtId.Text));
            LoadFood();
        }
private void BackToMain_Click(object sender, EventArgs e)
        {
            FormHelper.PopulateScreen(new MainMenu());
        }
    }
}
