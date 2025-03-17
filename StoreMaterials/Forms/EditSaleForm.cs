using StoreMaterials.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StoreMaterials.Forms
{
    public partial class EditSaleForm : Form
    {
        public Sale EditedSale { get; private set; }
        private List<Material> _materials; // Список материалов

        public EditSaleForm(Sale sale, List<Material> materials)
        {
            InitializeComponent();
            EditedSale = sale;
            _materials = materials;

            // Заполняем ComboBox материалами
            materialComboBox.DataSource = _materials;
            materialComboBox.DisplayMember = "MaterialName"; // Отображаемое поле
            materialComboBox.ValueMember = "Id"; // Значение, которое будет выбрано

            // Заполняем поля формы данными из выбранной записи
            saleIdTextBox.Text = sale.SaleId.ToString();
            saleDatePicker.Value = sale.SaleDate;
            unitTextBox.Text = sale.Unit;
            unitPriceTextBox.Text = sale.UnitPrice.ToString();
            deliveryCostTextBox.Text = sale.DeliveryCost.ToString();
            discountTextBox.Text = sale.Discount.ToString();
            customerNameTextBox.Text = sale.CustomerName;

            // Устанавливаем выбранный материал в ComboBox
            materialComboBox.SelectedValue = sale.MaterialId;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // Сохраняем изменения
            EditedSale.SaleDate = saleDatePicker.Value;
            EditedSale.MaterialId = (int)materialComboBox.SelectedValue; // Получаем ID выбранного материала
            EditedSale.Unit = unitTextBox.Text;
            EditedSale.UnitPrice = decimal.Parse(unitPriceTextBox.Text);
            EditedSale.DeliveryCost = decimal.Parse(deliveryCostTextBox.Text);
            EditedSale.Discount = decimal.Parse(discountTextBox.Text);
            EditedSale.CustomerName = customerNameTextBox.Text;

            this.DialogResult = DialogResult.OK; // Закрываем форму с результатом OK
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; // Закрываем форму с результатом Cancel
            this.Close();
        }
    }
}