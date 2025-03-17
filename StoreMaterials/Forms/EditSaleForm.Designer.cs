namespace StoreMaterials.Forms
{
    partial class EditSaleForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label saleIdLabel;
        private System.Windows.Forms.TextBox saleIdTextBox;
        private System.Windows.Forms.Label saleDateLabel;
        private System.Windows.Forms.DateTimePicker saleDatePicker;
        private System.Windows.Forms.Label materialLabel;
        private System.Windows.Forms.ComboBox materialComboBox; // Заменяем TextBox на ComboBox
        private System.Windows.Forms.Label unitLabel;
        private System.Windows.Forms.TextBox unitTextBox;
        private System.Windows.Forms.Label unitPriceLabel;
        private System.Windows.Forms.TextBox unitPriceTextBox;
        private System.Windows.Forms.Label deliveryCostLabel;
        private System.Windows.Forms.TextBox deliveryCostTextBox;
        private System.Windows.Forms.Label discountLabel;
        private System.Windows.Forms.TextBox discountTextBox;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.saleIdLabel = new System.Windows.Forms.Label();
            this.saleIdTextBox = new System.Windows.Forms.TextBox();
            this.saleDateLabel = new System.Windows.Forms.Label();
            this.saleDatePicker = new System.Windows.Forms.DateTimePicker();
            this.materialLabel = new System.Windows.Forms.Label();
            this.materialComboBox = new System.Windows.Forms.ComboBox(); // Заменяем TextBox на ComboBox
            this.unitLabel = new System.Windows.Forms.Label();
            this.unitTextBox = new System.Windows.Forms.TextBox();
            this.unitPriceLabel = new System.Windows.Forms.Label();
            this.unitPriceTextBox = new System.Windows.Forms.TextBox();
            this.deliveryCostLabel = new System.Windows.Forms.Label();
            this.deliveryCostTextBox = new System.Windows.Forms.TextBox();
            this.discountLabel = new System.Windows.Forms.Label();
            this.discountTextBox = new System.Windows.Forms.TextBox();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // saleIdLabel
            // 
            this.saleIdLabel.AutoSize = true;
            this.saleIdLabel.Location = new System.Drawing.Point(12, 15);
            this.saleIdLabel.Name = "saleIdLabel";
            this.saleIdLabel.Size = new System.Drawing.Size(118, 13);
            this.saleIdLabel.TabIndex = 0;
            this.saleIdLabel.Text = "Id";

            // 
            // saleIdTextBox
            // 
            this.saleIdTextBox.Location = new System.Drawing.Point(150, 12);
            this.saleIdTextBox.Name = "saleIdTextBox";
            this.saleIdTextBox.ReadOnly = true;
            this.saleIdTextBox.Size = new System.Drawing.Size(200, 20);
            this.saleIdTextBox.TabIndex = 1;

            // 
            // saleDateLabel
            // 
            this.saleDateLabel.AutoSize = true;
            this.saleDateLabel.Location = new System.Drawing.Point(12, 45);
            this.saleDateLabel.Name = "saleDateLabel";
            this.saleDateLabel.Size = new System.Drawing.Size(75, 13);
            this.saleDateLabel.TabIndex = 2;
            this.saleDateLabel.Text = "Дата продажи";

            // 
            // saleDatePicker
            // 
            this.saleDatePicker.Location = new System.Drawing.Point(150, 42);
            this.saleDatePicker.Name = "saleDatePicker";
            this.saleDatePicker.Size = new System.Drawing.Size(200, 20);
            this.saleDatePicker.TabIndex = 3;

            // 
            // materialLabel
            // 
            this.materialLabel.AutoSize = true;
            this.materialLabel.Location = new System.Drawing.Point(12, 75);
            this.materialLabel.Name = "materialLabel";
            this.materialLabel.Size = new System.Drawing.Size(57, 13);
            this.materialLabel.TabIndex = 4;
            this.materialLabel.Text = "Материал";

            // 
            // materialComboBox
            // 
            this.materialComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox.FormattingEnabled = true;
            this.materialComboBox.Location = new System.Drawing.Point(150, 72);
            this.materialComboBox.Name = "materialComboBox";
            this.materialComboBox.Size = new System.Drawing.Size(200, 21);
            this.materialComboBox.TabIndex = 5;

            // 
            // unitLabel
            // 
            this.unitLabel.AutoSize = true;
            this.unitLabel.Location = new System.Drawing.Point(12, 105);
            this.unitLabel.Name = "unitLabel";
            this.unitLabel.Size = new System.Drawing.Size(95, 13);
            this.unitLabel.TabIndex = 6;
            this.unitLabel.Text = "Единицы измер";

            // 
            // unitTextBox
            // 
            this.unitTextBox.Location = new System.Drawing.Point(150, 102);
            this.unitTextBox.Name = "unitTextBox";
            this.unitTextBox.Size = new System.Drawing.Size(200, 20);
            this.unitTextBox.TabIndex = 7;

            // 
            // unitPriceLabel
            // 
            this.unitPriceLabel.AutoSize = true;
            this.unitPriceLabel.Location = new System.Drawing.Point(12, 135);
            this.unitPriceLabel.Name = "unitPriceLabel";
            this.unitPriceLabel.Size = new System.Drawing.Size(80, 13);
            this.unitPriceLabel.TabIndex = 8;
            this.unitPriceLabel.Text = "Цена за ед";

            // 
            // unitPriceTextBox
            // 
            this.unitPriceTextBox.Location = new System.Drawing.Point(150, 132);
            this.unitPriceTextBox.Name = "unitPriceTextBox";
            this.unitPriceTextBox.Size = new System.Drawing.Size(200, 20);
            this.unitPriceTextBox.TabIndex = 9;

            // 
            // deliveryCostLabel
            // 
            this.deliveryCostLabel.AutoSize = true;
            this.deliveryCostLabel.Location = new System.Drawing.Point(12, 165);
            this.deliveryCostLabel.Name = "deliveryCostLabel";
            this.deliveryCostLabel.Size = new System.Drawing.Size(98, 13);
            this.deliveryCostLabel.TabIndex = 10;
            this.deliveryCostLabel.Text = "Цена доставки";

            // 
            // deliveryCostTextBox
            // 
            this.deliveryCostTextBox.Location = new System.Drawing.Point(150, 162);
            this.deliveryCostTextBox.Name = "deliveryCostTextBox";
            this.deliveryCostTextBox.Size = new System.Drawing.Size(200, 20);
            this.deliveryCostTextBox.TabIndex = 11;

            // 
            // discountLabel
            // 
            this.discountLabel.AutoSize = true;
            this.discountLabel.Location = new System.Drawing.Point(12, 195);
            this.discountLabel.Name = "discountLabel";
            this.discountLabel.Size = new System.Drawing.Size(44, 13);
            this.discountLabel.TabIndex = 12;
            this.discountLabel.Text = "Скидка";

            // 
            // discountTextBox
            // 
            this.discountTextBox.Location = new System.Drawing.Point(150, 192);
            this.discountTextBox.Name = "discountTextBox";
            this.discountTextBox.Size = new System.Drawing.Size(200, 20);
            this.discountTextBox.TabIndex = 13;

            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Location = new System.Drawing.Point(12, 225);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(85, 13);
            this.customerNameLabel.TabIndex = 14;
            this.customerNameLabel.Text = "ФИО покупателя";

            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(150, 222);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.customerNameTextBox.TabIndex = 15;

            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(150, 260);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(90, 30);
            this.saveButton.TabIndex = 16;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);

            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(260, 260);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(90, 30);
            this.cancelButton.TabIndex = 17;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);

            // 
            // EditSaleForm
            // 
            this.ClientSize = new System.Drawing.Size(370, 300);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.customerNameTextBox);
            this.Controls.Add(this.customerNameLabel);
            this.Controls.Add(this.discountTextBox);
            this.Controls.Add(this.discountLabel);
            this.Controls.Add(this.deliveryCostTextBox);
            this.Controls.Add(this.deliveryCostLabel);
            this.Controls.Add(this.unitPriceTextBox);
            this.Controls.Add(this.unitPriceLabel);
            this.Controls.Add(this.unitTextBox);
            this.Controls.Add(this.unitLabel);
            this.Controls.Add(this.materialComboBox);
            this.Controls.Add(this.materialLabel);
            this.Controls.Add(this.saleDatePicker);
            this.Controls.Add(this.saleDateLabel);
            this.Controls.Add(this.saleIdTextBox);
            this.Controls.Add(this.saleIdLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditSaleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактирование продажи";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}