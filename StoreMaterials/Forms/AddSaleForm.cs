using StoreMaterials.Models;
using System;
using System.Windows.Forms;

namespace StoreMaterials.Forms
{
    public partial class AddSaleForm : Form
    {
        public Sale NewSale { get; private set; }

        public AddSaleForm(List<Material> materials)
        {
            InitializeComponent();
            NewSale = new Sale();

            // Заполнение ComboBox материалами
            materialComboBox.DataSource = materials;
            materialComboBox.DisplayMember = "MaterialName";
            materialComboBox.ValueMember = "Id";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // Проверяем, что все поля заполнены
            if (materialComboBox.SelectedItem == null ||
                string.IsNullOrEmpty(unitTextBox.Text) ||
                string.IsNullOrEmpty(unitPriceTextBox.Text) ||
                string.IsNullOrEmpty(deliveryCostTextBox.Text) ||
                string.IsNullOrEmpty(discountTextBox.Text) ||
                string.IsNullOrEmpty(customerNameTextBox.Text))
            {
                MessageBox.Show("Все поля должны быть заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Сохраняем данные в новую запись
            NewSale.SaleId = 0; // ID будет установлен автоматически при добавлении в список
            NewSale.SaleDate = saleDatePicker.Value;
            NewSale.MaterialId = (int)materialComboBox.SelectedValue;
            NewSale.Unit = unitTextBox.Text;
            NewSale.UnitPrice = decimal.Parse(unitPriceTextBox.Text);
            NewSale.DeliveryCost = decimal.Parse(deliveryCostTextBox.Text);
            NewSale.Discount = decimal.Parse(discountTextBox.Text);
            NewSale.CustomerName = customerNameTextBox.Text;

            this.DialogResult = DialogResult.OK; // Закрываем форму с результатом OK
            this.Close();
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            // Закрываем форму с результатом Cancel
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}